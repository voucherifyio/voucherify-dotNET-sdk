using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.Tests.TestModel
{
    [JsonObject]
    internal class JsonTypeWithMetadata
    {
        [JsonProperty(PropertyName = "property_test", NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }

        [JsonProperty(PropertyName = "property_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PropertyDateTime { get; set; }

        [JsonProperty(PropertyName = "array_test", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Array { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "enum_test", NullValueHandling = NullValueHandling.Ignore)]
        public string Enum { get; set; }
    }
}
