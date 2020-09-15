#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class Order : OrderCreate
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public new Order WithAmount(long amount)
        {
            base.WithAmount(amount);
            return this;
        }

        public new Order WithItems(List<OrderItem> items)
        {
            base.WithItems(items);
            return this;
        }
    }
}
#endif