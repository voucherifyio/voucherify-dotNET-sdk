using Newtonsoft.Json;
using System;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class Voucher
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        public VoucherType Type { get; set; }

        [JsonProperty(PropertyName = "campaign")]
        public string Campaign { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; set; }
        
        [JsonProperty(PropertyName = "gift")]
        public Gift Gift { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        [JsonProperty(PropertyName = "publish")]
        public VoucherPublish Publish { get; set; }

        [JsonProperty(PropertyName = "redemption")]
        public VoucherRedemption Redemption { get; set; }

        [JsonProperty(PropertyName = "additional_info")]
        public string AdditionalInfo { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public Voucher()
        {
            this.Metadata = new Metadata();
        }
    }
}
