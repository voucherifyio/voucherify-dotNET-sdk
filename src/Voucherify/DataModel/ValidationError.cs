#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ValidationError
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; private set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }
        
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        public override string ToString()
        {
            return string.Format("ValidationError(Message={0})", this.Message);
        }
    }
}
#endif
