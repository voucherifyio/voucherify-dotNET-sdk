#if VOUCHERIFYSERVER && !APIASYNC
using System;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
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

        public void Get(string promotionTierId, Action<ApiResponse<DataModel.PromotionTier>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/tiers/{0}", UriBuilderExtension.EnsureEscapedDataString("promotionTierId", promotionTierId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void ListForCampaign(string campaign, Action<ApiResponse<DataModel.PromotionTierList>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/{0}/tiers", UriBuilderExtension.EnsureEscapedDataString("campaign", campaign)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void CreateCampaign(DataModel.Contexts.CampaignPromotionCreate promotionCampaign, Action<ApiResponse<DataModel.Campaign>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/campaigns/");
            this.client.DoPostRequest(uriBuilder.Uri, promotionCampaign, callback);
        }

        public void AddTierToCampaign(string campaignId, DataModel.Contexts.PromotionTierCreate promotionTier, Action<ApiResponse<DataModel.PromotionTier>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/{0}/tiers", UriBuilderExtension.EnsureEscapedDataString("campaignId", campaignId)));
            this.client.DoPutRequest(uriBuilder.Uri, promotionTier, callback);
        }


        public void Update(string promotionTierId, DataModel.Contexts.PromotionTierUpdate promotionTier, Action<ApiResponse<DataModel.PromotionTier>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/tiers/{0}", UriBuilderExtension.EnsureEscapedDataString("promotionTierId", promotionTierId)));
            this.client.DoPutRequest(uriBuilder.Uri, promotionTier, callback);
        }

        public void Delete(string promotionTierId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/tiers/{0}", UriBuilderExtension.EnsureEscapedDataString("promotionTierId", promotionTierId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif