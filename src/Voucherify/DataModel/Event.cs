#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Event : ApiObject
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        public Event()
        {
        }

        public override string ToString()
        {
            return string.Format("Event(Type={0})", this.Type);
        }
    }
}
#endif