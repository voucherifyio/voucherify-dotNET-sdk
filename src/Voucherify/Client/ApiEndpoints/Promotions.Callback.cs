#if VOUCHERIFYCLIENT && !APIASYNC
using System;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Promotions : EndpointBase
    {
        public Promotions(Api api) : base(api)
        {
        }

        public void List(DataModel.Queries.PromotionTiersFilter filter, Action<ApiResponse<DataModel.PromotionTierList>> callback)
        {
            UriBuilder uriBuilder =  UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/promotions/tiers"), filter);
            this.client.DoGetRequest<DataModel.PromotionTierList>(uriBuilder.Uri, callback);
        }
    }
}
#endif