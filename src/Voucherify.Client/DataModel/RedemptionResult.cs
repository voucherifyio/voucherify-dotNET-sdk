using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
