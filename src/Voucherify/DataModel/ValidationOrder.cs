#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ValidationOrder : ApiObject
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        [JsonProperty(PropertyName = "discounted_amount")]
        public int DiscountedAmount { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItem> Items { get; private set; }
        
        public ValidationOrder()
        {
            this.Items = new List<OrderItem>();
        }

        public override string ToString()
        {
            return string.Format("ValidationOrder(Amount={0},Items={1})", this.Amount, this.Items.Count);
        }
    }
}
#endif