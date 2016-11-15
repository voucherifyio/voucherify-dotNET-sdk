#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CampaignVoucherCreate
    {
        [JsonProperty(PropertyName = "code_config", NullValueHandling = NullValueHandling.Ignore)]
        public CodeConfig CodeConfig { get; set; }

        [JsonProperty(PropertyName = "type")]
        public VoucherType Type { get; private set; }

        [JsonProperty(PropertyName = "discount", NullValueHandling = NullValueHandling.Ignore)]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "gift", NullValueHandling = NullValueHandling.Ignore)]
        public Gift Gift { get; private set; }
        
        [JsonProperty(PropertyName = "redemption")]
        public VoucherRedemption Redemption { get; set; }
        
        public CampaignVoucherCreate()
        {
        }

        public CampaignVoucherCreate WithDiscount(Discount discount)
        {
            this.Discount = discount;
            this.Gift = null;
            this.Type = VoucherType.DiscountVoucher;
            return this;
        }

        public CampaignVoucherCreate WithGift(Gift gift)
        {
            this.Discount = null;
            this.Gift = gift;
            this.Type = VoucherType.GiftVoucher;
            return this;
        }
    }
}
#endif