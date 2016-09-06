using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Api
{
    internal class ApiClient
    {
        private VoucherifyClient voucherify;
        private Serialization.JsonSerializer<Exceptions.VoucherifyClientExceptionPortable> serializerException;

        internal ApiClient(VoucherifyClient voucherify)
        {
            this.voucherify = voucherify;
            this.serializerException = new Serialization.JsonSerializer<Exceptions.VoucherifyClientExceptionPortable>();
        }

        internal async Task<TResult> DoGetRequest<TResult>(Uri uri)
           where TResult : class
        {
            using (HttpClient client = this.PrepareClient())
            {
                try
                { 
                    var response = await client.GetAsync(uri);
                    return await EnsureResult<TResult>(response);
                }
                catch(Exception exception)
                {
                    if (exception is Exceptions.VoucherifyClientException)
                    {
                        throw exception;
                    }

                    throw new Exceptions.VoucherifyClientException(exception);
                }
            }
        }

        internal async Task DoPostRequest(Uri uri)
        {
            using (HttpClient client = this.PrepareClient())
            {
                try
                { 
                    var response = await client.PostAsync(uri, this.PrepareContent(string.Empty));
                    await this.EnsureResult(response);
                }
                catch (Exception exception)
                {
                    if (exception is Exceptions.VoucherifyClientException)
                    {
                        throw exception;
                    }

                    throw new Exceptions.VoucherifyClientException(exception);
                }
            }
        }

        internal async Task<TResult> DoPostRequest<TResult>(Uri uri)
            where TResult : class
        {
            using (HttpClient client = this.PrepareClient())
            {
                try
                {
                    var response = await client.PostAsync(uri, this.PrepareContent(string.Empty));
                    return await EnsureResult<TResult>(response);
                }
                catch(Exception exception)
                {
                    if (exception is Exceptions.VoucherifyClientException)
                    {
                        throw exception;
                    }

                    throw new Exceptions.VoucherifyClientException(exception);
                }
            }
        }

        internal async Task<TResult> DoPostRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            using (HttpClient client = this.PrepareClient())
            {
                try
                {
                    var response = await client.PostAsync(uri, this.PrepareContent(new Serialization.JsonSerializer<TPayload>().Serialize(payload)));
                    return await EnsureResult<TResult>(response);
                }
                catch (Exception exception)
                {
                    if (exception is Exceptions.VoucherifyClientException)
                    {
                        throw exception;
                    }

                    throw new Exceptions.VoucherifyClientException(exception);
                }
            }
        }

        internal async Task<TResult> DoPutRequest<TResult, TPayload>(Uri uri, TPayload payload)
            where TResult : class
            where TPayload : class
        {
            using (HttpClient client = this.PrepareClient())
            {
                try
                {
                    var response = await client.PutAsync(uri, this.PrepareContent(new Serialization.JsonSerializer<TPayload>().Serialize(payload)));
                    return await EnsureResult<TResult>(response);
                }
                catch (Exception exception)
                {
                    if (exception is Exceptions.VoucherifyClientException)
                    {
                        throw exception;
                    }

                    throw new Exceptions.VoucherifyClientException(exception);
                }
            }
        }

        internal async Task DoDeleteRequest(Uri uri)
        {
            using (HttpClient client = this.PrepareClient())
            {
                try
                {
                    var response = await client.DeleteAsync(uri);
                    await EnsureResult(response);
                }
                catch (Exception exception)
                {
                    if (exception is Exceptions.VoucherifyClientException)
                    {
                        throw exception;
                    }

                    throw new Exceptions.VoucherifyClientException(exception);
                }
            }
        }

        internal UriBuilder GetUriBuilder(string path)
        {
            return new UriBuilder(this.voucherify.Secure ? "HTTPS": "HTTP", this.voucherify.Endpoint)
            {
                Path = path
            };
        }

        private async Task EnsureResult(HttpResponseMessage response)
        {
            string resultString = await response.Content.ReadAsStringAsync();

            if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
            {
                Exceptions.VoucherifyClientExceptionPortable exception = this.serializerException.Deserialize(resultString);
                throw new Exceptions.VoucherifyClientException(exception.Message, exception.Code, exception.Details);
            }
        }

        private async Task<TResult> EnsureResult<TResult>(HttpResponseMessage response)
            where TResult : class
        {

            string resultString = await response.Content.ReadAsStringAsync();

            if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
            {
                Exceptions.VoucherifyClientExceptionPortable exception = this.serializerException.Deserialize(resultString);
                throw new Exceptions.VoucherifyClientException(exception.Message, exception.Code, exception.Details);
            }

            return new Serialization.JsonSerializer<TResult>().Deserialize(resultString);
        }

        private StringContent PrepareContent(string content)
        {
            return new StringContent(content, Encoding.UTF8, "application/json");
        }
        
        private HttpClient PrepareClient()
        {
            HttpClient client = new HttpClient();
            
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderAppId, this.voucherify.AppId);
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderAppToken, this.voucherify.AppToken);
            client.DefaultRequestHeaders.Add(Constants.HttpHeaderVoucherifyChannel, Constants.VoucherifyChannelName);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }
    }
}
