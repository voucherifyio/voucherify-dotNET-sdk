using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.Exceptions;
using Voucherify.Core.Serialization;
using NUnit.Framework;

namespace Voucherify.Tests.Core.Exceptions
{
    [TestFixture]
    public class VoucherifyClientExceptionTest
    {
        [Test]
        public void VoucherifyClientExceptionDeserialize()
        {
            //-- Arrange
            VoucherifyClientException jsonExpectedClientExceptionObject = new VoucherifyClientException("message_1", 1, "details_1", "key_1", null);
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
