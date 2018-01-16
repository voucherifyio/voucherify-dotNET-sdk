#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CampaignList : ApiListObject
    {
        [JsonProperty(PropertyName = "campaigns")]
        public List<Campaign> Campaigns { get; private set; }

        internal CampaignList()
        {
            this.Campaigns = new List<Campaign>();
        }

        public CampaignList(Campaign[] campaigns)
        {
            this.Campaigns = new List<Campaign>(campaigns);
            this.Total = this.Campaigns.Count;
            this.Object = "list";
            this.DataRef = "campaigns";
        }

        public override string ToString()
        {
            return string.Format("CampaignList[Entries={0}]", this.Total);
        }
    }
}
#endif