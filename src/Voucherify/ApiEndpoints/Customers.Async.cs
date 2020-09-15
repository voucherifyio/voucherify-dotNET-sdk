#if VOUCHERIFYSERVER && APIASYNC
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

        public async Task<DataModel.Customer> Create(DataModel.Contexts.CustomerCreate customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/customers");
            return await this.client.DoPostRequest<DataModel.Customer, DataModel.Contexts.CustomerCreate>(uriBuilder.Uri, customer).ConfigureAwait(false);
        }

        public async Task<DataModel.Customer> Get(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            return await this.client.DoGetRequest<DataModel.Customer>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Customer> Update(string customerId, DataModel.Contexts.CustomerUpdate customer)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            return await this.client.DoPutRequest<DataModel.Customer, DataModel.Contexts.CustomerUpdate>(uriBuilder.Uri, customer).ConfigureAwait(false);
        }

        public async Task Delete(string customerId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}", Uri.EscapeDataString(customerId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.CustomerList> List(DataModel.Queries.CustomerFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/customers/"), filter);
            return await this.client.DoGetRequest<DataModel.CustomerList>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<Core.DataModel.Empty> UpdateConsents (string customerId, DataModel.Contexts.CustomerConsentUpdate udpate)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}/consents", Uri.EscapeDataString(customerId)));
            return await this.client.DoPutRequest<Core.DataModel.Empty, DataModel.Contexts.CustomerConsentUpdate>(uriBuilder.Uri, udpate).ConfigureAwait(false);
        }
    }
}
#endif