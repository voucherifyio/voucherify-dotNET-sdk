using Newtonsoft.Json;
using System.Collections.Generic;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class Metadata : Dictionary<string, object>
    {
        public Metadata()
        {

        }
        public Metadata(Dictionary<string, object> dictionary) : base(dictionary ?? new Dictionary<string, object>())
        {
        }
    }
}
