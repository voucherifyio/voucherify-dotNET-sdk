#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class ProductUpdate
    {
        [JsonProperty(PropertyName = "source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "price", NullValueHandling = NullValueHandling.Ignore)]
        public long? Price { get; set; }

        [JsonProperty(PropertyName = "attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Attributes { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        private ProductUpdate()
        {
            this.Attributes = new List<string>();
            this.Metadata = new Metadata();
        }

        public static ProductUpdate FromEmpty()
        {
            return new ProductUpdate();
        }

        public static ProductUpdate FromProduct(Product product)
        {
            Metadata metadata = null;

            if (product.Metadata != null)
            {
                metadata = new Metadata();

                foreach (var key in product.Metadata.Keys)
                {
                    metadata.Add(key, product.Metadata[key]);
                }
            }

            List<string> attributes = null;

            if (product.Attributes != null)
            {
                attributes = new List<string>();

                foreach (string attribute in product.Attributes)
                {
                    attributes.Add(attribute);
                }
            }

            return new ProductUpdate()
            {
                SourceId = product.SourceId,
                Name = product.Name,
                Attributes = attributes,
                Metadata = metadata
            };
        }
    }
}
#endif