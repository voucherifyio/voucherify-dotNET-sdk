#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    public class BusinessValidationRule : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rules")]
        public Json Rules { get; set; }

        [JsonProperty(PropertyName = "error")]
        public BusinessValidationRuleError Error { get; set;  }

        [JsonProperty(PropertyName = "applicable_to", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessValidationRuleApplicableTo ApplicableTo { get; set; }

        public BusinessValidationRule()
        {
            this.Rules = new Json();
        }

        public override string ToString()
        {
            return string.Format("BusinessValidationRule(Id={0},Name={1})", this.Id, this.Name);
        }
    }
}
#endif
