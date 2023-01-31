using Newtonsoft.Json;
using System;

namespace Voucherify.Core.Exceptions
{
    [JsonObject]
    public class VoucherifyClientExceptionError
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }
    }
}