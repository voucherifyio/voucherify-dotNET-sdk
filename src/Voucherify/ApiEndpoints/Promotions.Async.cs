#if VOUCHERIFYSERVER && APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Promotions : EndpointBase
    {
        public Promotions(Api api) : base(api)
        {
        }


        public async Task<DataModel.PromotionTier> Get(string promotionTierId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/tiers/{0}", Uri.EscapeDataString(promotionTierId)));
            return await this.client.DoGetRequest<DataModel.PromotionTier>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.PromotionTierList> ListForCampaign(string campaign)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/{0}/tiers", Uri.EscapeDataString(campaign)));
            return await this.client.DoGetRequest<DataModel.PromotionTierList>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Campaign> CreateCampaign(DataModel.Contexts.CampaignPromotionCreate promotionCampaign)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/campaigns/");
            return await this.client.DoPostRequest<DataModel.Campaign, DataModel.Contexts.CampaignPromotionCreate>(uriBuilder.Uri, promotionCampaign).ConfigureAwait(false);
        }

        public async Task<DataModel.PromotionTier> AddTierToCampaign(string campaignId, DataModel.Contexts.PromotionTierCreate promotionTier)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/{0}/tiers", Uri.EscapeDataString(campaignId)));
            return await this.client.DoPutRequest<DataModel.PromotionTier, DataModel.Contexts.PromotionTierCreate>(uriBuilder.Uri, promotionTier).ConfigureAwait(false);
        }


        public async Task<DataModel.PromotionTier> Update(string promotionTierId, DataModel.Contexts.PromotionTierUpdate promotionTier)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/tiers/{0}", Uri.EscapeDataString(promotionTierId)));
            return await this.client.DoPutRequest<DataModel.PromotionTier, DataModel.Contexts.PromotionTierUpdate>(uriBuilder.Uri, promotionTier).ConfigureAwait(false);
        }

        public async Task Delete(string promotionTierId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/tiers/{0}", Uri.EscapeDataString(promotionTierId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif