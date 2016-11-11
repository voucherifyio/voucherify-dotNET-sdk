#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherPublish : ApiObject
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; private set; }

        [JsonProperty(PropertyName = "entries")]
        public List<PublishEntry> Entries { get; private set; }

        public VoucherPublish()
        {
            this.Count = 0;
            this.Entries = new List<PublishEntry>();
        }
    }
}
#endif