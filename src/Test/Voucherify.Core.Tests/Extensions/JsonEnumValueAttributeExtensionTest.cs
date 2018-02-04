using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.Extensions;
using Voucherify.Core.Tests.Extensions.TestModel;

namespace Voucherify.Core.Tests.Extensions
{
    [TestClass]
    public class JsonEnumValueAttributeExtensionTest
    {
        [TestMethod]
        public void JsonEnumValueAttributeExtensionGetValue()
        {
            // Arrange && Act && Assert
            Assert.AreEqual("Enum-Value-1", JsonEnumValueAttributeExtension.GetValue(EnumType.EnumValue1));
            Assert.AreEqual("Enum-Value-2", JsonEnumValueAttributeExtension.GetValue(EnumType.EnumValue2));
        }
    }
}
