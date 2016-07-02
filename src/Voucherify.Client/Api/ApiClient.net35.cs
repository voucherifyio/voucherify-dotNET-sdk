using System;
using System.Text;
using RestSharp;

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

        internal TResult DoGetRequest<TResult>(Uri uri)
            where TResult : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            RestClient client = this.PrepareClient();
            RestRequest request = new RestRequest(uri, Method.GET);
            return serializerResult.Deserialize(this.ProcessResponse(client.Execute(request)));
        }

        internal TResult DoPostRequest<TResult>(Uri uri)
            where TResult : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            RestClient client = this.PrepareClient();
            RestRequest request = new RestRequest(uri, Method.POST);
            return serializerResult.Deserialize(this.ProcessResponse(client.Execute(request)));
        }

        internal TResult DoPostRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            Serialization.JsonSerializer<TPayload> serializerPayload = new Serialization.JsonSerializer<TPayload>();
            RestClient client = this.PrepareClient();
            RestRequest request = new RestRequest(uri, Method.POST);
            request.AddBody(serializerPayload.Serialize(payload));
            return serializerResult.Deserialize(this.ProcessResponse(client.Execute(request)));
        }

        internal TResult DoPutRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            Serialization.JsonSerializer<TPayload> serializerPayload = new Serialization.JsonSerializer<TPayload>();
            RestClient client = this.PrepareClient();
            RestRequest request = new RestRequest(uri, Method.PUT);
            request.AddBody(serializerPayload.Serialize(payload));
            return serializerResult.Deserialize(this.ProcessResponse(client.Execute(request)));
        }

        internal void DoDeleteRequest(Uri uri)
        {
            RestClient client = this.PrepareClient();
            RestRequest request = new RestRequest(uri, Method.DELETE);
            this.ProcessResponse(client.Execute(request));
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

            if (!((int)response.StatusCode >= 200 && (int)response.StatusCode < 300))
            {
                throw this.serializerException.Deserialize(result);
            }

            return result;
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
