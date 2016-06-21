using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    public enum RedemptionResult
    {
        [EnumMember(Value = "Success")]
        Success,
        [EnumMember(Value = "Failure-Inactive")]
        FailureInactive,
        [EnumMember(Value = "Failure-Not-Exist")]
        FailureNotExist
    }
}
