#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ValidationVoucher : Validation
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        [JsonProperty(PropertyName = "campaign")]
        public string Campaign { get; private set; }

        [JsonProperty(PropertyName = "campaign_id")]
        public string CampaignId { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "gift")]
        public Gift Gift { get; private set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }

        public override string ToString()
        {
            return string.Format("Validation(Code={0},Result={1})", this.Code, base.ToString());
        }
    }
}
#endif