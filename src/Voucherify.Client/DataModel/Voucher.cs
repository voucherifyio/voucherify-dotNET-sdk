using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class Voucher
    {
        [DataMember(Name = "code")]
        public string Code { get; set; }
        
        [DataMember(Name = "type")]
        public VoucherType Type { get; set; }

        [DataMember(Name = "campaign")]
        public string Campaign { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "discount")]
        public Discount Discount { get; set; }
        
        [DataMember(Name = "gift")]
        public Gift Gift { get; set; }

        [DataMember(Name = "start_date")]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [DataMember(Name = "active")]
        public bool? Active { get; set; }

        [DataMember(Name = "publish")]
        public VoucherPublish Publish { get; set; }

        [DataMember(Name = "redemption")]
        public VoucherRedemption Redemption { get; set; }

        [DataMember(Name = "additional_info")]
        public string AdditionalInfo { get; set; }
        
        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }

        public Voucher()
        {
            this.Metadata = new Metadata();
        }
    }
}
