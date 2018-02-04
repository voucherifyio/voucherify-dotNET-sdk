#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Product : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "attributes")]
        public List<string> Attributes { get; private  set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "skus")]
        public ProductSkuList Skus { get; private set; }

        public Product()
        {
            this.Attributes = new List<string>();
            this.Metadata = new Metadata();
            this.Skus = new ProductSkuList();
        }

        public override string ToString()
        {
            return string.Format("Product(Id={0},SoruceId={1},Name={2},Skus={3})", this.Id, this.SourceId, this.Name, this.Skus);
        }
    }
}
#endif