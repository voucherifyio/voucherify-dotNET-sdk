#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class PromotionTier : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; private set; }

        [JsonProperty(PropertyName = "campaign")]
        public PromotionTierCampaign Campaign { get; private set; }
        
        [JsonProperty(PropertyName = "action")]
        public PromotionTierAction Action { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }
#if VOUCHERIFYSERVER
        [JsonProperty(PropertyName = "validation_rule_assignments")]
        public BusinessValidationRuleAssignmentList Assignments { get; private set; }
#endif
        public PromotionTier()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
#if VOUCHERIFYSERVER
            return string.Format("PromotionTier(Id={0},Name={1},Campaign={2}, Assignments={3})", this.Id, this.Name, this.Campaign, this.Assignments);
#else
            return string.Format("PromotionTier(Id={0},Name={1},Campaign={2})", this.Id, this.Name, this.Campaign);
#endif
        }
    }
}
#endif