#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class BusinessValidationRuleUpdate
    {
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rules", NullValueHandling = NullValueHandling.Ignore)]
        public Json Rules { get; set; }

        public BusinessValidationRuleUpdate()
        {
        }
    }
}
#endif