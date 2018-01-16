using Newtonsoft.Json;

namespace Voucherify.Core.Tests.Attributes.TestModel
{
    [JsonObject]
    internal class JsonTypeWithEnum
    {
        [JsonProperty(PropertyName = "enum_test")]
        public EnumType? Enum { get; set; }
    }
}
