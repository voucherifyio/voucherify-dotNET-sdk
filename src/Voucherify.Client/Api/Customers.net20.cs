using System;

namespace Voucherify.Client.Api
{
    public class Customers
    {
        private ApiClient client;

        public Customers(VoucherifyClient voucherify)
        {
            if (voucherify == null)
            {
                throw new ArgumentNullException("voucherify");
            }

            this.client = new ApiClient(voucherify);
        }

        public void Create(DataModel.Customer customer, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/customers");
            this.client.DoPostRequest<DataModel.Customer, DataModel.Customer>(uriBuilder.Uri, customer, callback);
        }

        public void Get(string customerId, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            this.client.DoGetRequest<DataModel.Customer>(uriBuilder.Uri, callback);
        }

        public void Update(string customerId, DataModel.Customer customer, Action<ApiResponse<DataModel.Customer>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            this.client.DoPutRequest<DataModel.Customer, DataModel.Customer>(uriBuilder.Uri, customer, callback);
        }

        public void Delete(string customerId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }
    }
}
