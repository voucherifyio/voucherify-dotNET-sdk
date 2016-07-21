using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class CodeConfig
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
