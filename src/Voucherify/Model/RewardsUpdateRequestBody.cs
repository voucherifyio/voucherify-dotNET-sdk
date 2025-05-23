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
    /// RewardsUpdateRequestBody
    /// </summary>
    [DataContract(Name = "RewardsUpdateRequestBody")]
    public partial class RewardsUpdateRequestBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RewardsUpdateRequestBody" /> class.
        /// </summary>
        /// <param name="name">Reward name..</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="metadata">The metadata object stores all custom attributes assigned to the reward. A set of key/value pairs that you can attach to a reward object. It can be useful for storing additional information about the reward in a structured format..</param>
        /// <param name="stock">The number of units of the product that you want to share as a reward..</param>
        /// <param name="attributes">attributes.</param>
        public RewardsUpdateRequestBody(string name = default(string), RewardsUpdateRequestBodyParameters parameters = default(RewardsUpdateRequestBodyParameters), Object metadata = default(Object), int? stock = default(int?), RewardsUpdateRequestBodyAttributes attributes = default(RewardsUpdateRequestBodyAttributes))
        {
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._Parameters = parameters;
            if (this.Parameters != null)
            {
                this._flagParameters = true;
            }
            this._Metadata = metadata;
            if (this.Metadata != null)
            {
                this._flagMetadata = true;
            }
            this._Stock = stock;
            if (this.Stock != null)
            {
                this._flagStock = true;
            }
            this._Attributes = attributes;
            if (this.Attributes != null)
            {
                this._flagAttributes = true;
            }
        }

        /// <summary>
        /// Reward name.
        /// </summary>
        /// <value>Reward name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name
        {
            get{ return _Name;}
            set
            {
                _Name = value;
                _flagName = true;
            }
        }
        private string _Name;
        private bool _flagName;

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public RewardsUpdateRequestBodyParameters Parameters
        {
            get{ return _Parameters;}
            set
            {
                _Parameters = value;
                _flagParameters = true;
            }
        }
        private RewardsUpdateRequestBodyParameters _Parameters;
        private bool _flagParameters;

        /// <summary>
        /// Returns false as Parameters should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParameters()
        {
            return _flagParameters;
        }
        /// <summary>
        /// The metadata object stores all custom attributes assigned to the reward. A set of key/value pairs that you can attach to a reward object. It can be useful for storing additional information about the reward in a structured format.
        /// </summary>
        /// <value>The metadata object stores all custom attributes assigned to the reward. A set of key/value pairs that you can attach to a reward object. It can be useful for storing additional information about the reward in a structured format.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Object Metadata
        {
            get{ return _Metadata;}
            set
            {
                _Metadata = value;
                _flagMetadata = true;
            }
        }
        private Object _Metadata;
        private bool _flagMetadata;

        /// <summary>
        /// Returns false as Metadata should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetadata()
        {
            return _flagMetadata;
        }
        /// <summary>
        /// The number of units of the product that you want to share as a reward.
        /// </summary>
        /// <value>The number of units of the product that you want to share as a reward.</value>
        [DataMember(Name = "stock", EmitDefaultValue = true)]
        public int? Stock
        {
            get{ return _Stock;}
            set
            {
                _Stock = value;
                _flagStock = true;
            }
        }
        private int? _Stock;
        private bool _flagStock;

        /// <summary>
        /// Returns false as Stock should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStock()
        {
            return _flagStock;
        }
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public RewardsUpdateRequestBodyAttributes Attributes
        {
            get{ return _Attributes;}
            set
            {
                _Attributes = value;
                _flagAttributes = true;
            }
        }
        private RewardsUpdateRequestBodyAttributes _Attributes;
        private bool _flagAttributes;

        /// <summary>
        /// Returns false as Attributes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttributes()
        {
            return _flagAttributes;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RewardsUpdateRequestBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
