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
#endif