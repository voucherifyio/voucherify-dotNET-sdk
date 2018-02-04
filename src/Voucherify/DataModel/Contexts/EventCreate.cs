#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class EventCreate
    {
        [JsonProperty(PropertyName = "event")]
        public string Event { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public EventCreate()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif