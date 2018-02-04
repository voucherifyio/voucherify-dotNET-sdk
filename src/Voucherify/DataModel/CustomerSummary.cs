#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerSummary
    {
        [JsonProperty(PropertyName = "orders")]
        public CustomerSummaryOrders Orders { get; private set; }

        [JsonProperty(PropertyName = "redemptions")]
        public CustomerSummaryRedemptions Redemptions { get; private set; }

        public override string ToString()
        {
            return string.Format("CustomerSummary(Orders={0},Redemptions={1})", this.Orders, this.Redemptions);
        }
    }
}
#endif