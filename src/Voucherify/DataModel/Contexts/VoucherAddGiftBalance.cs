#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherAddGiftBalance
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
#endif
