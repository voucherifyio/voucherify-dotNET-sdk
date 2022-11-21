using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;
using Voucherify.Core.Serialization;
using NUnit.Framework;

namespace Voucherify.Tests.Core.DataModel
{
    [TestFixture]
    public class ApiObjectTest
    {
        [Test]
        public void ApiObjectDeserialize()
        {
            // Arrange
            string jsonObject = "{\"object\":\"object_type\"}";

            // Act
            ApiObject jsonSerializedObject = new JsonSerializer<ApiObject>(new List<JsonConverter>() { }).Deserialize(jsonObject);

            // Assert
            Assert.AreEqual("object_type", jsonSerializedObject.Object);
        }
    }
}
