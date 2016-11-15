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

        [JsonProperty(PropertyName = "creation_status")]
        public CampaignCreationStatus CreationStatus { get; private set; }
        
        public Campaign()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Campaign[Name={0},Type={1},Start={2},Expiration={3},Voucher={4},Metadata={5},CreationStatus={6}]",
                this.Name,
                this.Type,
                this.StartDate,
                this.ExpirationDate,
                this.Voucher,
                this.Metadata,
                this.CreationStatus);
        }
    }
}
#endif