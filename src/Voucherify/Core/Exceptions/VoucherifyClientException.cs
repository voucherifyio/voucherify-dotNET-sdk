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

        [JsonProperty(PropertyName = "key")]
        public string Key { get; private set; }

        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; private set; }

        [JsonProperty(PropertyName = "resource_id")]
        public string ResourceId { get; private set; }

        [JsonProperty(PropertyName = "resource_type")]
        public string ResourceType { get; private set; }

        [JsonProperty(PropertyName = "error")]
        public VoucherifyClientExceptionError Error { get; private set; }

        public VoucherifyClientException() { }

        public VoucherifyClientException(string message, int code, string details, string key)
        {
            this.Message = message;
            this.Code = code;
            this.Details = details;
            this.Key = key;
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

            return string.Format("VoucherifyError[code={0}, key='{1}, message='{2}', details='{3}']", this.Code, this.Key, this.Message, this.Details);
        }
    }
}
