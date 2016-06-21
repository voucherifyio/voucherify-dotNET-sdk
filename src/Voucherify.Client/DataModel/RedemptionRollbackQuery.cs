using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
