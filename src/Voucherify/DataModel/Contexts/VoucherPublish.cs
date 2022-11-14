#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherPublish
    {
        [JsonObject]
        public class VoucherPublishCampaign
        {
            [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "count", NullValueHandling = NullValueHandling.Ignore)]
            public int Count { get; set; }

            public VoucherPublishCampaign()
            {
                this.Count = 1;
            }
        }
       
        [JsonProperty(PropertyName = "campaign", NullValueHandling = NullValueHandling.Ignore)]
        public VoucherPublishCampaign Campaign { get; set; }

        [JsonProperty(PropertyName = "channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "voucher", NullValueHandling = NullValueHandling.Ignore)]
        public string Voucher { get; set; }

        [JsonProperty(PropertyName = "customer", NullValueHandling = NullValueHandling.Ignore)]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        public VoucherPublish()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif