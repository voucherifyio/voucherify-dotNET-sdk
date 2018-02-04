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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public CampaignType Type { get; set; }

        [JsonProperty(PropertyName = "start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "vouchers_count")]
        public int? VouchersCount { get; set; }

        [JsonProperty(PropertyName = "voucher")]
        public CampaignVoucherCreate Voucher { get; set; }
        
        [JsonProperty(PropertyName = "validation_rules")]
        public ValidationRule ValidationRules { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public CampaignCreate()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif