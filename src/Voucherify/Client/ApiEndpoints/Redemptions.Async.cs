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

        public async Task<DataModel.Results.RedemptionRedeem> Redeem(DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redeem"), query);
            return await this.client.DoPostRequest<DataModel.Results.RedemptionRedeem, DataModel.Contexts.RedemptionRedeem>(uriBuilder.Uri, context).ConfigureAwait(false);
        }
    }
}
#endif
