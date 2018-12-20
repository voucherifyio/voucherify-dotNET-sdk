#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class BusinessValidationRuleCreate
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rules")]
        public Json Rules { get; set; }

        public BusinessValidationRuleCreate()
        {
            this.Rules = new Json();
        }
    }
}
#endif
