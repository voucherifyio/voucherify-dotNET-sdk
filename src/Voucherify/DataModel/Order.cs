#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Order : ApiObject
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItem> Items { get; private set; }

        public Order() {
            this.Items = new List<OrderItem>();
        }

        public Order WithAmount(int amount)
        {
            this.Amount = amount;
            return this;
        }

        public Order WithItems(List<OrderItem> items)
        {
            this.Items = items;
            return this;
        }

        public override string ToString()
        {
            return string.Format("Order[Amount={0},Entries={1}]", 
                this.Amount,
                this.Items != null ? this.Items.Count : 0);
        }
    }
}
#endif