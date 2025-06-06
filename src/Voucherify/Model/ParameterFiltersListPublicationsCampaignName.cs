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
    /// Filter publications by campaign names.
    /// </summary>
    [DataContract(Name = "ParameterFiltersListPublicationsCampaignName")]
    public partial class ParameterFiltersListPublicationsCampaignName : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterFiltersListPublicationsCampaignName" /> class.
        /// </summary>
        /// <param name="conditions">conditions.</param>
        public ParameterFiltersListPublicationsCampaignName(FilterConditionsString conditions = default(FilterConditionsString))
        {
            this._Conditions = conditions;
            if (this.Conditions != null)
            {
                this._flagConditions = true;
            }
        }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", EmitDefaultValue = true)]
        public FilterConditionsString Conditions
        {
            get{ return _Conditions;}
            set
            {
                _Conditions = value;
                _flagConditions = true;
            }
        }
        private FilterConditionsString _Conditions;
        private bool _flagConditions;

        /// <summary>
        /// Returns false as Conditions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConditions()
        {
            return _flagConditions;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParameterFiltersListPublicationsCampaignName {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
