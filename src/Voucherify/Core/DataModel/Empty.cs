using Newtonsoft.Json;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class Empty
    {
        public override string ToString()
        {
            return "Empty";
        }
    }
}
