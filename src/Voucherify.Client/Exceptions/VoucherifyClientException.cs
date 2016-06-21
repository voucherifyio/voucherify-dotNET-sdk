using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.Exceptions
{
    [Serializable]
    public class VoucherifyClientException : Exception
    {
        public VoucherifyClientException()
        {
        }

        public VoucherifyClientException(string message)
            : base(message)
        {
        }

        public VoucherifyClientException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected VoucherifyClientException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
