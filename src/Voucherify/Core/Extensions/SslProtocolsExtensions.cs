namespace System.Security.Authentication
{
    public static class SslProtocolsExtensions
    {
#if !PORTABLE
        public const SslProtocols Tls12 = (SslProtocols)0x00000C00;
        public const SslProtocols Tls11 = (SslProtocols)0x00000300;
#endif
    }
}