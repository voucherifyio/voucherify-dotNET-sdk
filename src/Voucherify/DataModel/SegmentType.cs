#if VOUCHERIFYSERVER
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum SegmentType
    {
        [JsonEnumValue(Value = "static")]
        Static,
        [JsonEnumValue(Value = "auto-update")]
        AutoUpdate
    }
}
#endif