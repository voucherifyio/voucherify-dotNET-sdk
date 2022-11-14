#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherPublishSingle
    {
        [JsonProperty(PropertyName = "campaign", NullValueHandling = NullValueHandling.Ignore)]
        public string Campaign { get; set; }

        [JsonProperty(PropertyName = "channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "voucher", NullValueHandling = NullValueHandling.Ignore)]
        public string Voucher { get; set; }

        [JsonProperty(PropertyName = "customer", NullValueHandling = NullValueHandling.Ignore)]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        public VoucherPublishSingle()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif