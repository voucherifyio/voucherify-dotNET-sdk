#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CampaignVoucherRedemption : ApiObject
    {
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; private set; }

        public override string ToString()
        {
            return string.Format("CampaignVoucherRedemption[Quantity={0}]",
                this.Quantity);
        }
    }
}
#endif