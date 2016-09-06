using Newtonsoft.Json;
using System;

namespace Voucherify.Client.Exceptions
{
    [JsonObject]
    public class VoucherifyClientExceptionPortable
    {
        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("code")]
        public int Code { get; private set; }

        [JsonProperty("details")]
        public string Details { get; private set; }

        public VoucherifyClientExceptionPortable() { }
    }
}
