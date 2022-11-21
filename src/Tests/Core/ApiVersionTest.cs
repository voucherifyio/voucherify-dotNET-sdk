using NUnit.Framework;
using Voucherify.Core;
using Voucherify.Core.Extensions;

namespace Voucherify.Tests.Core
{
    [TestFixture]
    public class ApiVersionTest
    {
        [Test]
        public void ApiVersionDefault()
        {
            // Arrange & Act & Assert
            Assert.True(ApiVersion.Default < ApiVersion.v2018_08_01);
            Assert.AreEqual((int)ApiVersion.Default, 0);
            Assert.AreEqual(JsonEnumValueAttributeExtension.GetValue(ApiVersion.Default), string.Empty);
        }
    }
}
