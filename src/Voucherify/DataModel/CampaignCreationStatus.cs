#if VOUCHERIFYSERVER
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum CampaignCreationStatus
    {
        [JsonEnumValue(Value = "IN_PROGRESS")]
        InProgress,
        [JsonEnumValue(Value = "DONE")]
        Done,
        [JsonEnumValue(Value = "FAILED")]
        Failed
    }
}
#endif