/*
 * Voucherify API
 *
 * Voucherify promotion engine REST API. Please see https://docs.voucherify.io/docs for more details.
 *
 * The version of the OpenAPI document: v2018-08-01
 * Contact: support@voucherify.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Voucherify.Client.OpenAPIDateConverter;

namespace Voucherify.Model
{
    /// <summary>
    /// ExportsCreateRequestBodyParameters
    /// </summary>
    [DataContract(Name = "ExportsCreateRequestBodyParameters")]
    public partial class ExportsCreateRequestBodyParameters : IValidatableObject
    {
        /// <summary>
        /// Defines Order
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            /// <summary>
            /// Enum CreatedAt for value: -created_at
            /// </summary>
            [EnumMember(Value = "-created_at")]
            CreatedAt = 1,

            /// <summary>
            /// Enum CreatedAt2 for value: created_at
            /// </summary>
            [EnumMember(Value = "created_at")]
            CreatedAt2 = 2,

            /// <summary>
            /// Enum UpdatedAt for value: -updated_at
            /// </summary>
            [EnumMember(Value = "-updated_at")]
            UpdatedAt = 3,

            /// <summary>
            /// Enum UpdatedAt2 for value: updated_at
            /// </summary>
            [EnumMember(Value = "updated_at")]
            UpdatedAt2 = 4,

            /// <summary>
            /// Enum Code for value: -code
            /// </summary>
            [EnumMember(Value = "-code")]
            Code = 5,

            /// <summary>
            /// Enum Code2 for value: code
            /// </summary>
            [EnumMember(Value = "code")]
            Code2 = 6,

            /// <summary>
            /// Enum Id for value: -id
            /// </summary>
            [EnumMember(Value = "-id")]
            Id = 7,

            /// <summary>
            /// Enum Id2 for value: id
            /// </summary>
            [EnumMember(Value = "id")]
            Id2 = 8,

            /// <summary>
            /// Enum VoucherCode for value: -voucher_code
            /// </summary>
            [EnumMember(Value = "-voucher_code")]
            VoucherCode = 9,

            /// <summary>
            /// Enum VoucherCode2 for value: voucher_code
            /// </summary>
            [EnumMember(Value = "voucher_code")]
            VoucherCode2 = 10,

            /// <summary>
            /// Enum TrackingId for value: -tracking_id
            /// </summary>
            [EnumMember(Value = "-tracking_id")]
            TrackingId = 11,

            /// <summary>
            /// Enum TrackingId2 for value: tracking_id
            /// </summary>
            [EnumMember(Value = "tracking_id")]
            TrackingId2 = 12,

            /// <summary>
            /// Enum CustomerId for value: -customer_id
            /// </summary>
            [EnumMember(Value = "-customer_id")]
            CustomerId = 13,

            /// <summary>
            /// Enum CustomerId2 for value: customer_id
            /// </summary>
            [EnumMember(Value = "customer_id")]
            CustomerId2 = 14,

            /// <summary>
            /// Enum Name for value: -name
            /// </summary>
            [EnumMember(Value = "-name")]
            Name = 15,

            /// <summary>
            /// Enum Name2 for value: name
            /// </summary>
            [EnumMember(Value = "name")]
            Name2 = 16,

            /// <summary>
            /// Enum Email for value: -email
            /// </summary>
            [EnumMember(Value = "-email")]
            Email = 17,

            /// <summary>
            /// Enum Email2 for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email2 = 18,

            /// <summary>
            /// Enum SourceId for value: -source_id
            /// </summary>
            [EnumMember(Value = "-source_id")]
            SourceId = 19,

            /// <summary>
            /// Enum SourceId2 for value: source_id
            /// </summary>
            [EnumMember(Value = "source_id")]
            SourceId2 = 20,

            /// <summary>
            /// Enum Channel for value: -channel
            /// </summary>
            [EnumMember(Value = "-channel")]
            Channel = 21,

            /// <summary>
            /// Enum Channel2 for value: channel
            /// </summary>
            [EnumMember(Value = "channel")]
            Channel2 = 22,

            /// <summary>
            /// Enum Status for value: -status
            /// </summary>
            [EnumMember(Value = "-status")]
            Status = 23,

            /// <summary>
            /// Enum Status2 for value: status
            /// </summary>
            [EnumMember(Value = "status")]
            Status2 = 24,

            /// <summary>
            /// Enum ExpiresAt for value: -expires_at
            /// </summary>
            [EnumMember(Value = "-expires_at")]
            ExpiresAt = 25,

            /// <summary>
            /// Enum ExpiresAt2 for value: expires_at
            /// </summary>
            [EnumMember(Value = "expires_at")]
            ExpiresAt2 = 26
        }


        /// <summary>
        /// Gets or Sets Order
        /// </summary>

        [DataMember(Name = "order", EmitDefaultValue = true)]
        public OrderEnum? Order
        {
            get{ return _Order;}
            set
            {
                _Order = value;
                _flagOrder = true;
            }
        }
        private OrderEnum? _Order;
        private bool _flagOrder;

        /// <summary>
        /// Returns false as Order should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrder()
        {
            return _flagOrder;
        }
        /// <summary>
        /// Defines Fields
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldsEnum
        {
            /// <summary>
            /// Enum Code for value: code
            /// </summary>
            [EnumMember(Value = "code")]
            Code = 1,

            /// <summary>
            /// Enum VoucherType for value: voucher_type
            /// </summary>
            [EnumMember(Value = "voucher_type")]
            VoucherType = 2,

            /// <summary>
            /// Enum Value for value: value
            /// </summary>
            [EnumMember(Value = "value")]
            Value = 3,

            /// <summary>
            /// Enum Formula for value: formula
            /// </summary>
            [EnumMember(Value = "formula")]
            Formula = 4,

            /// <summary>
            /// Enum DiscountType for value: discount_type
            /// </summary>
            [EnumMember(Value = "discount_type")]
            DiscountType = 5,

            /// <summary>
            /// Enum Campaign for value: campaign
            /// </summary>
            [EnumMember(Value = "campaign")]
            Campaign = 6,

            /// <summary>
            /// Enum Category for value: category
            /// </summary>
            [EnumMember(Value = "category")]
            Category = 7,

            /// <summary>
            /// Enum StartDate for value: start_date
            /// </summary>
            [EnumMember(Value = "start_date")]
            StartDate = 8,

            /// <summary>
            /// Enum ExpirationDate for value: expiration_date
            /// </summary>
            [EnumMember(Value = "expiration_date")]
            ExpirationDate = 9,

            /// <summary>
            /// Enum GiftBalance for value: gift_balance
            /// </summary>
            [EnumMember(Value = "gift_balance")]
            GiftBalance = 10,

            /// <summary>
            /// Enum LoyaltyBalance for value: loyalty_balance
            /// </summary>
            [EnumMember(Value = "loyalty_balance")]
            LoyaltyBalance = 11,

            /// <summary>
            /// Enum RedemptionQuantity for value: redemption_quantity
            /// </summary>
            [EnumMember(Value = "redemption_quantity")]
            RedemptionQuantity = 12,

            /// <summary>
            /// Enum RedemptionCount for value: redemption_count
            /// </summary>
            [EnumMember(Value = "redemption_count")]
            RedemptionCount = 13,

            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 14,

            /// <summary>
            /// Enum QrCode for value: qr_code
            /// </summary>
            [EnumMember(Value = "qr_code")]
            QrCode = 15,

            /// <summary>
            /// Enum BarCode for value: bar_code
            /// </summary>
            [EnumMember(Value = "bar_code")]
            BarCode = 16,

            /// <summary>
            /// Enum Metadata for value: metadata
            /// </summary>
            [EnumMember(Value = "metadata")]
            Metadata = 17,

            /// <summary>
            /// Enum Id for value: id
            /// </summary>
            [EnumMember(Value = "id")]
            Id = 18,

            /// <summary>
            /// Enum IsReferralCode for value: is_referral_code
            /// </summary>
            [EnumMember(Value = "is_referral_code")]
            IsReferralCode = 19,

            /// <summary>
            /// Enum CreatedAt for value: created_at
            /// </summary>
            [EnumMember(Value = "created_at")]
            CreatedAt = 20,

            /// <summary>
            /// Enum UpdatedAt for value: updated_at
            /// </summary>
            [EnumMember(Value = "updated_at")]
            UpdatedAt = 21,

            /// <summary>
            /// Enum ValidityTimeframeInterval for value: validity_timeframe_interval
            /// </summary>
            [EnumMember(Value = "validity_timeframe_interval")]
            ValidityTimeframeInterval = 22,

            /// <summary>
            /// Enum ValidityTimeframeDuration for value: validity_timeframe_duration
            /// </summary>
            [EnumMember(Value = "validity_timeframe_duration")]
            ValidityTimeframeDuration = 23,

            /// <summary>
            /// Enum ValidityDayOfWeek for value: validity_day_of_week
            /// </summary>
            [EnumMember(Value = "validity_day_of_week")]
            ValidityDayOfWeek = 24,

            /// <summary>
            /// Enum DiscountAmountLimit for value: discount_amount_limit
            /// </summary>
            [EnumMember(Value = "discount_amount_limit")]
            DiscountAmountLimit = 25,

            /// <summary>
            /// Enum CampaignId for value: campaign_id
            /// </summary>
            [EnumMember(Value = "campaign_id")]
            CampaignId = 26,

            /// <summary>
            /// Enum AdditionalInfo for value: additional_info
            /// </summary>
            [EnumMember(Value = "additional_info")]
            AdditionalInfo = 27,

            /// <summary>
            /// Enum CustomerId for value: customer_id
            /// </summary>
            [EnumMember(Value = "customer_id")]
            CustomerId = 28,

            /// <summary>
            /// Enum DiscountEffect for value: discount_effect
            /// </summary>
            [EnumMember(Value = "discount_effect")]
            DiscountEffect = 29,

            /// <summary>
            /// Enum DiscountUnitType for value: discount_unit_type
            /// </summary>
            [EnumMember(Value = "discount_unit_type")]
            DiscountUnitType = 30,

            /// <summary>
            /// Enum DiscountUnitEffect for value: discount_unit_effect
            /// </summary>
            [EnumMember(Value = "discount_unit_effect")]
            DiscountUnitEffect = 31,

            /// <summary>
            /// Enum ValidationRulesId for value: validation_rules_id
            /// </summary>
            [EnumMember(Value = "validation_rules_id")]
            ValidationRulesId = 32,

            /// <summary>
            /// Enum CustomerSourceId for value: customer_source_id
            /// </summary>
            [EnumMember(Value = "customer_source_id")]
            CustomerSourceId = 33,

            /// <summary>
            /// Enum Object for value: object
            /// </summary>
            [EnumMember(Value = "object")]
            Object = 34,

            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 35,

            /// <summary>
            /// Enum VoucherCode for value: voucher_code
            /// </summary>
            [EnumMember(Value = "voucher_code")]
            VoucherCode = 36,

            /// <summary>
            /// Enum PromotionTierId for value: promotion_tier_id
            /// </summary>
            [EnumMember(Value = "promotion_tier_id")]
            PromotionTierId = 37,

            /// <summary>
            /// Enum CustomerName for value: customer_name
            /// </summary>
            [EnumMember(Value = "customer_name")]
            CustomerName = 38,

            /// <summary>
            /// Enum TrackingId for value: tracking_id
            /// </summary>
            [EnumMember(Value = "tracking_id")]
            TrackingId = 39,

            /// <summary>
            /// Enum OrderId for value: order_id
            /// </summary>
            [EnumMember(Value = "order_id")]
            OrderId = 40,

            /// <summary>
            /// Enum OrderAmount for value: order_amount
            /// </summary>
            [EnumMember(Value = "order_amount")]
            OrderAmount = 41,

            /// <summary>
            /// Enum GiftAmount for value: gift_amount
            /// </summary>
            [EnumMember(Value = "gift_amount")]
            GiftAmount = 42,

            /// <summary>
            /// Enum LoyaltyPoints for value: loyalty_points
            /// </summary>
            [EnumMember(Value = "loyalty_points")]
            LoyaltyPoints = 43,

            /// <summary>
            /// Enum Result for value: result
            /// </summary>
            [EnumMember(Value = "result")]
            Result = 44,

            /// <summary>
            /// Enum FailureCode for value: failure_code
            /// </summary>
            [EnumMember(Value = "failure_code")]
            FailureCode = 45,

            /// <summary>
            /// Enum FailureMessage for value: failure_message
            /// </summary>
            [EnumMember(Value = "failure_message")]
            FailureMessage = 46,

            /// <summary>
            /// Enum Name for value: name
            /// </summary>
            [EnumMember(Value = "name")]
            Name = 47,

            /// <summary>
            /// Enum Description for value: description
            /// </summary>
            [EnumMember(Value = "description")]
            Description = 48,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 49,

            /// <summary>
            /// Enum SourceId for value: source_id
            /// </summary>
            [EnumMember(Value = "source_id")]
            SourceId = 50,

            /// <summary>
            /// Enum AddressCity for value: address_city
            /// </summary>
            [EnumMember(Value = "address_city")]
            AddressCity = 51,

            /// <summary>
            /// Enum AddressState for value: address_state
            /// </summary>
            [EnumMember(Value = "address_state")]
            AddressState = 52,

            /// <summary>
            /// Enum AddressLine1 for value: address_line_1
            /// </summary>
            [EnumMember(Value = "address_line_1")]
            AddressLine1 = 53,

            /// <summary>
            /// Enum AddressLine2 for value: address_line_2
            /// </summary>
            [EnumMember(Value = "address_line_2")]
            AddressLine2 = 54,

            /// <summary>
            /// Enum AddressCountry for value: address_country
            /// </summary>
            [EnumMember(Value = "address_country")]
            AddressCountry = 55,

            /// <summary>
            /// Enum AddressPostalCode for value: address_postal_code
            /// </summary>
            [EnumMember(Value = "address_postal_code")]
            AddressPostalCode = 56,

            /// <summary>
            /// Enum RedemptionsTotalRedeemed for value: redemptions_total_redeemed
            /// </summary>
            [EnumMember(Value = "redemptions_total_redeemed")]
            RedemptionsTotalRedeemed = 57,

            /// <summary>
            /// Enum RedemptionsTotalFailed for value: redemptions_total_failed
            /// </summary>
            [EnumMember(Value = "redemptions_total_failed")]
            RedemptionsTotalFailed = 58,

            /// <summary>
            /// Enum RedemptionsTotalSucceeded for value: redemptions_total_succeeded
            /// </summary>
            [EnumMember(Value = "redemptions_total_succeeded")]
            RedemptionsTotalSucceeded = 59,

            /// <summary>
            /// Enum RedemptionsTotalRolledBack for value: redemptions_total_rolled_back
            /// </summary>
            [EnumMember(Value = "redemptions_total_rolled_back")]
            RedemptionsTotalRolledBack = 60,

            /// <summary>
            /// Enum RedemptionsTotalRollbackFailed for value: redemptions_total_rollback_failed
            /// </summary>
            [EnumMember(Value = "redemptions_total_rollback_failed")]
            RedemptionsTotalRollbackFailed = 61,

            /// <summary>
            /// Enum RedemptionsTotalRollbackSucceeded for value: redemptions_total_rollback_succeeded
            /// </summary>
            [EnumMember(Value = "redemptions_total_rollback_succeeded")]
            RedemptionsTotalRollbackSucceeded = 62,

            /// <summary>
            /// Enum OrdersTotalAmount for value: orders_total_amount
            /// </summary>
            [EnumMember(Value = "orders_total_amount")]
            OrdersTotalAmount = 63,

            /// <summary>
            /// Enum OrdersTotalCount for value: orders_total_count
            /// </summary>
            [EnumMember(Value = "orders_total_count")]
            OrdersTotalCount = 64,

            /// <summary>
            /// Enum OrdersAverageAmount for value: orders_average_amount
            /// </summary>
            [EnumMember(Value = "orders_average_amount")]
            OrdersAverageAmount = 65,

            /// <summary>
            /// Enum OrdersLastOrderAmount for value: orders_last_order_amount
            /// </summary>
            [EnumMember(Value = "orders_last_order_amount")]
            OrdersLastOrderAmount = 66,

            /// <summary>
            /// Enum OrdersLastOrderDate for value: orders_last_order_date
            /// </summary>
            [EnumMember(Value = "orders_last_order_date")]
            OrdersLastOrderDate = 67,

            /// <summary>
            /// Enum LoyaltyReferredCustomers for value: loyalty_referred_customers
            /// </summary>
            [EnumMember(Value = "loyalty_referred_customers")]
            LoyaltyReferredCustomers = 68,

            /// <summary>
            /// Enum Phone for value: phone
            /// </summary>
            [EnumMember(Value = "phone")]
            Phone = 69,

            /// <summary>
            /// Enum Birthday for value: birthday
            /// </summary>
            [EnumMember(Value = "birthday")]
            Birthday = 70,

            /// <summary>
            /// Enum Birthdate for value: birthdate
            /// </summary>
            [EnumMember(Value = "birthdate")]
            Birthdate = 71,

            /// <summary>
            /// Enum Channel for value: channel
            /// </summary>
            [EnumMember(Value = "channel")]
            Channel = 72,

            /// <summary>
            /// Enum IsWinner for value: is_winner
            /// </summary>
            [EnumMember(Value = "is_winner")]
            IsWinner = 73,

            /// <summary>
            /// Enum Status for value: status
            /// </summary>
            [EnumMember(Value = "status")]
            Status = 74,

            /// <summary>
            /// Enum Amount for value: amount
            /// </summary>
            [EnumMember(Value = "amount")]
            Amount = 75,

            /// <summary>
            /// Enum DiscountAmount for value: discount_amount
            /// </summary>
            [EnumMember(Value = "discount_amount")]
            DiscountAmount = 76,

            /// <summary>
            /// Enum ItemsDiscountAmount for value: items_discount_amount
            /// </summary>
            [EnumMember(Value = "items_discount_amount")]
            ItemsDiscountAmount = 77,

            /// <summary>
            /// Enum TotalDiscountAmount for value: total_discount_amount
            /// </summary>
            [EnumMember(Value = "total_discount_amount")]
            TotalDiscountAmount = 78,

            /// <summary>
            /// Enum TotalAmount for value: total_amount
            /// </summary>
            [EnumMember(Value = "total_amount")]
            TotalAmount = 79,

            /// <summary>
            /// Enum ReferrerId for value: referrer_id
            /// </summary>
            [EnumMember(Value = "referrer_id")]
            ReferrerId = 80,

            /// <summary>
            /// Enum VoucherId for value: voucher_id
            /// </summary>
            [EnumMember(Value = "voucher_id")]
            VoucherId = 81,

            /// <summary>
            /// Enum Points for value: points
            /// </summary>
            [EnumMember(Value = "points")]
            Points = 82,

            /// <summary>
            /// Enum ExpiresAt for value: expires_at
            /// </summary>
            [EnumMember(Value = "expires_at")]
            ExpiresAt = 83,

            /// <summary>
            /// Enum Type for value: type
            /// </summary>
            [EnumMember(Value = "type")]
            Type = 84,

            /// <summary>
            /// Enum Reason for value: reason
            /// </summary>
            [EnumMember(Value = "reason")]
            Reason = 85,

            /// <summary>
            /// Enum Source for value: source
            /// </summary>
            [EnumMember(Value = "source")]
            Source = 86,

            /// <summary>
            /// Enum Balance for value: balance
            /// </summary>
            [EnumMember(Value = "balance")]
            Balance = 87,

            /// <summary>
            /// Enum RelatedTransactionId for value: related_transaction_id
            /// </summary>
            [EnumMember(Value = "related_transaction_id")]
            RelatedTransactionId = 88,

            /// <summary>
            /// Enum Details for value: details
            /// </summary>
            [EnumMember(Value = "details")]
            Details = 89
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateRequestBodyParameters" /> class.
        /// </summary>
        /// <param name="order">order.</param>
        /// <param name="fields">Array of strings containing the data in the export. These fields define the headers in the CSV file..</param>
        /// <param name="filters">Allowed additional properties must start with \&quot;metadata.\&quot; or \&quot;redemption.\&quot; and Allowed additional properties must start with \&quot;metadata.\&quot; and Allowed additional properties must start with \&quot;metadata.\&quot; or \&quot;address.\&quot; or \&quot;summary.\&quot; or \&quot;loyalty.\&quot; or \&quot;loyalty_tier.\&quot; or \&quot;loyalty_points.\&quot; or \&quot;system_metadata.\&quot;.</param>
        public ExportsCreateRequestBodyParameters(OrderEnum? order = default(OrderEnum?), List<FieldsEnum> fields = default(List<FieldsEnum>), Object filters = default(Object))
        {
            this._Order = order;
            if (this.Order != null)
            {
                this._flagOrder = true;
            }
            this._Fields = fields;
            if (this.Fields != null)
            {
                this._flagFields = true;
            }
            this._Filters = filters;
            if (this.Filters != null)
            {
                this._flagFilters = true;
            }
        }

        /// <summary>
        /// Array of strings containing the data in the export. These fields define the headers in the CSV file.
        /// </summary>
        /// <value>Array of strings containing the data in the export. These fields define the headers in the CSV file.</value>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<ExportsCreateRequestBodyParameters.FieldsEnum> Fields
        {
            get{ return _Fields;}
            set
            {
                _Fields = value;
                _flagFields = true;
            }
        }
        private List<ExportsCreateRequestBodyParameters.FieldsEnum> _Fields;
        private bool _flagFields;

        /// <summary>
        /// Returns false as Fields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFields()
        {
            return _flagFields;
        }
        /// <summary>
        /// Allowed additional properties must start with \&quot;metadata.\&quot; or \&quot;redemption.\&quot; and Allowed additional properties must start with \&quot;metadata.\&quot; and Allowed additional properties must start with \&quot;metadata.\&quot; or \&quot;address.\&quot; or \&quot;summary.\&quot; or \&quot;loyalty.\&quot; or \&quot;loyalty_tier.\&quot; or \&quot;loyalty_points.\&quot; or \&quot;system_metadata.\&quot;
        /// </summary>
        /// <value>Allowed additional properties must start with \&quot;metadata.\&quot; or \&quot;redemption.\&quot; and Allowed additional properties must start with \&quot;metadata.\&quot; and Allowed additional properties must start with \&quot;metadata.\&quot; or \&quot;address.\&quot; or \&quot;summary.\&quot; or \&quot;loyalty.\&quot; or \&quot;loyalty_tier.\&quot; or \&quot;loyalty_points.\&quot; or \&quot;system_metadata.\&quot;</value>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public Object Filters
        {
            get{ return _Filters;}
            set
            {
                _Filters = value;
                _flagFilters = true;
            }
        }
        private Object _Filters;
        private bool _flagFilters;

        /// <summary>
        /// Returns false as Filters should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFilters()
        {
            return _flagFilters;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportsCreateRequestBodyParameters {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
