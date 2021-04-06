#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class ValidationGift
    {
        [JsonProperty(PropertyName = "credits")]
        public long? Credits { get; set; }
    }
}
#endif