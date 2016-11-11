#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum DiscountType
    {
        [JsonEnumValue(Value = "AMOUNT")]
        Amount,
        [JsonEnumValue(Value = "PERCENT")]
        Percent,
        [JsonEnumValue(Value = "UNIT")]
        Unit
    }
}
#endif