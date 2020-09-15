using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ConsentGroupList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<ConsentGroup> Data { get; private set; }

        [JsonConstructor]
        public ConsentGroupList()
        {
            this.Data = new List<ConsentGroup>();
        }

        public override string ToString()
        {
            return string.Format("ConsentGroupList(Total={0})", this.Total);
        }
    }
}