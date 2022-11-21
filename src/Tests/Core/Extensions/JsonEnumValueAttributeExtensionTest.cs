using Voucherify.Core.Extensions;
using Voucherify.Tests.TestModel;
using NUnit.Framework;

namespace Voucherify.Tests.Core.Extensions
{
    [TestFixture]
    public class JsonEnumValueAttributeExtensionTest
    {
        [Test]
        public void JsonEnumValueAttributeExtensionGetValue()
        {
            // Arrange && Act && Assert
            Assert.AreEqual("Enum-Value-1", JsonEnumValueAttributeExtension.GetValue(EnumType.EnumValue1));
            Assert.AreEqual("Enum-Value-2", JsonEnumValueAttributeExtension.GetValue(EnumType.EnumValue2));
        }
    }
}
