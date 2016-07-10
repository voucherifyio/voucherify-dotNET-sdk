using Newtonsoft.Json;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class Order
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; private set; }

        private Order() { }

        public static Order WithAmount(int amount)
        {
            return new Order
            {
                Amount = amount
            };
        }
    }
}