using System;

namespace Voucherify.Client.Attributes
{
    public class JsonEnumValueAttribute : Attribute
    {
        public string Value { get; set; }

        public JsonEnumValueAttribute() { }
    }
}
