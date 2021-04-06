#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionReward
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "assignment_id")]
        public string AssignmentId { get; set; }

        [JsonProperty(PropertyName = "points")]
        public long? Points { get; set; }
    }
}
#endif