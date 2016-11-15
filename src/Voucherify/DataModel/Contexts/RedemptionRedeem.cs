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
        public object Customer { get; private set; }
        

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public RedemptionRedeem()
        {
            this.Metadata = new Metadata();
        }

        public RedemptionRedeem WithCustomer(CustomerCreate customer)
        {
            this.Customer = customer;
            return this;
        }

        public RedemptionRedeem WithCustomerId(string customerId)
        {
            this.Customer = customerId;
            return this;
        }
    }
}
#endif