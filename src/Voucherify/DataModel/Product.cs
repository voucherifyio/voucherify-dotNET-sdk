#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Product : ApiObject
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; private set; }

        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "attributes")]
        public List<string> Attributes { get; private  set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "skus")]
        public ProductSkus Skus { get; private set; }

        public Product()
        {
            this.Attributes = new List<string>();
            this.Metadata = new Metadata();
            this.Skus = new ProductSkus();
        }

        public override string ToString()
        {
            return string.Format("Product[Id={0},SourceId={1},Name={2},Attributes={3},Metadata={4},Skus={5}]",
                this.Id,
                this.SourceId,
                this.Name,
                this.Attributes != null ? this.Attributes.Count : 0,
                this.Metadata,
                this.Skus);
        }
    }
}
#endif