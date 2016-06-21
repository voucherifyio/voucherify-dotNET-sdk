using System;
using Voucherify.Client.Serialization;

namespace Voucherify.Client.Extensions
{
    public static class UriBuilderExtension
    {
        public static UriBuilder WithQuery<TPayload>(this UriBuilder builder, TPayload payload)
                where TPayload : class
        {
            QuerySerializer<TPayload> serializerFilter = new QuerySerializer<TPayload>();
            builder.Query = serializerFilter.Serialize(payload);
            return builder;
        }
    }
}
