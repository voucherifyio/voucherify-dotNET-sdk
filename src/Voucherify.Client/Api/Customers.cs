using System;
using RSG;

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

        public IPromise<DataModel.Customer> Create(DataModel.Customer customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/customers");
            return this.client.DoPostRequest<DataModel.Customer, DataModel.Customer>(uriBuilder.Uri, customer);
        }

        public IPromise<DataModel.Customer> Get(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            return this.client.DoGetRequest<DataModel.Customer>(uriBuilder.Uri);
        }

        public IPromise<DataModel.Customer> Update(string customerId, DataModel.Customer customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            return this.client.DoPutRequest<DataModel.Customer, DataModel.Customer>(uriBuilder.Uri, customer);
        }

        public IPromise Delete(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
           return  this.client.DoDeleteRequest(uriBuilder.Uri);
        }
    }
}
