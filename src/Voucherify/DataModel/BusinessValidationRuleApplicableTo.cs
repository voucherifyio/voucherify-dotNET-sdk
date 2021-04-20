#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class BusinessValidationRuleApplicableTo
    {
        [JsonProperty(PropertyName = "excluded", NullValueHandling = NullValueHandling.Ignore)]
        public List<VoucherSubject> Excluded { get; set; }

        [JsonProperty(PropertyName = "included", NullValueHandling = NullValueHandling.Ignore)]
        public List<VoucherSubject> Included { get; set; }

        public BusinessValidationRuleApplicableTo()
        {
        }
    }
}
#endif