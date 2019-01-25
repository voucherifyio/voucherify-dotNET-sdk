#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class OrderItemSku
    {
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }
        
        [JsonProperty(PropertyName = "override")]
        public bool Override { get; set; }

        public OrderItemSku()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("OrderItemSku(Sku={0},ProductId={1},Metadata={2},Override={3})", this.Sku, this.ProductId, this.Metadata, this.Override);
        }
    }
}
#endif