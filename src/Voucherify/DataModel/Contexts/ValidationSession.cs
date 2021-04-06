#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class ValidationSession
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "ttl")]
        public string TTL { get; set; }

        [JsonProperty(PropertyName = "ttl_unit")]
        public string TTLUnit { get; set; }
    }
}
#endif