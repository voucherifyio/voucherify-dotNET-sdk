using System;
using RestSharp;
using RSG;

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

        internal IPromise<TResult> DoGetRequest<TResult>(Uri uri)
            where TResult : class
        {
            return ExecuteRequest<TResult>(this.PrepareRequest(uri, Method.GET));
        }

        internal IPromise DoPostRequest(Uri uri)
        {
            return ExecuteRequest(this.PrepareRequest(uri, Method.POST));
        }

        internal IPromise<TResult> DoPostRequest<TResult>(Uri uri)
            where TResult : class
        {
            return ExecuteRequest<TResult>(this.PrepareRequest(uri, Method.POST));
        }

        internal IPromise<TResult> DoPostRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            RestRequest request = this.PrepareRequest(uri, Method.POST);
            request.AddParameter("application/json", new Serialization.JsonSerializer<TPayload>().Serialize(payload), ParameterType.RequestBody);
            return ExecuteRequest<TResult>(request);;
        }

        internal IPromise<TResult> DoPutRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            RestRequest request = this.PrepareRequest(uri, Method.PUT);
            request.AddParameter("application/json", new Serialization.JsonSerializer<TPayload>().Serialize(payload), ParameterType.RequestBody);
            return ExecuteRequest<TResult>(request);
        }

        internal IPromise DoDeleteRequest(Uri uri)
        {
            RestRequest request = this.PrepareRequest(uri, Method.DELETE);
            return ExecuteRequest(request);
        }

        internal UriBuilder GetUriBuilder(string path)
        {
            return new UriBuilder()
            {
                Path = path
            };
        }

        private RestRequest PrepareRequest(Uri uri, Method method)
        {
            RestRequest request = new RestRequest(uri, method) { RequestFormat = DataFormat.Json };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.Parameters.Clear();
            return request;
        }

        private IPromise ExecuteRequest(IRestRequest request)
        {
            Promise promise = new Promise();
            RestClient client = PrepareClient();

            client.ExecuteAsync(request, (response) => {
                if (response.ErrorException != null)
                {
                    promise.Reject(new Exceptions.VoucherifyClientException(response.ErrorException));
                    return;
                }

                if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
                {
                    promise.Reject(this.serializerException.Deserialize(response.Content));
                    return;
                }

                promise.Resolve();
            });

            return promise;
        }

        private IPromise<TResult> ExecuteRequest<TResult>(IRestRequest request) 
            where TResult : class
        {
            Promise<TResult> promise = new Promise<TResult>();
            RestClient client = PrepareClient();

            client.ExecuteAsync(request, (response) => {
                if (response.ErrorException != null)
                {
                    promise.Reject(new Exceptions.VoucherifyClientException(response.ErrorException));
                    return;
                }

                if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
                {
                    promise.Reject(this.serializerException.Deserialize(response.Content));
                    return;
                }

                Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
                promise.Resolve(serializerResult.Deserialize(response.Content));
            });

            return promise;
        }

        private RestClient PrepareClient()
        {
            RestClient client = new RestClient(new UriBuilder(this.voucherify.Secure ? Uri.UriSchemeHttps : Uri.UriSchemeHttp, this.voucherify.Endpoint).Uri);
            client.AddDefaultHeader(Constants.HttpHeaderAppId, this.voucherify.AppId);
            client.AddDefaultHeader(Constants.HttpHeaderAppToken, this.voucherify.AppToken);
            client.AddDefaultHeader(Constants.HttpHeaderVoucherifyChannel, Constants.VoucherifyChannelName);
            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("Content-Type", "application/json");
            return client;
        }
    }
}
