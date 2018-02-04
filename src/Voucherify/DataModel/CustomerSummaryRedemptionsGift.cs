#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerSummaryRedemptionsGift
    {
        [JsonProperty(PropertyName = "redeemed_amount")]
        public int RedeemedAmount { get; private set; }

        [JsonProperty(PropertyName = "amount_to_go")]
        public int AmountToGo { get; private set; }
    }
}
#endif