using System;

namespace Voucherify.Core.Attributes
{
    public class JsonEnumValueAttribute : Attribute
    {
        public string Value { get; set; }

        public JsonEnumValueAttribute() { }
    }
}
