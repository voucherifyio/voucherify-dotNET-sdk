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
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rules", NullValueHandling = NullValueHandling.Ignore)]
        public Json Rules { get; set; }
        
        [JsonProperty(PropertyName = "applicable_to", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessValidationRuleApplicableTo ApplicableTo { get; set; }

        [JsonProperty(PropertyName = "error", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessValidationRuleError Error { get; set;  }

        public BusinessValidationRuleCreate()
        {
            this.Rules = new Json();
        }
    }
}
#endif
