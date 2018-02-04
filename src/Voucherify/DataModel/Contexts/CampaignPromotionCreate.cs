#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CampaignPromotionCreate
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public CampaignType Type { get; set; }

        [JsonProperty(PropertyName = "campaign_type")]
        public string CampaignType { get; private set; }

        [JsonProperty(PropertyName = "start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }
        
        [JsonProperty(PropertyName = "promotion")]
        public PromotionTierListCreate Promotion { get; set; }

        public CampaignPromotionCreate()
        {
            this.CampaignType = "PROMOTION";
            this.Metadata = new Metadata();
        }
    }
}
#endif