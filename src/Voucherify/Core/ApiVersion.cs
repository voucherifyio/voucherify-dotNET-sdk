using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Attributes;

namespace Voucherify.Core
{
    public enum ApiVersion
    {
        [JsonEnumValue(Value = "")]
        Default,
        [JsonEnumValue(Value = "v2018-08-01")]
        v2018_08_01
    }
}
