using System.Net;
using System.Security.Authentication;

namespace System.Net
{
    public static class SecurityProtocolTypeExtensions
    {
#if !PORTABLE
        public const System.Net.SecurityProtocolType Tls12 = (System.Net.SecurityProtocolType)SslProtocolsExtensions.Tls12;
#else
        public const System.Net.SecurityProtocolType Tls12 = System.Net.SecurityProtocolType.Tls12;
#endif
#if !PORTABLE
        public const System.Net.SecurityProtocolType Tls11 = (System.Net.SecurityProtocolType)SslProtocolsExtensions.Tls11;
#else
        public const System.Net.SecurityProtocolType Tls11 = System.Net.SecurityProtocolType.Tls11;
#endif
        public const System.Net.SecurityProtocolType SystemDefault = (System.Net.SecurityProtocolType)0;
    }
}