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
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; private set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("sku")]
        public string SkuValue { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("price")]
        public int? Price { get; set; }

        [JsonProperty("attributes")]
        public Metadata Attributes { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        public Sku()
        {
            this.Attributes = new Metadata();
            this.Metadata = new Metadata();
        }
    }
}
#endif