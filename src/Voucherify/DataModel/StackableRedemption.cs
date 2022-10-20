#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Extensions;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class StackableRedemption
    {
        [JsonProperty(PropertyName = "redemptions")]
        public List<Redemption> Redemptions { get; private set; }

        [JsonProperty(PropertyName = "parent_redemption")]
        public Redemption ParentRedemption { get; private set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }

        public StackableRedemption()
        {
            this.Redemptions = new List<Redemption>();
        }

        public override string ToString()
        {
            return string.Format("StackableRedemption(Redemptions={0},ParentRedemption={1},Order={2})", ListExtensions.ToString(this.Redemptions), this.ParentRedemption, this.Order);
        }
    }
}
#endif