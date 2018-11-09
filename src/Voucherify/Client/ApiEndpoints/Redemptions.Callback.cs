#if VOUCHERIFYCLIENT && !APIASYNC
using System;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Redemptions : EndpointBase
    {
        public Redemptions(Api api) : base(api)
        {
        }

        public void Redeem(DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context, Action<ApiResponse<DataModel.Redemption>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redeem"), query);
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }
    }
}
#endif