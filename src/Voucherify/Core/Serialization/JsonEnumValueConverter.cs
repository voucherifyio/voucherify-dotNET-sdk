#if PORTABLE
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Voucherify.Core.Attributes;
#else
using System;
using Newtonsoft.Json;
using Voucherify.Core.Attributes;
#endif


namespace Voucherify.Core.Serialization
{
    public class JsonEnumValueConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            // Value as Enum
            Type objectType = value.GetType();
            Type enumType = Nullable.GetUnderlyingType(objectType) ?? objectType;
#if PORTABLE
            JsonEnumValueAttribute[] attributes = enumType.GetTypeInfo().GetDeclaredField(value.ToString()).GetCustomAttributes<JsonEnumValueAttribute>(false).ToArray();

            if (attributes.Length == 1)
            {
                writer.WriteValue(attributes[0].Value);
                return;
            }
#else
            object[] attributes = enumType.GetField(value.ToString()).GetCustomAttributes(typeof(JsonEnumValueAttribute), false);

            if (attributes.Length == 1)
            {
                writer.WriteValue(((JsonEnumValueAttribute)attributes[0]).Value);
                return;
            }
#endif

            writer.WriteValue(value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Type nullableType = Nullable.GetUnderlyingType(objectType);
            Type enumType = nullableType ?? objectType;
            string stringEnumValue = (string)reader.Value ?? string.Empty;

            foreach (object enumValue in Enum.GetValues(enumType))
            {
#if PORTABLE
                JsonEnumValueAttribute[] attributes = enumType.GetTypeInfo().GetDeclaredField(enumValue.ToString()).GetCustomAttributes<JsonEnumValueAttribute>(false).ToArray();

                if (attributes.Length == 1 && attributes[0].Value.ToUpperInvariant() == stringEnumValue.ToUpperInvariant())
                {
                    return enumValue;
                }
#else
                object[] attributes = enumType.GetField(enumValue.ToString()).GetCustomAttributes(typeof(JsonEnumValueAttribute), false);

                if (attributes.Length == 1 && ((JsonEnumValueAttribute)attributes[0]).Value.ToUpperInvariant() == stringEnumValue.ToUpperInvariant())
                {
                    return enumValue;
                }
#endif
            }

            try
            {
                return Enum.Parse(enumType, stringEnumValue);
            }
            catch (ArgumentException) { }

            if (nullableType != null)
            {
                return null;
            }

            return 0;
        }

        public override bool CanConvert(Type objectType)
        {
            Type nullableType = Nullable.GetUnderlyingType(objectType);
#if PORTABLE
            return objectType.GetTypeInfo().IsEnum || (nullableType != null && nullableType.GetTypeInfo().IsEnum);
#else
            return objectType.IsEnum || (nullableType != null && nullableType.IsEnum);
#endif
        }
    }
}