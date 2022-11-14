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
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "banner", NullValueHandling = NullValueHandling.Ignore)]
        public string Banner { get; private set; }

        [JsonProperty(PropertyName = "action", NullValueHandling = NullValueHandling.Ignore)]
        public PromotionTierAction Action { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
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
