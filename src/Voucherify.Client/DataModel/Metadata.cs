using Newtonsoft.Json;
using System.Collections.Generic;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class Metadata : Dictionary<string, object>
    {
    }
}
