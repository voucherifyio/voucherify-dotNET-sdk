using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CustomerSystemMetadata
    {
        [JsonProperty(PropertyName = "consents")]
        public Json Consents { get; private set; }

        public override string ToString()
        {
            return string.Format("CustomerSystemMetadata(Consents={0})", this.Consents);
        }
    }
}