#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum RedemptionResult
    {
        [JsonEnumValue(Value = "SUCCESS")]
        Success,
        [JsonEnumValue(Value = "FAILURE")]
        Failure
    }
}
#endif