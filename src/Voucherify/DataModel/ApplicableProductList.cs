#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ApplicableProductList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<ApplicableProduct> Products { get; private set; }
        
        public override string ToString()
        {
            return string.Format("ApplicableProductList(Total={0})", this.Total);
        }
    }
}
#endif