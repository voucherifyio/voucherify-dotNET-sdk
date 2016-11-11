#if !APIASYNC
using System;
using Voucherify.Core.Communication;

namespace Voucherify.ApiEndpoints
{
    public class Customers : EndpointBase
    {
        public Customers(Api api) : base(api)
        {
        }

        public void Create(DataModel.Customer customer, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/customers");
            this.client.DoPostRequest(uriBuilder.Uri, customer, callback);
        }

        public void Get(string customerId, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Update(string customerId, DataModel.Contexts.CustomerUpdateContext customer, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            this.client.DoPutRequest(uriBuilder.Uri, customer, callback);
        }

        public void Delete(string customerId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif