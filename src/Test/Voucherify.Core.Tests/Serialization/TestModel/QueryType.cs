using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.Core.Tests.Serialization.TestModel
{
    [JsonObject]
    internal class QueryType
    {
        [JsonProperty(PropertyName = "property_test", Order = 1)]
        public string Property { get; set; }

        [JsonProperty(PropertyName = "array_test", Order = 2)]
        public IList<string> Array { get; set; }

        [JsonProperty(PropertyName = "enum_test")]
        public EnumType? Enum { get; set; }
    }
}
