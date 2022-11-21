using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.Serialization;
using Voucherify.Tests.TestModel;
using NUnit.Framework;

namespace Voucherify.Tests.Core.Attributes
{
    [TestFixture]
    public class JsonEnumValueAttributeTest
    {
        [Test]
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
            Assert.AreEqual(jsonSerializedExpectedObject, jsonSerializedObject);
        }

        [Test]
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
            Assert.AreEqual(jsonExpectedDeserializedObject.Enum, jsonSerializedObject.Enum);
        }
    }
}
