using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace Voucherify.Client.Api
{
    internal class ApiClient
    {
        private VoucherifyClient voucherify;
        private Serialization.JsonSerializer<Exceptions.VoucherifyClientException> serializerException;

        internal ApiClient(VoucherifyClient voucherify)
        {
            this.voucherify = voucherify;
            this.serializerException = new Serialization.JsonSerializer<Exceptions.VoucherifyClientException>();
        }

        internal void DoGetRequest<TResult>(Uri uri, Action<ApiResponse<TResult>> callback)
           where TResult : class
        {
            using (WebClient client = this.PrepareClient())
            {
                client.DownloadStringCompleted += (sender, arguments) => {
                    HandleResponse(arguments, callback);
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
            return new UriBuilder(this.voucherify.Secure ? Uri.UriSchemeHttps : Uri.UriSchemeHttp, this.voucherify.Endpoint)
            {
                Path = path
            };
        }

        private void HandleResponse<TResult>(AsyncCompletedEventArgs arguments, Action<ApiResponse<TResult>> callback)
            where TResult : class
        {
            if (arguments.Error == null)
            {
                DownloadStringCompletedEventArgs stringDownloadArguments = (arguments as DownloadStringCompletedEventArgs);
                UploadStringCompletedEventArgs stringUploadArguments = (arguments as UploadStringCompletedEventArgs);

                if (stringDownloadArguments != null) {
                    callback(ApiResponse<TResult>.WithResult(new Serialization.JsonSerializer<TResult>().Deserialize(stringDownloadArguments.Result)));
                } else if (stringUploadArguments != null) {
                    callback(ApiResponse<TResult>.WithResult(new Serialization.JsonSerializer<TResult>().Deserialize(stringUploadArguments.Result)));
                } else {
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

            callback(ApiResponse<TResult>.WithException<TResult>(new Exceptions.VoucherifyClientException(arguments.Error)));
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

            callback(ApiResponse.WithException(new Exceptions.VoucherifyClientException(arguments.Error)));
        }


        private WebClient PrepareClient()
        {
            WebClient client = new WebClient();

            client.Headers.Add(Constants.HttpHeaderAppId, this.voucherify.AppId);
            client.Headers.Add(Constants.HttpHeaderAppToken, this.voucherify.AppToken);
            client.Headers.Add(Constants.HttpHeaderVoucherifyChannel, Constants.VoucherifyChannelName);
            client.Headers.Add("Accept", "application/json");
            client.Headers.Add("Content-Type", "application/json");

            return client;
        }
    }
}
