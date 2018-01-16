using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voucherify.Core.Exceptions;
using Voucherify.Core.Serialization;

namespace Voucherify.Core.Tests.Exceptions
{
    [TestClass]
    public class VoucherifyClientExceptionTest
    {
        [TestMethod]
        public void VoucherifyClientExceptionDeserialize()
        {
            //-- Arrange
            VoucherifyClientException jsonExpectedClientExceptionObject = new VoucherifyClientException("message_1", 1, "details_1", "key_1");
            string jsonObject = "{\"message\":\"message_1\",\"code\":1,\"details\":\"details_1\",\"key\":\"key_1\"}";

            //-- Act
            VoucherifyClientException clientExceptionObject = new JsonSerializer<VoucherifyClientException>(new List<JsonConverter>() { }).Deserialize(jsonObject);

            //-- Assert
            Assert.AreEqual(jsonExpectedClientExceptionObject.Message, clientExceptionObject.Message);
            Assert.AreEqual(jsonExpectedClientExceptionObject.Key, clientExceptionObject.Key);
            Assert.AreEqual(jsonExpectedClientExceptionObject.Code, clientExceptionObject.Code);
            Assert.AreEqual(jsonExpectedClientExceptionObject.Details, clientExceptionObject.Details);
        }
    }
}
