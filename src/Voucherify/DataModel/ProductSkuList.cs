#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ProductSkuList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<Sku> Entries { get; private set; }

        public override string ToString()
        {
            return string.Format("ProductSkuList(Total={0})", this.Total);
        }
    }
}
#endif