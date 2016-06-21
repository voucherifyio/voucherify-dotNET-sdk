using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class VoucherRedemptionContext
    {
        [DataMember(Name = "customer")]
        public Customer Customer { get; private set; }
        
        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; private set; }
    }
}
