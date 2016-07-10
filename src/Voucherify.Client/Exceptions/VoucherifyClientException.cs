using Newtonsoft.Json;
using System;

namespace Voucherify.Client.Exceptions
{
    [JsonObject]
    public class VoucherifyClientException : Exception
    {
        [JsonIgnore]
        private Exception internalException;

        [JsonProperty("message")]
        public new string Message { get; private set; }

        [JsonProperty("code")]
        public int Code { get; private set; }

        [JsonProperty("details")]
        public string Details { get; private set; }

        public VoucherifyClientException() { }

        public VoucherifyClientException(Exception internalException)
        {
            this.internalException = internalException;
        }

        public override string ToString()
        {
            if (internalException != null)
            {
                return string.Format("VoucherifyError[inner='{0}']", internalException);
            }

            return string.Format("VoucherifyError[code={0}, message='{1}', details='{2}']", this.Code, this.Message, this.Details);
        }
    }
}
