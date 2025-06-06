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
    /// Contains the schema id of a custom event. **Required** for the custom event option in &#x60;event&#x60;.
    /// </summary>
    [DataContract(Name = "LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent")]
    public partial class LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent" /> class.
        /// </summary>
        /// <param name="schemaId">Contains a unique identifier of a custom event schema. Assigned by the Voucherify API..</param>
        public LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent(string schemaId = default(string))
        {
            this._SchemaId = schemaId;
            if (this.SchemaId != null)
            {
                this._flagSchemaId = true;
            }
        }

        /// <summary>
        /// Contains a unique identifier of a custom event schema. Assigned by the Voucherify API.
        /// </summary>
        /// <value>Contains a unique identifier of a custom event schema. Assigned by the Voucherify API.</value>
        /*
        <example>ms_gn4Qe4xsFPf7orCArCiNVY13</example>
        */
        [DataMember(Name = "schema_id", EmitDefaultValue = true)]
        public string SchemaId
        {
            get{ return _SchemaId;}
            set
            {
                _SchemaId = value;
                _flagSchemaId = true;
            }
        }
        private string _SchemaId;
        private bool _flagSchemaId;

        /// <summary>
        /// Returns false as SchemaId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSchemaId()
        {
            return _flagSchemaId;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesEarningRulesCreateRequestBodyItemCustomEvent {\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
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
