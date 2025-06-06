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
    /// LoyaltiesEarningRulesCreateRequestBodyItem
    /// </summary>
    [DataContract(Name = "LoyaltiesEarningRulesCreateRequestBodyItem")]
    public partial class LoyaltiesEarningRulesCreateRequestBodyItem : IValidatableObject
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
        /// Initializes a new instance of the <see cref="LoyaltiesEarningRulesCreateRequestBodyItem" /> class.
        /// </summary>
        /// <param name="validationRuleId">A unique validation rule identifier assigned by the Voucherify API. The validation rule is verified before points are added to the balance..</param>
        /// <param name="loyalty">loyalty.</param>
        /// <param name="varEvent">varEvent.</param>
        /// <param name="source">source.</param>
        /// <param name="active">A flag to toggle the earning rule on or off. You can disable an earning rule even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60; of the campaign or the earning rule&#39;s own &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* earning rule - &#x60;false&#x60; indicates an *inactive* earning rule.</param>
        /// <param name="startDate">Start date defines when the earning rule starts to be active. Activation timestamp is presented in the ISO 8601 format. Earning rule is *inactive before* this date. If you don&#39;t define the start date for an earning rule, it&#39;ll inherit the campaign start date by default. .</param>
        /// <param name="expirationDate">Expiration date defines when the earning rule expires. Expiration timestamp is presented in the ISO 8601 format.  Earning rule is *inactive after* this date.If you don&#39;t define the expiration date for an earning rule, it&#39;ll inherit the campaign expiration date by default..</param>
        /// <param name="pendingPoints">pendingPoints.</param>
        /// <param name="validityTimeframe">validityTimeframe.</param>
        /// <param name="validityDayOfWeek">Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday.</param>
        /// <param name="validityHours">validityHours.</param>
        /// <param name="metadata">The metadata object stores all custom attributes assigned to the earning rule. A set of key/value pairs that you can attach to an earning rule object. It can be useful for storing additional information about the earning rule in a structured format..</param>
        /// <param name="segment">segment.</param>
        /// <param name="customEvent">customEvent.</param>
        /// <param name="loyaltyTier">loyaltyTier.</param>
        public LoyaltiesEarningRulesCreateRequestBodyItem(string validationRuleId = default(string), LoyaltiesEarningRulesCreateRequestBodyItemLoyalty loyalty = default(LoyaltiesEarningRulesCreateRequestBodyItemLoyalty), string varEvent = default(string), LoyaltiesEarningRulesCreateRequestBodyItemSource source = default(LoyaltiesEarningRulesCreateRequestBodyItemSource), bool? active = default(bool?), DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? expirationDate = default(DateTimeOffset?), LoyaltiesEarningRulesCreateRequestBodyItemPendingPoints pendingPoints = default(LoyaltiesEarningRulesCreateRequestBodyItemPendingPoints), ValidityTimeframe validityTimeframe = default(ValidityTimeframe), List<ValidityDayOfWeekEnum> validityDayOfWeek = default(List<ValidityDayOfWeekEnum>), ValidityHours validityHours = default(ValidityHours), Object metadata = default(Object), LoyaltiesEarningRulesCreateRequestBodyItemSegment segment = default(LoyaltiesEarningRulesCreateRequestBodyItemSegment), LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent customEvent = default(LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent), LoyaltiesEarningRulesCreateRequestBodyItemLoyaltyTier loyaltyTier = default(LoyaltiesEarningRulesCreateRequestBodyItemLoyaltyTier))
        {
            this._ValidationRuleId = validationRuleId;
            if (this.ValidationRuleId != null)
            {
                this._flagValidationRuleId = true;
            }
            this._Loyalty = loyalty;
            if (this.Loyalty != null)
            {
                this._flagLoyalty = true;
            }
            this._Event = varEvent;
            if (this.Event != null)
            {
                this._flagEvent = true;
            }
            this._Source = source;
            if (this.Source != null)
            {
                this._flagSource = true;
            }
            this._Active = active;
            if (this.Active != null)
            {
                this._flagActive = true;
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
            this._PendingPoints = pendingPoints;
            if (this.PendingPoints != null)
            {
                this._flagPendingPoints = true;
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
            this._Metadata = metadata;
            if (this.Metadata != null)
            {
                this._flagMetadata = true;
            }
            this._Segment = segment;
            if (this.Segment != null)
            {
                this._flagSegment = true;
            }
            this._CustomEvent = customEvent;
            if (this.CustomEvent != null)
            {
                this._flagCustomEvent = true;
            }
            this._LoyaltyTier = loyaltyTier;
            if (this.LoyaltyTier != null)
            {
                this._flagLoyaltyTier = true;
            }
        }

        /// <summary>
        /// A unique validation rule identifier assigned by the Voucherify API. The validation rule is verified before points are added to the balance.
        /// </summary>
        /// <value>A unique validation rule identifier assigned by the Voucherify API. The validation rule is verified before points are added to the balance.</value>
        /*
        <example>val_248vs7tUjlIE</example>
        */
        [DataMember(Name = "validation_rule_id", EmitDefaultValue = true)]
        public string ValidationRuleId
        {
            get{ return _ValidationRuleId;}
            set
            {
                _ValidationRuleId = value;
                _flagValidationRuleId = true;
            }
        }
        private string _ValidationRuleId;
        private bool _flagValidationRuleId;

        /// <summary>
        /// Returns false as ValidationRuleId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidationRuleId()
        {
            return _flagValidationRuleId;
        }
        /// <summary>
        /// Gets or Sets Loyalty
        /// </summary>
        [DataMember(Name = "loyalty", EmitDefaultValue = true)]
        public LoyaltiesEarningRulesCreateRequestBodyItemLoyalty Loyalty
        {
            get{ return _Loyalty;}
            set
            {
                _Loyalty = value;
                _flagLoyalty = true;
            }
        }
        private LoyaltiesEarningRulesCreateRequestBodyItemLoyalty _Loyalty;
        private bool _flagLoyalty;

        /// <summary>
        /// Returns false as Loyalty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLoyalty()
        {
            return _flagLoyalty;
        }
        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = true)]
        public string Event
        {
            get{ return _Event;}
            set
            {
                _Event = value;
                _flagEvent = true;
            }
        }
        private string _Event;
        private bool _flagEvent;

        /// <summary>
        /// Returns false as Event should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEvent()
        {
            return _flagEvent;
        }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public LoyaltiesEarningRulesCreateRequestBodyItemSource Source
        {
            get{ return _Source;}
            set
            {
                _Source = value;
                _flagSource = true;
            }
        }
        private LoyaltiesEarningRulesCreateRequestBodyItemSource _Source;
        private bool _flagSource;

        /// <summary>
        /// Returns false as Source should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSource()
        {
            return _flagSource;
        }
        /// <summary>
        /// A flag to toggle the earning rule on or off. You can disable an earning rule even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60; of the campaign or the earning rule&#39;s own &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* earning rule - &#x60;false&#x60; indicates an *inactive* earning rule
        /// </summary>
        /// <value>A flag to toggle the earning rule on or off. You can disable an earning rule even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60; of the campaign or the earning rule&#39;s own &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* earning rule - &#x60;false&#x60; indicates an *inactive* earning rule</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active
        {
            get{ return _Active;}
            set
            {
                _Active = value;
                _flagActive = true;
            }
        }
        private bool? _Active;
        private bool _flagActive;

        /// <summary>
        /// Returns false as Active should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActive()
        {
            return _flagActive;
        }
        /// <summary>
        /// Start date defines when the earning rule starts to be active. Activation timestamp is presented in the ISO 8601 format. Earning rule is *inactive before* this date. If you don&#39;t define the start date for an earning rule, it&#39;ll inherit the campaign start date by default. 
        /// </summary>
        /// <value>Start date defines when the earning rule starts to be active. Activation timestamp is presented in the ISO 8601 format. Earning rule is *inactive before* this date. If you don&#39;t define the start date for an earning rule, it&#39;ll inherit the campaign start date by default. </value>
        /*
        <example>2022-02-02T13:00Z</example>
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
        /// Expiration date defines when the earning rule expires. Expiration timestamp is presented in the ISO 8601 format.  Earning rule is *inactive after* this date.If you don&#39;t define the expiration date for an earning rule, it&#39;ll inherit the campaign expiration date by default.
        /// </summary>
        /// <value>Expiration date defines when the earning rule expires. Expiration timestamp is presented in the ISO 8601 format.  Earning rule is *inactive after* this date.If you don&#39;t define the expiration date for an earning rule, it&#39;ll inherit the campaign expiration date by default.</value>
        /*
        <example>2022-03-03T14:30Z</example>
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
        /// Gets or Sets PendingPoints
        /// </summary>
        [DataMember(Name = "pending_points", EmitDefaultValue = true)]
        public LoyaltiesEarningRulesCreateRequestBodyItemPendingPoints PendingPoints
        {
            get{ return _PendingPoints;}
            set
            {
                _PendingPoints = value;
                _flagPendingPoints = true;
            }
        }
        private LoyaltiesEarningRulesCreateRequestBodyItemPendingPoints _PendingPoints;
        private bool _flagPendingPoints;

        /// <summary>
        /// Returns false as PendingPoints should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePendingPoints()
        {
            return _flagPendingPoints;
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
        public List<LoyaltiesEarningRulesCreateRequestBodyItem.ValidityDayOfWeekEnum> ValidityDayOfWeek
        {
            get{ return _ValidityDayOfWeek;}
            set
            {
                _ValidityDayOfWeek = value;
                _flagValidityDayOfWeek = true;
            }
        }
        private List<LoyaltiesEarningRulesCreateRequestBodyItem.ValidityDayOfWeekEnum> _ValidityDayOfWeek;
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
        /// The metadata object stores all custom attributes assigned to the earning rule. A set of key/value pairs that you can attach to an earning rule object. It can be useful for storing additional information about the earning rule in a structured format.
        /// </summary>
        /// <value>The metadata object stores all custom attributes assigned to the earning rule. A set of key/value pairs that you can attach to an earning rule object. It can be useful for storing additional information about the earning rule in a structured format.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Object Metadata
        {
            get{ return _Metadata;}
            set
            {
                _Metadata = value;
                _flagMetadata = true;
            }
        }
        private Object _Metadata;
        private bool _flagMetadata;

        /// <summary>
        /// Returns false as Metadata should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetadata()
        {
            return _flagMetadata;
        }
        /// <summary>
        /// Gets or Sets Segment
        /// </summary>
        [DataMember(Name = "segment", EmitDefaultValue = true)]
        public LoyaltiesEarningRulesCreateRequestBodyItemSegment Segment
        {
            get{ return _Segment;}
            set
            {
                _Segment = value;
                _flagSegment = true;
            }
        }
        private LoyaltiesEarningRulesCreateRequestBodyItemSegment _Segment;
        private bool _flagSegment;

        /// <summary>
        /// Returns false as Segment should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSegment()
        {
            return _flagSegment;
        }
        /// <summary>
        /// Gets or Sets CustomEvent
        /// </summary>
        [DataMember(Name = "custom_event", EmitDefaultValue = true)]
        public LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent CustomEvent
        {
            get{ return _CustomEvent;}
            set
            {
                _CustomEvent = value;
                _flagCustomEvent = true;
            }
        }
        private LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent _CustomEvent;
        private bool _flagCustomEvent;

        /// <summary>
        /// Returns false as CustomEvent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomEvent()
        {
            return _flagCustomEvent;
        }
        /// <summary>
        /// Gets or Sets LoyaltyTier
        /// </summary>
        [DataMember(Name = "loyalty_tier", EmitDefaultValue = true)]
        public LoyaltiesEarningRulesCreateRequestBodyItemLoyaltyTier LoyaltyTier
        {
            get{ return _LoyaltyTier;}
            set
            {
                _LoyaltyTier = value;
                _flagLoyaltyTier = true;
            }
        }
        private LoyaltiesEarningRulesCreateRequestBodyItemLoyaltyTier _LoyaltyTier;
        private bool _flagLoyaltyTier;

        /// <summary>
        /// Returns false as LoyaltyTier should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLoyaltyTier()
        {
            return _flagLoyaltyTier;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesEarningRulesCreateRequestBodyItem {\n");
            sb.Append("  ValidationRuleId: ").Append(ValidationRuleId).Append("\n");
            sb.Append("  Loyalty: ").Append(Loyalty).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  PendingPoints: ").Append(PendingPoints).Append("\n");
            sb.Append("  ValidityTimeframe: ").Append(ValidityTimeframe).Append("\n");
            sb.Append("  ValidityDayOfWeek: ").Append(ValidityDayOfWeek).Append("\n");
            sb.Append("  ValidityHours: ").Append(ValidityHours).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Segment: ").Append(Segment).Append("\n");
            sb.Append("  CustomEvent: ").Append(CustomEvent).Append("\n");
            sb.Append("  LoyaltyTier: ").Append(LoyaltyTier).Append("\n");
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
