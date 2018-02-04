using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum OrderStatus
    {
        [JsonEnumValue(Value = "CREATED")]
        Created,
        [JsonEnumValue(Value = "PAID")]
        Paid,
        [JsonEnumValue(Value = "CANCELED")]
        Canceled,
        [JsonEnumValue(Value = "FULFILLED")]
        Fulfilled
    }
}