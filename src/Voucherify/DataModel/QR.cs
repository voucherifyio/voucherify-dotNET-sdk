#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public  class QR
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        private QR() { }
    }
}
#endif