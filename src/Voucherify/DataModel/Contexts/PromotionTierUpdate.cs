#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class PromotionTierUpdate
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; private set; }
        
        [JsonProperty(PropertyName = "condition")]
        public ValidationRuleUpdate Condition { get; set; }

        [JsonProperty(PropertyName = "action")]
        public PromotionTierAction Action { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public PromotionTierUpdate()
        {
            this.Metadata = new Metadata();
        }

        public PromotionTierUpdate WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
        }
    }
}
#endif
