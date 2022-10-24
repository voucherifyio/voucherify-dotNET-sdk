#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RedeemableResult
    {
        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        public override string ToString()
        {
            return string.Format("RedeemableResult(Discount={0})", this.Discount);
        }
    }
}
#endif
