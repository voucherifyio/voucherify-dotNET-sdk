#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RedemptionEntry : ApiObject
    {
        [JsonProperty(PropertyName = "redemption_id")]
        public string RedemptionId { get; private set; }

        [JsonProperty(PropertyName = "result")]
        public RedemptionEntryResult Result { get; private set; }

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
#endif