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
    /// ApplicableToResultList
    /// </summary>
    [DataContract(Name = "ApplicableToResultList")]
    public partial class ApplicableToResultList : IValidatableObject
    {
        /// <summary>
        /// The type of the object represented by JSON.
        /// </summary>
        /// <value>The type of the object represented by JSON.</value>
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
        /// The type of the object represented by JSON.
        /// </summary>
        /// <value>The type of the object represented by JSON.</value>

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
        /// The type of the object represented by JSON.
        /// </summary>
        /// <value>The type of the object represented by JSON.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataRefEnum
        {
            /// <summary>
            /// Enum Data for value: data
            /// </summary>
            [EnumMember(Value = "data")]
            Data = 1
        }


        /// <summary>
        /// The type of the object represented by JSON.
        /// </summary>
        /// <value>The type of the object represented by JSON.</value>

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
        /// Initializes a new instance of the <see cref="ApplicableToResultList" /> class.
        /// </summary>
        /// <param name="data">Contains array of items to which the discount can apply..</param>
        /// <param name="total">Total number of objects defining included products, SKUs, or product collections..</param>
        /// <param name="varObject">The type of the object represented by JSON..</param>
        /// <param name="dataRef">The type of the object represented by JSON..</param>
        public ApplicableToResultList(List<ApplicableTo> data = default(List<ApplicableTo>), int? total = default(int?), ObjectEnum? varObject = default(ObjectEnum?), DataRefEnum? dataRef = default(DataRefEnum?))
        {
            this._Data = data;
            if (this.Data != null)
            {
                this._flagData = true;
            }
            this._Total = total;
            if (this.Total != null)
            {
                this._flagTotal = true;
            }
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
        }

        /// <summary>
        /// Contains array of items to which the discount can apply.
        /// </summary>
        /// <value>Contains array of items to which the discount can apply.</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<ApplicableTo> Data
        {
            get{ return _Data;}
            set
            {
                _Data = value;
                _flagData = true;
            }
        }
        private List<ApplicableTo> _Data;
        private bool _flagData;

        /// <summary>
        /// Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return _flagData;
        }
        /// <summary>
        /// Total number of objects defining included products, SKUs, or product collections.
        /// </summary>
        /// <value>Total number of objects defining included products, SKUs, or product collections.</value>
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
            sb.Append("class ApplicableToResultList {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  DataRef: ").Append(DataRef).Append("\n");
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
            // Total (int?) minimum
            if (this.Total < (int?)0)
            {
                yield return new ValidationResult("Invalid value for Total, must be a value greater than or equal to 0.", new [] { "Total" });
            }

            yield break;
        }
    }

}
