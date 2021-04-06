#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Validation
    {
        [JsonProperty(PropertyName = "applicable_to")]
        public VoucherSubjectList ApplicableTo { get; private set; }

        [JsonProperty(PropertyName = "inapplicable_to")]
        public VoucherSubjectList InapplicableTo { get; private set; }

        [JsonProperty(PropertyName = "error")]
        public ValidationError Error { get; private set; }

        [JsonProperty(PropertyName = "valid")]
        public bool Valid { get; private set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }

        [JsonProperty(PropertyName = "session")]
        public ValidationSession Session { get; private set; }

        public override string ToString()
        {
            return string.Format("Validation(IsValid={0},ApplicableTo={1},InapplicableTo={2},Erorr={3})", this.Valid, this.ApplicableTo, this.InapplicableTo, this.Error);
        }
    }
}
#endif