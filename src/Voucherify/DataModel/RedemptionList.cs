#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RedemptionList : ApiListObject
    {
        [JsonProperty(PropertyName = "redemptions")]
        public List<Redemption> Redemptions { get; private set; }

        private RedemptionList()
        {
            this.Redemptions = new List<Redemption>();
        }

        public override string ToString()
        {
            return string.Format("RedemptionList[Entries={0}]", this.Total);
        }
    }
}
#endif