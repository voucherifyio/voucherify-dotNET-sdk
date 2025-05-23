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
    /// Schema model for a campaign voucher.
    /// </summary>
    [DataContract(Name = "CampaignVoucher")]
    public partial class CampaignVoucher : IValidatableObject
    {
        /// <summary>
        /// Defines ValidityDayOfWeek
        /// </summary>
        public enum ValidityDayOfWeekEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignVoucher" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignVoucher() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignVoucher" /> class.
        /// </summary>
        /// <param name="type">Type of voucher..</param>
        /// <param name="discount">discount.</param>
        /// <param name="gift">gift.</param>
        /// <param name="loyaltyCard">loyaltyCard.</param>
        /// <param name="redemption">redemption.</param>
        /// <param name="codeConfig">codeConfig (required).</param>
        /// <param name="isReferralCode">Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;..</param>
        /// <param name="startDate">Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is *inactive before* this date. .</param>
        /// <param name="expirationDate">Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is *inactive after* this date..</param>
        /// <param name="validityTimeframe">validityTimeframe.</param>
        /// <param name="validityDayOfWeek">Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday.</param>
        /// <param name="validityHours">validityHours.</param>
        public CampaignVoucher(string type = default(string), Discount discount = default(Discount), Gift gift = default(Gift), CampaignLoyaltyCard loyaltyCard = default(CampaignLoyaltyCard), CampaignVoucherRedemption redemption = default(CampaignVoucherRedemption), CodeConfig codeConfig = default(CodeConfig), bool? isReferralCode = default(bool?), DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? expirationDate = default(DateTimeOffset?), ValidityTimeframe validityTimeframe = default(ValidityTimeframe), List<ValidityDayOfWeekEnum> validityDayOfWeek = default(List<ValidityDayOfWeekEnum>), ValidityHours validityHours = default(ValidityHours))
        {
            // to ensure "codeConfig" is required (not null)
            if (codeConfig == null)
            {
                throw new ArgumentNullException("codeConfig is a required property for CampaignVoucher and cannot be null");
            }
            this._CodeConfig = codeConfig;
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._Discount = discount;
            if (this.Discount != null)
            {
                this._flagDiscount = true;
            }
            this._Gift = gift;
            if (this.Gift != null)
            {
                this._flagGift = true;
            }
            this._LoyaltyCard = loyaltyCard;
            if (this.LoyaltyCard != null)
            {
                this._flagLoyaltyCard = true;
            }
            this._Redemption = redemption;
            if (this.Redemption != null)
            {
                this._flagRedemption = true;
            }
            this._IsReferralCode = isReferralCode;
            if (this.IsReferralCode != null)
            {
                this._flagIsReferralCode = true;
            }
            this._StartDate = startDate;
            if (this.StartDate != null)
            {
                this._flagStartDate = true;
            }
            this._ExpirationDate = expirationDate;
            if (this.ExpirationDate != null)
            {
                this._flagExpirationDate = true;
            }
            this._ValidityTimeframe = validityTimeframe;
            if (this.ValidityTimeframe != null)
            {
                this._flagValidityTimeframe = true;
            }
            this._ValidityDayOfWeek = validityDayOfWeek;
            if (this.ValidityDayOfWeek != null)
            {
                this._flagValidityDayOfWeek = true;
            }
            this._ValidityHours = validityHours;
            if (this.ValidityHours != null)
            {
                this._flagValidityHours = true;
            }
        }

        /// <summary>
        /// Type of voucher.
        /// </summary>
        /// <value>Type of voucher.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type
        {
            get{ return _Type;}
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private string _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name = "discount", EmitDefaultValue = true)]
        public Discount Discount
        {
            get{ return _Discount;}
            set
            {
                _Discount = value;
                _flagDiscount = true;
            }
        }
        private Discount _Discount;
        private bool _flagDiscount;

        /// <summary>
        /// Returns false as Discount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscount()
        {
            return _flagDiscount;
        }
        /// <summary>
        /// Gets or Sets Gift
        /// </summary>
        [DataMember(Name = "gift", EmitDefaultValue = true)]
        public Gift Gift
        {
            get{ return _Gift;}
            set
            {
                _Gift = value;
                _flagGift = true;
            }
        }
        private Gift _Gift;
        private bool _flagGift;

        /// <summary>
        /// Returns false as Gift should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGift()
        {
            return _flagGift;
        }
        /// <summary>
        /// Gets or Sets LoyaltyCard
        /// </summary>
        [DataMember(Name = "loyalty_card", EmitDefaultValue = true)]
        public CampaignLoyaltyCard LoyaltyCard
        {
            get{ return _LoyaltyCard;}
            set
            {
                _LoyaltyCard = value;
                _flagLoyaltyCard = true;
            }
        }
        private CampaignLoyaltyCard _LoyaltyCard;
        private bool _flagLoyaltyCard;

        /// <summary>
        /// Returns false as LoyaltyCard should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLoyaltyCard()
        {
            return _flagLoyaltyCard;
        }
        /// <summary>
        /// Gets or Sets Redemption
        /// </summary>
        [DataMember(Name = "redemption", EmitDefaultValue = true)]
        public CampaignVoucherRedemption Redemption
        {
            get{ return _Redemption;}
            set
            {
                _Redemption = value;
                _flagRedemption = true;
            }
        }
        private CampaignVoucherRedemption _Redemption;
        private bool _flagRedemption;

        /// <summary>
        /// Returns false as Redemption should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRedemption()
        {
            return _flagRedemption;
        }
        /// <summary>
        /// Gets or Sets CodeConfig
        /// </summary>
        [DataMember(Name = "code_config", IsRequired = true, EmitDefaultValue = true)]
        public CodeConfig CodeConfig
        {
            get{ return _CodeConfig;}
            set
            {
                _CodeConfig = value;
                _flagCodeConfig = true;
            }
        }
        private CodeConfig _CodeConfig;
        private bool _flagCodeConfig;

        /// <summary>
        /// Returns false as CodeConfig should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCodeConfig()
        {
            return _flagCodeConfig;
        }
        /// <summary>
        /// Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;.
        /// </summary>
        /// <value>Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;.</value>
        [DataMember(Name = "is_referral_code", EmitDefaultValue = true)]
        public bool? IsReferralCode
        {
            get{ return _IsReferralCode;}
            set
            {
                _IsReferralCode = value;
                _flagIsReferralCode = true;
            }
        }
        private bool? _IsReferralCode;
        private bool _flagIsReferralCode;

        /// <summary>
        /// Returns false as IsReferralCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsReferralCode()
        {
            return _flagIsReferralCode;
        }
        /// <summary>
        /// Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is *inactive before* this date. 
        /// </summary>
        /// <value>Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is *inactive before* this date. </value>
        /*
        <example>2022-09-20T00:00Z</example>
        */
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public DateTimeOffset? StartDate
        {
            get{ return _StartDate;}
            set
            {
                _StartDate = value;
                _flagStartDate = true;
            }
        }
        private DateTimeOffset? _StartDate;
        private bool _flagStartDate;

        /// <summary>
        /// Returns false as StartDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartDate()
        {
            return _flagStartDate;
        }
        /// <summary>
        /// Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is *inactive after* this date.
        /// </summary>
        /// <value>Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is *inactive after* this date.</value>
        /*
        <example>2022-09-30T00:00Z</example>
        */
        [DataMember(Name = "expiration_date", EmitDefaultValue = true)]
        public DateTimeOffset? ExpirationDate
        {
            get{ return _ExpirationDate;}
            set
            {
                _ExpirationDate = value;
                _flagExpirationDate = true;
            }
        }
        private DateTimeOffset? _ExpirationDate;
        private bool _flagExpirationDate;

        /// <summary>
        /// Returns false as ExpirationDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpirationDate()
        {
            return _flagExpirationDate;
        }
        /// <summary>
        /// Gets or Sets ValidityTimeframe
        /// </summary>
        [DataMember(Name = "validity_timeframe", EmitDefaultValue = true)]
        public ValidityTimeframe ValidityTimeframe
        {
            get{ return _ValidityTimeframe;}
            set
            {
                _ValidityTimeframe = value;
                _flagValidityTimeframe = true;
            }
        }
        private ValidityTimeframe _ValidityTimeframe;
        private bool _flagValidityTimeframe;

        /// <summary>
        /// Returns false as ValidityTimeframe should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidityTimeframe()
        {
            return _flagValidityTimeframe;
        }
        /// <summary>
        /// Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday
        /// </summary>
        /// <value>Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday</value>
        [DataMember(Name = "validity_day_of_week", EmitDefaultValue = true)]
        public List<CampaignVoucher.ValidityDayOfWeekEnum> ValidityDayOfWeek
        {
            get{ return _ValidityDayOfWeek;}
            set
            {
                _ValidityDayOfWeek = value;
                _flagValidityDayOfWeek = true;
            }
        }
        private List<CampaignVoucher.ValidityDayOfWeekEnum> _ValidityDayOfWeek;
        private bool _flagValidityDayOfWeek;

        /// <summary>
        /// Returns false as ValidityDayOfWeek should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidityDayOfWeek()
        {
            return _flagValidityDayOfWeek;
        }
        /// <summary>
        /// Gets or Sets ValidityHours
        /// </summary>
        [DataMember(Name = "validity_hours", EmitDefaultValue = true)]
        public ValidityHours ValidityHours
        {
            get{ return _ValidityHours;}
            set
            {
                _ValidityHours = value;
                _flagValidityHours = true;
            }
        }
        private ValidityHours _ValidityHours;
        private bool _flagValidityHours;

        /// <summary>
        /// Returns false as ValidityHours should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidityHours()
        {
            return _flagValidityHours;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CampaignVoucher {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Gift: ").Append(Gift).Append("\n");
            sb.Append("  LoyaltyCard: ").Append(LoyaltyCard).Append("\n");
            sb.Append("  Redemption: ").Append(Redemption).Append("\n");
            sb.Append("  CodeConfig: ").Append(CodeConfig).Append("\n");
            sb.Append("  IsReferralCode: ").Append(IsReferralCode).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ValidityTimeframe: ").Append(ValidityTimeframe).Append("\n");
            sb.Append("  ValidityDayOfWeek: ").Append(ValidityDayOfWeek).Append("\n");
            sb.Append("  ValidityHours: ").Append(ValidityHours).Append("\n");
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
