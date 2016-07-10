using Newtonsoft.Json;
using System;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class PublishEntry
    {
        [JsonProperty(PropertyName = "customer")]
        public string Customer { get; private set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; private set; }

        [JsonProperty(PropertyName = "published_at")]
        public DateTime? PublishedAt { get; private set; }
    }
}
