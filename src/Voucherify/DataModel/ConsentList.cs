using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ConsentList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<Consent> Data { get; private set; }

        [JsonConstructor]
        public ConsentList()
        {
            this.Data = new List<Consent>();
        }

        public override string ToString()
        {
            return string.Format("ConsentList(Total={0})", this.Total);
        }
    }
}
