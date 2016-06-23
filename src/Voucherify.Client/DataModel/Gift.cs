using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class Gift
    {
        [DataMember(Name = "amount")]
        public int Amount { get; private set; }

        private Gift() { }

        public static Gift WithAmount(int amount)
        {
            return new Gift
            {
                Amount = amount
            };
        }
    }
}