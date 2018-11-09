#if APIASYNC
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Voucherify.Core.Communication
{
    internal class ApiClient
    {
        private readonly bool isSecure;
        private readonly string baseAddress;
        private readonly Dictionary<string, string> headers;
        private readonly List<JsonConverter> converters;
        private Serialization.JsonSerializer<Exceptions.VoucherifyClientException> serializerException;

        internal ApiClient(bool isSecure, string baseAddress, Dictionary<string, string> headers, List<JsonConverter> converters)
        {
            this.isSecure = isSecure;
            this.headers = headers;
            this.baseAddress = baseAddress;
            this.converters = converters;
            this.serializerException = new Serialization.JsonSerializer<Exceptions.VoucherifyClientException>(converters);
        }

        internal async Task<TResult> DoGetRequest<TResult>(Uri uri)
           where TResult : class
        {
            using (HttpClient client = this.PrepareClient())
            {
                try
                { 
                    var response = await client.GetAsync(uri).ConfigureAwait(false);
                    return await EnsureResult<TResult>(response).ConfigureAwait(false);
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
                    var response = await client.PostAsync(uri, this.PrepareContent("{}")).ConfigureAwait(false);
                    await this.EnsureResult(response).ConfigureAwait(false);
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
                    var response = await client.PostAsync(uri, this.PrepareContent("{}")).ConfigureAwait(false);
                    return await EnsureResult<TResult>(response).ConfigureAwait(false);
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
                    var response = await client.PostAsync(uri, this.PrepareContent(new Serialization.JsonSerializer<TPayload>(this.converters).Serialize(payload))).ConfigureAwait(false);
                    return await EnsureResult<TResult>(response).ConfigureAwait(false);
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
                    var response = await client.PutAsync(uri, this.PrepareContent(new Serialization.JsonSerializer<TPayload>(this.converters).Serialize(payload))).ConfigureAwait(false);
                    return await EnsureResult<TResult>(response).ConfigureAwait(false);
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
                    var response = await client.DeleteAsync(uri).ConfigureAwait(false);
                    await EnsureResult(response).ConfigureAwait(false);
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
            return new UriBuilder(this.isSecure ? "HTTPS": "HTTP", this.baseAddress) { Path = path };
        }

        private async Task EnsureResult(HttpResponseMessage response)
        {
            string resultString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
            {
                Exceptions.VoucherifyClientException exception;

                try
                {
                    exception = this.serializerException.Deserialize(resultString);
                    exception = new Exceptions.VoucherifyClientException(exception.Message, exception.Code, exception.Details, exception.Key);
                }
                catch
                {
                    exception = new Exceptions.VoucherifyClientException(response.StatusCode.ToString(), (int)response.StatusCode, resultString, string.Empty);
                }

                throw exception;
            }
        }

        private async Task<TResult> EnsureResult<TResult>(HttpResponseMessage response)
            where TResult : class
        {
            string resultString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
            {
                Exceptions.VoucherifyClientException exception;

                try
                {
                    exception = this.serializerException.Deserialize(resultString);
                    exception = new Exceptions.VoucherifyClientException(exception.Message, exception.Code, exception.Details, exception.Key);
                }
                catch
                {
                    exception = new Exceptions.VoucherifyClientException(response.StatusCode.ToString(), (int)response.StatusCode, resultString, string.Empty);
                }

                throw exception;
            }

            return new Serialization.JsonSerializer<TResult>(this.converters).Deserialize(resultString);
        }

        private StringContent PrepareContent(string content)
        {
            return new StringContent(content, Encoding.UTF8, "application/json");
        }
        
        private HttpClient PrepareClient()
        {

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolTypeExtensions.Tls12;

            HttpClient client = new HttpClient();
            
            foreach (var entry in this.headers)
            {
                client.DefaultRequestHeaders.Add(entry.Key, entry.Value);
            }

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }
    }
}
#endif