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
            return string.Format("CodeConfig[Length={0},Charset={1},Prefix={2},Postfix={3},Pattern={4}]",
                this.Length,
                this.Charset,
                this.Prefix,
                this.Postfix,
                this.Pattern);
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

        public CodeConfig WithPatter(string pattern)
        {
            this.Pattern = pattern;
            return this;
        }
    }
}
#endif