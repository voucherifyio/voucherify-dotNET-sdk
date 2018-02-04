#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class VouchersFilter
    {
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }

        [JsonProperty(PropertyName = "campaign")]
        public string Campaign { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string Customer { get; set; }
    }
}
#endif