#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedeemableGift
    {
        [JsonProperty(PropertyName = "credits")]
        public long? Credits { get; set; }
    }
}
#endif
