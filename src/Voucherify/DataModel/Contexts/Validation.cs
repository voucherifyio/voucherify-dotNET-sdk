#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class Validation
    {
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "reward")]
        public ValidationReward Reward { get; set; }

        [JsonProperty(PropertyName = "gift")]
        public ValidationGift Gift { get; set; }

        [JsonProperty(PropertyName = "session")]
        public ValidationSession Session { get; set; }
    }
}
#endif