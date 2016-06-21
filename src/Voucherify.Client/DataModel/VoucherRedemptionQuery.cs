using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class VoucherRedemptionQuery
    {
        [DataMember(Name = "tracking_id")]
        public string TrackingId { get; set; }
    }
}
