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
    /// Defines the reccuring period(s) when the resource will be active.
    /// </summary>
    [DataContract(Name = "ValidityHoursDailyItem")]
    public partial class ValidityHoursDailyItem : IValidatableObject
    {
        /// <summary>
        /// Defines DaysOfWeek
        /// </summary>
        public enum DaysOfWeekEnum
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
        /// Initializes a new instance of the <see cref="ValidityHoursDailyItem" /> class.
        /// </summary>
        /// <param name="startTime">Defines the starting hour of validity in the HH:mm format. The resource is *inactive before* this time..</param>
        /// <param name="daysOfWeek">Integer array corresponding to the particular days of the week in which the resource is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60;  Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday.</param>
        /// <param name="expirationTime">Defines the ending hour of validity in the HH:mm format. The resource is *inactive after* this time..</param>
        public ValidityHoursDailyItem(string startTime = default(string), List<DaysOfWeekEnum> daysOfWeek = default(List<DaysOfWeekEnum>), string expirationTime = default(string))
        {
            this._StartTime = startTime;
            if (this.StartTime != null)
            {
                this._flagStartTime = true;
            }
            this._DaysOfWeek = daysOfWeek;
            if (this.DaysOfWeek != null)
            {
                this._flagDaysOfWeek = true;
            }
            this._ExpirationTime = expirationTime;
            if (this.ExpirationTime != null)
            {
                this._flagExpirationTime = true;
            }
        }

        /// <summary>
        /// Defines the starting hour of validity in the HH:mm format. The resource is *inactive before* this time.
        /// </summary>
        /// <value>Defines the starting hour of validity in the HH:mm format. The resource is *inactive before* this time.</value>
        /*
        <example>12:00</example>
        */
        [DataMember(Name = "start_time", EmitDefaultValue = true)]
        public string StartTime
        {
            get{ return _StartTime;}
            set
            {
                _StartTime = value;
                _flagStartTime = true;
            }
        }
        private string _StartTime;
        private bool _flagStartTime;

        /// <summary>
        /// Returns false as StartTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartTime()
        {
            return _flagStartTime;
        }
        /// <summary>
        /// Integer array corresponding to the particular days of the week in which the resource is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60;  Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday
        /// </summary>
        /// <value>Integer array corresponding to the particular days of the week in which the resource is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60;  Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday</value>
        [DataMember(Name = "days_of_week", EmitDefaultValue = true)]
        public List<ValidityHoursDailyItem.DaysOfWeekEnum> DaysOfWeek
        {
            get{ return _DaysOfWeek;}
            set
            {
                _DaysOfWeek = value;
                _flagDaysOfWeek = true;
            }
        }
        private List<ValidityHoursDailyItem.DaysOfWeekEnum> _DaysOfWeek;
        private bool _flagDaysOfWeek;

        /// <summary>
        /// Returns false as DaysOfWeek should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDaysOfWeek()
        {
            return _flagDaysOfWeek;
        }
        /// <summary>
        /// Defines the ending hour of validity in the HH:mm format. The resource is *inactive after* this time.
        /// </summary>
        /// <value>Defines the ending hour of validity in the HH:mm format. The resource is *inactive after* this time.</value>
        /*
        <example>14:00</example>
        */
        [DataMember(Name = "expiration_time", EmitDefaultValue = true)]
        public string ExpirationTime
        {
            get{ return _ExpirationTime;}
            set
            {
                _ExpirationTime = value;
                _flagExpirationTime = true;
            }
        }
        private string _ExpirationTime;
        private bool _flagExpirationTime;

        /// <summary>
        /// Returns false as ExpirationTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpirationTime()
        {
            return _flagExpirationTime;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidityHoursDailyItem {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
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
