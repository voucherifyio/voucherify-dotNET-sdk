#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class RedemptionQuery
    {
        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; set; }
    }
}
#endif
