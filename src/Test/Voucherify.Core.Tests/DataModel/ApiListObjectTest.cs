using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.DataModel;
using Voucherify.Core.Serialization;

namespace Voucherify.Core.Tests.DataModel
{
    [TestClass]
    public class ApiListObjectTest
    {
        [TestMethod]
        public void ApiListObjectDeserialize()
        {
            // Arrange
            string jsonObject = "{\"object\":\"list\",\"data_ref\":\"object_list\",\"total\":1}";

            // Act
            ApiListObject jsonSerializedObject = new JsonSerializer<ApiListObject>(new List<JsonConverter>() { }).Deserialize(jsonObject);

            // Assert
            Assert.AreEqual("list", jsonSerializedObject.Object);
            Assert.AreEqual("object_list", jsonSerializedObject.DataRef);
            Assert.AreEqual(1, jsonSerializedObject.Total);
        }
    }
}
