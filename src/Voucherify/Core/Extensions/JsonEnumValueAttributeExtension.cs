using System;
using Newtonsoft.Json;
using Voucherify.Core.Attributes;


namespace Voucherify.Core.Extensions
{
    public static class JsonEnumValueAttributeExtension
    {
        public static string GetValue(Enum enumValue)
        {
            Type enumType = enumValue.GetType();

            object[] attributes = enumType.GetField(enumValue.ToString()).GetCustomAttributes(typeof(JsonEnumValueAttribute), false);

            if (attributes.Length == 1)
            {
                return (attributes[0] as JsonEnumValueAttribute).Value;
            }

            return string.Empty;
        }
    }
}
