using Newtonsoft.Json;
using System;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class DateFilter
    {
        [JsonProperty(PropertyName = "after", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? After { get; set; }

        [JsonProperty(PropertyName = "before", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Before { get; set; }
    }
}
