using Newtonsoft.Json;
using System;

namespace Voucherify.Core.Exceptions
{
    [JsonObject]
    public class VoucherifyClientException : Exception
    {
        [JsonIgnore]
        private Exception internalException;

        [JsonProperty(PropertyName = "message")]
        public new string Message { get; private set; }

        [JsonProperty(PropertyName = "code")]
        public int Code { get; private set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; private set; }

        public VoucherifyClientException() { }

        public VoucherifyClientException(string message, int code, string details)
        {
            this.Message = message;
            this.Code = code;
            this.Details = details;        
        }

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
