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

        [JsonProperty(PropertyName = "discount_amount_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmountLimit { get; private set; }

        public Discount() { }

        public override string ToString()
        {
            return string.Format("Discount(Type={0})", this.Type);
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
            this.AmountLimit = null;
            return this;
        }

        public Discount WithPercentOff(double percentOff)
        {
            return this.WithPercentOff(percentOff, null);
        }

        public Discount WithPercentOff(double percentOff, int? amountLimit)
        {
            this.Type = DiscountType.Percent;
            this.AmountOff = null;
            this.UnitOff = null;
            this.UnitType = null;
            this.PercentOff = percentOff;
            this.AmountLimit = amountLimit;
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
            this.AmountLimit = null;
            return this;
        }
    }
}
#endif