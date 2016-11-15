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
    }
}
