#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class BusinessValidationRuleList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<BusinessValidationRule> Data { get; private set; }

        internal BusinessValidationRuleList()
        {
            this.Data = new List<BusinessValidationRule>();
        }

        public override string ToString()
        {
            return string.Format("BusinessValidationRuleList(Total={0})", this.Total);
        }
    }
}
#endif