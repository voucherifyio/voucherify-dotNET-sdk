using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Voucherify.Client
{
    public class SafeEnumConverter<T> : StringEnumConverter where T : struct
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException)
            {
                return null;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T?);
        }
    }
}
