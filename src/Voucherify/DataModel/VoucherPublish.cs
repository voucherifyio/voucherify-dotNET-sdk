#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherPublish : ApiObject
    {
        [JsonProperty(PropertyName = "customer")]
        public string Customer { get; private set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; private set; }

        [JsonProperty(PropertyName = "published_at")]
        public DateTime? PublishedAt { get; private set; }

        public override string ToString()
        {
            return string.Format("VoucherPublish(Customer={0},Channel={1})", this.Customer, this.Channel);
        }
    }
}
#endif