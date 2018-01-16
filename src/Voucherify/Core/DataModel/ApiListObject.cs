using Newtonsoft.Json;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class ApiListObject : ApiObject
    {
        [JsonProperty(PropertyName = "total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; internal set; }

        [JsonProperty(PropertyName = "data_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string DataRef { get; internal set; }
    }
}
