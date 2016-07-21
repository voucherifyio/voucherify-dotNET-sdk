using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Voucherify.Client.net45.Tests
{
    [TestClass]
    public class Client
    {
        public void AppTokensTest()
        {
            //-- Arrange & Act
            VoucherifyClient client = new VoucherifyClient(Configuration.AppId, Configuration.AppToken);

            //-- Assert
            Assert.AreEqual(Configuration.AppId, client.AppId);
            Assert.AreEqual(Configuration.AppToken, client.AppToken);
        }

        [TestMethod]
        public void SecureTest()
        {
            //-- Arange
            VoucherifyClient client = new VoucherifyClient(Configuration.AppId, Configuration.AppToken).WithoutSSL();

            //-- Act
            bool withSSL = client.WithSSL().Secure;
            bool withoutSSL = client.WithoutSSL().Secure;

            //-- Assert
            Assert.IsTrue(withSSL);
            Assert.IsFalse(withoutSSL);
        }

        [TestMethod]
        public void EndpointTest()
        {
            //-- Arange
            VoucherifyClient client = new VoucherifyClient(Configuration.AppId, Configuration.AppToken).WithoutSSL();
            string endpoint = "www.sample.endpoint.com";

            //-- Act
            client.WithEndpoint(endpoint);

            //-- Assert
            Assert.AreEqual(endpoint, client.Endpoint);
        }
    }
}
