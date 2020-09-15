using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core;
using Voucherify.Core.Serialization;
using Voucherify.Tests.TestModel;
using Xunit;

namespace Voucherify.Tests.Core.Serialization
{
    public class ObjectListFromArrayConverterTest
    {
        [Fact]
        public void ObjectListFromArrayConverterDeserializeVersionDefaultArray()
        {
            //-- Arrange
            JsonType[] jsonExpectedDeserializedObject = new JsonType[] {
            new JsonType()
                {
                    Property = "test_property_value",
                    Array = new string[] { "test_array_value_1", "test_array_value_2" },
                    Dictionary = new Dictionary<string, object>()
                    {
                        { "property_1", "value_1" },
                        { "property_2", "value_2" },
                        { "property_3", new JsonType() { Property = "property_nested" } }
                    },
                    Enum = "Enum-Value-2"
                }
            };
            string jsonObject = "[{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-2\"}]";

            //-- Act
            JsonTypeList jsonSerializedObject = new JsonSerializer<JsonTypeList>(new List<JsonConverter>() { new ObjectListFromArrayConverter<JsonType, JsonTypeList>(ApiVersion.Default, ApiVersion.v2017_04_05) }).Deserialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonExpectedDeserializedObject.Length, jsonSerializedObject.Objects.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Enum, jsonSerializedObject.Objects[0].Enum);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array.Count, jsonSerializedObject.Objects[0].Array.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[0], jsonSerializedObject.Objects[0].Array[0]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[1], jsonSerializedObject.Objects[0].Array[1]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary.Count, jsonSerializedObject.Objects[0].Dictionary.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_1"], jsonSerializedObject.Objects[0].Dictionary["property_1"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_2"], jsonSerializedObject.Objects[0].Dictionary["property_2"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_3"] is object, jsonSerializedObject.Objects[0].Dictionary["property_1"] is object);
        }

        [Fact]
        public void ObjectListFromArrayConverterDeserializeVersionDefaultList()
        {
            //-- Arrange
            JsonType[] jsonExpectedDeserializedObject = new JsonType[] {
            new JsonType()
                {
                    Property = "test_property_value",
                    Array = new string[] { "test_array_value_1", "test_array_value_2" },
                    Dictionary = new Dictionary<string, object>()
                    {
                        { "property_1", "value_1" },
                        { "property_2", "value_2" },
                        { "property_3", new JsonType() { Property = "property_nested" } }
                    },
                    Enum = "Enum-Value-2"
                }
            };
            string jsonObject = "{\"total\":1,\"objects\":[{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-2\"}]}";

            //-- Act
            JsonTypeList jsonSerializedObject = new JsonSerializer<JsonTypeList>(new List<JsonConverter>() { new ObjectListFromArrayConverter<JsonType, JsonTypeList>(ApiVersion.Default, ApiVersion.v2017_04_05) }).Deserialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonExpectedDeserializedObject.Length, jsonSerializedObject.Objects.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Enum, jsonSerializedObject.Objects[0].Enum);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array.Count, jsonSerializedObject.Objects[0].Array.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[0], jsonSerializedObject.Objects[0].Array[0]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[1], jsonSerializedObject.Objects[0].Array[1]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary.Count, jsonSerializedObject.Objects[0].Dictionary.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_1"], jsonSerializedObject.Objects[0].Dictionary["property_1"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_2"], jsonSerializedObject.Objects[0].Dictionary["property_2"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_3"] is object, jsonSerializedObject.Objects[0].Dictionary["property_1"] is object);
        }

        [Fact]
        public void ObjectListFromArrayConverterDeserializeVersionArray()
        {
            //-- Arrange
            JsonType[] jsonExpectedDeserializedObject = new JsonType[] {
            new JsonType()
                {
                    Property = "test_property_value",
                    Array = new string[] { "test_array_value_1", "test_array_value_2" },
                    Dictionary = new Dictionary<string, object>()
                    {
                        { "property_1", "value_1" },
                        { "property_2", "value_2" },
                        { "property_3", new JsonType() { Property = "property_nested" } }
                    },
                    Enum = "Enum-Value-2"
                }
            };
            string jsonObject = "[{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-2\"}]";

            //-- Act
            JsonTypeList jsonSerializedObject = new JsonSerializer<JsonTypeList>(new List<JsonConverter>() { new ObjectListFromArrayConverter<JsonType, JsonTypeList>(ApiVersion.v1, ApiVersion.v2017_04_05) }).Deserialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonExpectedDeserializedObject.Length, jsonSerializedObject.Objects.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Enum, jsonSerializedObject.Objects[0].Enum);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array.Count, jsonSerializedObject.Objects[0].Array.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[0], jsonSerializedObject.Objects[0].Array[0]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[1], jsonSerializedObject.Objects[0].Array[1]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary.Count, jsonSerializedObject.Objects[0].Dictionary.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_1"], jsonSerializedObject.Objects[0].Dictionary["property_1"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_2"], jsonSerializedObject.Objects[0].Dictionary["property_2"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_3"] is object, jsonSerializedObject.Objects[0].Dictionary["property_1"] is object);
        }

        [Fact]
        public void ObjectListFromArrayConverterDeserializeVersionList()
        {
            //-- Arrange
            JsonType[] jsonExpectedDeserializedObject = new JsonType[] {
            new JsonType()
                {
                    Property = "test_property_value",
                    Array = new string[] { "test_array_value_1", "test_array_value_2" },
                    Dictionary = new Dictionary<string, object>()
                    {
                        { "property_1", "value_1" },
                        { "property_2", "value_2" },
                        { "property_3", new JsonType() { Property = "property_nested" } }
                    },
                    Enum = "Enum-Value-2"
                }
            };
            string jsonObject = "{\"total\":1,\"objects\":[{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-2\"}]}";

            //-- Act
            JsonTypeList jsonSerializedObject = new JsonSerializer<JsonTypeList>(new List<JsonConverter>() { new ObjectListFromArrayConverter<JsonType, JsonTypeList>(ApiVersion.v2017_04_20, ApiVersion.v2017_04_05) }).Deserialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonExpectedDeserializedObject.Length, jsonSerializedObject.Objects.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Property, jsonSerializedObject.Objects[0].Property);
            Assert.Equal(jsonExpectedDeserializedObject[0].Enum, jsonSerializedObject.Objects[0].Enum);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array.Count, jsonSerializedObject.Objects[0].Array.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[0], jsonSerializedObject.Objects[0].Array[0]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Array[1], jsonSerializedObject.Objects[0].Array[1]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary.Count, jsonSerializedObject.Objects[0].Dictionary.Count);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_1"], jsonSerializedObject.Objects[0].Dictionary["property_1"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_2"], jsonSerializedObject.Objects[0].Dictionary["property_2"]);
            Assert.Equal(jsonExpectedDeserializedObject[0].Dictionary["property_3"] is object, jsonSerializedObject.Objects[0].Dictionary["property_1"] is object);
        }

        [Fact]
        public void ObjectListFromArrayConverterDeserializeVersionListException()
        {
            //-- Arrange
            string jsonObject = "{\"total\":1,\"objects\":[{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-2\"}]}";

            //-- Act & Assert
            JsonSerializationException exception = Assert.Throws<JsonSerializationException>(() =>
            {
                JsonTypeList jsonSerializedObject = new JsonSerializer<JsonTypeList>(new List<JsonConverter>() { new ObjectListFromArrayConverter<JsonType, JsonTypeList>(ApiVersion.v1, ApiVersion.v2017_04_05) }).Deserialize(jsonObject);
            });
        }

        [Fact]
        public void ObjectListFromArrayConverterDeserializeVersionArrayException()
        {
            //-- Arrange
            string jsonObject = "[{\"property_test\":\"test_property_value\",\"array_test\":[\"test_array_value_1\",\"test_array_value_2\"],\"dictionary_test\":{\"property_1\":\"value_1\",\"property_2\":\"value_2\",\"property_3\":{\"property_test\":\"property_nested\",\"array_test\":null,\"dictionary_test\":null,\"enum_test\":null}},\"enum_test\":\"Enum-Value-2\"}]";

            //-- Act & Assert
            JsonSerializationException exception = Assert.Throws<JsonSerializationException>(() =>
            {
                JsonTypeList jsonSerializedObject = new JsonSerializer<JsonTypeList>(new List<JsonConverter>() { new ObjectListFromArrayConverter<JsonType, JsonTypeList>(ApiVersion.v2017_04_20, ApiVersion.v2017_04_05) }).Deserialize(jsonObject);
            });

        }
    }
}
