#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json; 

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionSession
    {
        [JsonProperty(PropertyName = "key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "ttl", NullValueHandling = NullValueHandling.Ignore)]
        public string TTL { get; set; }

        [JsonProperty(PropertyName = "ttl_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TTLUnit { get; set; }
    }
}
#endif