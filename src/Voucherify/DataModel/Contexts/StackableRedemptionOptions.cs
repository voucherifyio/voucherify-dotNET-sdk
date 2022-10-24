#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class StackableRedemptionOptions
    {
        [JsonProperty(PropertyName = "expand")]
        public HashSet<string> Expand { get; set; }

        public StackableRedemptionOptions()
        {
            this.Expand = new HashSet<string>();
        }

        public StackableRedemptionOptions WithOrder()
        {
            this.Expand.Add("order");
            return this;
        }

        public StackableRedemptionOptions WithRedeemable()
        {
            this.Expand.Add("redeemable");
            return this;
        }

        public StackableRedemptionOptions WithCategory()
        {
            this.Expand.Add("category");
            return this;
        }

        public StackableRedemptionOptions WithRedemption()
        {
            this.Expand.Add("redemption");
            return this;
        }
    }
}
#endif