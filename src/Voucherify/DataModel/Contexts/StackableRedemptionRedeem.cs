#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class StackableRedemptionRedeem
    {
        [JsonProperty(PropertyName = "customer", NullValueHandling = NullValueHandling.Ignore)]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "order", NullValueHandling = NullValueHandling.Ignore)]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "options", NullValueHandling = NullValueHandling.Ignore)]
        public StackableRedemptionOptions Options { get; set; }

        [JsonProperty(PropertyName = "redeemables", NullValueHandling = NullValueHandling.Ignore)]
        public List<Redeemable> Redeemables { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "session", NullValueHandling = NullValueHandling.Ignore)]
        public ValidationSession Session { get; set; }

        public StackableRedemptionRedeem()
        {
            this.Redeemables = new List<Redeemable>();
            this.Metadata = new Metadata();
        }
    }
}
#endif
