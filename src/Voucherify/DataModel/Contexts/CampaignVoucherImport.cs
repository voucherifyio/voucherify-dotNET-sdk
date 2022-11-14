#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CampaignVoucherImport
    {
        [JsonProperty(PropertyName = "additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalInfo { get; set; }

        [JsonProperty(PropertyName = "code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "redemption", NullValueHandling = NullValueHandling.Ignore)]
        public VoucherRedemption VoucherRedemption { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        public CampaignVoucherImport()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif