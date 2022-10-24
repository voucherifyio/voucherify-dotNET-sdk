#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Extensions;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class StackableValidation
    {
        [JsonProperty(PropertyName = "valid")]
        public bool Valid { get; private set; }

        [JsonProperty(PropertyName = "redeemables")]
        public List<Redeemable> Redeemables { get; private set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; private set; }

        [JsonProperty(PropertyName = "session")]
        public ValidationSession Session { get; private set; }

        public StackableValidation()
        {
            this.Redeemables = new List<Redeemable>();
        }

        public override string ToString()
        {
            return string.Format("StackableValidation(IsValid={0},Redeemables={1},Order={2},TrackingId={3},Session={4})", this.Valid, ListExtensions.ToString(this.Redeemables), this.Order, this.TrackingId, this.Session);
        }
    }
}
#endif
