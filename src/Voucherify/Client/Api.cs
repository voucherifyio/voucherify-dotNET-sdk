#if VOUCHERIFYCLIENT
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core;

namespace Voucherify.Client
{
    public class Api
    {
        public string AppToken { get; private set; }
        public string AppId { get; private set; }
        public string Host { get; private set; }
        public string BasePath { get; private set; }
        public int? Port { get; private set; }
        public string Origin { get; private set; }
        public ApiVersion Version { get; private set; }
        public bool Secure { get; private set; }

        public string Channel
        {
            get
            {
                return Constants.HttpHeaderChannelName;
            }
        }

        private Client.ApiEndpoints.Events events;

        public Client.ApiEndpoints.Events Events
        {
            get
            {
                if (events == null)
                {
                    events = new ApiEndpoints.Events(this);
                }

                return events;
            }
        }

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

        private Client.ApiEndpoints.Promotions promotions;

        public Client.ApiEndpoints.Promotions Promotions
        {
            get
            {
                if (promotions == null)
                {
                    promotions = new ApiEndpoints.Promotions(this);
                }

                return promotions;
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
            this.Host = Core.Constants.HostApi;
            this.BasePath = "/client/v1";
            this.Port = null;
        }

        public Api WithSSL()
        {
            this.Secure = true;
            this.validations = null;
            this.redemptions = null;
            this.events = null;
            this.promotions = null;
            return this;
        }

        public Api WithoutSSL()
        {
            this.Secure = false;
            this.validations = null;
            this.redemptions = null;
            this.events = null;
            this.promotions = null;
            return this;
        }

        public Api WithHost(string host)
        {
            this.Host = (host ?? Core.Constants.HostApi) + "/v1";
            this.validations = null;
            this.redemptions = null;
            this.events = null;
            this.promotions = null;

            return this;
        }

        public Api WithPort(int? port)
        {
            this.Port = port;
            this.validations = null;
            this.redemptions = null;
            this.events = null;
            this.promotions = null;

            return this;
        }

        public Api WithVersion(ApiVersion apiVersion)
        {
            this.Version = apiVersion;

            this.validations = null;
            this.redemptions = null;
            this.events = null;
            this.promotions = null;

            return this;
        }
    }
}
#endif