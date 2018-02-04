using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.DataModel;
using Voucherify.Core.Serialization;

namespace Voucherify.Core.Tests.DataModel
{
    [TestClass]
    public class ApiObjectTest
    {
        [TestMethod]
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
