#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Redemption : ApiObject
    {
        [JsonProperty(PropertyName = "redemption_id")]
        public string RedemptionId { get; private set; }

        [JsonProperty(PropertyName = "result")]
        public RedemptionResult Result { get; private set; }
        
        [JsonProperty(PropertyName = "failure_code")]
        public RedemptionFailureCode? FailureCode { get; private set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Voucher Voucher { get; private set; }

        [JsonProperty(PropertyName = "customer_id")]
        public string CustomerId { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }

        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; private set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }

        public override string ToString()
        {
            return string.Format("Redemption[RedemptionId={0},Result={1},FailureCode={2},Date={3},Voucher={4},CustomerId={5},TrackingId={6},Customer={7},Order={8}]",
                this.RedemptionId,
                this.Result,
                this.FailureCode,
                this.Date,
                this.Voucher,
                this.CustomerId,
                this.TrackingId,
                this.Customer,
                this.Order);
        }
    }
}
#endif