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
    /// This is an object representing a customer with limited properties used in Event Tracking endpoints.
    /// </summary>
    [DataContract(Name = "SimpleCustomerRequiredObjectType")]
    public partial class SimpleCustomerRequiredObjectType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCustomerRequiredObjectType" /> class.
        /// </summary>
        /// <param name="id">The unique ID of a customer that is assigned by Voucherify..</param>
        /// <param name="sourceId">The merchant&#39;s customer ID if it is different from the Voucherify customer ID. It is really useful in case of an integration between multiple systems. It can be a customer ID from a CRM system, database or 3rd-party service..</param>
        /// <param name="name">Customer&#39;s first and last name..</param>
        /// <param name="email">Customer&#39;s email address..</param>
        /// <param name="metadata">A set of custom key/value pairs that you can attach to a customer. The metadata object stores all custom attributes assigned to the customer. It can be useful for storing additional information about the customer in a structured format. This metadata can be used for validating whether the customer qualifies for a discount or it can be used in building customer segments. .</param>
        /// <param name="varObject">The type of the object represented by the JSON. This object stores information about the customer..</param>
        public SimpleCustomerRequiredObjectType(string id = default(string), string sourceId = default(string), string name = default(string), string email = default(string), Object metadata = default(Object), string varObject = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._SourceId = sourceId;
            if (this.SourceId != null)
            {
                this._flagSourceId = true;
            }
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._Email = email;
            if (this.Email != null)
            {
                this._flagEmail = true;
            }
            this._Metadata = metadata;
            if (this.Metadata != null)
            {
                this._flagMetadata = true;
            }
            this._Object = varObject;
            if (this.Object != null)
            {
                this._flagObject = true;
            }
        }

        /// <summary>
        /// The unique ID of a customer that is assigned by Voucherify.
        /// </summary>
        /// <value>The unique ID of a customer that is assigned by Voucherify.</value>
        /*
        <example>cust_CSnYd37MXmrbS19XCrghjBsv</example>
        */
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
        /// The merchant&#39;s customer ID if it is different from the Voucherify customer ID. It is really useful in case of an integration between multiple systems. It can be a customer ID from a CRM system, database or 3rd-party service.
        /// </summary>
        /// <value>The merchant&#39;s customer ID if it is different from the Voucherify customer ID. It is really useful in case of an integration between multiple systems. It can be a customer ID from a CRM system, database or 3rd-party service.</value>
        [DataMember(Name = "source_id", EmitDefaultValue = true)]
        public string SourceId
        {
            get{ return _SourceId;}
            set
            {
                _SourceId = value;
                _flagSourceId = true;
            }
        }
        private string _SourceId;
        private bool _flagSourceId;

        /// <summary>
        /// Returns false as SourceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSourceId()
        {
            return _flagSourceId;
        }
        /// <summary>
        /// Customer&#39;s first and last name.
        /// </summary>
        /// <value>Customer&#39;s first and last name.</value>
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
        /// Customer&#39;s email address.
        /// </summary>
        /// <value>Customer&#39;s email address.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email
        {
            get{ return _Email;}
            set
            {
                _Email = value;
                _flagEmail = true;
            }
        }
        private string _Email;
        private bool _flagEmail;

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return _flagEmail;
        }
        /// <summary>
        /// A set of custom key/value pairs that you can attach to a customer. The metadata object stores all custom attributes assigned to the customer. It can be useful for storing additional information about the customer in a structured format. This metadata can be used for validating whether the customer qualifies for a discount or it can be used in building customer segments. 
        /// </summary>
        /// <value>A set of custom key/value pairs that you can attach to a customer. The metadata object stores all custom attributes assigned to the customer. It can be useful for storing additional information about the customer in a structured format. This metadata can be used for validating whether the customer qualifies for a discount or it can be used in building customer segments. </value>
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
        /// The type of the object represented by the JSON. This object stores information about the customer.
        /// </summary>
        /// <value>The type of the object represented by the JSON. This object stores information about the customer.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimpleCustomerRequiredObjectType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
