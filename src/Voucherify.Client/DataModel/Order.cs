using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class Order
    {
        [DataMember(Name = "amount")]
        public int Amount { get; private set; }

        private Order() { }

        public static Order WithAmount(int amount)
        {
            return new Order
            {
                Amount = amount
            };
        }
    }
}