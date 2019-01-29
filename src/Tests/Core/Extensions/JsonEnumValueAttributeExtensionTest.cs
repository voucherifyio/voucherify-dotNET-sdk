using Voucherify.Core.Extensions;
using Voucherify.Tests.TestModel;
using Xunit;

namespace Voucherify.Tests.Core.Extensions
{
    public class JsonEnumValueAttributeExtensionTest
    {
        [Fact]
        public void JsonEnumValueAttributeExtensionGetValue()
        {
            // Arrange && Act && Assert
            Assert.Equal("Enum-Value-1", JsonEnumValueAttributeExtension.GetValue(EnumType.EnumValue1));
            Assert.Equal("Enum-Value-2", JsonEnumValueAttributeExtension.GetValue(EnumType.EnumValue2));
        }
    }
}
