using Voucherify.Client.Attributes;

namespace Voucherify.Client.DataModel
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
