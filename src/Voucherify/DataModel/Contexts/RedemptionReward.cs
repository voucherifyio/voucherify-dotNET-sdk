#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionReward
    {
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignmentId { get; set; }

        [JsonProperty(PropertyName = "points", NullValueHandling = NullValueHandling.Ignore)]
        public long? Points { get; set; }
    }
}
#endif