namespace Voucherify.Client
{
    /// <summary>
    /// Definition of constants members used within Voucherfy Client Library.
    /// </summary>
    internal class Constants
    {
        /// <summary>
        /// Private constuctor to disallow creating instance of the object.
        /// </summary>
        private Constants() { }

        /// <summary>
        /// A HTTP header field used for Voucherify authentication.
        /// </summary>
        public const string HttpHeaderAppId = "X-App-Id";
        /// <summary>
        /// A HTTP header field used for Voucherify authentication.
        /// </summary>
        public const string HttpHeaderAppToken = "X-App-Token";
        /// <summary>
        /// A HTTP header field used for Voucherify channel recognition.
        /// </summary>
        public const string HttpHeaderVoucherifyChannel = "X-Voucherify-Channel";
        /// <summary>
        /// A HTTP header field name used for Voucherify channel recognition.
        /// </summary>
        public const string VoucherifyChannelName = "dotNET-SDK";
        /// <summary>
        /// A default endpoint of Voucherify api.
        /// </summary>
        public const string EndpointApi = "api.voucherify.io/v1";
    }
}
