#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class ValidationRuleUpdate
    {
        [JsonProperty(PropertyName = "junction")]
        public string Junction { get; set; }

        [JsonProperty(PropertyName = "segments")]
        public Metadata Segments { get; private set; }

        [JsonProperty(PropertyName = "products")]
        public Metadata Products { get; private set; }

        [JsonProperty(PropertyName = "skus")]
        public Metadata Skus { get; private set; }

        [JsonProperty(PropertyName = "orders")]
        public Metadata Orders { get; private set; }

        [JsonProperty(PropertyName = "redemptions")]
        public Metadata Redemptions { get; private set; }

        public ValidationRuleUpdate()
        {
            this.Segments = new Metadata();
            this.Products = new Metadata();
            this.Skus = new Metadata();
            this.Orders = new Metadata();
            this.Redemptions = new Metadata();
        }

        public ValidationRuleUpdate WithSegments(Metadata segments)
        {
            this.Segments = segments;
            return this;
        }

        public ValidationRuleUpdate WithProducts(Metadata products)
        {
            this.Products = products;
            return this;
        }

        public ValidationRuleUpdate WithSkus(Metadata skus)
        {
            this.Skus = skus;
            return this;
        }

        public ValidationRuleUpdate WithOrders(Metadata orders)
        {
            this.Orders = orders;
            return this;
        }

        public ValidationRuleUpdate WitRedemptions(Metadata redemptions)
        {
            this.Redemptions = redemptions;
            return this;
        }
    }
}
#endif