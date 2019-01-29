using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.Tests.TestModel
{
    [JsonObject]
    internal class JsonTypeWithEnum
    {

        [JsonProperty(PropertyName = "property_test", NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }

        [JsonProperty(PropertyName = "array_test", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Array { get; set; }

        [JsonProperty(PropertyName = "dictionary_test", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Dictionary { get; set; }

        [JsonProperty(PropertyName = "enum_test", NullValueHandling = NullValueHandling.Ignore)]
        public EnumType? Enum { get; set; }
    }
}
