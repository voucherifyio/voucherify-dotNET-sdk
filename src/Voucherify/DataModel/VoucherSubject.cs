#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;


namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherSubject
    {
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "price")]
        public long? Price { get; set; }

        public override string ToString()
        {
            return string.Format("VoucherSubject(Object={0},Id={1},SourceId={2})", this.Object, this.Id, this.SourceId);
        }
    }
}
#endif