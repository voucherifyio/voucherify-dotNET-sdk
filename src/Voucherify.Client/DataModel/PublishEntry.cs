using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class PublishEntry
    {
        [DataMember(Name = "customer")]
        public string Customer { get; private set; }

        [DataMember(Name = "channel")]
        public string Channel { get; private set; }

        [DataMember(Name = "published_at")]
        public DateTime? PublishedAt { get; private set; }
    }
}
