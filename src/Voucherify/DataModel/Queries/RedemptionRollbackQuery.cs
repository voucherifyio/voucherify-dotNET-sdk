#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class RedemptionRollbackQuery
    {
        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
    }
}
#endif