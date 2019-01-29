using Newtonsoft.Json;
using System;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class ForcedOperation
    {
        [JsonProperty(PropertyName = "force")]
        public Boolean Force { get; set; }
    }
}
