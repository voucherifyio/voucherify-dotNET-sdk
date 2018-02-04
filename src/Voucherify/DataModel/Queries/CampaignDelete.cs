#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class CampaignDelete
    {
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }
    }
}
#endif