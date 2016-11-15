#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ProductList : ApiObject
    {
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; private set; }

        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; private set; }

        public override string ToString()
        {
            return string.Format("ProductList[Entries={0}]", this.Total);
        }
    }
}
#endif