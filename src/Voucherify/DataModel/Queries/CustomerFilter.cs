#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class CustomerFilter
    {
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
#endif