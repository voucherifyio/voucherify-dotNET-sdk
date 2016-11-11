#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CodeConfig : ApiObject
    {
        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        [JsonProperty(PropertyName = "charset")]
        public string Charset { get; set; }

        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        [JsonProperty(PropertyName = "postfix")]
        public string Postfix { get; set; }

        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        public CodeConfig()
        {
        }

        public static CodeConfig WithAlphabeticCharset()
        {
            return new CodeConfig()
            {
                Charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            };
        }

        public static CodeConfig WithAlphanumericCharset()
        {
            return new CodeConfig()
            {
                Charset = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
            };
        }

        public static CodeConfig WithNumbersCharset()
        {
            return new CodeConfig()
            {
                Charset = "0123456789"
            };
        }
    }
}
#endif