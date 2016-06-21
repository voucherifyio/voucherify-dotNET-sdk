using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Voucherify.Client;

namespace Voucherify.Client
{
    public class VoucherifyClient
    {
        public string AppToken { get; private set; }
        public string AppId { get; private set; }
        public string Endpoint { get; private set; }
        public bool Secure { get; private set; } 

        public Api.Vouchers Vouchers { get; private set; }

        public VoucherifyClient(string appToken, string appId)
        {
            if (string.IsNullOrWhiteSpace(appToken))
            {
                throw new ArgumentNullException("appToken");
            }

            if (string.IsNullOrWhiteSpace("appId"))
            {
                throw new ArgumentNullException("appId");
            }

            this.AppToken = appToken;
            this.AppId = appId;
            this.Secure = true;
            this.Endpoint = Constants.EndpointApi;
            this.Vouchers = new Api.Vouchers(this);
        }

        public VoucherifyClient WithSSL()
        {
            this.Secure = true;
            return this;
        }

        public VoucherifyClient WithoutSSL()
        {
            this.Secure = false;
            return this;
        }

        public VoucherifyClient WithEndpoint(string endpoint)
        {
            this.Endpoint = endpoint;

            if (endpoint == null)
            {
                this.Endpoint = Constants.EndpointApi;
            }

            return this;
        }
    }
}
