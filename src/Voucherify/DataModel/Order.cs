#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

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

        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItem> Items { get; private set; }

        [JsonProperty(PropertyName = "referrer")]
        public RelatedObject Referrer { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public Order() {
            this.Items = new List<OrderItem>();
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Order(Id={0},SourceId={1},Status={2},Amount={3})", this.Id, this.SourceId, this.Status, this.Amount);
        }
    }
}
#endif