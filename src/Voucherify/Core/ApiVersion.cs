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
        [JsonEnumValue(Value = "v1")]
        v1,
        [JsonEnumValue(Value = "v2017-04-05")]
        v2017_04_05,
        [JsonEnumValue(Value = "v2017-04-20")]
        v2017_04_20,
        [JsonEnumValue(Value = "v2018-08-01")]
        v2018_08_01
    }
}
