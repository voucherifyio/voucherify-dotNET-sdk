#if VOUCHERIFYSERVER
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class OrderUpdate
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItem> Items { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public OrderUpdate()
        {
            this.Items = new List<OrderItem>();
            this.Metadata = new Metadata();
        }

        public OrderUpdate WithAmount(long? amount)
        {
            this.Amount = amount;
            return this;
        }

        public OrderUpdate WithItems(List<OrderItem> items)
        {
            this.Items = items;
            return this;
        }
    }
}
#endif