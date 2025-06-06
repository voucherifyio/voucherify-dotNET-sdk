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
    /// ParameterFiltersListCustomerRedeemablesCampaignTypeConditions
    /// </summary>
    [DataContract(Name = "ParameterFiltersListCustomerRedeemablesCampaignType_conditions")]
    public partial class ParameterFiltersListCustomerRedeemablesCampaignTypeConditions : IValidatableObject
    {
        /// <summary>
        /// Defines In
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InEnum
        {
            /// <summary>
            /// Enum LOYALTYPROGRAM for value: LOYALTY_PROGRAM
            /// </summary>
            [EnumMember(Value = "LOYALTY_PROGRAM")]
            LOYALTYPROGRAM = 1,

            /// <summary>
            /// Enum GIFTVOUCHERS for value: GIFT_VOUCHERS
            /// </summary>
            [EnumMember(Value = "GIFT_VOUCHERS")]
            GIFTVOUCHERS = 2,

            /// <summary>
            /// Enum DISCOUNTCOUPONS for value: DISCOUNT_COUPONS
            /// </summary>
            [EnumMember(Value = "DISCOUNT_COUPONS")]
            DISCOUNTCOUPONS = 3,

            /// <summary>
            /// Enum REFERRALPROGRAM for value: REFERRAL_PROGRAM
            /// </summary>
            [EnumMember(Value = "REFERRAL_PROGRAM")]
            REFERRALPROGRAM = 4
        }

        /// <summary>
        /// Defines NotIn
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NotInEnum
        {
            /// <summary>
            /// Enum LOYALTYPROGRAM for value: LOYALTY_PROGRAM
            /// </summary>
            [EnumMember(Value = "LOYALTY_PROGRAM")]
            LOYALTYPROGRAM = 1,

            /// <summary>
            /// Enum GIFTVOUCHERS for value: GIFT_VOUCHERS
            /// </summary>
            [EnumMember(Value = "GIFT_VOUCHERS")]
            GIFTVOUCHERS = 2,

            /// <summary>
            /// Enum DISCOUNTCOUPONS for value: DISCOUNT_COUPONS
            /// </summary>
            [EnumMember(Value = "DISCOUNT_COUPONS")]
            DISCOUNTCOUPONS = 3,

            /// <summary>
            /// Enum REFERRALPROGRAM for value: REFERRAL_PROGRAM
            /// </summary>
            [EnumMember(Value = "REFERRAL_PROGRAM")]
            REFERRALPROGRAM = 4
        }

        /// <summary>
        /// Value is exactly this value (single value).
        /// </summary>
        /// <value>Value is exactly this value (single value).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IsEnum
        {
            /// <summary>
            /// Enum LOYALTYPROGRAM for value: LOYALTY_PROGRAM
            /// </summary>
            [EnumMember(Value = "LOYALTY_PROGRAM")]
            LOYALTYPROGRAM = 1,

            /// <summary>
            /// Enum GIFTVOUCHERS for value: GIFT_VOUCHERS
            /// </summary>
            [EnumMember(Value = "GIFT_VOUCHERS")]
            GIFTVOUCHERS = 2,

            /// <summary>
            /// Enum DISCOUNTCOUPONS for value: DISCOUNT_COUPONS
            /// </summary>
            [EnumMember(Value = "DISCOUNT_COUPONS")]
            DISCOUNTCOUPONS = 3,

            /// <summary>
            /// Enum REFERRALPROGRAM for value: REFERRAL_PROGRAM
            /// </summary>
            [EnumMember(Value = "REFERRAL_PROGRAM")]
            REFERRALPROGRAM = 4
        }


        /// <summary>
        /// Value is exactly this value (single value).
        /// </summary>
        /// <value>Value is exactly this value (single value).</value>

        [DataMember(Name = "$is", EmitDefaultValue = true)]
        public IsEnum? Is
        {
            get{ return _Is;}
            set
            {
                _Is = value;
                _flagIs = true;
            }
        }
        private IsEnum? _Is;
        private bool _flagIs;

        /// <summary>
        /// Returns false as Is should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIs()
        {
            return _flagIs;
        }
        /// <summary>
        /// Results omit this value (single value).
        /// </summary>
        /// <value>Results omit this value (single value).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IsNotEnum
        {
            /// <summary>
            /// Enum LOYALTYPROGRAM for value: LOYALTY_PROGRAM
            /// </summary>
            [EnumMember(Value = "LOYALTY_PROGRAM")]
            LOYALTYPROGRAM = 1,

            /// <summary>
            /// Enum GIFTVOUCHERS for value: GIFT_VOUCHERS
            /// </summary>
            [EnumMember(Value = "GIFT_VOUCHERS")]
            GIFTVOUCHERS = 2,

            /// <summary>
            /// Enum DISCOUNTCOUPONS for value: DISCOUNT_COUPONS
            /// </summary>
            [EnumMember(Value = "DISCOUNT_COUPONS")]
            DISCOUNTCOUPONS = 3,

            /// <summary>
            /// Enum REFERRALPROGRAM for value: REFERRAL_PROGRAM
            /// </summary>
            [EnumMember(Value = "REFERRAL_PROGRAM")]
            REFERRALPROGRAM = 4
        }


        /// <summary>
        /// Results omit this value (single value).
        /// </summary>
        /// <value>Results omit this value (single value).</value>

        [DataMember(Name = "$is_not", EmitDefaultValue = true)]
        public IsNotEnum? IsNot
        {
            get{ return _IsNot;}
            set
            {
                _IsNot = value;
                _flagIsNot = true;
            }
        }
        private IsNotEnum? _IsNot;
        private bool _flagIsNot;

        /// <summary>
        /// Returns false as IsNot should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsNot()
        {
            return _flagIsNot;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterFiltersListCustomerRedeemablesCampaignTypeConditions" /> class.
        /// </summary>
        /// <param name="varIn">Array of resource values that should be included in the results (multiple values)..</param>
        /// <param name="notIn">Array of resource values that should be included in the results (multiple values)..</param>
        /// <param name="varIs">Value is exactly this value (single value)..</param>
        /// <param name="isNot">Results omit this value (single value)..</param>
        /// <param name="hasValue">Value is NOT null. The value for this parameter is an empty string..</param>
        /// <param name="isUnknown">Value is null. The value for this parameter is an empty string..</param>
        /// <param name="startsWith">Value starts with the specified string..</param>
        /// <param name="endsWith">Value ends with the specified string..</param>
        public ParameterFiltersListCustomerRedeemablesCampaignTypeConditions(List<InEnum> varIn = default(List<InEnum>), List<NotInEnum> notIn = default(List<NotInEnum>), IsEnum? varIs = default(IsEnum?), IsNotEnum? isNot = default(IsNotEnum?), string hasValue = default(string), string isUnknown = default(string), string startsWith = default(string), string endsWith = default(string))
        {
            this._In = varIn;
            if (this.In != null)
            {
                this._flagIn = true;
            }
            this._NotIn = notIn;
            if (this.NotIn != null)
            {
                this._flagNotIn = true;
            }
            this._Is = varIs;
            if (this.Is != null)
            {
                this._flagIs = true;
            }
            this._IsNot = isNot;
            if (this.IsNot != null)
            {
                this._flagIsNot = true;
            }
            this._HasValue = hasValue;
            if (this.HasValue != null)
            {
                this._flagHasValue = true;
            }
            this._IsUnknown = isUnknown;
            if (this.IsUnknown != null)
            {
                this._flagIsUnknown = true;
            }
            this._StartsWith = startsWith;
            if (this.StartsWith != null)
            {
                this._flagStartsWith = true;
            }
            this._EndsWith = endsWith;
            if (this.EndsWith != null)
            {
                this._flagEndsWith = true;
            }
        }

        /// <summary>
        /// Array of resource values that should be included in the results (multiple values).
        /// </summary>
        /// <value>Array of resource values that should be included in the results (multiple values).</value>
        [DataMember(Name = "$in", EmitDefaultValue = true)]
        public List<ParameterFiltersListCustomerRedeemablesCampaignTypeConditions.InEnum> In
        {
            get{ return _In;}
            set
            {
                _In = value;
                _flagIn = true;
            }
        }
        private List<ParameterFiltersListCustomerRedeemablesCampaignTypeConditions.InEnum> _In;
        private bool _flagIn;

        /// <summary>
        /// Returns false as In should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIn()
        {
            return _flagIn;
        }
        /// <summary>
        /// Array of resource values that should be included in the results (multiple values).
        /// </summary>
        /// <value>Array of resource values that should be included in the results (multiple values).</value>
        [DataMember(Name = "$not_in", EmitDefaultValue = true)]
        public List<ParameterFiltersListCustomerRedeemablesCampaignTypeConditions.NotInEnum> NotIn
        {
            get{ return _NotIn;}
            set
            {
                _NotIn = value;
                _flagNotIn = true;
            }
        }
        private List<ParameterFiltersListCustomerRedeemablesCampaignTypeConditions.NotInEnum> _NotIn;
        private bool _flagNotIn;

        /// <summary>
        /// Returns false as NotIn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotIn()
        {
            return _flagNotIn;
        }
        /// <summary>
        /// Value is NOT null. The value for this parameter is an empty string.
        /// </summary>
        /// <value>Value is NOT null. The value for this parameter is an empty string.</value>
        [DataMember(Name = "$has_value", EmitDefaultValue = true)]
        public string HasValue
        {
            get{ return _HasValue;}
            set
            {
                _HasValue = value;
                _flagHasValue = true;
            }
        }
        private string _HasValue;
        private bool _flagHasValue;

        /// <summary>
        /// Returns false as HasValue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasValue()
        {
            return _flagHasValue;
        }
        /// <summary>
        /// Value is null. The value for this parameter is an empty string.
        /// </summary>
        /// <value>Value is null. The value for this parameter is an empty string.</value>
        [DataMember(Name = "$is_unknown", EmitDefaultValue = true)]
        public string IsUnknown
        {
            get{ return _IsUnknown;}
            set
            {
                _IsUnknown = value;
                _flagIsUnknown = true;
            }
        }
        private string _IsUnknown;
        private bool _flagIsUnknown;

        /// <summary>
        /// Returns false as IsUnknown should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsUnknown()
        {
            return _flagIsUnknown;
        }
        /// <summary>
        /// Value starts with the specified string.
        /// </summary>
        /// <value>Value starts with the specified string.</value>
        [DataMember(Name = "$starts_with", EmitDefaultValue = true)]
        public string StartsWith
        {
            get{ return _StartsWith;}
            set
            {
                _StartsWith = value;
                _flagStartsWith = true;
            }
        }
        private string _StartsWith;
        private bool _flagStartsWith;

        /// <summary>
        /// Returns false as StartsWith should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartsWith()
        {
            return _flagStartsWith;
        }
        /// <summary>
        /// Value ends with the specified string.
        /// </summary>
        /// <value>Value ends with the specified string.</value>
        [DataMember(Name = "$ends_with", EmitDefaultValue = true)]
        public string EndsWith
        {
            get{ return _EndsWith;}
            set
            {
                _EndsWith = value;
                _flagEndsWith = true;
            }
        }
        private string _EndsWith;
        private bool _flagEndsWith;

        /// <summary>
        /// Returns false as EndsWith should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEndsWith()
        {
            return _flagEndsWith;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParameterFiltersListCustomerRedeemablesCampaignTypeConditions {\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  NotIn: ").Append(NotIn).Append("\n");
            sb.Append("  Is: ").Append(Is).Append("\n");
            sb.Append("  IsNot: ").Append(IsNot).Append("\n");
            sb.Append("  HasValue: ").Append(HasValue).Append("\n");
            sb.Append("  IsUnknown: ").Append(IsUnknown).Append("\n");
            sb.Append("  StartsWith: ").Append(StartsWith).Append("\n");
            sb.Append("  EndsWith: ").Append(EndsWith).Append("\n");
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
