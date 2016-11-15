#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel.Results
{
    [JsonObject]
    public class VoucherValidation
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        [JsonProperty(PropertyName = "valid")]
        public bool Valid { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "gift")]
        public Gift Gift { get; private set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }

        public override string ToString()
        {
            return string.Format("VoucherValidationResult[Code={0},Valid={1},Discount={2},Gift={3},Reason={4},TrackingId={5}]",
                this.Code,
                this.Valid,
                this.Discount,
                this.Gift,
                this.Reason,
                this.TrackingId);
        }
    }
}
#endif