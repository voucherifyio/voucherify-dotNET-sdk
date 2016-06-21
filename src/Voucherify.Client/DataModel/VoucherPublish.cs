using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class VoucherPublish
    {
        [DataMember(Name = "count")]
        public int Count { get; private set; }

        [DataMember(Name = "entries")]
        public List<PublishEntry> Entries { get; private set; }

        public VoucherPublish()
        {
            this.Count = 0;
            this.Entries = new List<PublishEntry>();
        }
    }
}
