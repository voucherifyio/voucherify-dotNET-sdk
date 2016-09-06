using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Voucherify.Client.Attributes;

namespace Voucherify.Client.Serialization
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
            JsonEnumValueAttribute[] attributes = enumType.GetTypeInfo().GetDeclaredField(value.ToString()).GetCustomAttributes<JsonEnumValueAttribute>(false).ToArray();

            if (attributes.Length == 1)
            {
                writer.WriteValue(attributes[0].Value);
                return;
            }

            writer.WriteValue(value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Type nullableType = Nullable.GetUnderlyingType(objectType);
            Type enumType = nullableType ?? objectType;
            string stringEnumValue = (string)reader.Value;

            foreach (object enumValue in Enum.GetValues(enumType))
            {
                JsonEnumValueAttribute[] attributes = enumType.GetTypeInfo().GetDeclaredField(enumValue.ToString()).GetCustomAttributes<JsonEnumValueAttribute>(false).ToArray();

                if (attributes.Length == 1 && attributes[0].Value == stringEnumValue)
                {
                    return enumValue;
                }
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
            return objectType.GetTypeInfo().IsEnum || (nullableType != null && nullableType.GetTypeInfo().IsEnum);
        }
    }
}