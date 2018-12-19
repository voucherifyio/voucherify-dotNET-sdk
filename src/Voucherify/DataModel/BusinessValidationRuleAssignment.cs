#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    public class BusinessValidationRuleAssignment : ApiObjectWithId
    {
        [JsonProperty("rule_id")]
        public string RuleId { get; private set; }

        [JsonProperty("related_object_id")]
        public string RelatedObjectId { get; private set; }

        [JsonProperty("related_object_type")]
        public string RelatedObjectType { get; private set; }
    }
}
#endif