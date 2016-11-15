#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherRedemptionEntry : ApiObject
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty(PropertyName = "customer_id")]
        public string CustomerId { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }
        
        [JsonProperty(PropertyName = "result")]
        public RedemptionResult Result { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }
        
        public VoucherRedemptionEntry()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("VoucherRedemptionEntry[Id={0},Date={1},CustomerId={2},TrackingId={3},Result={4},Metadata={5}]",
                this.Id,
                this.Date,
                this.CustomerId,
                this.TrackingId,
                this.Result,
                this.Metadata);
        }
    }
}
#endif