using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class RedemptionRollbackQuery
    {
        [DataMember(Name = "tracking_id")]
        public string TrackingId { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }
    }
}
