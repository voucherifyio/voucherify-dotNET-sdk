#if VOUCHERIFYCLIENT && !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Customers : EndpointBase
    {
        public Customers(Api api) : base(api)
        {
        }

        public void UpdateConsents (string customerId, DataModel.Contexts.CustomerConsentUpdate udpate, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/customers/{0}/consents", Uri.EscapeDataString(customerId)));
            this.client.DoPutRequest(uriBuilder.Uri, udpate, callback);
        }
    }
}
#endif