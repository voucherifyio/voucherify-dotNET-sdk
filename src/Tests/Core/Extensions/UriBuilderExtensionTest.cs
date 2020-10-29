using System;
using Voucherify.Core.Extensions;
using Voucherify.Tests.TestModel;
using Xunit;

namespace Voucherify.Tests.Core.Extensions
{
    public class UriBuilderExtensionTest
    {
        [Fact]
        public void UriBuilderExtensionWithQuery()
        {
            //-- Arrange
            UriBuilder uriBulder = new UriBuilder();
            QueryType queryObject = new QueryType()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" }
            };
            string queryExpectedSerializedObject = "?property_test=test_property_value&array_test=test_array_value_1&array_test=test_array_value_2";

            // Act
            uriBulder = UriBuilderExtension.WithQuery<QueryType>(uriBulder, queryObject);

            // Assert
            Assert.Equal(queryExpectedSerializedObject, uriBulder.Query);
        }

        [Fact]
        public void UriBuilderExtensionEnsureEscapedDataString()
        {
            //-- Arrange
            string paramName = "param";
            string paramValue = "<value>";

            // Act
            String escapedParam = UriBuilderExtension.EnsureEscapedDataString(paramName, paramValue);

            // Assert
            Assert.Equal(escapedParam, Uri.EscapeDataString(paramValue));
        }

        [Fact]
        public void UriBuilderExtensionEnsureEscapedDataStrinEmpty()
        {
            //-- Arrange
            string paramName = "param";
            string paramValue = "";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => UriBuilderExtension.EnsureEscapedDataString(paramName, paramValue));
        }
    }
}
