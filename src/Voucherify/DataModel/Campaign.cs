#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Campaign : ApiObject
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public CampaignType Type { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "vouchers_count")]
        public int VouchersCount { get; set; }

        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "creation_status")]
        public CampaignCreationStatus CreationStatus { get; private set; }

        [JsonProperty(PropertyName = "default_voucher_redemption")]
        public VoucherRedemption DefaultVoucherRedemption { get; private set; }

        public Campaign()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif