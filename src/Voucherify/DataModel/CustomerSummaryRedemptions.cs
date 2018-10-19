#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerSummaryRedemptions
    {
        [JsonProperty(PropertyName = "total_redeemed")]
        public int TotalRedeemed { get; private set; }

        [JsonProperty(PropertyName = "total_failed")]
        public int TotalFailed { get; private set; }

        [JsonProperty(PropertyName = "total_succeeded")]
        public int TotalSucceeded { get; private set; }

        [JsonProperty(PropertyName = "total_rolled_back")]
        public int TotalRolledBack { get; private set; }

        [JsonProperty(PropertyName = "total_rollback_failed")]
        public int TotalRollbackFailed { get; private set; }

        [JsonProperty(PropertyName = "total_rollback_succeeded")]
        public int TotalRollbackSucceeded { get; private set; }

        [JsonProperty(PropertyName = "gift")]
        public CustomerSummaryRedemptionsGift Gift { get; private set; }

        public override string ToString()
        {
            return string.Format("CustomerSummaryRedemptions(TotalRedemed={0},TotalRolledBack={1})", this.TotalRedeemed, this.TotalRolledBack);
        }
    }
}
#endif