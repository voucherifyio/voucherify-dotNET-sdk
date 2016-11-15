#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class VoucherDelete
    {
        [JsonProperty(PropertyName = "force")]
        public bool Force { get; set; }
    }
}
#endif