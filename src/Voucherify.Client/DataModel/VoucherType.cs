using Voucherify.Client.Attributes;

namespace Voucherify.Client.DataModel
{
    public enum VoucherType
    {
        [JsonEnumValue(Value = "DISCOUNT_VOUCHER")]
        DiscountVoucher,
        [JsonEnumValue(Value = "GIFT_VOUCHER")]
        GiftVoucher
    }
}
