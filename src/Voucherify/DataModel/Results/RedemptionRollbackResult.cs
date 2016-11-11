#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Results
{
    [JsonObject]
    public class RedemptionRollbackResult : DataModel.RedemptionRollback
    {
        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; private set; }
    }
}
#endif