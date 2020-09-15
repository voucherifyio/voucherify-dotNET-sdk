using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ConsentAndGroupList : ApiObject
    {
        [JsonProperty(PropertyName = "consents")]
        public ConsentList Consents { get; private set; }

        [JsonProperty(PropertyName = "groups")]
        public ConsentGroupList Groups { get; private set; }

        public ConsentAndGroupList()
        {
        }

        public override string ToString()
        {
            return string.Format("ConsentAndGroupList(Consents={0},Groups={1})", this.Consents, this.Groups);
        }
    }
}
