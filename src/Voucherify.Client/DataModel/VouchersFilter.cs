using Newtonsoft.Json;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class VouchersFilter
    {
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        [JsonProperty(PropertyName = "code_query")]
        public string CodeQuery { get; set; }

        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }

        [JsonProperty(PropertyName = "skip")]
        public int? Skip { get; set; }

        [JsonProperty(PropertyName = "campaign")]
        public string Campaign { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string Customer { get; set; }
    }
}
