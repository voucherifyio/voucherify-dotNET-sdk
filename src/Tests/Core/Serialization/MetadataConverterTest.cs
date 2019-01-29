using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Tests.TestModel;
using Voucherify.Core.Serialization;
using Xunit;

namespace Voucherify.Tests.Core.Serialization
{
    public class MetadataConverterTest
    {
        [Fact]
        public void MetadataConverterSerialize()
        {
            //-- Arrange
            JsonTypeWithMetadata jsonObject = new JsonTypeWithMetadata()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                Metadata = new Voucherify.Core.DataModel.Metadata(new Dictionary<string, object>()
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
            Assert.Equal(jsonSerializedExpectedObject, jsonSerializedObject);
        }

        [Fact]
        public void MetadataConverterDeserialize()
        {
            //-- Arrange
            JsonTypeWithMetadata jsonExpectedDeserializedObject = new JsonTypeWithMetadata()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                Metadata = new Voucherify.Core.DataModel.Metadata(new Dictionary<string, object> {
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
            Assert.Equal(jsonExpectedDeserializedObject.Property, jsonSerializedObject.Property);
            Assert.Equal(jsonExpectedDeserializedObject.Enum, jsonSerializedObject.Enum);
            Assert.Equal(jsonExpectedDeserializedObject.Array.Count, jsonSerializedObject.Array.Count);
            Assert.Equal(jsonExpectedDeserializedObject.Array[0], jsonSerializedObject.Array[0]);
            Assert.Equal(jsonExpectedDeserializedObject.Array[1], jsonSerializedObject.Array[1]);
            Assert.Equal(jsonExpectedDeserializedObject.Metadata.Count, jsonSerializedObject.Metadata.Count);
            Assert.Equal(jsonExpectedDeserializedObject.Metadata["property_1"], jsonSerializedObject.Metadata["property_1"]);
            Assert.Equal(jsonExpectedDeserializedObject.Metadata["property_2"], jsonSerializedObject.Metadata["property_2"]);
            Assert.Equal(jsonExpectedDeserializedObject.Metadata["property_3"], jsonSerializedObject.Metadata["property_3"]);
        }
    }
}
