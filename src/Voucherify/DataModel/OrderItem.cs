#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class OrderItem : ApiObject
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "sku_id")]
        public string SkuId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        public override string ToString()
        {
            return string.Format("OrderItem(SourceId={0},ProductId={1},SkuId={2},Quantity={3})", this.SourceId, this.ProductId, this.SkuId, this.Quantity);
        }
    }
}
#endif