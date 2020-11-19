#if VOUCHERIFYSERVER
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum CampaignType
    {
        [JsonEnumValue(Value = "DISCOUNT_COUPONS")]
        DISCOUNT_COUPONS,
        [JsonEnumValue(Value = "GIFT_VOUCHERS")]
        GIFT_VOUCHERS,
        [JsonEnumValue(Value = "PROMOTION")]
        PROMOTION,
        [JsonEnumValue(Value = "REFERRAL_PROGRAM")]
        REFERRAL_PROGRAM,
        [JsonEnumValue(Value = "LOYALTY_PROGRAM")]
        LOYALTY_PROGRAM,
        [JsonEnumValue(Value = "LUCKY_DRAW")]
        LUCKY_DRAW
    }
}
#endif