using Voucherify.Core.Attributes;

namespace Voucherify.Core.Tests.Serialization.TestModel
{
    internal enum EnumType
    {
        [JsonEnumValue(Value = "Enum-Value-1")]
        EnumValue1,
        [JsonEnumValue(Value = "Enum-Value-2")]
        EnumValue2
    }
}
