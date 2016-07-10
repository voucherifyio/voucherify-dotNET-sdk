using Voucherify.Client.Attributes;

namespace Voucherify.Client.DataModel
{
    public enum RedemptionResult
    {
        [JsonEnumValue(Value = "Success")]
        Success,
        [JsonEnumValue(Value = "Failure-Inactive")]
        FailureInactive,
        [JsonEnumValue(Value = "Failure-NotExist")]
        FailureNotExist
    }
}
