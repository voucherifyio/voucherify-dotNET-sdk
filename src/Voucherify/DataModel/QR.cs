#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public  class QR : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        private QR() { }

        public override string ToString()
        {
            return string.Format("QR(Id={0})");
        }
    }
}
#endif