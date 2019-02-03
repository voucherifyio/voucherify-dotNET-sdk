#if VOUCHERIFYCLIENT && APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Promotions : EndpointBase
    {
        public Promotions(Api api) : base(api)
        {
        }

        public async Task<DataModel.PromotionTierList> List(DataModel.Queries.PromotionTiersFilter filter)
        {
            UriBuilder uriBuilder =  UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/promotions/tiers"), filter);
            return await this.client.DoGetRequest<DataModel.PromotionTierList>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif