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
    /// Response body schema for listing publications using **GET** &#x60;v1/publications&#x60;.
    /// </summary>
    [DataContract(Name = "PublicationsListResponseBody")]
    public partial class PublicationsListResponseBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationsListResponseBody" /> class.
        /// </summary>
        /// <param name="varObject">The type of the object represented by JSON. This object stores information about publications in a dictionary..</param>
        /// <param name="dataRef">Identifies the name of the attribute that contains the array of publications..</param>
        /// <param name="publications">Response schema model for publishing vouchers to a specific customer..</param>
        /// <param name="total">Total number of publications..</param>
        public PublicationsListResponseBody(string varObject = default(string), string dataRef = default(string), List<PublicationsListResponseBodyPublicationsItem> publications = default(List<PublicationsListResponseBodyPublicationsItem>), int? total = default(int?))
        {
            this._Object = varObject;
            if (this.Object != null)
            {
                this._flagObject = true;
            }
            this._DataRef = dataRef;
            if (this.DataRef != null)
            {
                this._flagDataRef = true;
            }
            this._Publications = publications;
            if (this.Publications != null)
            {
                this._flagPublications = true;
            }
            this._Total = total;
            if (this.Total != null)
            {
                this._flagTotal = true;
            }
        }

        /// <summary>
        /// The type of the object represented by JSON. This object stores information about publications in a dictionary.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about publications in a dictionary.</value>
        [DataMember(Name = "object", EmitDefaultValue = true)]
        public string Object
        {
            get{ return _Object;}
            set
            {
                _Object = value;
                _flagObject = true;
            }
        }
        private string _Object;
        private bool _flagObject;

        /// <summary>
        /// Returns false as Object should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObject()
        {
            return _flagObject;
        }
        /// <summary>
        /// Identifies the name of the attribute that contains the array of publications.
        /// </summary>
        /// <value>Identifies the name of the attribute that contains the array of publications.</value>
        [DataMember(Name = "data_ref", EmitDefaultValue = true)]
        public string DataRef
        {
            get{ return _DataRef;}
            set
            {
                _DataRef = value;
                _flagDataRef = true;
            }
        }
        private string _DataRef;
        private bool _flagDataRef;

        /// <summary>
        /// Returns false as DataRef should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDataRef()
        {
            return _flagDataRef;
        }
        /// <summary>
        /// Response schema model for publishing vouchers to a specific customer.
        /// </summary>
        /// <value>Response schema model for publishing vouchers to a specific customer.</value>
        [DataMember(Name = "publications", EmitDefaultValue = true)]
        public List<PublicationsListResponseBodyPublicationsItem> Publications
        {
            get{ return _Publications;}
            set
            {
                _Publications = value;
                _flagPublications = true;
            }
        }
        private List<PublicationsListResponseBodyPublicationsItem> _Publications;
        private bool _flagPublications;

        /// <summary>
        /// Returns false as Publications should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePublications()
        {
            return _flagPublications;
        }
        /// <summary>
        /// Total number of publications.
        /// </summary>
        /// <value>Total number of publications.</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public int? Total
        {
            get{ return _Total;}
            set
            {
                _Total = value;
                _flagTotal = true;
            }
        }
        private int? _Total;
        private bool _flagTotal;

        /// <summary>
        /// Returns false as Total should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotal()
        {
            return _flagTotal;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicationsListResponseBody {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  DataRef: ").Append(DataRef).Append("\n");
            sb.Append("  Publications: ").Append(Publications).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
