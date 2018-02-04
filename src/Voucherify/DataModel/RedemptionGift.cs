#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RedemptionGift {

        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; private set; }

        public override string ToString()
        {
            return string.Format("RedemptionGift(Amount={0})", this.Amount);
        }
    }
}
#endif