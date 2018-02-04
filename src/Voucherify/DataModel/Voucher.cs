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

        [JsonProperty(PropertyName = "assets")]
        public VoucherAssets Assets { get; private set; }

        [JsonProperty(PropertyName = "publish")]
        public VoucherPublishList Publish { get; private set; }

        [JsonProperty(PropertyName = "redemption")]
        public VoucherRedemptionList Redemption { get; private set; }

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
            return string.Format("Voucher(Code={0},Type={1},Discount={2},Gift={3},Active={4})", this.Code, this.Type, this.Discount, this.Gift, this.Active);
        }
    }
}
#endif