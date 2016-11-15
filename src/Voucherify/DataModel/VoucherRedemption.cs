#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherRedemption : ApiObject
    {
        [JsonProperty(PropertyName = "data_ref")]
        public string DataRef { get; private set; }

        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; private set; }

        [JsonProperty(PropertyName = "redeemed_quantity")]
        public int? RedeemedQuantity { get; private set;  }

        [JsonProperty(PropertyName = "redemption_entries")]
        public List<VoucherRedemptionEntry> RedemptionEntries { get; private set; }

        public VoucherRedemption()
        {
            this.RedemptionEntries = new List<VoucherRedemptionEntry>();
        }

        public override string ToString()
        {
            return string.Format("VoucherRedemption[Quantity={0},Redeemed={1}]",
                this.Quantity,
                this.RedeemedQuantity);
        }
    }
}
#endif