using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.Core.Tests.Serialization.DataModel
{
    [JsonObject]
    internal class JsonTypeWithMetadata
    {
        [JsonProperty(PropertyName = "property_test")]
        public string Property { get; set; }

        [JsonProperty(PropertyName = "array_test")]
        public IList<string> Array { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "enum_test")]
        public string Enum { get; set; }
    }
}
