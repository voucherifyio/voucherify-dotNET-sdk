using System;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class Discount
    {
        [DataMember(Name = "type")]
        public DiscountType Type { get; set; }

        [DataMember(Name = "amount_off")]
        public int? AmountOff { get; set; }

        [DataMember(Name = "percent_off")]
        public double? PercentOff { get; set; }

        [DataMember(Name = "unit_off")]
        public double? UnitOff { get; set; }

        [DataMember(Name = "unit_type")]
        public string UnitType { get; set; }

        private Discount() { }

        public static Discount From(DiscountType type, int value)
        {
            Discount discount = new Discount() { Type = type };

            switch(type)
            {
                case DiscountType.Amount:
                    discount.UnitOff = value;
                    break;
                case DiscountType.Percent:
                    discount.PercentOff = value / 100.0;
                    break;
                case DiscountType.Unit:
                    discount.UnitOff = value / 100.0;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type", "Unsupported discount type: " + type);
            }

            return discount;
        }

        public static Discount WithAmountOff(int amountOff)
        {
            return new Discount() { Type = DiscountType.Amount, AmountOff = amountOff };
        }

        public static Discount WithPercentOff(double percentOff)
        {
            return new Discount() { Type = DiscountType.Amount, PercentOff = percentOff };
        }

        public static Discount WithUnitOff(double unitOff)
        {
            return Discount.WithUnitOff(unitOff, string.Empty);
        }
        public static Discount WithUnitOff(double unitOff, string unitType)
        {
            return new Discount() { Type = DiscountType.Unit, UnitOff = unitOff, UnitType = unitType };
        }
    }
}
