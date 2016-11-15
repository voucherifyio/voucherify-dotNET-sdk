#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class OrderItem : ApiObject
    {
        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "sku_id")]
        public string SkuId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        public override string ToString()
        {
            return string.Format("OrderItem[ProductId={0},SkuId={1},Quantity={2}]", 
                this.ProductId,
                this.SkuId,
                this.Quantity);
        }
    }
}
#endif