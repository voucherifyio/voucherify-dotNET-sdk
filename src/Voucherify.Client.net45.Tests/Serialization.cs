using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Voucherify.Client.Serialization;

namespace Voucherify.Client.net45.Tests
{
    [TestClass]
    public class Serialization
    {
        [DataContract]
        private enum EnumType
        {
            [EnumMember(Value = "Enum-Value-1")]
            EnumValue1,
            [EnumMember(Value = "Enum-Value-2")]
            EnumValue2
        }

        [DataContract]
        private class JsonType
        {
            [DataMember(Name = "property_test", Order = 1)]
            public string Property { get; set; }

            [DataMember(Name = "array_test", Order = 2)]
            public IList<string> Array { get; set; }

            [DataMember(Name = "dictionary_test", Order = 3)]
            public Dictionary<string, object> Dictionary { get; set; }

            [DataMember(Name = "enum_test", Order = 4)]
            public EnumType? Enum { get; set; }
        }

        [TestMethod]
        public void JsonSerialize()
        {
            //-- Arrange
            JsonType jsonObject = new JsonType()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                Dictionary = new Dictionary<string, object>()
                {
                    { "property_1", "value_1" },
                    { "property_2", "value_2" },
                    { "property_3", new JsonType() { Property = "property_nested" } }
                },
                Enum = EnumType.EnumValue1
            };
            string jsonSerializedExpectedObject = "{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-1\"}";

            //-- Act
            string jsonSerializedObject = new JsonSerializer<JsonType>(new JsonSerializerSettings()
                {
                    Formatting = Formatting.None,
                    ContractResolver = new DefaultContractResolver() { IgnoreSerializableInterface = true },
                    Converters = new List<JsonConverter>() { new StringEnumConverter() },
                }).Serialize(jsonObject);

            //-- Assert
            Assert.AreEqual(jsonSerializedExpectedObject, jsonSerializedObject);
        }

        [TestMethod]
        public void JsonDeserialize()
        {
            //-- Arrange
            JsonType jsonExpectedDeserializedObject = new JsonType()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                Dictionary = new Dictionary<string, object>()
                {
                    { "property_1", "value_1" },
                    { "property_2", "value_2" },
                    { "property_3", new JsonType() { Property = "property_nested" } }
                },
                Enum = EnumType.EnumValue2
            };
            string jsonObject = "{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-2\"}";

            //-- Act
            JsonType jsonSerializedObject = new JsonSerializer<JsonType>(new JsonSerializerSettings()
                {
                    Formatting = Formatting.None,
                    ContractResolver = new DefaultContractResolver() { IgnoreSerializableInterface = true },
                    Converters = new List<JsonConverter>() { new StringEnumConverter() },
                }).Deserialize(jsonObject);

            //-- Assert
            Assert.AreEqual(jsonExpectedDeserializedObject.Property, jsonSerializedObject.Property);
            Assert.AreEqual(jsonExpectedDeserializedObject.Enum, jsonSerializedObject.Enum);
            Assert.AreEqual(jsonExpectedDeserializedObject.Array.Count, jsonSerializedObject.Array.Count);
            Assert.AreEqual(jsonExpectedDeserializedObject.Array[0], jsonSerializedObject.Array[0]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Array[1], jsonSerializedObject.Array[1]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Dictionary.Count, jsonSerializedObject.Dictionary.Count);
            Assert.AreEqual(jsonExpectedDeserializedObject.Dictionary["property_1"], jsonSerializedObject.Dictionary["property_1"]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Dictionary["property_2"], jsonSerializedObject.Dictionary["property_2"]);
            Assert.AreEqual(jsonExpectedDeserializedObject.Dictionary["property_3"] is object, jsonSerializedObject.Dictionary["property_1"] is object);
        }

        [DataContract]
        private class QueryType
        {
            [DataMember(Name = "property_test", Order = 1)]
            public string Property { get; set; }

            [DataMember(Name = "array_test", Order = 2)]
            public IList<string> Array { get; set; }

            [DataMember(Name = "enum_test")]
            public EnumType? Enum { get; set; }
        }

        [TestMethod]
        public void QuerySerialize()
        {
            //-- Arrange
            QueryType queryObject = new QueryType()
            {
                Property = "test_property_value",
                Array = new string[] { "test_array_value_1", "test_array_value_2" },
                Enum = EnumType.EnumValue2
            };
            string queryExpectedSerializedObject = "property_test=test_property_value&array_test=test_array_value_1&array_test=test_array_value_2&enum_test=Enum-Value-2";

            QuerySerializer<QueryType> querySerializer = new QuerySerializer<QueryType>();

            //-- Act
            string querySerializedObject = querySerializer.Serialize(queryObject);

            //-- Assert
            Assert.AreEqual(queryExpectedSerializedObject, querySerializedObject);
        }
    }
}
