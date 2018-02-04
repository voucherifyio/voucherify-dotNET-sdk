#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RedemptionRollback : ApiObjectWithId
    {
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

        [JsonProperty(PropertyName = "gift")]
        public RedemptionGift Gift { get; private set; }

        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; private set; }
        
        [JsonProperty(PropertyName = "result")]
        public RedemptionResult Result { get; private set; }

        [JsonProperty(PropertyName = "failure_code")]
        public FailureCode? FailureCode { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public RedemptionRollback()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("RedemptionRollback(Id={0},Customer={1},Tracking={2},Redemption={3})", this.Id, this.CustomerId, this.TrackingId, this.Redemption);
        }
    }
}
#endif