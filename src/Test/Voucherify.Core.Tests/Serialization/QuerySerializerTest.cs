using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.Tests.Serialization.TestModel;
using Voucherify.Core.Serialization;

namespace Voucherify.Core.Tests.Serialization
{
    [TestClass]
    public class QuerySerializerTest
    {
        [TestMethod]
        public void QuerySerializerSerialize()
        {
            //-- Arrange
            QueryType queryObject = new QueryType()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                ArrayJson = new JsonType[]
                {
                    new JsonType() { Property = "property1" },
                    new JsonType() { Property = "property2" }
                },
                Enum = EnumType.EnumValue2
            };
            string queryExpectedSerializedObject = "property_test=test_property_value&array_test=test_array_value_1&array_test=test_array_value_2&array_json[0][property_test]=property1&array_json[1][property_test]=property2&enum_test=Enum-Value-2";

            QuerySerializer<QueryType> querySerializer = new QuerySerializer<QueryType>();

            //-- Act
            string querySerializedObject = querySerializer.Serialize(queryObject);

            //-- Assert
            Assert.AreEqual(queryExpectedSerializedObject, querySerializedObject);
        }
    }
}
