using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voucherify.Client
{
    public class Constants
    {
        private Constants() { }

        // HTTP constants
        public const string HttpHeaderAppId = "X-App-Id";
        public const string HttpHeaderAppToken = "X-App-Token";
        public const string HttpHeaderVoucherifyChannel = "X-Voucherify-Channel";
        public const string VoucherifyChannelName = "dotNET-SDK";

        // Configuration
        public const string EndpointApi = "api.voucherify.io/v1";
        public const string EndpointDateFormat = "yyyy-MM-dd'T'HH:mm:ssXXX";
        public const string EndpointSecondaryDateFormat ="yyyy-MM-dd'T'HH:mm:ss.SSSXXX";
    }
}
