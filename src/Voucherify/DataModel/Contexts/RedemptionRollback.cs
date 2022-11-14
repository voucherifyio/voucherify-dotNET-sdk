#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class RedemptionRollback
    {
        [JsonProperty(PropertyName = "customer", NullValueHandling = NullValueHandling.Ignore)]
        public object Customer { get; private set; }

        public RedemptionRollback WithCustomer(CustomerCreate customer)
        {
            this.Customer = customer;
            return this;
        }

        public RedemptionRollback WithCustomerId(string customerId)
        {
            this.Customer = customerId;
            return this;
        }
    }
}
#endif