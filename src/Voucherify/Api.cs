#if VOUCHERIFYSERVER
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core;

namespace Voucherify
{
    public class Api
    {
        public ApiVersion Version { get; private set; }
        public string AppToken { get; private set; }
        public string AppId { get; private set; }
        public string Endpoint { get; private set; }
        public bool Secure { get; private set; }
        
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

        private ApiEndpoints.Events events;

        public ApiEndpoints.Events Events
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

        private ApiEndpoints.Orders orders;

        public ApiEndpoints.Orders Orders
        {
            get
            {
                if (orders == null)
                {
                    orders = new ApiEndpoints.Orders(this);
                }

                return orders;
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

        private ApiEndpoints.Promotions promotions;

        public ApiEndpoints.Promotions Promotions
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

        private ApiEndpoints.Segments segments;

        public ApiEndpoints.Segments Segments
        {
            get
            {
                if (segments == null)
                {
                    segments = new ApiEndpoints.Segments(this);
                }

                return segments;
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

        private ApiEndpoints.ValidationRules validationRules;

        public ApiEndpoints.ValidationRules ValidationRules
        {
            get
            {
                if (validationRules == null)
                {
                    validationRules = new ApiEndpoints.ValidationRules(this);
                }

                return validationRules;
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
        
        public Api(string appId, string appToken) : this (appId, appToken, ApiVersion.Default)
        {
        }

        public Api(string appId, string appToken, Core.ApiVersion apiVersion)
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
            this.Version = apiVersion;
            this.Endpoint = Core.Constants.EndpointApi;
        }

        public Api WithSSL()
        {
            this.Secure = true;

            this.campaigns = null;
            this.customers = null;
            this.distributions = null;
            this.events = null;
            this.orders = null;
            this.products = null;
            this.promotions = null;
            this.redemptions = null;
            this.segments = null;
            this.validations = null;
            this.validationRules = null;
            this.vouchers = null;

            return this;
        }

        public Api WithoutSSL()
        {
            this.Secure = false;

            this.campaigns = null;
            this.customers = null;
            this.distributions = null;
            this.events = null;
            this.orders = null;
            this.products = null;
            this.promotions = null;
            this.redemptions = null;
            this.segments = null;
            this.validations = null;
            this.validationRules = null;
            this.vouchers = null;

            return this;
        }

        public Api WithVersion(ApiVersion apiVersion)
        {
            this.Version = apiVersion;

            this.campaigns = null;
            this.customers = null;
            this.distributions = null;
            this.events = null;
            this.orders = null;
            this.products = null;
            this.promotions = null;
            this.redemptions = null;
            this.segments = null;
            this.validations = null;
            this.validationRules = null;
            this.vouchers = null;

            return this;
        }

        public Api WithEndpoint(string endpoint)
        {
            this.Endpoint = endpoint;

            this.campaigns = null;
            this.customers = null;
            this.distributions = null;
            this.events = null;
            this.orders = null;
            this.products = null;
            this.promotions = null;
            this.redemptions = null;
            this.segments = null;
            this.validations = null;
            this.validationRules = null;
            this.vouchers = null;

            if (endpoint == null)
            {
                this.Endpoint = Core.Constants.EndpointApi;
            }

            return this;
        }
    }
}
#endif