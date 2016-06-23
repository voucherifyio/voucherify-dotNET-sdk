using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.Exceptions
{
    [Serializable]
    public class VoucherifyClientException : Exception
    {
        public int Code { get; private set; }
        public string Details { get; private set; }

        public VoucherifyClientException()
        {
        }

        public VoucherifyClientException(int code, string message, string details)
            : base(message)
        {
            this.Code = code;
            this.Details = details;
        }

        public VoucherifyClientException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected VoucherifyClientException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override string ToString()
        {
            return string.Format("VoucherifyError[code={0}, message='{1}', details='{2}']", this.Code, this.Message, this.Details);
        }
    }
}
