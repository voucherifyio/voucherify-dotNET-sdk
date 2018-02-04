#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class RelatedObject : ApiObjectWithId
    {
        public override string ToString()
        {
            return string.Format("RelatedObject(Type={0},Id={1})", this.Id, this.Object, this.Id);
        }
    }
}
#endif