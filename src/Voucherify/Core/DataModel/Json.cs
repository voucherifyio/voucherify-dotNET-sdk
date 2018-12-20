using Newtonsoft.Json;
using System.Collections.Generic;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class Json : Dictionary<string, object>
    {
        [JsonConstructor]
        public Json()
        {

        }

        public Json(Dictionary<string, object> dictionary) : base(dictionary ?? new Dictionary<string, object>())
        {
        }

        public override string ToString()
        {
            return string.Format("Object(Type=Json,Count={0})", this.Count);
        }
    }
}
