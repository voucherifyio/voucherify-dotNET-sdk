#if VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class VoucherValidation
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        [JsonProperty(PropertyName = "item")]
        public IList<OrderItem> Items { get; set; }
    }
}
#endif