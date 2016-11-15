#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class SkuCreate
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

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

        public SkuCreate()
        {
            this.Attributes = new Metadata();
            this.Metadata = new Metadata();
        }
    }
}
#endif