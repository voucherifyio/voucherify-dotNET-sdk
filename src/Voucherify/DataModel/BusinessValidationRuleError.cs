#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    public class BusinessValidationRuleError
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        public override string ToString()
        {
            return string.Format("BusinessValidationRuleError(Message={0})", this.Message);
        }
    }
}
#endif
