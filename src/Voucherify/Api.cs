using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify
{
    public class Api
    {
        public string AppToken { get; private set; }
        public string AppId { get; private set; }
        public string Endpoint { get; private set; }
        public bool Secure { get; private set; }

        public ApiEndpoints.Campaigns Campaigns { get; private set; }
        public ApiEndpoints.Customers Customers { get; private set; }
        public ApiEndpoints.Products Products { get; private set; }
        public ApiEndpoints.Redemptions Redemptions { get; private set; }
        public ApiEndpoints.Vouchers Vouchers { get; private set; }

        public Api(string appId, string appToken)
        {
            if (string.IsNullOrEmpty(appToken))
            {
                throw new ArgumentNullException("appToken");
            }

            if (string.IsNullOrEmpty("appId"))
            {
                throw new ArgumentNullException("appId");
            }

            this.AppToken = appToken;
            this.AppId = appId;
            this.Secure = true;
            this.Endpoint = Core.Constants.EndpointApi;

            this.Vouchers = new ApiEndpoints.Vouchers(this);
            this.Redemptions = new ApiEndpoints.Redemptions(this);
            this.Customers = new ApiEndpoints.Customers(this);
            this.Campaigns = new ApiEndpoints.Campaigns(this);
            this.Products = new ApiEndpoints.Products(this);
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
