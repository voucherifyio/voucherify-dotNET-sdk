#if VOUCHERIFYSERVER
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class SegmentCreate
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "customers")]
        public List<string> Customers { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public SegmentType Type { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "filters")]
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