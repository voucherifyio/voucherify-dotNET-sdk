#if APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Redemptions : EndpointBase
    {
        public Redemptions(Api api) : base(api)
        {
        }

        public async Task<DataModel.Results.RedemptionResult> Redeem(DataModel.Queries.RedemptionQuery query, DataModel.Contexts.RedemptionContext context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redeem"), query);
            return await this.client.DoPostRequest<DataModel.Results.RedemptionResult, DataModel.Contexts.RedemptionContext>(uriBuilder.Uri, context);
        }
    }
}
#endif
