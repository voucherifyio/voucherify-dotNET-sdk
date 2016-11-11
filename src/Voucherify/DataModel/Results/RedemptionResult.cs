#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Results
{
    [JsonObject]
    public class RedemptionResult : DataModel.Redemption
    {
        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; private set; }
    }
}
#endif