using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Voucherify.Client.Tests
{
    [TestClass]
    public class Client
    {
        public void AppTokensTest()
        {
            //-- Arange
            string app_token = "app_token";
            string app_id = "app_id";

            //-- Act
            VoucherifyClient client = new VoucherifyClient(app_id, app_token);

            //-- Assert
            Assert.AreEqual(app_id, client.AppId);
            Assert.AreEqual(app_token, client.AppToken);
        }

        [TestMethod]
        public void SecureTest()
        {
            //-- Arange
            VoucherifyClient client = new VoucherifyClient("app_id", "app_token").WithoutSSL();

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
            VoucherifyClient client = new VoucherifyClient("app_id", "app_token").WithoutSSL();
            string endpoint = "www.google.com";

            //-- Act
            client.WithEndpoint(endpoint);

            //-- Assert
            Assert.AreEqual(endpoint, client.Endpoint);
        }
    }
}
