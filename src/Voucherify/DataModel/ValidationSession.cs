using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ValidationSession
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        [JsonProperty(PropertyName = "ttl")]
        public string TTL { get; private set; }

        [JsonProperty(PropertyName = "ttl_unit")]
        public string TTLUnit { get; private set; }

        public ValidationSession()
        {
        }
    }
}
