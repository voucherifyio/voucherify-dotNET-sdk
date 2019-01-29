using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Voucherify.Core.Serialization;
using Voucherify.Tests.TestModel;
using Xunit;

namespace Voucherify.Tests.Core.Attributes
{
    public class JsonEnumValueAttributeTest
    {
        [Fact]
        public void JsonEnumValueAttributeSerilize()
        {
            //-- Arrange
            JsonTypeWithEnum jsonObject = new JsonTypeWithEnum()
            {
                Enum = EnumType.EnumValue1
            };
            string jsonSerializedExpectedObject = "{\"enum_test\":\"Enum-Value-1\"}";

            //-- Act
            string jsonSerializedObject = new JsonSerializer<JsonTypeWithEnum>(new List<JsonConverter>() { new JsonEnumValueConverter() }).Serialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonSerializedExpectedObject, jsonSerializedObject);
        }

        [Fact]
        public void JsonEnumValueAttributeDeserilize()
        {
            //-- Arrange
            JsonTypeWithEnum jsonExpectedDeserializedObject = new JsonTypeWithEnum()
            {
                Enum = EnumType.EnumValue2
            };
            string jsonObject = "{\"enum_test\":\"Enum-Value-2\"}";

            //-- Act
            JsonTypeWithEnum jsonSerializedObject = new JsonSerializer<JsonTypeWithEnum>(new List<JsonConverter>() { new JsonEnumValueConverter() }).Deserialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonExpectedDeserializedObject.Enum, jsonSerializedObject.Enum);
        }
    }
}
