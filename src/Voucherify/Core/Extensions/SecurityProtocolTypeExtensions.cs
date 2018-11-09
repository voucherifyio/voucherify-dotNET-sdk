using System.Net;
using System.Security.Authentication;

namespace System.Net
{
    public static class SecurityProtocolTypeExtensions
    {
#if !PORTABLE
        public const SecurityProtocolType Tls12 = (SecurityProtocolType)SslProtocolsExtensions.Tls12;
#else
        public const SecurityProtocolType Tls12 = SecurityProtocolType.Tls12;
#endif
#if !PORTABLE
        public const SecurityProtocolType Tls11 = (SecurityProtocolType)SslProtocolsExtensions.Tls11;
#else
        public const SecurityProtocolType Tls11 = SecurityProtocolType.Tls11;
#endif
        public const SecurityProtocolType SystemDefault = (SecurityProtocolType)0;
    }
}