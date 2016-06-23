using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class VoucherRedemptionResult
    {
        [DataMember(Name = "id")]
        public string Id { get; private set; }

        [DataMember(Name = "date")]
        public DateTime? Date { get; private set; }

        [DataMember(Name = "object")]
        public string Object { get; private set; }

        [DataMember(Name = "customer_id")]
        public string CustomerId { get; private set; }

        [DataMember(Name = "tracking_id")]
        public string TrackingId { get; private set; }

        [DataMember(Name = "redemption")]
        public string Redemption { get; private set; }

        [DataMember(Name = "reason")]
        public string Reason { get; private set; }

        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; private set; }

        [DataMember(Name = "voucher")]
        public Voucher Voucher { get; private set; }

        public VoucherRedemptionResult()
        {
            this.Metadata = new Metadata();
        }
    }
}
