using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;
using Voucherify.Core.Serialization;
using Xunit;

namespace Voucherify.Tests.Core.DataModel
{
    public class ApiObjectTest
    {
        [Fact]
        public void ApiObjectDeserialize()
        {
            // Arrange
            string jsonObject = "{\"object\":\"object_type\"}";

            // Act
            ApiObject jsonSerializedObject = new JsonSerializer<ApiObject>(new List<JsonConverter>() { }).Deserialize(jsonObject);

            // Assert
            Assert.Equal("object_type", jsonSerializedObject.Object);
        }
    }
}
