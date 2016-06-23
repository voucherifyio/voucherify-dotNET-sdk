using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class RedemptionDetails
    {
        [DataMember(Name = "redemption_id")]
        public string RedemptionId { get; private set; }

        [DataMember(Name = "result")]
        public RedemptionResult Result { get; private set; }

        [DataMember(Name = "date")]
        public DateTime? Date { get; private set; }

        [DataMember(Name = "voucher_code")]
        public string VoucherCode { get; private set;  }

        [DataMember(Name = "discount")]
        public Discount Discount { get; private set; }

        [DataMember(Name = "customer")]
        public Customer Customer { get; private set; }
    }
}
