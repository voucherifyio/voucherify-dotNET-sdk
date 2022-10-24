#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class StackableValidationOptions
    {
        [JsonProperty(PropertyName = "expand")]
        public IList<string> Expand { get; set; }

        private void EnsureExpandEntry(string expandEntry)
        {
            if (!this.Expand.Contains(expandEntry))
            {
                this.Expand.Add(expandEntry);
            }
        }

        public StackableValidationOptions()
        {
            this.Expand = new List<string>();
        }

        public StackableValidationOptions WithOrder()
        {
            this.EnsureExpandEntry("order");
            return this;
        }

        public StackableValidationOptions WithRedeemable()
        {
            this.EnsureExpandEntry("redeemable");
            return this;
        }

        public StackableValidationOptions WithCategory()
        {
            this.EnsureExpandEntry("category");
            return this;
        }
    }
}
#endif