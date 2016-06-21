using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
