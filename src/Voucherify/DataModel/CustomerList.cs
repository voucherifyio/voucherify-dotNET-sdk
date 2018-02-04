#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerList : ApiListObject
    {
        [JsonProperty(PropertyName = "customers")]
        public List<Customer> Customers { get; private set; }

        internal CustomerList()
        {
            this.Customers = new List<Customer>();
        }

        public override string ToString()
        {
            return string.Format("CustomerList(Total={0})", this.Total);
        }
    }
}
#endif