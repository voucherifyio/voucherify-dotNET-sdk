#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ProductSkus
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("data")]
        public List<Sku> Entries { get; set; }
    }
}
#endif