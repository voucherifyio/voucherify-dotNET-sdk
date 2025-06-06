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
    /// Defines the configuration for pending points. Pending points can be used only with the &#x60;order.paid&#x60; event.
    /// </summary>
    [DataContract(Name = "LoyaltiesEarningRulesGetResponseBodyPendingPoints")]
    public partial class LoyaltiesEarningRulesGetResponseBodyPendingPoints : IValidatableObject
    {
        /// <summary>
        /// Defines the type of the period during which the points are in the pending state. Currently, only &#x60;DAY&#x60; value is accepted.
        /// </summary>
        /// <value>Defines the type of the period during which the points are in the pending state. Currently, only &#x60;DAY&#x60; value is accepted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodTypeEnum
        {
            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            [EnumMember(Value = "DAY")]
            DAY = 1
        }


        /// <summary>
        /// Defines the type of the period during which the points are in the pending state. Currently, only &#x60;DAY&#x60; value is accepted.
        /// </summary>
        /// <value>Defines the type of the period during which the points are in the pending state. Currently, only &#x60;DAY&#x60; value is accepted.</value>

        [DataMember(Name = "period_type", EmitDefaultValue = true)]
        public PeriodTypeEnum? PeriodType
        {
            get{ return _PeriodType;}
            set
            {
                _PeriodType = value;
                _flagPeriodType = true;
            }
        }
        private PeriodTypeEnum? _PeriodType;
        private bool _flagPeriodType;

        /// <summary>
        /// Returns false as PeriodType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePeriodType()
        {
            return _flagPeriodType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltiesEarningRulesGetResponseBodyPendingPoints" /> class.
        /// </summary>
        /// <param name="periodType">Defines the type of the period during which the points are in the pending state. Currently, only &#x60;DAY&#x60; value is accepted..</param>
        /// <param name="periodValue">Defines for how long the points are in the pending state. The minimum value is 1, maximum is 90..</param>
        public LoyaltiesEarningRulesGetResponseBodyPendingPoints(PeriodTypeEnum? periodType = default(PeriodTypeEnum?), int? periodValue = default(int?))
        {
            this._PeriodType = periodType;
            if (this.PeriodType != null)
            {
                this._flagPeriodType = true;
            }
            this._PeriodValue = periodValue;
            if (this.PeriodValue != null)
            {
                this._flagPeriodValue = true;
            }
        }

        /// <summary>
        /// Defines for how long the points are in the pending state. The minimum value is 1, maximum is 90.
        /// </summary>
        /// <value>Defines for how long the points are in the pending state. The minimum value is 1, maximum is 90.</value>
        [DataMember(Name = "period_value", EmitDefaultValue = true)]
        public int? PeriodValue
        {
            get{ return _PeriodValue;}
            set
            {
                _PeriodValue = value;
                _flagPeriodValue = true;
            }
        }
        private int? _PeriodValue;
        private bool _flagPeriodValue;

        /// <summary>
        /// Returns false as PeriodValue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePeriodValue()
        {
            return _flagPeriodValue;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesEarningRulesGetResponseBodyPendingPoints {\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  PeriodValue: ").Append(PeriodValue).Append("\n");
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
            // PeriodValue (int?) maximum
            if (this.PeriodValue > (int?)90)
            {
                yield return new ValidationResult("Invalid value for PeriodValue, must be a value less than or equal to 90.", new [] { "PeriodValue" });
            }

            // PeriodValue (int?) minimum
            if (this.PeriodValue < (int?)1)
            {
                yield return new ValidationResult("Invalid value for PeriodValue, must be a value greater than or equal to 1.", new [] { "PeriodValue" });
            }

            yield break;
        }
    }

}
