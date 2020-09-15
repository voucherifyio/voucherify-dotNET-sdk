#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class SkuUpdate
    {
        [JsonProperty(PropertyName = "sku")]
        public string SkuValue { get; set; }

        [JsonProperty(PropertyName = "price")]
        public long? Price { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public Metadata Attributes { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        private SkuUpdate()
        {
            Metadata = new Metadata();
            Attributes = new Metadata();
        }

        public static SkuUpdate FromEmpty()
        {
            return new SkuUpdate();
        }

        public static SkuUpdate FromSku(Sku sku)
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

            return new SkuUpdate()
            {
                SkuValue = sku.SkuValue,
                Price = sku.Price,
                Attributes = attributes,
                Metadata = metadata
            };
        }

        public SkuUpdate WithSkuValue(string skuValue)
        {
            this.SkuValue = skuValue;
            return this;
        }

        public SkuUpdate WithPrice(long? price)
        {
            this.Price = price;
            return this;
        }

        public SkuUpdate WithAttributes(Metadata attributes)
        {
            this.Attributes = attributes;
            return this;
        }

        public SkuUpdate WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
        }
    }
}
#endif