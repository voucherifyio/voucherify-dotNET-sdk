using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.Tests.TestModel
{
    [JsonObject]
    internal class QueryType
    {
        [JsonProperty(PropertyName = "property_test", Order = 1, NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }
        
        [JsonProperty(PropertyName = "array_test", Order = 2, NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Array { get; set; }

        [JsonProperty(PropertyName = "array_json", Order = 3, NullValueHandling = NullValueHandling.Ignore)]
        public IList<JsonType> ArrayJson { get; set; }

        [JsonProperty(PropertyName = "array_json_with_metadata", Order = 4, NullValueHandling = NullValueHandling.Ignore)]
        public IList<JsonTypeWithMetadata> ArrayJsonWithMetadata { get; set; }

        [JsonProperty(PropertyName = "enum_test", Order = 5, NullValueHandling = NullValueHandling.Ignore)]
        public EnumType? Enum { get; set; }
    }
}
