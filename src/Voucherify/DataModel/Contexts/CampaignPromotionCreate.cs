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
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public CampaignExtensionType Type { get; set; }

        [JsonProperty(PropertyName = "campaign_type", NullValueHandling = NullValueHandling.Ignore)]
        public CampaignType CampaignType { get; private set; }

        [JsonProperty(PropertyName = "start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }
        
        [JsonProperty(PropertyName = "promotion", NullValueHandling = NullValueHandling.Ignore)]
        public PromotionTierListCreate Promotion { get; set; }

        public CampaignPromotionCreate()
        {
            this.CampaignType = CampaignType.PROMOTION;
            this.Metadata = new Metadata();
        }
    }
}
#endif