#if VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class RedemptionQuery
    {
        [JsonProperty(PropertyName = "coder")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; set; }
    }
}
#endif
