#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class RedemptionRedeem
    {
        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; set; }
    }
}
#endif
