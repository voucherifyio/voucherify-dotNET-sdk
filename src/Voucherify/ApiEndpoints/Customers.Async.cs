#if APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Customers : EndpointBase
    {
        public Customers(Api api) : base(api)
        {
        }

        public async Task<DataModel.Customer> Create(DataModel.Customer customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/customers");
            return await this.client.DoPostRequest<DataModel.Customer, DataModel.Customer>(uriBuilder.Uri, customer);
        }

        public async Task<DataModel.Customer> Get(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            return await this.client.DoGetRequest<DataModel.Customer>(uriBuilder.Uri);
        }

        public async Task<DataModel.Customer> Update(string customerId, DataModel.Contexts.CustomerUpdateContext customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            return await this.client.DoPutRequest<DataModel.Customer, DataModel.Contexts.CustomerUpdateContext>(uriBuilder.Uri, customer);
        }

        public async Task Delete(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri);
        }
    }
}
#endif