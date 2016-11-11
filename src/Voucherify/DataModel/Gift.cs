#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Gift : ApiObject
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
#endif