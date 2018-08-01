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
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "price")]
        public int? Price { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public List<string> Attributes { get; set; }

        [JsonProperty(PropertyName = "metadata")]
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