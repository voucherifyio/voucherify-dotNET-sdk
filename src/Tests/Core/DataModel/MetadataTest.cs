using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;
using Voucherify.Core.Serialization;
using NUnit.Framework;

namespace Voucherify.Tests.Core.DataModel
{
    [TestFixture]
    public class MetadataTest
    {
        [Test]
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
            Assert.AreEqual(jsonSerializedExpectedObject, jsonSerializedObject);
        }

        [Test]
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
            Assert.AreEqual(jsonExpectedDeserializedObject["property_1"], jsonSerializedObject["property_1"]);
            Assert.AreEqual(jsonExpectedDeserializedObject["property_2"], jsonSerializedObject["property_2"]);
            Assert.AreEqual(jsonExpectedDeserializedObject["property_3"], jsonSerializedObject["property_3"]);
        }
    }
}
