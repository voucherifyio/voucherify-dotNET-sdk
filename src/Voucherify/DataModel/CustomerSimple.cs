#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerSimple : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public CustomerSimple()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("CustomerSimple(Id={0},SoruceId={1},Name={2})", this.Id, this.SourceId, this.Name);
        }
    }
}
#endif
