#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Publication : PublicationSingle
    {
        [JsonProperty(PropertyName = "vouchers")]
        public List<string> Vouchers { get; private set; }

        public override string ToString()
        {
            return string.Format("Publication(Id={0},Customer={1},Tracking={2},Voucher={3},Vouchers={4})", this.Id, this.CustomerId, this.TrackingId, this.Voucher, string.Join(",", this.Vouchers != null ? this.Vouchers.ToArray() : new string[] { }));
        }
    }
}
#endif