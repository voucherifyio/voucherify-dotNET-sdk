#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Barcode : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        private Barcode () { }

        public override string ToString()
        {
            return string.Format("Barcode(Id={0},Url={1})", this.Id, this.Url);
        }
    }
}
#endif