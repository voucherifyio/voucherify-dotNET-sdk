#if VOUCHERIFYCLIENT && APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
	public class Customers : EndpointBase
    {
        public Customers(Api api) : base(api)
        {
        }

        public async Task<Core.DataModel.Empty> UpdateConsents (string customerId, DataModel.Contexts.CustomerConsentUpdate udpate)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}/consents", Uri.EscapeDataString(customerId)));
            return await this.client.DoPutRequest<Core.DataModel.Empty, DataModel.Contexts.CustomerConsentUpdate>(uriBuilder.Uri, udpate).ConfigureAwait(false);
        }
    }
}
#endif