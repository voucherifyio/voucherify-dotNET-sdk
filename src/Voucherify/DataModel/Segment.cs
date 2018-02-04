#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Segment : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public SegmentType Type { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "filters")]
        public Metadata Filters { get; private set; }

        public Segment()
        {
            this.Filters = new Metadata();
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Segment(Id={0},Name={1},Type={2})", this.Id, this.Name, this.Type);
        }
    }
}
#endif