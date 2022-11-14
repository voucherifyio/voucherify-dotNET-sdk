#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedeemableGift
    {
        [JsonProperty(PropertyName = "credits", NullValueHandling = NullValueHandling.Ignore)]
        public long? Credits { get; set; }
    }
}
#endif
