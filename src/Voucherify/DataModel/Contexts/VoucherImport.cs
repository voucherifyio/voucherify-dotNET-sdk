#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherImport
    {
        [JsonProperty(PropertyName = "code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public VoucherType Type { get; private set; }

        [JsonProperty(PropertyName = "campaign", NullValueHandling = NullValueHandling.Ignore)]
        public string Campaign { get; set; }

        [JsonProperty(PropertyName = "category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "discount", NullValueHandling = NullValueHandling.Ignore)]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "gift", NullValueHandling = NullValueHandling.Ignore)]
        public Gift Gift { get; private set; }

        [JsonProperty(PropertyName = "start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "active", NullValueHandling = NullValueHandling.Ignore)]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "redemption", NullValueHandling = NullValueHandling.Ignore)]
        public VoucherRedemption Redemption { get; set; }

        [JsonProperty(PropertyName = "additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalInfo { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
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