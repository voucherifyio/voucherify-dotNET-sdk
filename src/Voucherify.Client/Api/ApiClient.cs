using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Voucherify.Client.Api
{
    internal class ApiClient
    {
        private VoucherifyClient client;

        internal ApiClient(VoucherifyClient client)
        {
            this.client = client;
        }

        internal async Task<TResult> DoGetRequest<TResult>(Uri uri)
            where TResult: class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();

            using (HttpClient httpClient = this.PreapreHttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                string result = await response.RequestMessage.Content.ReadAsStringAsync();
                return serializerResult.Deserialize(result);
            }
        }

        internal async Task<TResult> DoPostRequest<TResult>(Uri uri) 
            where TResult : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();

            using (HttpClient httpClient = this.PreapreHttpClient())
            { 
                HttpResponseMessage response = await httpClient.PostAsync(uri, null);
                string result = await response.RequestMessage.Content.ReadAsStringAsync();
                return serializerResult.Deserialize(result);
            }
        }

        internal async Task<TResult> DoPostRequest<TResult, TPayload>(Uri uri, TPayload payload) 
            where TResult : class 
            where TPayload : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            Serialization.JsonSerializer<TPayload> serializerPayload = new Serialization.JsonSerializer<TPayload>();

            using (HttpClient httpClient = this.PreapreHttpClient())
            {
                HttpResponseMessage response = await httpClient.PostAsync(uri, new StringContent(serializerPayload.Serialize(payload), Encoding.UTF8, "application/json"));
                string result = await response.RequestMessage.Content.ReadAsStringAsync();
                return serializerResult.Deserialize(result);
            }
        }

        private HttpClient PreapreHttpClient()
        {
            UriBuilder uriBuilder = new UriBuilder(this.client.Secure ? Uri.UriSchemeHttps : Uri.UriSchemeHttp, this.client.Endpoint);
            HttpClient client = new HttpClient() { BaseAddress = uriBuilder.Uri };
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderAppId, this.client.AppId);
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderAppToken, this.client.AppToken);
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderVoucherifyChannel, Constants.VoucherifyChannelName);
            return client;
        }
    }
}
