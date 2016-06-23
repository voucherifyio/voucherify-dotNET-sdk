using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<DataModel.Customer> Create(DataModel.Customer customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/customers");
            return await this.client.DoPostRequest<DataModel.Customer, DataModel.Customer>(uriBuilder.Uri, customer);
        }

        public async Task<DataModel.Customer> Get(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            return await this.client.DoGetRequest<DataModel.Customer>(uriBuilder.Uri);
        }

        public async Task<DataModel.Customer> Update(string customerId, DataModel.Customer customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            return await this.client.DoPutRequest<DataModel.Customer, DataModel.Customer>(uriBuilder.Uri, customer);
        }

        public async Task Delete(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", customerId));
            await this.client.DoDeleteRequest(uriBuilder.Uri);
        }
    }
}
