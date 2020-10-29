using System;
using Voucherify.Core.Serialization;

namespace Voucherify.Core.Extensions
{
    public static class UriBuilderExtension
    {
        public static UriBuilder WithQuery<TPayload>(UriBuilder builder, TPayload payload)
                where TPayload : class
        {
            QuerySerializer<TPayload> serializerFilter = new QuerySerializer<TPayload>();
            builder.Query = serializerFilter.Serialize(payload);
            return builder;
        }

        public static String EnsureEscapedDataString(String paramName, String paramValue)
        {
            if (string.IsNullOrEmpty(paramValue))
            {
                throw new ArgumentNullException(String.Format("Missing required '{0}' parameter", paramName));
            }

            return Uri.EscapeDataString(paramValue);
        }
    }
}
