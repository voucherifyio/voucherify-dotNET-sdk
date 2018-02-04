#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RedemptionQuantity
    {
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; private set; }

        public override string ToString()
        {
            return string.Format("RedemptionQuantity(Quantity={0})", this.Quantity);
        }
    }
}
#endif