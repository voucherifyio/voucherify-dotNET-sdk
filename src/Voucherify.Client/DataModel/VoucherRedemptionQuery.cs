using Newtonsoft.Json;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class VoucherRedemptionQuery
    {
        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; set; }
    }
}
