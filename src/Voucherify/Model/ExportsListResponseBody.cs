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
    /// Response body schema for **GET** &#x60;v1/exports&#x60;.
    /// </summary>
    [DataContract(Name = "ExportsListResponseBody")]
    public partial class ExportsListResponseBody : IValidatableObject
    {
        /// <summary>
        /// The type of the object represented by JSON. This object stores information about exports.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about exports.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum List for value: list
            /// </summary>
            [EnumMember(Value = "list")]
            List = 1
        }


        /// <summary>
        /// The type of the object represented by JSON. This object stores information about exports.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about exports.</value>

        [DataMember(Name = "object", EmitDefaultValue = true)]
        public ObjectEnum? Object
        {
            get{ return _Object;}
            set
            {
                _Object = value;
                _flagObject = true;
            }
        }
        private ObjectEnum? _Object;
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
        /// Identifies the name of the attribute that contains the array of exports.
        /// </summary>
        /// <value>Identifies the name of the attribute that contains the array of exports.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataRefEnum
        {
            /// <summary>
            /// Enum Exports for value: exports
            /// </summary>
            [EnumMember(Value = "exports")]
            Exports = 1
        }


        /// <summary>
        /// Identifies the name of the attribute that contains the array of exports.
        /// </summary>
        /// <value>Identifies the name of the attribute that contains the array of exports.</value>

        [DataMember(Name = "data_ref", EmitDefaultValue = true)]
        public DataRefEnum? DataRef
        {
            get{ return _DataRef;}
            set
            {
                _DataRef = value;
                _flagDataRef = true;
            }
        }
        private DataRefEnum? _DataRef;
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
        /// Initializes a new instance of the <see cref="ExportsListResponseBody" /> class.
        /// </summary>
        /// <param name="varObject">The type of the object represented by JSON. This object stores information about exports..</param>
        /// <param name="dataRef">Identifies the name of the attribute that contains the array of exports..</param>
        /// <param name="exports">An array of export objects..</param>
        /// <param name="total">Total number of exports..</param>
        public ExportsListResponseBody(ObjectEnum? varObject = default(ObjectEnum?), DataRefEnum? dataRef = default(DataRefEnum?), List<Export> exports = default(List<Export>), int? total = default(int?))
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
            this._Exports = exports;
            if (this.Exports != null)
            {
                this._flagExports = true;
            }
            this._Total = total;
            if (this.Total != null)
            {
                this._flagTotal = true;
            }
        }

        /// <summary>
        /// An array of export objects.
        /// </summary>
        /// <value>An array of export objects.</value>
        [DataMember(Name = "exports", EmitDefaultValue = true)]
        public List<Export> Exports
        {
            get{ return _Exports;}
            set
            {
                _Exports = value;
                _flagExports = true;
            }
        }
        private List<Export> _Exports;
        private bool _flagExports;

        /// <summary>
        /// Returns false as Exports should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExports()
        {
            return _flagExports;
        }
        /// <summary>
        /// Total number of exports.
        /// </summary>
        /// <value>Total number of exports.</value>
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
            sb.Append("class ExportsListResponseBody {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  DataRef: ").Append(DataRef).Append("\n");
            sb.Append("  Exports: ").Append(Exports).Append("\n");
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
