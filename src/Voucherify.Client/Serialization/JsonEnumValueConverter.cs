﻿using System;
using Newtonsoft.Json;
using Voucherify.Client.Attributes;

namespace Voucherify.Client.Serialization
{
    public class JsonEnumValueConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) {
                return;
            }

            // Value as Enum
            Type objectType = value.GetType();
            Type enumType = Nullable.GetUnderlyingType(objectType) ?? objectType;
            object[] attributes = enumType.GetField(value.ToString()).GetCustomAttributes(typeof(JsonEnumValueAttribute), false);

            if (attributes.Length == 1)
            {
                writer.WriteValue(((JsonEnumValueAttribute)attributes[0]).Value);
                return;
            }

            writer.WriteValue(value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Type nullableType = Nullable.GetUnderlyingType(objectType);
            Type enumType = nullableType ?? objectType;
            string stringEnumValue = (string)reader.Value ?? string.Empty;

            foreach (object enumValue in Enum.GetValues(enumType)) {
                object[] attributes = enumType.GetField(enumValue.ToString()).GetCustomAttributes(typeof(JsonEnumValueAttribute), false);

                if (attributes.Length == 1 && ((JsonEnumValueAttribute)attributes[0]).Value.ToUpperInvariant() == stringEnumValue.ToUpperInvariant())
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
            return objectType.IsEnum || (nullableType != null && nullableType.IsEnum);
        }
    }
}