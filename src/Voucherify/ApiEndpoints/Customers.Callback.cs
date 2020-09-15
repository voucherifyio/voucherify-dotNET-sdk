#if VOUCHERIFYSERVER && !APIASYNC
using System;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;
using DataModel = Voucherify.DataModel;

namespace Voucherify.ApiEndpoints
{
    public class Customers : EndpointBase
    {
        public Customers(Api api) : base(api)
        {
        }

        public void Create(DataModel.Contexts.CustomerCreate customer, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/customers");
            this.client.DoPostRequest(uriBuilder.Uri, customer, callback);
        }

        public void Get(string customerId, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Update(string customerId, DataModel.Contexts.CustomerUpdate customer, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            this.client.DoPutRequest(uriBuilder.Uri, customer, callback);
        }

        public void Delete(string customerId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void List(DataModel.Queries.CustomerFilter filter, Action<ApiResponse<DataModel.CustomerList>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/customers/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void UpdateConsents (string customerId, DataModel.Contexts.CustomerConsentUpdate udpate, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}/consents", Uri.EscapeDataString(customerId)));
            this.client.DoPutRequest(uriBuilder.Uri, udpate, callback);
        }
    }
}
#endif