#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerLoyalty
    {
        [JsonProperty(PropertyName = "points")]
        public int Points { get; private set; }

        [JsonProperty(PropertyName = "referred_customers")]
        public int ReferredCustomers { get; private set; }

        [JsonProperty(PropertyName = "campaigns")]
        public Metadata Campaigns { get; private set; }

        public CustomerLoyalty()
        {
            this.Campaigns = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("CustomerLoyalty(Points={0})", this.Points);
        }
    }
}
#endif