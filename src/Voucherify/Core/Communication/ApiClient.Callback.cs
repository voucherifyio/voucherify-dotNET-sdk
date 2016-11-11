#if !APIASYNC
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using Voucherify.Core.Exceptions;

namespace Voucherify.Core.Communication
{
    public class ApiResponse
    {
        public VoucherifyClientException Exception { get; private set; }

        private ApiResponse() { }

        public static ApiResponse WithException(VoucherifyClientException exception)
        {
            return new ApiResponse() { Exception = exception };
        }

        public static ApiResponse WithSuccess()
        {
            return new ApiResponse();
        }
    }

    public class ApiResponse<T>
        where T : class
    {
        public T Result { get; private set; }

        public VoucherifyClientException Exception { get; private set; }

        private ApiResponse() { }

        public static ApiResponse<TResult> WithException<TResult>(VoucherifyClientException exception)
            where TResult : class
        {
            return new ApiResponse<TResult>() { Exception = exception };
        }

        public static ApiResponse<TResult> WithResult<TResult>(TResult result)
            where TResult : class
        {
            return new ApiResponse<TResult>() { Result = result };
        }
    }

    internal class ApiClient
    {
        private readonly bool isSecure;
        private readonly string baseAddress;
        private readonly Dictionary<string, string> headers;
        private Serialization.JsonSerializer<VoucherifyClientException> serializerException;

        internal ApiClient(bool isSecure, string baseAddress, Dictionary<string, string> headers)
        {
            this.isSecure = isSecure;
            this.headers = headers;
            this.baseAddress = baseAddress;
            this.serializerException = new Serialization.JsonSerializer<VoucherifyClientException>();
        }

        internal void DoGetRequest<TResult>(Uri uri, Action<ApiResponse<TResult>> callback)
           where TResult : class
        {
            using (WebClient client = this.PrepareClient())
            {
                client.DownloadStringCompleted += (sender, arguments) => {
                    HandleResponse<TResult>(arguments, callback);
                };
                client.DownloadStringAsync(uri);
            }
        }
        
        internal void DoPostRequest(Uri uri, Action<ApiResponse> callback)
        {
            using (WebClient client = this.PrepareClient())
            {
                client.UploadStringCompleted += (sender, arguments) => {
                    HandleResponse(arguments, callback);
                };
                client.UploadStringAsync(uri, string.Empty);
            }
        }

        internal void DoPostRequest<TResult>(Uri uri, Action<ApiResponse<TResult>> callback)
            where TResult : class
        {
            using (WebClient client = this.PrepareClient())
            {
                client.UploadStringCompleted += (sender, arguments) => {
                    HandleResponse(arguments, callback);
                };
                client.UploadStringAsync(uri, string.Empty);
            }
        }

        internal void DoPostRequest<TResult, TPayload>(Uri uri, TPayload payload, Action<ApiResponse<TResult>> callback)
            where TResult : class
            where TPayload : class
        {
            using (WebClient client = this.PrepareClient())
            {
                client.UploadStringCompleted += (sender, arguments) => {
                    HandleResponse(arguments, callback);
                };
                client.UploadStringAsync(uri, new Serialization.JsonSerializer<TPayload>().Serialize(payload));
            }
        }

        internal void DoPutRequest<TResult, TPayload>(Uri uri, TPayload payload, Action<ApiResponse<TResult>> callback)
            where TResult : class
            where TPayload : class
        {
            using (WebClient client = this.PrepareClient())
            {
                client.UploadStringCompleted += (sender, arguments) => {
                    HandleResponse(arguments, callback);
                };
                client.UploadStringAsync(uri, "PUT", new Serialization.JsonSerializer<TPayload>().Serialize(payload));
            }
        }

        internal void DoDeleteRequest(Uri uri, Action<ApiResponse> callback)
        {
            using (WebClient client = this.PrepareClient())
            {
                client.UploadStringCompleted += (sender, arguments) => {
                    HandleResponse(arguments, callback);
                };
                client.UploadStringAsync(uri, "DELETE", string.Empty);
            }
        }

        internal UriBuilder GetUriBuilder(string path)
        {
            return new UriBuilder(this.isSecure ? Uri.UriSchemeHttps : Uri.UriSchemeHttp, this.baseAddress) { Path = path };
        }

        private void HandleResponse<TResult>(AsyncCompletedEventArgs arguments, Action<ApiResponse<TResult>> callback)
            where TResult : class
        {
            if (arguments.Error == null)
            {
                DownloadStringCompletedEventArgs stringDownloadArguments = (arguments as DownloadStringCompletedEventArgs);
                UploadStringCompletedEventArgs stringUploadArguments = (arguments as UploadStringCompletedEventArgs);

                if (stringDownloadArguments != null)
                {
                    callback(ApiResponse<TResult>.WithResult(new Serialization.JsonSerializer<TResult>().Deserialize(stringDownloadArguments.Result)));
                }
                else if (stringUploadArguments != null)
                {
                    callback(ApiResponse<TResult>.WithResult(new Serialization.JsonSerializer<TResult>().Deserialize(stringUploadArguments.Result)));
                }
                else
                {
                    callback(ApiResponse<TResult>.WithResult(new Serialization.JsonSerializer<TResult>().Deserialize(string.Empty)));
                }

                return;
            }

            WebException exception = arguments.Error as WebException;

            if (exception != null)
            {
                HttpWebResponse response = exception.Response as HttpWebResponse;

                if (response != null)
                {
                    using (var responseStream = response.GetResponseStream())
                    using (var reader = new StreamReader(responseStream))
                    {
                        callback(ApiResponse<TResult>.WithException<TResult>(this.serializerException.Deserialize(reader.ReadToEnd())));
                    }

                    return;
                }
            }

            callback(ApiResponse<TResult>.WithException<TResult>(new VoucherifyClientException(arguments.Error)));
        }

        private void HandleResponse(AsyncCompletedEventArgs arguments, Action<ApiResponse> callback)
        {

            if (arguments.Error == null)
            {
                callback(ApiResponse.WithSuccess());
                return;
            }

            WebException exception = arguments.Error as WebException;

            if (exception != null)
            {
                HttpWebResponse response = exception.Response as HttpWebResponse;

                if (response != null)
                {
                    using (var responseStream = response.GetResponseStream())
                    using (var reader = new StreamReader(responseStream))
                    {
                        callback(ApiResponse.WithException(this.serializerException.Deserialize(reader.ReadToEnd())));
                    }

                    return;
                }
            }

            callback(ApiResponse.WithException(new VoucherifyClientException(arguments.Error)));
        }


        private WebClient PrepareClient()
        {
            WebClient client = new WebClient();

            foreach(var entry in this.headers)
            {
                client.Headers.Add(entry.Key, entry.Value);
            }

            client.Headers.Add("Accept", "application/json");
            client.Headers.Add("Content-Type", "application/json");

            return client;
        }
    }
}

#endif
