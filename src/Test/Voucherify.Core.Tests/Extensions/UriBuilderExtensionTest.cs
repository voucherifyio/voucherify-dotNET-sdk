using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.Extensions;
using Voucherify.Core.Tests.Extensions.TestModel;

namespace Voucherify.Core.Tests.Extensions
{
    [TestClass]
    public class UriBuilderExtensionTest
    {
        [TestMethod]
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
            Assert.AreEqual(queryExpectedSerializedObject, uriBulder.Query);
        }
    }
}
