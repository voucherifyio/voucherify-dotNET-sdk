using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public enum DiscountType
    {
        [EnumMember(Value = "Amount")]
        Amount,
        [EnumMember(Value = "Percent")]
        Percent,
        [EnumMember(Value = "Unit")]
        Unit
    }
}
