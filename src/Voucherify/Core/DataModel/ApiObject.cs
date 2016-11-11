using Newtonsoft.Json;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class ApiObject
    {
        [JsonProperty(PropertyName = "object")]
        public string Object { get; private set; }
    }
}
