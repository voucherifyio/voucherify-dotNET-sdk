using Newtonsoft.Json;
using System.Collections.Generic;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class Metadata : Dictionary<string, object>
    {
        [JsonConstructor]
        public Metadata()
        {

        }

        public Metadata(Dictionary<string, object> dictionary) : base(dictionary ?? new Dictionary<string, object>())
        {
        }

        public override string ToString()
        {
            return string.Format("Object(Type=Metadata,Count={0})", this.Count);
        }
    }
}
