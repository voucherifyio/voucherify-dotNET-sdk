#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherAssets
    {
        [JsonProperty(PropertyName = "qr")]
        public QR QR { get; private set; }

        [JsonProperty(PropertyName = "barcode")]
        public Barcode Barcode { get; private set; }

        public override string ToString()
        {
            return string.Format("VoucherAssets(QR={0},Barcode={1})", this.QR, this.Barcode);
        }
    }
}
#endif