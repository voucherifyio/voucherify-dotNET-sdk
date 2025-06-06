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
    /// Provides details about the reason why the redeemable is skipped.
    /// </summary>
    [DataContract(Name = "ValidationsRedeemableSkippedResult")]
    public partial class ValidationsRedeemableSkippedResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationsRedeemableSkippedResult" /> class.
        /// </summary>
        /// <param name="details">details.</param>
        public ValidationsRedeemableSkippedResult(ValidationsRedeemableSkippedResultDetails details = default(ValidationsRedeemableSkippedResultDetails))
        {
            this._Details = details;
            if (this.Details != null)
            {
                this._flagDetails = true;
            }
        }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public ValidationsRedeemableSkippedResultDetails Details
        {
            get{ return _Details;}
            set
            {
                _Details = value;
                _flagDetails = true;
            }
        }
        private ValidationsRedeemableSkippedResultDetails _Details;
        private bool _flagDetails;

        /// <summary>
        /// Returns false as Details should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDetails()
        {
            return _flagDetails;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidationsRedeemableSkippedResult {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
