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
        public string DataRef { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        [JsonProperty(PropertyName = "redeemed_quantity")]
        public int? RedeemedQuantity { get; private set;  }

        [JsonProperty(PropertyName = "redemption_entries")]
        public List<Redemption> RedemptionEntries { get; private set; }

        public VoucherRedemption()
        {
            this.RedemptionEntries = new List<Redemption>();
        }

        public static VoucherRedemption WithQuantity(int limit)
        {
            return new VoucherRedemption() { Quantity = limit };
        }
    }
}
#endif