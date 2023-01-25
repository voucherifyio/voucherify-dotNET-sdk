#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class Referral
    {
        [JsonProperty(PropertyName = "code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "referrer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferrerId { get; set; }
    }
}
#endif