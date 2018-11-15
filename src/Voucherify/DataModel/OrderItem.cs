#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class OrderItem : ApiObject
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; private set; }

        [JsonProperty(PropertyName = "related_object")]
        public string RelatedObject { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "sku_id")]
        public string SkuId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        public OrderItem WithSourceId(string sourceId, string relatedObject)
        {
            this.SourceId = sourceId;
            this.RelatedObject = relatedObject;
            return this;
        }

        public override string ToString()
        {
            return string.Format("OrderItem(SourceId={0},RelatedObject={1},ProductId={2},SkuId={3},Quantity={4})", this.SourceId, this.RelatedObject, this.ProductId, this.SkuId, this.Quantity);
        }
    }
}
#endif