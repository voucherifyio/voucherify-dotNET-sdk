using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.Core.Tests.Serialization.DataModel
{
    [JsonObject]
    internal class JsonType
    {
        [JsonProperty(PropertyName = "property_test")]
        public string Property { get; set; }

        [JsonProperty(PropertyName = "array_test")]
        public IList<string> Array { get; set; }

        [JsonProperty(PropertyName = "dictionary_test")]
        public Dictionary<string, object> Dictionary { get; set; }

        [JsonProperty(PropertyName = "enum_test")]
        public string Enum { get; set; }
    }
}
