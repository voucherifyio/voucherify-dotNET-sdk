#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherAssets
    {
        [JsonProperty(PropertyName = "qr")]
        public QR QR { get; private set; }

        public override string ToString()
        {
            return string.Format("VoucherAssets(QR={0})", this.QR);
        }
    }
}
#endif