#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherList : ApiListObject
    {
        [JsonProperty(PropertyName = "vouchers")]
        public List<Voucher> Vouchers { get; private set; }

        internal VoucherList()
        {
            this.Vouchers = new List<Voucher>();
        }

        public VoucherList(Voucher[] vouchers)
        {
            this.Vouchers = new List<Voucher>(vouchers);
            this.Total = this.Vouchers.Count;
            this.Object = "list";
            this.DataRef = "vouchers";
        }
 
        public override string ToString()
        {
            return string.Format("VoucherList[Entries={0}]", this.Total);
        }
    }
}
#endif