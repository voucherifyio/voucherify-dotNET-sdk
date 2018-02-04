using System;
using Newtonsoft.Json;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class ApiObject
    {
        [JsonProperty(PropertyName = "object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; internal set; }

        [JsonProperty(PropertyName = "created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; internal set; }
        
        [JsonProperty(PropertyName = "updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; internal set; }

        public override string ToString()
        {
            return string.Format("{0}()", string.IsNullOrEmpty(this.Object) ? "object" : this.Object);
        }
    }
}
