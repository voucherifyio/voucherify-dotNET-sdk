#if PORTABLE
using System;
using System.Linq;
using System.Reflection;
using Voucherify.Core.Attributes;
#else
using System;
using Newtonsoft.Json;
using Voucherify.Core.Attributes;
#endif

namespace Voucherify.Core.Extensions
{
    public static class JsonEnumValueAttributeExtension
    {
        public static string GetValue(Enum enumValue)
        {
            Type enumType = enumValue.GetType();

#if PORTABLE
            JsonEnumValueAttribute[] attributes = enumType.GetTypeInfo().GetDeclaredField(enumValue.ToString()).GetCustomAttributes<JsonEnumValueAttribute>(false).ToArray();

            if (attributes.Length == 1)
            {
                return attributes[0].Value;
            }
#else
            object[] attributes = enumType.GetField(enumValue.ToString()).GetCustomAttributes(typeof(JsonEnumValueAttribute), false);

            if (attributes.Length == 1)
            {
                return (attributes[0] as JsonEnumValueAttribute).Value;
            }
#endif
            return string.Empty;
        }
    }
}
