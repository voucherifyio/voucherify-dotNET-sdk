#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    public class CustomerSummaryOrders
    {
        [JsonProperty(PropertyName = "total_amount")]
        public long TotalAmount { get; private set; }

        [JsonProperty(PropertyName = "total_count")]
        public int TotalCount { get; private set; }

        [JsonProperty(PropertyName = "average_amount")]
        public long? AverageAmount { get; private set; }

        [JsonProperty(PropertyName = "last_order_amount")]
        public int? LastOrderAmount { get; private set; }

        [JsonProperty(PropertyName = "last_order_date")]
        public DateTime? LastOrderDate { get; private set; }

        public override string ToString()
        {
            return string.Format("CustomerSummaryOrders(Total={0},TotalAmount={1})", this.TotalCount, this.TotalAmount);
        }
    }
}
#endif