#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherImport
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "type")]
        public VoucherType Type { get; private set; }

        [JsonProperty(PropertyName = "campaign")]
        public string Campaign { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "gift")]
        public Gift Gift { get; private set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "redemption")]
        public VoucherRedemption Redemption { get; set; }

        [JsonProperty(PropertyName = "additional_info")]
        public string AdditionalInfo { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public VoucherImport()
        {
            this.Metadata = new Metadata();
        }

        public VoucherImport WithDiscount(Discount discount)
        {
            this.Discount = discount;
            this.Gift = null;
            this.Type = VoucherType.DiscountVoucher;
            return this;
        }

        public VoucherImport WithGift(Gift gift)
        {
            this.Discount = null;
            this.Gift = gift;
            this.Type = VoucherType.GiftVoucher;
            return this;
        }
    }
}
#endif