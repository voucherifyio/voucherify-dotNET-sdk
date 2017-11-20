#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Voucher : ApiObject
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }
        
        [JsonProperty("code_config")]
        public CodeConfig CodeConfig { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public VoucherType Type { get; private set; }

        [JsonProperty(PropertyName = "campaign")]
        public string Campaign { get; private set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }
        
        [JsonProperty(PropertyName = "gift")]
        public Gift Gift { get; private set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "expiration_date")]
        public DateTime? ExpirationDate { get; private set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; private set; }

        [JsonProperty(PropertyName = "publish")]
        public VoucherPublish Publish { get; private set; }
        
        [JsonProperty(PropertyName = "assets")]
        public VoucherAssets Assets { get; private set; }

        [JsonProperty(PropertyName = "redemption")]
        public VoucherRedemption Redemption { get; private set; }

        [JsonProperty(PropertyName = "additional_info")]
        public string AdditionalInfo { get; private set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "applicable_to")]
        public ApplicableProductList ApplicableTo { get; private set; }

        public Voucher()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Voucher[Code={0},Type={1},Campaign={2},Category={3},Discount={4},Gift={5},Start={6},Expiration={7},Active={8},Publish={9},Redemption={10},Additional={11},Metadata={12},ApplicableTo={13}]",
                this.Code,
                this.Type,
                this.Campaign,
                this.Category,
                this.Discount,
                this.Gift,
                this.StartDate,
                this.ExpirationDate,
                this.Active,
                this.Publish,
                this.Redemption,
                this.AdditionalInfo,
                this.Metadata,
                this.ApplicableTo);
        }
    }
}
#endif