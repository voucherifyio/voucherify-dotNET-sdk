using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections.Specialized;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class RedemptionsFilter 
    {
        [DataMember(Name = "limit")]
        public int? Limit { get; set; }
        
        [DataMember(Name = "start_date")]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "end_date")]
        public DateTime? EndDate { get; set; }

        [DataMember(Name = "customer")]
        public string Customer { get; set; }

        [DataMember(Name = "results")]
        public List<RedemptionResult> Results { get; private set; }

        public RedemptionsFilter()
        {
            this.Results = new List<RedemptionResult>();
        }
    }
}
