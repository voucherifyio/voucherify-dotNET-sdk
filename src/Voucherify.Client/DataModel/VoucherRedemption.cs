using Newtonsoft.Json;
using System.Collections.Generic;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class VoucherRedemption
    {
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; private set; }

        [JsonProperty(PropertyName = "redeemed_quantity")]
        public int? RedeemedQuantity { get; private set;  }

        [JsonProperty(PropertyName = "redemption_entries")]
        public List<RedemptionEntry> RedemptionEntries { get; private set; }

        public VoucherRedemption()
        {
            this.RedemptionEntries = new List<RedemptionEntry>();
        }

        public static VoucherRedemption WithQuantity(int limit)
        {
            return new VoucherRedemption() { Quantity = limit };
        }
    }
}
