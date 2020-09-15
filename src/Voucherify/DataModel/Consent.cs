using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Consent: ApiObjectWithId
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; private set; }

        public override string ToString()
        {
            return string.Format("Consent(Id={0},Name={1})", this.Id, this.Name);
        }
    }
}
