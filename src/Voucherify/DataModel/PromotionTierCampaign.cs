#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class PromotionTierCampaign : ApiObject
    {
        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "expiration_date")]
        public DateTime? ExpirationDate { get; private set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; private set; }

        public PromotionTierCampaign()
        {
        }

        public override string ToString()
        {
            return string.Format("PromotionTierCampaign(Active={0})", this.Active);
        }
    }
}
#endif