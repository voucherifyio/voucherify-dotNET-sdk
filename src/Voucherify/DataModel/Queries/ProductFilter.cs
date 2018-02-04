#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class ProductFilter
    {
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }
    }
}
#endif