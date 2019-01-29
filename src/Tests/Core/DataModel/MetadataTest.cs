using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;
using Voucherify.Core.Serialization;
using Xunit;

namespace Voucherify.Tests.Core.DataModel
{
    public class MetadataTest
    {
        [Fact]
        public void MetadataSerialize()
        {
            // Arrange
            Metadata jsonObject = new Metadata(new Dictionary<string, object>()
            {
                { "property_1", "value_1" },
                { "property_2", "value_2" },
                { "property_3", "value_3" }
            });
            string jsonSerializedExpectedObject = "{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":\"value_3\"}";

            //-- Act
            string jsonSerializedObject = new JsonSerializer<Metadata>(new List<JsonConverter>() { new MetadataConverter() }).Serialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonSerializedExpectedObject, jsonSerializedObject);
        }

        [Fact]
        public void MetadataDeserialize()
        {
            //-- Arrange
            Metadata jsonExpectedDeserializedObject = new Metadata(new Dictionary<string, object> {
                { "property_1", "value_1" },
                { "property_2", "value_2" },
                { "property_3", "value_3" }
            });
            string jsonObject = "{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":\"value_3\"}";

            //-- Act
            Metadata jsonSerializedObject = new JsonSerializer<Metadata>(new List<JsonConverter>() { new MetadataConverter() }).Deserialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonExpectedDeserializedObject["property_1"], jsonSerializedObject["property_1"]);
            Assert.Equal(jsonExpectedDeserializedObject["property_2"], jsonSerializedObject["property_2"]);
            Assert.Equal(jsonExpectedDeserializedObject["property_3"], jsonSerializedObject["property_3"]);
        }
    }
}
