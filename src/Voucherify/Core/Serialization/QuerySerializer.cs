using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Voucherify.Core.Attributes;

namespace Voucherify.Core.Serialization
{
    public class QuerySerializer<T>
        where T : class
    {
        public string Serialize(T payload)
        {
            Type payloadType = typeof(T);
            Type dataContractAttributeType = typeof(JsonObjectAttribute);
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
                var jsonPropertyAttributes = property.GetCustomAttributes(typeof(JsonPropertyAttribute), true);
                if (jsonPropertyAttributes == null || jsonPropertyAttributes.Length == 0) { continue; }
                JsonPropertyAttribute jsonPropertyAttribute = (JsonPropertyAttribute)jsonPropertyAttributes[0];
                object propertyValue = property.GetValue(payload, null);

                if (propertyValue == null) { continue; }

                queryValues.AddRange(this.ConvertProperty(jsonPropertyAttribute.PropertyName ?? property.Name, property.PropertyType, propertyValue));
            }

            return string.Join("&", queryValues.ToArray());
        }

        private string[] ConvertProperty(string propertyName, Type propertyType, object propertyValue)
        {
            Type enumType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;

            if (enumType.IsEnum)
            {
                object[] attributes = enumType.GetField(propertyValue.ToString()).GetCustomAttributes(typeof(JsonEnumValueAttribute), false);
                return new string[] {
                    string.Format("{0}={1}", propertyName, attributes.Length == 1 ? ((JsonEnumValueAttribute)attributes[0]).Value : propertyValue.ToString())
                };
            }

            if (typeof(string).IsAssignableFrom(propertyType))
            {
                return new string[] {
                    string.Format("{0}={1}", propertyName, propertyValue.ToString())
                };
            }

            if (typeof(Core.DataModel.Metadata).IsAssignableFrom(propertyType))
            {
                List<string> values = new List<string>();

                foreach (KeyValuePair<string, object> entry in (Core.DataModel.Metadata)propertyValue)
                {
                    values.Add(string.Format("{0}={1}", string.Format("{0}[{1}]", propertyName, entry.Key), entry.Value.ToString()));
                }

                return values.ToArray();
            }

            if (typeof(IEnumerable).IsAssignableFrom(propertyType) || typeof(IEnumerable<>).IsAssignableFrom(propertyType))
            {
                var index = 0;
                List<string> values = new List<string>();
                
                foreach (var childPropertyValue in (IEnumerable)propertyValue)
                {
                    string childpropertyName = childPropertyValue.GetType().GetCustomAttributes(typeof(JsonObjectAttribute), true).Length > 0 ?
                        string.Format("{0}[{1}]", propertyName, index) : propertyName;
                    values.AddRange(this.ConvertProperty(childpropertyName, childPropertyValue.GetType(), childPropertyValue));
                    index++;
                }

                return values.ToArray();
            }

            if (propertyType.GetCustomAttributes(typeof(JsonObjectAttribute), true).Length > 0)
            {
                PropertyInfo[] properties = propertyType.GetProperties();
                List<string> values = new List<string>();

                foreach (PropertyInfo property in properties)
                {
                    var jsonPropertyAttributes = property.GetCustomAttributes(typeof(JsonPropertyAttribute), true);
                    if (jsonPropertyAttributes == null || jsonPropertyAttributes.Length == 0) { continue; }
                    JsonPropertyAttribute jsonPropertyAttribute = (JsonPropertyAttribute)jsonPropertyAttributes[0];
                    object chilPropertyValue = property.GetValue(propertyValue, null);

                    if (chilPropertyValue == null) { continue; }

                    values.AddRange(this.ConvertProperty(string.Format("{0}[{1}]", propertyName, jsonPropertyAttribute.PropertyName ?? property.Name), property.PropertyType, chilPropertyValue));
                }

                return values.ToArray();
            }

            return new string[] {
                string.Format("{0}={1}", propertyName, propertyValue.ToString())
            };
        }
    }
}
