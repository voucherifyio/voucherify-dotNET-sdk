#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class ValidationRuleCreate
    {
        [JsonProperty(PropertyName = "voucher_code")]
        public string VoucherCode { get; private set; }

        [JsonProperty(PropertyName = "campaign_name")]
        public string CampaignName { get; private set; }

        [JsonProperty(PropertyName = "junction", NullValueHandling = NullValueHandling.Ignore)]
        public string Junction { get; private set; }

        [JsonProperty(PropertyName = "segments", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Segments { get; private set; }

        [JsonProperty(PropertyName = "products", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Products { get; private set; }

        [JsonProperty(PropertyName = "skus", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Skus { get; private set; }

        [JsonProperty(PropertyName = "orders", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Orders { get; private set; }

        [JsonProperty(PropertyName = "redemptions", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Redemptions { get; private set; }

        public ValidationRuleCreate()
        {
        }

        public ValidationRuleCreate WithSegments(Metadata segments)
        {
            this.Segments = segments;
            return this;
        }

        public ValidationRuleCreate WithProducts(Metadata products)
        {
            this.Products = products;
            return this;
        }

        public ValidationRuleCreate WithSkus(Metadata skus)
        {
            this.Skus = skus;
            return this;
        }

        public ValidationRuleCreate WithOrders(Metadata orders)
        {
            this.Orders = orders;
            return this;
        }

        public ValidationRuleCreate WitRedemptions(Metadata redemptions)
        {
            this.Redemptions = redemptions;
            return this;
        }
    }
}
#endif