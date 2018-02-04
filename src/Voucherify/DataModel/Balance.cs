#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Balance : ApiObject
    {
        [JsonProperty("amount")]
        public int Amount { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("related_object")]
        public RelatedObject RelatedObject { get; private set; }

        public override string ToString()
        {
            return string.Format("Balance(Amount={0},Type={1})", this.Amount, this.Type);
        }
    }
}
#endif