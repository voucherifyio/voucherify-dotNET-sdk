#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts {
    [JsonObject]
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