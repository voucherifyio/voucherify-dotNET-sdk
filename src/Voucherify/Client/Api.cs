using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Client
{
    public class Api
    {
        public string AppToken { get; private set; }
        public string AppId { get; private set; }
        public string Endpoint { get; private set; }
        public string Origin { get; private set; }
        public bool Secure { get; private set; }

        public Client.ApiEndpoints.Redemptions Redemptions { get; private set; }
        public Client.ApiEndpoints.Vouchers Vouchers { get; private set; }

        public Api(string appId, string appToken, string origin)
        {
            if (string.IsNullOrEmpty(appToken))
            {
                throw new ArgumentNullException("appToken");
            }

            if (string.IsNullOrEmpty("appId"))
            {
                throw new ArgumentNullException("appId");
            }

            if (string.IsNullOrEmpty("origin"))
            {
                throw new ArgumentNullException("origin");
            }

            this.AppToken = appToken;
            this.AppId = appId;
            this.Origin = origin;
            this.Secure = true;
            this.Endpoint = Core.Constants.EndpointApi;

            this.Vouchers = new Client.ApiEndpoints.Vouchers(this);
            this.Redemptions = new Client.ApiEndpoints.Redemptions(this);
        }

        public Api WithSSL()
        {
            this.Secure = true;
            return this;
        }

        public Api WithoutSSL()
        {
            this.Secure = false;
            return this;
        }

        public Api WithEndpoint(string endpoint)
        {
            this.Endpoint = endpoint;

            if (endpoint == null)
            {
                this.Endpoint = Core.Constants.EndpointApi;
            }

            return this;
        }
    }
}
