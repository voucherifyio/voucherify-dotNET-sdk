#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Results
{
    [JsonObject]
    public class RedemptionRedeem : DataModel.VoucherRedemptionEntry
    {
        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; private set; }

        public override string ToString()
        {
            return string.Format("RedemptionResult[Redemption={0},Voucher={1}]",
                base.ToString(),
                this.Voucher);
        }
    }
}
#endif