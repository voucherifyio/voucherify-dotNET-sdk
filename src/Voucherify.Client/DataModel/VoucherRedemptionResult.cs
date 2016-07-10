using Newtonsoft.Json;
using System;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class VoucherRedemptionResult
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; private set; }

        [JsonProperty(PropertyName = "customer_id")]
        public string CustomerId { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }

        [JsonProperty(PropertyName = "redemption")]
        public string Redemption { get; private set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; private set; }

        public VoucherRedemptionResult()
        {
            this.Metadata = new Metadata();
        }
    }
}
