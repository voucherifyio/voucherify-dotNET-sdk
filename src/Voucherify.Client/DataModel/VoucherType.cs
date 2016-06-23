using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public enum VoucherType
    {
        [EnumMember(Value = "DISCOUNT_VOUCHER")]
        DiscountVoucher,
        [EnumMember(Value = "GIFT_VOUCHER")]
        GiftVoucher
    }
}
