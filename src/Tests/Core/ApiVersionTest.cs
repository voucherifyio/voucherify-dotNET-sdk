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
            Assert.True(ApiVersion.Default < ApiVersion.v2018_08_01);
            Assert.Equal((int)ApiVersion.Default, 0);
            Assert.Equal(JsonEnumValueAttributeExtension.GetValue(ApiVersion.Default), string.Empty);
        }
    }
}
