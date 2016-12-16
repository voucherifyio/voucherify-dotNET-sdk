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

        private ApiEndpoints.Redemptions redemptions;

        public ApiEndpoints.Redemptions Redemptions
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

        private ApiEndpoints.Vouchers vouchers;

        public ApiEndpoints.Vouchers Vouchers
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

        private ApiEndpoints.Campaigns campaigns;

        public ApiEndpoints.Campaigns Campaigns
        {
            get
            {
                if (campaigns == null)
                {
                    campaigns = new ApiEndpoints.Campaigns(this);
                }

                return campaigns;
            }
        }

        private ApiEndpoints.Customers customers;

        public ApiEndpoints.Customers Customers
        {
            get
            {
                if (customers == null)
                {
                    customers = new ApiEndpoints.Customers(this);
                }

                return customers;
            }
        }

        private ApiEndpoints.Products products;

        public ApiEndpoints.Products Products
        {
            get
            {
                if (products == null)
                {
                    products = new ApiEndpoints.Products(this);
                }

                return products;
            }
        }

        private ApiEndpoints.Validations validations;

        public ApiEndpoints.Validations Validations
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

        private ApiEndpoints.Distributions distributions;

        public ApiEndpoints.Distributions Distributions
        {
            get
            {
                if (distributions == null)
                {
                    distributions = new ApiEndpoints.Distributions(this);
                }

                return distributions;
            }
        }

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
        }

        public Api WithSSL()
        {
            this.Secure = true;
            this.redemptions = null;
            this.products = null;
            this.vouchers = null;
            this.customers = null;
            this.campaigns = null;
            return this;
        }

        public Api WithoutSSL()
        {
            this.Secure = false;
            this.redemptions = null;
            this.products = null;
            this.vouchers = null;
            this.customers = null;
            this.campaigns = null;
            return this;
        }

        public Api WithEndpoint(string endpoint)
        {
            this.Endpoint = endpoint;
            this.redemptions = null;
            this.products = null;
            this.vouchers = null;
            this.customers = null;
            this.campaigns = null;

            if (endpoint == null)
            {
                this.Endpoint = Core.Constants.EndpointApi;
            }

            return this;
        }
    }
}
