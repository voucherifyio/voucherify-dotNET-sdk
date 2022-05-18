#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Redemption : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "result")]
        public RedemptionResult Result { get; private set; }
        
        [JsonProperty(PropertyName = "failure_code")]
        public FailureCode? FailureCode { get; private set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "gift")]
        public RedemptionGift Gift { get; private set; }

        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; private set; }

        [JsonProperty(PropertyName = "customer_id")]
        public string CustomerId { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }

        [JsonProperty(PropertyName = "customer")]
        public CustomerSimple Customer { get; private set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }

        [JsonProperty(PropertyName = "promotion_tier")]
        public PromotionTier PromotionTier { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
        public long Amount { get; private set; }

        public override string ToString()
        {
            return string.Format("Redemption(Id={0},Result={1},Customer={2},Tracking={3},Order={4})", this.Id, this.Result, this.CustomerId, this.TrackingId, this.Order);
        }
    }
}
#endif