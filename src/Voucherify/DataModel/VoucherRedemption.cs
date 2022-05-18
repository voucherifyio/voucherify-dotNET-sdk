#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherRedemption : ApiObjectWithId
    {
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

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }
        
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; private set; }

        public VoucherRedemption()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("VoucherRedemption(Id={0},Cusotmer={1},Tracking={2},Result={3})", this.Id, this.CustomerId, this.TrackingId, this.Result);
        }
    }
}
#endif