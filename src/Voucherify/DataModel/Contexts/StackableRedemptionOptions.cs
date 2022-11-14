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
        [JsonProperty(PropertyName = "expand", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Expand { get; set; }

        public StackableRedemptionOptions()
        {
            this.Expand = new List<string>();
        }

        private void EnsureExpandEntry(string expandEntry)
        {
            if (!this.Expand.Contains(expandEntry))
            {
                this.Expand.Add(expandEntry);
            }
        }

        public StackableRedemptionOptions WithOrder()
        {
            this.EnsureExpandEntry("order");
            return this;
        }

        public StackableRedemptionOptions WithRedeemable()
        {
            this.EnsureExpandEntry("redeemable");
            return this;
        }

        public StackableRedemptionOptions WithCategory()
        {
            this.EnsureExpandEntry("category");
            return this;
        }

        public StackableRedemptionOptions WithRedemption()
        {
            this.EnsureExpandEntry("redemption");
            return this;
        }
    }
}
#endif