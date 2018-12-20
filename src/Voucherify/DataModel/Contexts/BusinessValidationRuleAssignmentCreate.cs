#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class BusinessValidationRuleAssignmentCreate
    {
        [JsonProperty(PropertyName = "campaign", NullValueHandling = NullValueHandling.Ignore)]
        public string Campaign { get; private set; }

        [JsonProperty(PropertyName = "voucher", NullValueHandling = NullValueHandling.Ignore)]
        public string Voucher { get; private set; }

        [JsonProperty(PropertyName = "promotion_tier", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionTier { get; private set; }

        public BusinessValidationRuleAssignmentCreate()
        {
        }

        public BusinessValidationRuleAssignmentCreate withVoucher(string voucher)
        {
            this.Voucher = voucher;
            this.PromotionTier = null;
            this.Campaign = null;
            return this;
        }

        public BusinessValidationRuleAssignmentCreate withCampaign(string campaign)
        {
            this.Voucher = null;
            this.PromotionTier = null;
            this.Campaign = campaign;
            return this;
        }

        public BusinessValidationRuleAssignmentCreate withPromotionTier(string promotionTier)
        {
            this.Voucher = null;
            this.PromotionTier = promotionTier;
            this.Campaign = null;
            return this;
        }
    }
}
#endif