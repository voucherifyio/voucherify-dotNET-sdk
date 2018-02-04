#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class PromotionTierListCreate
    {
        [JsonProperty(PropertyName = "tiers")]
        public List<PromotionTierCreate> Tiers { get; private set; }

        public PromotionTierListCreate()
        {
            this.Tiers = new List<PromotionTierCreate>();
        }

        public PromotionTierListCreate WithTiers(List<PromotionTierCreate> tiers)
        {
            this.Tiers = tiers;
            return this;
        }
    }
}
#endif