#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum RedemptionEntryResult
    {
        [JsonEnumValue(Value = "Success")]
        Success,
        [JsonEnumValue(Value = "Failure-Inactive")]
        FailureInactive,
        [JsonEnumValue(Value = "Failure-NotExist")]
        FailureNotExist
    }
}
#endif