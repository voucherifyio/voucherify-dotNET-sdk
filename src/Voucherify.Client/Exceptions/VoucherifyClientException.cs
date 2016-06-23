using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.Exceptions
{
    public class VoucherifyClientException : Exception
    {
        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("code")]
        public int Code { get; private set; }

        [JsonProperty("details")]
        public string Details { get; private set; }

        public VoucherifyClientException() { }

        protected VoucherifyClientException(SerializationInfo info, StreamingContext context) { }

        public override string ToString()
        {
            return string.Format("VoucherifyError[code={0}, message='{1}', details='{2}']", this.Code, this.Message, this.Details);
        }
    }
}
