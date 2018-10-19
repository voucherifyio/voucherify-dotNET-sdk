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
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "count")]
            public int Count { get; set; }

            public VoucherPublishCampaign()
            {
                this.Count = 1;
            }
        }
       
        [JsonProperty(PropertyName = "campaign")]
        public VoucherPublishCampaign Campaign { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "voucher")]
        public string Voucher { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public VoucherPublish()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif