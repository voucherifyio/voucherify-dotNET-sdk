using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;
using Voucherify.Core.Serialization;
using Xunit;

namespace Voucherify.Tests.Core.DataModel
{
    public class ApiListObjectTest
    {
        [Fact]
        public void ApiListObjectDeserialize()
        {
            // Arrange
            string jsonObject = "{\"object\":\"list\",\"data_ref\":\"object_list\",\"total\":1}";

            // Act
            ApiListObject jsonSerializedObject = new JsonSerializer<ApiListObject>(new List<JsonConverter>() { }).Deserialize(jsonObject);

            // Assert
            Assert.Equal("list", jsonSerializedObject.Object);
            Assert.Equal("object_list", jsonSerializedObject.DataRef);
            Assert.Equal(1, jsonSerializedObject.Total);
        }
    }
}
