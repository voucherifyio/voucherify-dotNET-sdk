#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerSummaryRedemptionsGift
    {
        [JsonProperty(PropertyName = "redeemed_amount")]
        public long RedeemedAmount { get; private set; }

        [JsonProperty(PropertyName = "amount_to_go")]
        public long AmountToGo { get; private set; }

        public override string ToString()
        {
            return string.Format("CustomerSummaryRedemptionsGift(RedeemedAmount={0},AmountToGo={1})", this.RedeemedAmount, this.AmountToGo);
        }
    }
}
#endif