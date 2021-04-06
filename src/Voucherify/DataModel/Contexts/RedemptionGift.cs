#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionGift
    {
        [JsonProperty(PropertyName = "credits")]
        public long? Credits { get; set; }
    }
}
#endif