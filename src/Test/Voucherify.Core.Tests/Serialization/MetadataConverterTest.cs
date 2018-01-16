using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Voucherify.Core.Tests.Serialization.DataModel;
using Voucherify.Core.Serialization;

namespace Voucherify.Core.Tests.Serialization
{
    [TestClass]
    public class MetadataConverterTest
    {
        [TestMethod]
        public void MetadataConverterSerialize()
        {
            //-- Arrange
            JsonTypeWithMetadata jsonObject = new JsonTypeWithMetadata()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>()
                {
                    { "property_1", "value_1" },
                    { "property_2", "value_2" },
                    { "property_3", "value_3" }
                }),
                Enum = "Enum-Value-2"
            };
            string jsonSerializedExpectedObject = "{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"metadata\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":\"value_3\"},\"enum_test\":\"Enum-Value-2\"}";


            //-- Act
            string jsonSerializedObject = new JsonSerializer<JsonTypeWithMetadata>(new List<JsonConverter>() { new MetadataConverter() }).Serialize(jsonObject);

            //-- Assert
            Assert.AreEqual(jsonSerializedExpectedObject, jsonSerializedObject);
        }

        [TestMethod]
        public void MetadataConverterDeserialize()
        {
            //-- Arrange
            JsonTypeWithMetadata jsonExpectedDeserializedObject = new JsonTypeWithMetadata()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                Metadata = new Core.DataModel.Metadata(new Dictionary<string, object> {
                    { "property_1", "value_1" },
                    { "property_2", "value_2" },
                    { "property_3", "value_3" }
                }),
                Enum = "Enum-Value-2"
            };
            string jsonObject = "{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"metadata\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":\"value_3\"},\"enum_test\":\"Enum-Value-2\"}";

            //-- Act
            JsonTypeWithMetadata jsonSerializedObject = new JsonSerializer<JsonTypeWithMetadata>(new List<JsonConverter>() { new MetadataConverter() }).Deserialize(jsonObject);

            //-- Assert
            Assert.AreEqual(jsonExpectedDeserializedObject.Property, jsonSerializedObject.Property);
            Assert.AreEqual(jsonExpectedDeserializedObject.Enum, jsonSerializedObject.Enum);
            Assert.AreEqual(jsonExpectedDeserializedObject.Array.Count, jsonSerializedObject.Array.Count);
            Assert.AreEqual(jsonExpectedDeserializedObject.Array[0], jsonSerializedObject.Array[0]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Array[1], jsonSerializedObject.Array[1]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Metadata.Count, jsonSerializedObject.Metadata.Count);
            Assert.AreEqual(jsonExpectedDeserializedObject.Metadata["property_1"], jsonSerializedObject.Metadata["property_1"]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Metadata["property_2"], jsonSerializedObject.Metadata["property_2"]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Metadata["property_3"], jsonSerializedObject.Metadata["property_3"]);
        }
    }
}
