using Newtonsoft.Json;

namespace Voucherify.Core.DataModel
{
    [JsonObject]
    public class ApiObjectWithId : ApiObject
    {
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; internal set; }

        public override string ToString()
        {
            return string.Format("{0}(Id={1})", string.IsNullOrEmpty(this.Object) ? "object" : this.Object, this.Id);
        }
    }
}
