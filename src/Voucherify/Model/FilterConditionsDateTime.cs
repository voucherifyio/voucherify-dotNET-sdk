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
    /// Data filters used to narrow down the data records to be returned in the result.
    /// </summary>
    [DataContract(Name = "FilterConditionsDateTime")]
    public partial class FilterConditionsDateTime : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterConditionsDateTime" /> class.
        /// </summary>
        /// <param name="after">Value is after this date. The value for this parameter is shown in the ISO 8601 format..</param>
        /// <param name="before">Value is before this date. The value for this parameter is shown in the ISO 8601 format..</param>
        /// <param name="hasValue">Value is NOT null. The value for this parameter is an empty string..</param>
        /// <param name="isUnknown">Value is null. The value for this parameter is an empty string..</param>
        /// <param name="moreThan">Value is more days ago before the current date and time, e.g. more than &#x60;10&#x60; days ago..</param>
        /// <param name="lessThan">Value is less days before the current date and time, e.g. less than &#x60;10&#x60; days ago..</param>
        public FilterConditionsDateTime(DateTimeOffset? after = default(DateTimeOffset?), DateTimeOffset? before = default(DateTimeOffset?), string hasValue = default(string), string isUnknown = default(string), int? moreThan = default(int?), int? lessThan = default(int?))
        {
            this._After = after;
            if (this.After != null)
            {
                this._flagAfter = true;
            }
            this._Before = before;
            if (this.Before != null)
            {
                this._flagBefore = true;
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
            this._MoreThan = moreThan;
            if (this.MoreThan != null)
            {
                this._flagMoreThan = true;
            }
            this._LessThan = lessThan;
            if (this.LessThan != null)
            {
                this._flagLessThan = true;
            }
        }

        /// <summary>
        /// Value is after this date. The value for this parameter is shown in the ISO 8601 format.
        /// </summary>
        /// <value>Value is after this date. The value for this parameter is shown in the ISO 8601 format.</value>
        /*
        <example>2024-01-01T00:00Z</example>
        */
        [DataMember(Name = "$after", EmitDefaultValue = true)]
        public DateTimeOffset? After
        {
            get{ return _After;}
            set
            {
                _After = value;
                _flagAfter = true;
            }
        }
        private DateTimeOffset? _After;
        private bool _flagAfter;

        /// <summary>
        /// Returns false as After should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAfter()
        {
            return _flagAfter;
        }
        /// <summary>
        /// Value is before this date. The value for this parameter is shown in the ISO 8601 format.
        /// </summary>
        /// <value>Value is before this date. The value for this parameter is shown in the ISO 8601 format.</value>
        /*
        <example>2024-01-01T00:00Z</example>
        */
        [DataMember(Name = "$before", EmitDefaultValue = true)]
        public DateTimeOffset? Before
        {
            get{ return _Before;}
            set
            {
                _Before = value;
                _flagBefore = true;
            }
        }
        private DateTimeOffset? _Before;
        private bool _flagBefore;

        /// <summary>
        /// Returns false as Before should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBefore()
        {
            return _flagBefore;
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
        /// Value is more days ago before the current date and time, e.g. more than &#x60;10&#x60; days ago.
        /// </summary>
        /// <value>Value is more days ago before the current date and time, e.g. more than &#x60;10&#x60; days ago.</value>
        [DataMember(Name = "$more_than", EmitDefaultValue = true)]
        public int? MoreThan
        {
            get{ return _MoreThan;}
            set
            {
                _MoreThan = value;
                _flagMoreThan = true;
            }
        }
        private int? _MoreThan;
        private bool _flagMoreThan;

        /// <summary>
        /// Returns false as MoreThan should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMoreThan()
        {
            return _flagMoreThan;
        }
        /// <summary>
        /// Value is less days before the current date and time, e.g. less than &#x60;10&#x60; days ago.
        /// </summary>
        /// <value>Value is less days before the current date and time, e.g. less than &#x60;10&#x60; days ago.</value>
        [DataMember(Name = "$less_than", EmitDefaultValue = true)]
        public int? LessThan
        {
            get{ return _LessThan;}
            set
            {
                _LessThan = value;
                _flagLessThan = true;
            }
        }
        private int? _LessThan;
        private bool _flagLessThan;

        /// <summary>
        /// Returns false as LessThan should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLessThan()
        {
            return _flagLessThan;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilterConditionsDateTime {\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
            sb.Append("  HasValue: ").Append(HasValue).Append("\n");
            sb.Append("  IsUnknown: ").Append(IsUnknown).Append("\n");
            sb.Append("  MoreThan: ").Append(MoreThan).Append("\n");
            sb.Append("  LessThan: ").Append(LessThan).Append("\n");
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
