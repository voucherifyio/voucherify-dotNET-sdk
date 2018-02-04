#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CodeConfig : ApiObject
    {
        [JsonProperty(PropertyName = "length")]
        public int? Length { get; private set; }

        [JsonProperty(PropertyName = "charset")]
        public string Charset { get; private set; }

        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; private set; }

        [JsonProperty(PropertyName = "postfix")]
        public string Postfix { get; private set; }

        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; private set; }

        public CodeConfig()
        {
        }

        public override string ToString()
        {
            return string.Format("CodeConfig(Pattern={0})", this.Pattern);
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

        public CodeConfig WithLength(int length)
        {
            this.Length = length;
            return this;
        }

        public CodeConfig WithCharset(string charset)
        {
            this.Charset = charset;
            return this;
        }

        public CodeConfig WithPrefix(string prefix)
        {
            this.Prefix = prefix;
            return this;
        }

        public CodeConfig WithPostfix(string postfix)
        {
            this.Postfix = postfix;
            return this;
        }

        public CodeConfig WithPattern(string pattern)
        {
            this.Pattern = pattern;
            return this;
        }
    }
}
#endif