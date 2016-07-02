using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Voucherify.Client.Serialization
{
    public class QuerySerializer<T>
        where T : class
    {
        public string Serialize(T payload)
        {
            Type payloadType = typeof(T);
            Type dataContractAttributeType = typeof(DataContractAttribute);
            PropertyInfo[] properties = payloadType.GetProperties();
            List<string> queryValues = new List<string>();

            if (!payloadType.IsDefined(dataContractAttributeType, true))
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
                    DataMemberAttribute dataMemberAttribute = (DataMemberAttribute)attribute;

                    if (dataMemberAttribute == null) { continue; }
                    
                    object propertyValue = property.GetValue(payload, null);
                    
                    if (propertyValue == null) { continue; }

                    if (typeof(string).IsAssignableFrom(property.PropertyType))
                    {
                        queryValues.Add(string.Format("{0}={1}", dataMemberAttribute.Name ?? property.Name, propertyValue.ToString()));
                        break; 
                    }

                    if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) || typeof(IEnumerable<>).IsAssignableFrom(property.PropertyType))
                    {
                        foreach (var singlePropertyvalue in (IEnumerable)propertyValue)
                        {
                            queryValues.Add(string.Format("{0}={1}", dataMemberAttribute.Name ?? property.Name, this.ConvertSingleValue(singlePropertyvalue.GetType(), singlePropertyvalue)));
                        }

                        break;
                    }

                    queryValues.Add(string.Format("{0}={1}", dataMemberAttribute.Name ?? property.Name, this.ConvertSingleValue(property.PropertyType, propertyValue)));
                }
            }

            return string.Join("&", queryValues.ToArray());
        }

        private string ConvertSingleValue(Type valueType, object value)
        {
            Type nullableType = Nullable.GetUnderlyingType(valueType);
            
            if (valueType.IsEnum || (nullableType != null && nullableType.IsEnum))
            {
                EnumMemberAttribute attribute = (nullableType ?? valueType)
                    .GetField(value.ToString())
                    .GetCustomAttributes(typeof(EnumMemberAttribute), false)
                    .SingleOrDefault() as EnumMemberAttribute;

                return attribute == null ? value.ToString() : attribute.Value;
            }

            return value.ToString();
        }
    }
}
