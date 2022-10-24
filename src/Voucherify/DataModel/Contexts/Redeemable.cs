#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class Redeemable
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        [JsonProperty(PropertyName = "reward")]
        public RedeemableReward Reward { get; set; }

        [JsonProperty(PropertyName = "gift")]
        public RedeemableGift Gift { get; set; }
    }
}
#endif
