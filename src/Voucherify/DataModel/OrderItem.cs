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

        [JsonProperty(PropertyName = "product")]
        public OrderItemProduct Product { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public OrderItemSku Sku { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        [JsonProperty(PropertyName = "price")]
        public long? Price { get; set; }

        [JsonProperty(PropertyName = "discount_amount")]
        public long? DiscountAmount { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public OrderItem() {
            this.Metadata = new Metadata();
        }

        public OrderItem WithSourceId(string sourceId, string relatedObject)
        {
            this.SourceId = sourceId;
            this.RelatedObject = relatedObject;
            return this;
        }

        public OrderItem WithSku(string sourceId, OrderItemSku sku)
        {
            this.SourceId = sourceId;
            this.RelatedObject = "sku";
            this.Sku = sku;
            this.Product = null;
            return this;
        }

        public OrderItem WithProduct(string sourceId, OrderItemProduct product)
        {
            this.SourceId = sourceId;
            this.RelatedObject = "product";
            this.Product = product;
            this.Sku = null;
            return this;
        }

        public override string ToString()
        {
            return string.Format("OrderItem(SourceId={0},RelatedObject={1},ProductId={2},SkuId={3},Quantity={4},Product={5},Sku={6},Price={7},Amount={8},DiscountAmount={9})", 
                this.SourceId, this.RelatedObject, this.ProductId, this.SkuId, this.Quantity, this.Product, this.Sku, this.Price, this.Amount, this.DiscountAmount);
        }
    }
}
#endif