#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum VoucherType
    {
        [JsonEnumValue(Value = "DISCOUNT_VOUCHER")]
        DiscountVoucher,
        [JsonEnumValue(Value = "GIFT_VOUCHER")]
        GiftVoucher
    }
}
#endif