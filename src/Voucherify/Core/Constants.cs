namespace Voucherify.Core
{
    internal class Constants
    {
        /// <summary>
        /// Private constuctor to disallow creating instance of the object.
        /// </summary>
        private Constants() { }

#if VOUCHERIFYSERVER
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
        public const string HttpHeaderChannel = "X-Voucherify-Channel";
#endif

#if VOUCHERIFYCLIENT
        /// <summary>
        /// A HTTP header field used for Voucherify Client authentication.
        /// </summary>
        public const string HttpHeaderClintAppId = "X-Client-Application-Id";

        /// <summary>
        /// A HTTP header field used for Voucherify Client authentication.
        /// </summary>
        public const string HttpHeaderClientAppToken = "X-Client-Token";

        /// <summary>
        /// A HTTP header field used for Voucherify Client origin recognition.
        /// </summary>
        public const string HttpHeaderClientOrigin = "X-Voucherify-Channel";
#endif

        /// <summary>
        /// A HTTP header field name used for Voucherify channel recognition.
        /// </summary>
#if NET20
        public const string HttpHeaderChannelName = "dotNET-SDK-20";
#elif NET35 && UNITY
        public const string HttpHeaderChannelName = "dotNET-SDK-35-Unity";
#elif NET35
        public const string HttpHeaderChannelName = "dotNET-SDK-35";
#elif NET40
        public const string HttpHeaderChannelName = "dotNET-SDK-40";
#elif NET45 && PORTABLE
        public const string HttpHeaderChannelName = "dotNET-SDK-45-Portable";
#elif NET45
        public const string HttpHeaderChannelName = "dotNET-SDK-45";
#else
        public const string HttpHeaderChannelName = "dotNET-SDK";
#endif

        /// <summary>
        /// A default endpoint of Voucherify api.
        /// </summary>
#if VOUCHERIFYCLIENT
        public const string EndpointApi = "api.voucherify.io/client/v1";
#else
        public const string EndpointApi = "api.voucherify.io/v1";
#endif
    }
}
