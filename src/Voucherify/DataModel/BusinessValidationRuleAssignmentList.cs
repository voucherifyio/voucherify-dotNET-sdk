#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class BusinessValidationRuleAssignmentList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<BusinessValidationRuleAssignment> Data { get; private set; }

        internal BusinessValidationRuleAssignmentList()
        {
            this.Data = new List<BusinessValidationRuleAssignment>();
        }

        public override string ToString()
        {
            return string.Format("BusinessValidationRuleAssignmentList(Total={0})", this.Total);
        }
    }
}
#endif