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
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public CampaignType Type { get; private set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "expiration_date")]
        public DateTime? ExpirationDate { get; private set; }

        [JsonProperty(PropertyName = "voucher")]
        public CampaignVoucher Voucher { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "voucher_generation_status")]
        public CampaignVoucherGenerationStatus VoucherGenerationStatus { get; private set; }

        [JsonProperty(PropertyName = "validation_rules")]
        public ValidationRule ValidationRules { get; private set; }

        [JsonProperty(PropertyName = "promotion")]
        public PromotionTierList Promotion { get; private set; }

        public Campaign()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Campaign(Name={0},Type={1})", this.Name, this.Type);
        }
    }
}
#endif