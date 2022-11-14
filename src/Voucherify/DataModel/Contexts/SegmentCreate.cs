#if VOUCHERIFYSERVER
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class SegmentCreate
    {
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "customers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Customers { get; private set; }

        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public SegmentType Type { get; private set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Filters { get; private set; }

        public SegmentCreate()
        {
            this.Filters = new Metadata();
            this.Metadata = new Metadata();
            this.Customers = new List<string>();
        }
    }
}
#endif