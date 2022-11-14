#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CampaignCreate
    {
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public CampaignExtensionType Type { get; set; }

        [JsonProperty(PropertyName = "campaign_type", NullValueHandling = NullValueHandling.Ignore)]
        public CampaignType CampaignType { get; set; }

        [JsonProperty(PropertyName = "start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "vouchers_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VouchersCount { get; set; }

        [JsonProperty(PropertyName = "voucher", NullValueHandling = NullValueHandling.Ignore)]
        public CampaignVoucherCreate Voucher { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        public CampaignCreate()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif