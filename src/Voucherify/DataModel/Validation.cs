#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Validation
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
        
        [JsonProperty(PropertyName = "order")]
        public ValidationOrder Order { get; private set; }

        [JsonProperty(PropertyName = "promotions")]
        public List<ValidationPromotion> Promotions { get; private set; }
        
        [JsonProperty(PropertyName = "applicable_to")]
        public VoucherSubjectList ApplicableTo { get; private set; }

        public override string ToString()
        {
            return string.Format("Validation(Code={0},IsValid={1},ApplicableTo={2})", this.Code, this.Valid, this.ApplicableTo);
        }
    }
}
#endif