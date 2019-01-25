using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.Extensions;

namespace Voucherify.Core.Tests
{
    [TestClass]
    public class ApiVersionTest
    {
        [TestMethod]
        public void ApiVersionDefault()
        {
            // Arrange & Act & Assert
            Assert.IsTrue(ApiVersion.Default < ApiVersion.v1);
            Assert.AreEqual((int)ApiVersion.Default, 0);
            Assert.AreEqual(JsonEnumValueAttributeExtension.GetValue(ApiVersion.Default), string.Empty);
        }

        [TestMethod]
        public void ApiVersion_v1()
        {
            // Arrange & Act & Assert
            Assert.IsTrue(ApiVersion.v1 > ApiVersion.Default);
            Assert.IsTrue(ApiVersion.v1 < ApiVersion.v2017_04_05);
            Assert.AreEqual(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v1), "v1");
        }

        [TestMethod]
        public void ApiVersion_v2017_04_05()
        {
            // Arrange & Act & Assert
            Assert.IsTrue(ApiVersion.v2017_04_05 > ApiVersion.v1);
            Assert.IsTrue(ApiVersion.v2017_04_05 < ApiVersion.v2017_04_20);
            Assert.AreEqual(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v2017_04_05), "v2017-04-05");
        }

        [TestMethod]
        public void ApiVersion_v2017_04_20()
        {
            // Arrange & Act & Assert
            Assert.IsTrue(ApiVersion.v2017_04_20 > ApiVersion.v2017_04_05);
            Assert.AreEqual(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v2017_04_20), "v2017-04-20");
        }

        [TestMethod]
        public void ApiVersion_v2018_08_01()
        {
            // Arrange & Act & Assert
            Assert.IsTrue(ApiVersion.v2018_08_01 > ApiVersion.v2017_04_20);
            Assert.AreEqual(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v2018_08_01), "v2018-08-01");
        }
    }
}
