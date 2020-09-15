using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ConsentGroup : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "consents")]
        public List<string> Consents { get; private set; }

        public ConsentGroup()
        {
            this.Consents = new List<string>();
        }

        public override string ToString()
        {
            return string.Format("ConsentGroup(Id={0},Name={1},Consents={2})", this.Id, this.Name, String.Join(",", this.Consents.ToArray()));
        }
    }
}
