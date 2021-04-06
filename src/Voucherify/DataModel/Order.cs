#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;
using Voucherify.Core.Extensions;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Order : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public OrderStatus Status { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public RelatedObject Customer { get; set; }

        [JsonProperty(PropertyName = "referrer")]
        public RelatedObject Referrer { get; private set; }

        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        [JsonProperty(PropertyName = "discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? DiscountAmount { get; private set; }

        [JsonProperty(PropertyName = "total_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDiscountAmount { get; private set; }

        [JsonProperty(PropertyName = "total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalAmount { get; private set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItem> Items { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public Order() {
            this.Items = new List<OrderItem>();
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Order(Id={0},SourceId={1},Status={2},Amount={3},DiscountAmount={4},TotalDiscountAmount={5},TotalAmount={6},Items={7})", 
                this.Id, this.SourceId, this.Status, this.Amount, this.DiscountAmount, this.TotalDiscountAmount, this.TotalAmount, ListExtensions.ToString<OrderItem>(this.Items));
        }
    }
}
#endif