#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;


namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherSubject
    {
        [JsonProperty(PropertyName = "object")]
        public string Object { get; private set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; private set; }
    }
}
#endif