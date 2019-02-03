#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class PromotionTiersFilter : Core.DataModel.PageFilter
    {
        [JsonProperty(PropertyName = "is_available")]
        public bool? IsAvailable { get; set; }
    }
}
#endif