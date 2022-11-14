#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class GiftUpdate
    {
        [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
        public long Amount { get; set; }

        public GiftUpdate() { }

        public GiftUpdate WithAmount(int amount)
        {
            this.Amount = amount;
            return this;
        }
    }
}

#endif
