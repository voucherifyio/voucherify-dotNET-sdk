#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Queries
{
    [JsonObject]
    public class VoucherPublishQuery
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("voucher")]
        public string Voucher { get; set; }
    }
}
#endif