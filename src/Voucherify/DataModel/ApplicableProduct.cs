#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ApplicableProduct : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; private set; }

        public override string ToString()
        {
            return string.Format("ApplicableProduct(Id={0},SourceId={1})", this.Id, this.SourceId);
        }
    }
}
#endif