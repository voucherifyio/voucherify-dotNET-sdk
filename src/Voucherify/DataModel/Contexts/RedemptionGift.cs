#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionGift
    {
        [JsonProperty(PropertyName = "credits", NullValueHandling = NullValueHandling.Ignore)]
        public long? Credits { get; set; }
    }
}
#endif