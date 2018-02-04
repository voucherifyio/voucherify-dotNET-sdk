#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionRedeem
    {
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; private set; }
        
        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

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