using Newtonsoft.Json;
using System.Collections.Generic;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class VoucherPublish
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
