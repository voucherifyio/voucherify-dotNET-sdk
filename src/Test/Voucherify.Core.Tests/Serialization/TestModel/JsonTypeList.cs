using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.Core.Tests.Serialization.TestModel
{
    [JsonObject]
    internal class JsonTypeList
    {
        [JsonProperty(PropertyName = "objects")]
        public List<JsonType> Objects { get; private set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; private set; }

        internal JsonTypeList()
        {
            this.Objects = new List<JsonType>();
        }

        public JsonTypeList(JsonType[] objects)
        {
            this.Objects = new List<JsonType>(objects);
            this.Total = this.Objects.Count;
        }

        public override string ToString()
        {
            return string.Format("Objectss[Entries={0}]", this.Total);
        }
    }
}
