#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class PublicationSingle : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "customer_id")]
        public string CustomerId { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }

        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public override string ToString()
        {
            return string.Format("PublicationSingle(Id={0},Customer={1},Tracking={2,.Voucher={3})", this.Id, this.CustomerId, this.TrackingId, this.Voucher);
        }
    }
}
#endif