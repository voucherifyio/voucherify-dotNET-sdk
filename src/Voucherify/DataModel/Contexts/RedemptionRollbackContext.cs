#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionRollbackContext
    {
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }
    }
}
#endif