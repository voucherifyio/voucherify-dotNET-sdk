using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.Serialization;
using Voucherify.Core.Tests.Attributes.TestModel;

namespace Voucherify.Core.Tests.Attributes
{
    [TestClass]
    public class JsonEnumValueAttributeTest
    {
        [TestMethod]
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

        [TestMethod]
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
