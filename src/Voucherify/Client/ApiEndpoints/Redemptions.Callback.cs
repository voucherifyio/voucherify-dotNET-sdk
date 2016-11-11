#if !APIASYNC
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

        public void Redeem(DataModel.Queries.RedemptionQuery query, DataModel.Contexts.RedemptionContext context, Action<ApiResponse<DataModel.Results.RedemptionResult>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redeem"), query);
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }
    }
}
#endif