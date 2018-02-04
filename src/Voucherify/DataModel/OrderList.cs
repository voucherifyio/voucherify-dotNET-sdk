#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class OrderList : ApiListObject
    {
        [JsonProperty(PropertyName = "orders")]
        public List<Order> Orders { get; private set; }

        internal OrderList()
        {
            this.Orders = new List<Order>();
        }

        public override string ToString()
        {
            return string.Format("OrderList(Total={0})", this.Total);
        }
    }
}
#endif