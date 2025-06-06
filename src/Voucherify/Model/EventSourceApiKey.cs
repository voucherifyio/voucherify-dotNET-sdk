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
    /// Determines the API key used to initiate the event.
    /// </summary>
    [DataContract(Name = "EventSourceApiKey")]
    public partial class EventSourceApiKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSourceApiKey" /> class.
        /// </summary>
        /// <param name="name">Channel name in the application keys..</param>
        /// <param name="appId">Contains the application ID from the Voucherify API key pair..</param>
        public EventSourceApiKey(string name = default(string), string appId = default(string))
        {
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._AppId = appId;
            if (this.AppId != null)
            {
                this._flagAppId = true;
            }
        }

        /// <summary>
        /// Channel name in the application keys.
        /// </summary>
        /// <value>Channel name in the application keys.</value>
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
        /// Contains the application ID from the Voucherify API key pair.
        /// </summary>
        /// <value>Contains the application ID from the Voucherify API key pair.</value>
        /*
        <example>1XXXX5XX-0XXX-XXXb-X7XX-XX2XXaXXX6XX</example>
        */
        [DataMember(Name = "app_id", EmitDefaultValue = true)]
        public string AppId
        {
            get{ return _AppId;}
            set
            {
                _AppId = value;
                _flagAppId = true;
            }
        }
        private string _AppId;
        private bool _flagAppId;

        /// <summary>
        /// Returns false as AppId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAppId()
        {
            return _flagAppId;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventSourceApiKey {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
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
