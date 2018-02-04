#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherRedemptionList : ApiListObject
    {
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; private set; }

        [JsonProperty(PropertyName = "redeemed_quantity")]
        public int? RedeemedQuantity { get; private set;  }

        [JsonProperty(PropertyName = "redemption_entries")]
        public List<VoucherRedemption> RedemptionEntries { get; private set; }

        public VoucherRedemptionList()
        {
            this.RedemptionEntries = new List<VoucherRedemption>();
        }

        public override string ToString()
        {
            return string.Format("VoucherRedemptionList(Total={0},Redeemed={1})", this.Total, this.RedeemedQuantity);
        }
    }
}
#endif