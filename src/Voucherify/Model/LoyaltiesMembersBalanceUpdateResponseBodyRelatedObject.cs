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
    /// Defines the object that is being modified with the values that are returned in the balance object.
    /// </summary>
    [DataContract(Name = "LoyaltiesMembersBalanceUpdateResponseBodyRelatedObject")]
    public partial class LoyaltiesMembersBalanceUpdateResponseBodyRelatedObject : IValidatableObject
    {
        /// <summary>
        /// The object being modified.
        /// </summary>
        /// <value>The object being modified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Voucher for value: voucher
            /// </summary>
            [EnumMember(Value = "voucher")]
            Voucher = 1
        }


        /// <summary>
        /// The object being modified.
        /// </summary>
        /// <value>The object being modified.</value>

        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type
        {
            get{ return _Type;}
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private TypeEnum? _Type;
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
        /// Initializes a new instance of the <see cref="LoyaltiesMembersBalanceUpdateResponseBodyRelatedObject" /> class.
        /// </summary>
        /// <param name="type">The object being modified..</param>
        /// <param name="id">Identifies the loyalty card that is being modified, this is the ID that was assigned by the Voucherify API..</param>
        public LoyaltiesMembersBalanceUpdateResponseBodyRelatedObject(TypeEnum? type = default(TypeEnum?), string id = default(string))
        {
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
        }

        /// <summary>
        /// Identifies the loyalty card that is being modified, this is the ID that was assigned by the Voucherify API.
        /// </summary>
        /// <value>Identifies the loyalty card that is being modified, this is the ID that was assigned by the Voucherify API.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id
        {
            get{ return _Id;}
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private string _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesMembersBalanceUpdateResponseBodyRelatedObject {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
