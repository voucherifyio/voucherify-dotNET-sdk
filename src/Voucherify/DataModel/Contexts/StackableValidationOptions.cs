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
        public HashSet<string> Expand { get; set; }

        public StackableValidationOptions()
        {
            this.Expand = new HashSet<string>();
        }

        public StackableValidationOptions WithOrder()
        {
            this.Expand.Add("order");
            return this;
        }

        public StackableValidationOptions WithRedeemable()
        {
            this.Expand.Add("redeemable");
            return this;
        }

        public StackableValidationOptions WithCategory()
        {
            this.Expand.Add("category");
            return this;
        }
    }
}
#endif