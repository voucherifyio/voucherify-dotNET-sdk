#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    public class BusinessValidationRule : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rules")]
        public Json Rules { get; set; }

        public BusinessValidationRule()
        {
            this.Rules = new Json();
        }
    }
}
#endif
