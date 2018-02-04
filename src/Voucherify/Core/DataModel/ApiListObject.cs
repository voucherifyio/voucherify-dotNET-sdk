using Newtonsoft.Json;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class ApiListObject
    {
        [JsonProperty(PropertyName = "object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; internal set; }

        [JsonProperty(PropertyName = "total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; internal set; }

        [JsonProperty(PropertyName = "data_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string DataRef { get; internal set; }

        public override string ToString()
        {
            return string.Format("{0}(Total={1})", string.IsNullOrEmpty(this.Object) ? "list" : this.Object, this.Total);
        }
    }
}
