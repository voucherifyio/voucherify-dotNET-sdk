
using System;
using System.Collections.Generic;
#if PORTABLE
using System.Reflection;
#endif
using Newtonsoft.Json;
using Voucherify.Core;


namespace Voucherify.Core.Serialization
{
    public class ObjectListFromArrayConverter<T, TList> : JsonConverter
        where T : class
        where TList : class
    {
        private readonly ApiVersion currentApiVersion;
        private readonly ApiVersion changeApiVersion;

        public ObjectListFromArrayConverter(ApiVersion currentApiVersion, ApiVersion changeApiVersion) : base()
        {
            this.currentApiVersion = currentApiVersion;
            this.changeApiVersion = changeApiVersion;
        }

        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(TList));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (this.currentApiVersion == ApiVersion.Default)
            {
                if (reader.TokenType == JsonToken.StartArray)
                {
                    return DeserializeArray(reader, objectType, serializer);
                }

                return DeserializeList(reader, serializer);
            }

            if (this.currentApiVersion >= this.changeApiVersion)
            {
                return DeserializeList(reader, serializer);
            }
            else
            {
                return DeserializeArray(reader, objectType, serializer);
            }
        }

        private object DeserializeList(JsonReader reader, JsonSerializer serializer)
        {
            List<JsonConverter> converters = new List<JsonConverter>();

            foreach (JsonConverter converter in serializer.Converters)
            {
                if (converter is ObjectListFromArrayConverter<T, TList>)
                {
                    continue;
                }

                converters.Add(converter);
            }

            JsonSerializer targetSerializer = JsonSerializer.Create(new JsonSerializerSettings()
            {
                Formatting = serializer.Formatting,
                ContractResolver = serializer.ContractResolver,
                DateFormatString = serializer.DateFormatString,
                Converters = converters
            });

            return targetSerializer.Deserialize<TList>(reader);
        }

        private object DeserializeArray(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
#if PORTABLE
            foreach (ConstructorInfo constructor in objectType.GetTypeInfo().DeclaredConstructors)
            {
                ParameterInfo[] parameters = constructor.GetParameters();

                if (parameters.Length != 1)
                {
                    continue;
                }

                if (parameters[0].ParameterType == typeof(T))
                {
                    return constructor.Invoke(new object[] { new object[] { serializer.Deserialize<T[]>(reader) } });
                }
            }

            return null;
#else
            return objectType.GetConstructor(new[] { typeof(T[]) }).Invoke(new object[] { serializer.Deserialize<T[]>(reader) });
#endif
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }
    }
}
