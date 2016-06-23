using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class VoucherRedemptionContext
    {
        [DataMember(Name = "customer")]
        public Customer Customer { get; set; }
        
        [DataMember(Name = "order")]
        public Order Order { get; set; }

        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }

        public VoucherRedemptionContext()
        {
            this.Metadata = new Metadata();
        }
    }
}
