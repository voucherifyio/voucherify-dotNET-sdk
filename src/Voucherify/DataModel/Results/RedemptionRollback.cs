#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Results
{
    [JsonObject]
    public class RedemptionRollback : DataModel.RedemptionRollback
    {
        [JsonProperty(PropertyName = "voucher")]
        public Voucher Voucher { get; private set; }

        public override string ToString()
        {
            return string.Format("VoucherValidationResult[Rollback={0},Voucher={1}]",
                base.ToString(),
                this.Voucher);
        }
    }
}
#endif