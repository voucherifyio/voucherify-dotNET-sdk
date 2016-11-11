#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class SkuUpdateContext
    {
        [JsonProperty(PropertyName = "sku")]
        public string SkuValue { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "price")]
        public int? Price { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public Metadata Attributes { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        private SkuUpdateContext()
        {
            Metadata = new Metadata();
            Attributes = new Metadata();
        }

        public static SkuUpdateContext FromEmpty()
        {
            return new SkuUpdateContext();
        }

        public static SkuUpdateContext FromSku(Sku sku)
        {
            Metadata metadata = null;
            if (sku.Metadata != null)
            {
                metadata = new Metadata();

                foreach (var key in sku.Metadata.Keys)
                {
                    metadata.Add(key, sku.Metadata[key]);
                }
            }

            Metadata attributes = null;

            if (sku.Attributes != null)
            {
                attributes = new Metadata();

                foreach (var key in sku.Attributes.Keys)
                {
                    attributes.Add(key, sku.Attributes[key]);
                }
            }

            return new SkuUpdateContext()
            {
                SkuValue = sku.SkuValue,
                Currency = sku.Currency,
                Price = sku.Price,
                Attributes = attributes,
                Metadata = metadata
            };
        }

        public SkuUpdateContext WithSkuValue(string skuValue)
        {
            this.SkuValue = skuValue;
            return this;
        }

        public SkuUpdateContext WithCurrency(string currency)
        {
            this.Currency = currency;
            return this;
        }

        public SkuUpdateContext WithPrice(int? price)
        {
            this.Price = price;
            return this;
        }

        public SkuUpdateContext WithAttributes(Metadata attributes)
        {
            this.Attributes = attributes;
            return this;
        }

        public SkuUpdateContext WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
        }
    }
}
#endif