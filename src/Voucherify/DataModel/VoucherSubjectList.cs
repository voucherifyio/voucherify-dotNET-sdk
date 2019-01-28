#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class VoucherSubjectList : ApiListObject
    {
        [JsonProperty(PropertyName = "data")]
        public List<VoucherSubject> Entries { get; private set; }

        public override string ToString()
        {
            return string.Format("VoucherSubjectList(Total={0})", this.Total);
        }
    }
}
#endif