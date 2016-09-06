using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Voucherify.Client.Attributes;

namespace Voucherify.Client.Serialization
{
    public class QuerySerializer<T>
        where T : class
    {
        public string Serialize(T payload)
        {
            Type payloadType = typeof(T);
            Type dataContractAttributeType = typeof(JsonObjectAttribute);
            PropertyInfo[] properties = payloadType.GetTypeInfo().DeclaredProperties.ToArray();
            List<string> queryValues = new List<string>();

            if (!payloadType.GetTypeInfo().IsDefined(dataContractAttributeType, true))
            {
                throw new ArgumentException(string.Format("Payload type {0} must define {0} attribute", payloadType.Name, dataContractAttributeType.Name), "payload");
            }

            if (payload == null)
            {
                return string.Empty;
            }

            foreach (PropertyInfo property in properties)
            {
                var attributes = property.GetCustomAttributes(true);

                foreach (object attribute in attributes)
                {
                    JsonPropertyAttribute dataMemberAttribute = (JsonPropertyAttribute)attribute;

                    if (dataMemberAttribute == null) { continue; }

                    object propertyValue = property.GetValue(payload, null);

                    if (propertyValue == null) { continue; }

                    if (typeof(string).GetTypeInfo().IsAssignableFrom(property.PropertyType.GetTypeInfo()))
                    {
                        queryValues.Add(string.Format("{0}={1}", dataMemberAttribute.PropertyName ?? property.Name, propertyValue.ToString()));
                        break;
                    }

                    if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(property.PropertyType.GetTypeInfo()) 
                        || typeof(IEnumerable<>).GetTypeInfo().IsAssignableFrom(property.PropertyType.GetTypeInfo()))
                    {
                        foreach (var singlePropertyvalue in (IEnumerable)propertyValue)
                        {
                            queryValues.Add(string.Format("{0}={1}", dataMemberAttribute.PropertyName ?? property.Name, this.ConvertSingleValue(singlePropertyvalue.GetType(), singlePropertyvalue)));
                        }

                        break;
                    }

                    queryValues.Add(string.Format("{0}={1}", dataMemberAttribute.PropertyName ?? property.Name, this.ConvertSingleValue(property.PropertyType, propertyValue)));
                }
            }

            return string.Join("&", queryValues.ToArray());
        }

        private string ConvertSingleValue(Type valueType, object value)
        {
            Type enumType = Nullable.GetUnderlyingType(valueType) ?? valueType;

            if (enumType.GetTypeInfo().IsEnum)
            {
                JsonEnumValueAttribute[] attributes = enumType.GetTypeInfo().GetDeclaredField(value.ToString()).GetCustomAttributes<JsonEnumValueAttribute>(false).ToArray();
                return (attributes.Length == 1 ? attributes[0].Value : value.ToString());
            }

            return value.ToString();
        }
    }
}
