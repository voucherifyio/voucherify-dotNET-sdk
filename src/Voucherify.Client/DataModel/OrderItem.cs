using Newtonsoft.Json;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class OrderItem
    {
        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "sku_id")]
        public string SkuId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int quantity { get; set; }
    }
}