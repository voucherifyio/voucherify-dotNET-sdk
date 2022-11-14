#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class GiftCreate
    {
        [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
        public long Amount { get; set; }

        public GiftCreate() { }

        public GiftCreate WithAmount(int amount)
        {
            this.Amount = amount;
            return this;
        }
    }
}

#endif
