#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherPublishList : ApiListObject
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; private set; }

        [JsonProperty(PropertyName = "entries")]
        public List<VoucherPublish> Entries { get; private set; }

        public VoucherPublishList()
        {
            this.Count = 0;
            this.Entries = new List<VoucherPublish>();
        }

        public override string ToString()
        {
            return string.Format("VoucherPublishList(Total={0})", this.Total);
        }
    }
}
#endif