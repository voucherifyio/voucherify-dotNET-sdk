using Newtonsoft.Json;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class Gift
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; private set; }

        private Gift() { }

        public static Gift WithAmount(int amount)
        {
            return new Gift
            {
                Amount = amount
            };
        }
    }
}