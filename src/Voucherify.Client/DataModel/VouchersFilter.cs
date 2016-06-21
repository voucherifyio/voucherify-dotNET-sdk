using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class VouchersFilter
    {
        [DataMember(Name = "limit")]
        public int? Limit { get; set; }

        [DataMember(Name = "code_query")]
        public string CodeQuery { get; set; }

        [DataMember(Name = "page")]
        public int? Page { get; set; }

        [DataMember(Name = "skip")]
        public int? Skip { get; set; }

        [DataMember(Name = "campaign")]
        public string Campaign { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "customer")]
        public string Customer { get; set; }
    }
}
