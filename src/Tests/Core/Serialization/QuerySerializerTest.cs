using Voucherify.Tests.TestModel;
using Voucherify.Core.Serialization;
using Xunit;

namespace Voucherify.Tests.Core.Serialization
{
    public class QuerySerializerTest
    {
        [Fact]
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
                ArrayJsonWithMetadata = new JsonTypeWithMetadata[] 
                {
                    new JsonTypeWithMetadata
                    {
                        Metadata = new Voucherify.Core.DataModel.Metadata(new System.Collections.Generic.Dictionary<string, object>()
                        {
                            { "property1", "value1" }
                        })
                    },
                     new JsonTypeWithMetadata
                    {
                        Metadata = new Voucherify.Core.DataModel.Metadata(new System.Collections.Generic.Dictionary<string, object>()
                        {
                            { "property2", "value2" }
                        })
                    }
                },
                Enum = EnumType.EnumValue2
            };
            string queryExpectedSerializedObject = "property_test=test_property_value" +
            	"&array_test=test_array_value_1" +
            	"&array_test=test_array_value_2" +
            	"&array_json[0][property_test]=property1" +
            	"&array_json[1][property_test]=property2" +
            	"&array_json_with_metadata[0][metadata][property1]=value1" +
            	"&array_json_with_metadata[1][metadata][property2]=value2" +
            	"&enum_test=Enum-Value-2";

            QuerySerializer<QueryType> querySerializer = new QuerySerializer<QueryType>();

            //-- Act
            string querySerializedObject = querySerializer.Serialize(queryObject);

            //-- Assert
            Assert.Equal(queryExpectedSerializedObject, querySerializedObject);
        }
    }
}
