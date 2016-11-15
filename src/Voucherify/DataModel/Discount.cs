#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Discount : ApiObject
    {
        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public DiscountType Type { get; private set; }

        [JsonProperty(PropertyName = "amount_off", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmountOff { get; private set; }

        [JsonProperty(PropertyName = "percent_off", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentOff { get; private set; }

        [JsonProperty(PropertyName = "unit_off", NullValueHandling = NullValueHandling.Ignore)]
        public double? UnitOff { get; private set; }

        [JsonProperty(PropertyName = "unit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitType { get; private set; }

        public Discount() { }

        public override string ToString()
        {
            return string.Format("Discount[Type={0},AmountOff={1},PercentOff={2},UnitOff={3},UnitType={4}]",
                this.Type,
                this.AmountOff,
                this.PercentOff,
                this.UnitOff,
                this.UnitType);
        }

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

        public Discount WithAmountOff(int amountOff)
        {
            this.Type = DiscountType.Amount;
            this.AmountOff = amountOff;
            this.UnitOff = null;
            this.UnitType = null;
            this.PercentOff = null;
            return this;
        }

        public Discount WithPercentOff(double percentOff)
        {
            this.Type = DiscountType.Percent;
            this.AmountOff = null;
            this.UnitOff = null;
            this.UnitType = null;
            this.PercentOff = percentOff;
            return this;
        }

        public Discount WithUnitOff(double unitOff)
        {
            return this.WithUnitOff(unitOff, string.Empty);
        }

        public Discount WithUnitOff(double unitOff, string unitType)
        {
            this.Type = DiscountType.Amount;
            this.AmountOff = null;
            this.UnitOff = unitOff / 100.0;
            this.UnitType = unitType;
            this.PercentOff = null;
            return this;
        }
    }
}
#endif