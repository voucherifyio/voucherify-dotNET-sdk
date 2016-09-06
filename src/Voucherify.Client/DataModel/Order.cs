using Newtonsoft.Json;
using System.Collections.Generic;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class Order
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; private set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItem> Items { get; private set; }

        private Order() { }

        public static Order WithAmount(int amount)
        {
            return new Order
            {
                Amount = amount,
                Items = new List<OrderItem>()
            };
        }
    }
}