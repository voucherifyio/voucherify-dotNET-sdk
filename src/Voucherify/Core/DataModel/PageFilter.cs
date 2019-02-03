using Newtonsoft.Json;
using System;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class PageFilter
    {
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        
        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }
    }
}
