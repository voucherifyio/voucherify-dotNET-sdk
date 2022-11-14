#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionRedeem
    {
        [JsonProperty(PropertyName = "customer", NullValueHandling = NullValueHandling.Ignore)]
        public Customer Customer { get; private set; }
        
        [JsonProperty(PropertyName = "order", NullValueHandling = NullValueHandling.Ignore)]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "reward", NullValueHandling = NullValueHandling.Ignore)]
        public RedemptionReward Reward { get; set; }

        [JsonProperty(PropertyName = "gift", NullValueHandling = NullValueHandling.Ignore)]
        public RedemptionGift Gift { get; set; }

        [JsonProperty(PropertyName = "session", NullValueHandling = NullValueHandling.Ignore)]
        public RedemptionSession Session { get; set; }

        public RedemptionRedeem()
        {
            this.Metadata = new Metadata();
        }

        public RedemptionRedeem WithCustomer(Customer customer)
        {
            this.Customer = customer;
            return this;
        }

        public RedemptionRedeem WithCustomerId(string customerId)
        {
            this.Customer = new Customer() { Id = customerId };
            return this;
        }
    }
}
#endif