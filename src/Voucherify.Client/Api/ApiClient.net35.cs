using System;
using RestSharp;
using System.Threading.Tasks;

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

        internal async Task<TResult> DoGetRequest<TResult>(Uri uri)
            where TResult : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            IRestResponse response = await ExecuteRequest(new RestRequest(uri, Method.GET));
            return serializerResult.Deserialize(this.ProcessResponse(response));
        }

        internal async Task<TResult> DoPostRequest<TResult>(Uri uri)
            where TResult : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            IRestResponse response = await ExecuteRequest(new RestRequest(uri, Method.POST));
            return serializerResult.Deserialize(this.ProcessResponse(response));
        }

        internal async Task<TResult> DoPostRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            Serialization.JsonSerializer<TPayload> serializerPayload = new Serialization.JsonSerializer<TPayload>();
            RestRequest request = new RestRequest(uri, Method.POST);
            request.AddBody(serializerPayload.Serialize(payload));
            IRestResponse response = await ExecuteRequest(request);
            return serializerResult.Deserialize(this.ProcessResponse(response));
        }

        internal async Task<TResult> DoPutRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            Serialization.JsonSerializer<TPayload> serializerPayload = new Serialization.JsonSerializer<TPayload>();
            RestRequest request = new RestRequest(uri, Method.PUT);
            request.AddBody(serializerPayload.Serialize(payload));
            IRestResponse response = await ExecuteRequest(request);
            return serializerResult.Deserialize(this.ProcessResponse(response));
        }

        internal async Task DoDeleteRequest(Uri uri)
        {
            RestRequest request = new RestRequest(uri, Method.DELETE);

            IRestResponse response = await ExecuteRequest(request);
            this.ProcessResponse(response);
        }

        internal UriBuilder GetUriBuilder(string path)
        {
            return new UriBuilder()
            {
                Path = path
            };
        }

        private string ProcessResponse(IRestResponse response)
        {
            string result = response.Content;

            if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
            {
                throw this.serializerException.Deserialize(result);
            }

            return result;
        }

        private Task<IRestResponse> ExecuteRequest(IRestRequest request) {
            RestClient client = PrepareClient();
            return Task.Factory.StartNew<IRestResponse>(() => client.Execute(request));
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
