using Newtonsoft.Json;
using System;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class RedemptionDetails
    {
        [JsonProperty(PropertyName = "redemption_id")]
        public string RedemptionId { get; private set; }

        [JsonProperty(PropertyName = "result")]
        public RedemptionResult Result { get; private set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "voucher_code")]
        public string VoucherCode { get; private set;  }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; private set; }
    }
}
