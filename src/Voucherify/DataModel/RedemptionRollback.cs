#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RedemptionRollback : ApiObject
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

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

        public RedemptionRollback()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("RedemptionRollkach[Id={0},Date={1},CustomerId={2},TrackingId={3},Redemption={4},Reason={5},Metadata={6}]",
                this.Id,
                this.Date,
                this.CustomerId,
                this.TrackingId,
                this.Redemption,
                this.Reason,
                this.Metadata);
        }
    }
}
#endif