#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Sku : ApiObject
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; private set; }

        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; private set; }

        [JsonProperty(PropertyName = "sku")]
        public string SkuValue { get; private set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; private set; }

        [JsonProperty(PropertyName = "price")]
        public int? Price { get; private set; }

        [JsonProperty(PropertyName = "attributes")]
        public Metadata Attributes { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public Sku()
        {
            this.Attributes = new Metadata();
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Sku[Id={0},SourceId={1},SkuValue={2},Currency={3},Price={4},Attributes={5},Metadata={6}]",
                this.Id,
                this.SourceId,
                this.SkuValue,
                this.Currency,
                this.Price,
                this.Attributes != null ? this.Attributes.Count : 0,
                this.Metadata);
        }
    }
}
#endif