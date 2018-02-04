#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class PromotionTierCreate
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; set; }

        [JsonProperty(PropertyName = "condition")]
        public ValidationRuleCreate Condition { get; set; }

        [JsonProperty(PropertyName = "action")]
        public PromotionTierAction Action { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public PromotionTierCreate()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif
