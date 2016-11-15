#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class RedemptionsFilter 
    {
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        
        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string Customer { get; set; }

        [JsonProperty(PropertyName = "results")]
        public List<RedemptionResult> Results { get; private set; }

        public RedemptionsFilter()
        {
            this.Results = new List<RedemptionResult>();
        }
    }
}
#endif