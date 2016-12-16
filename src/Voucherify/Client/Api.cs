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

        private Client.ApiEndpoints.Redemptions redemptions;

        public Client.ApiEndpoints.Redemptions Redemptions
        {
            get
            {
                if (redemptions == null)
                {
                    redemptions = new ApiEndpoints.Redemptions(this);
                }

                return redemptions;
            }
        }

        private Client.ApiEndpoints.Vouchers vouchers;

        public Client.ApiEndpoints.Vouchers Vouchers
        {
            get
            {
                if (vouchers == null)
                {
                    vouchers = new ApiEndpoints.Vouchers(this);
                }

                return vouchers;
            }
        }

        private Client.ApiEndpoints.Validations validations;

        public Client.ApiEndpoints.Validations Validations
        {
            get
            {
                if (validations == null)
                {
                    validations = new ApiEndpoints.Validations(this);
                }

                return validations;
            }
        }

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
        }

        public Api WithSSL()
        {
            this.Secure = true;
            this.vouchers = null;
            this.redemptions = null;
            return this;
        }

        public Api WithoutSSL()
        {
            this.Secure = false;
            this.vouchers = null;
            this.redemptions = null;
            return this;
        }

        public Api WithEndpoint(string endpoint)
        {
            this.Endpoint = endpoint;
            this.vouchers = null;
            this.redemptions = null;

            if (endpoint == null)
            {
                this.Endpoint = Core.Constants.EndpointApi;
            }

            return this;
        }
    }
}
