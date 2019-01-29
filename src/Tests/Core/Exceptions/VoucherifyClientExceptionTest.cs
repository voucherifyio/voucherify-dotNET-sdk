using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.Exceptions;
using Voucherify.Core.Serialization;
using Xunit;

namespace Voucherify.Tests.Core.Exceptions
{
    public class VoucherifyClientExceptionTest
    {
        [Fact]
        public void VoucherifyClientExceptionDeserialize()
        {
            //-- Arrange
            VoucherifyClientException jsonExpectedClientExceptionObject = new VoucherifyClientException("message_1", 1, "details_1", "key_1");
            string jsonObject = "{\"message\":\"message_1\",\"code\":1,\"details\":\"details_1\",\"key\":\"key_1\"}";

            //-- Act
            VoucherifyClientException clientExceptionObject = new JsonSerializer<VoucherifyClientException>(new List<JsonConverter>() { }).Deserialize(jsonObject);

            //-- Assert
            Assert.Equal(jsonExpectedClientExceptionObject.Message, clientExceptionObject.Message);
            Assert.Equal(jsonExpectedClientExceptionObject.Key, clientExceptionObject.Key);
            Assert.Equal(jsonExpectedClientExceptionObject.Code, clientExceptionObject.Code);
            Assert.Equal(jsonExpectedClientExceptionObject.Details, clientExceptionObject.Details);
        }
    }
}
