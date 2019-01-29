using System;
using Xunit;
using Voucherify.Core;
using Voucherify.Core.Extensions;

namespace Voucherify.Tests.Core
{
    public class ApiVersionTest
    {
        [Fact]
        public void ApiVersionDefault()
        {
            // Arrange & Act & Assert
            Assert.True(ApiVersion.Default < ApiVersion.v1);
            Assert.Equal((int)ApiVersion.Default, 0);
            Assert.Equal(JsonEnumValueAttributeExtension.GetValue(ApiVersion.Default), string.Empty);
        }

        [Fact]
        public void ApiVersion_v1()
        {
            // Arrange & Act & Assert
            Assert.True(ApiVersion.v1 > ApiVersion.Default);
            Assert.True(ApiVersion.v1 < ApiVersion.v2017_04_05);
            Assert.Equal(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v1), "v1");
        }

        [Fact]
        public void ApiVersion_v2017_04_05()
        {
            // Arrange & Act & Assert
            Assert.True(ApiVersion.v2017_04_05 > ApiVersion.v1);
            Assert.True(ApiVersion.v2017_04_05 < ApiVersion.v2017_04_20);
            Assert.Equal(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v2017_04_05), "v2017-04-05");
        }

        [Fact]
        public void ApiVersion_v2017_04_20()
        {
            // Arrange & Act & Assert
            Assert.True(ApiVersion.v2017_04_20 > ApiVersion.v2017_04_05);
            Assert.Equal(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v2017_04_20), "v2017-04-20");
        }

        [Fact]
        public void ApiVersion_v2018_08_01()
        {
            // Arrange & Act & Assert
            Assert.True(ApiVersion.v2018_08_01 > ApiVersion.v2017_04_20);
            Assert.Equal(JsonEnumValueAttributeExtension.GetValue(ApiVersion.v2018_08_01), "v2018-08-01");
        }
    }
}
