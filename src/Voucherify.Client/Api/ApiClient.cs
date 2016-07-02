using System;
using System.Net.Http;
using System.Text;
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
            where TResult: class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();

            using (HttpClient client = this.PrepareClient())
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                return serializerResult.Deserialize(await this.ProcessResponse(response));
            }
        }

        internal async Task<TResult> DoPostRequest<TResult>(Uri uri) 
            where TResult : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();

            using (HttpClient client = this.PrepareClient())
            { 
                HttpResponseMessage response = await client.PostAsync(uri, null);
                return serializerResult.Deserialize(await this.ProcessResponse(response));
            }
        }

        internal async Task<TResult> DoPostRequest<TResult, TPayload>(Uri uri, TPayload payload) 
            where TResult : class 
            where TPayload : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            Serialization.JsonSerializer<TPayload> serializerPayload = new Serialization.JsonSerializer<TPayload>();

            using (HttpClient client = this.PrepareClient())
            {
                HttpResponseMessage response = await client.PostAsync(uri, new StringContent(serializerPayload.Serialize(payload), Encoding.UTF8, "application/json"));
                return serializerResult.Deserialize(await this.ProcessResponse(response));
            }
        }

        internal async Task<TResult> DoPutRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            Serialization.JsonSerializer<TResult> serializerResult = new Serialization.JsonSerializer<TResult>();
            Serialization.JsonSerializer<TPayload> serializerPayload = new Serialization.JsonSerializer<TPayload>();

            using (HttpClient client = this.PrepareClient())
            {
                HttpResponseMessage response = await client.PutAsync(uri, new StringContent(serializerPayload.Serialize(payload), Encoding.UTF8, "application/json"));
                return serializerResult.Deserialize(await this.ProcessResponse(response));
            }
        }

        internal async Task DoDeleteRequest(Uri uri)
        {
            using (HttpClient client = this.PrepareClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(uri);
                await this.ProcessResponse(response);
            }
        }

        internal UriBuilder GetUriBuilder(string path)
        {
            return new UriBuilder(this.voucherify.Secure ? Uri.UriSchemeHttps : Uri.UriSchemeHttp, this.voucherify.Endpoint) {
                Path = path
            };
        }

        private async Task<string> ProcessResponse(HttpResponseMessage response)
        {
            string result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw this.serializerException.Deserialize(result);
            }

            return result;
        }

        private HttpClient PrepareClient()
        {
            HttpClient client = new HttpClient() { };
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderAppId, this.voucherify.AppId);
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderAppToken, this.voucherify.AppToken);
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderVoucherifyChannel, Constants.VoucherifyChannelName);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            return client;
        }
    }
}
