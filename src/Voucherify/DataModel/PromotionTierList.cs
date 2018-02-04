#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class PromotionTierList : ApiListObject
    {
        [JsonProperty(PropertyName = "tiers")]
        public List<PromotionTier> Tiers { get; private set; }

        public override string ToString()
        {
            return string.Format("PromotionTierCampaign(Total={0})", this.Total);
        }
    }
}
#endif