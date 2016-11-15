#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ProductSkus : ApiObject
    {
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; private set; }

        [JsonProperty(PropertyName = "data")]
        public List<Sku> Entries { get; private set; }

        public override string ToString()
        {
            return string.Format("ProductSkus[Entries={0}]", this.Total);
        }
    }
}
#endif