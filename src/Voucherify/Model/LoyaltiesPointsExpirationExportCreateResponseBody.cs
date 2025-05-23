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
    /// Object representing an export of points expirations. 
    /// </summary>
    [DataContract(Name = "LoyaltiesPointsExpirationExportCreateResponseBody")]
    public partial class LoyaltiesPointsExpirationExportCreateResponseBody : IValidatableObject
    {
        /// <summary>
        /// The type of object being represented. This object stores information about the export.
        /// </summary>
        /// <value>The type of object being represented. This object stores information about the export.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Export for value: export
            /// </summary>
            [EnumMember(Value = "export")]
            Export = 1
        }


        /// <summary>
        /// The type of object being represented. This object stores information about the export.
        /// </summary>
        /// <value>The type of object being represented. This object stores information about the export.</value>

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
        /// Status of the export. Informs you whether the export has already been completed.
        /// </summary>
        /// <value>Status of the export. Informs you whether the export has already been completed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            SCHEDULED = 1
        }


        /// <summary>
        /// Status of the export. Informs you whether the export has already been completed.
        /// </summary>
        /// <value>Status of the export. Informs you whether the export has already been completed.</value>

        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status
        {
            get{ return _Status;}
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private StatusEnum? _Status;
        private bool _flagStatus;

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return _flagStatus;
        }
        /// <summary>
        /// The channel through which the export was triggered.
        /// </summary>
        /// <value>The channel through which the export was triggered.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum API for value: API
            /// </summary>
            [EnumMember(Value = "API")]
            API = 1,

            /// <summary>
            /// Enum WEBSITE for value: WEBSITE
            /// </summary>
            [EnumMember(Value = "WEBSITE")]
            WEBSITE = 2
        }


        /// <summary>
        /// The channel through which the export was triggered.
        /// </summary>
        /// <value>The channel through which the export was triggered.</value>

        [DataMember(Name = "channel", EmitDefaultValue = true)]
        public ChannelEnum? Channel
        {
            get{ return _Channel;}
            set
            {
                _Channel = value;
                _flagChannel = true;
            }
        }
        private ChannelEnum? _Channel;
        private bool _flagChannel;

        /// <summary>
        /// Returns false as Channel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChannel()
        {
            return _flagChannel;
        }
        /// <summary>
        /// The type of exported object.
        /// </summary>
        /// <value>The type of exported object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportedObjectEnum
        {
            /// <summary>
            /// Enum PointsExpiration for value: points_expiration
            /// </summary>
            [EnumMember(Value = "points_expiration")]
            PointsExpiration = 1
        }


        /// <summary>
        /// The type of exported object.
        /// </summary>
        /// <value>The type of exported object.</value>

        [DataMember(Name = "exported_object", EmitDefaultValue = true)]
        public ExportedObjectEnum? ExportedObject
        {
            get{ return _ExportedObject;}
            set
            {
                _ExportedObject = value;
                _flagExportedObject = true;
            }
        }
        private ExportedObjectEnum? _ExportedObject;
        private bool _flagExportedObject;

        /// <summary>
        /// Returns false as ExportedObject should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExportedObject()
        {
            return _flagExportedObject;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltiesPointsExpirationExportCreateResponseBody" /> class.
        /// </summary>
        /// <param name="id">Unique export ID..</param>
        /// <param name="varObject">The type of object being represented. This object stores information about the export..</param>
        /// <param name="createdAt">Timestamp representing the date and time when the export was scheduled in ISO 8601 format..</param>
        /// <param name="status">Status of the export. Informs you whether the export has already been completed..</param>
        /// <param name="channel">The channel through which the export was triggered..</param>
        /// <param name="exportedObject">The type of exported object..</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="result">Always null..</param>
        /// <param name="userId">&#x60;user_id&#x60; identifies the specific user who initiated the export through the Voucherify Dashboard. &#x60;user_id&#x60; is returned when the channel value is &#x60;WEBSITE&#x60;..</param>
        public LoyaltiesPointsExpirationExportCreateResponseBody(string id = default(string), ObjectEnum? varObject = default(ObjectEnum?), DateTimeOffset? createdAt = default(DateTimeOffset?), StatusEnum? status = default(StatusEnum?), ChannelEnum? channel = default(ChannelEnum?), ExportedObjectEnum? exportedObject = default(ExportedObjectEnum?), LoyaltiesPointsExpirationExportCreateResponseBodyParameters parameters = default(LoyaltiesPointsExpirationExportCreateResponseBodyParameters), Object result = default(Object), string userId = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Object = varObject;
            if (this.Object != null)
            {
                this._flagObject = true;
            }
            this._CreatedAt = createdAt;
            if (this.CreatedAt != null)
            {
                this._flagCreatedAt = true;
            }
            this._Status = status;
            if (this.Status != null)
            {
                this._flagStatus = true;
            }
            this._Channel = channel;
            if (this.Channel != null)
            {
                this._flagChannel = true;
            }
            this._ExportedObject = exportedObject;
            if (this.ExportedObject != null)
            {
                this._flagExportedObject = true;
            }
            this._Parameters = parameters;
            if (this.Parameters != null)
            {
                this._flagParameters = true;
            }
            this._Result = result;
            if (this.Result != null)
            {
                this._flagResult = true;
            }
            this._UserId = userId;
            if (this.UserId != null)
            {
                this._flagUserId = true;
            }
        }

        /// <summary>
        /// Unique export ID.
        /// </summary>
        /// <value>Unique export ID.</value>
        /*
        <example>exp_FFfp9o7daWuJqJCKp5xqqli4</example>
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
        /// Timestamp representing the date and time when the export was scheduled in ISO 8601 format.
        /// </summary>
        /// <value>Timestamp representing the date and time when the export was scheduled in ISO 8601 format.</value>
        /*
        <example>2022-04-28T11:23:20.922Z</example>
        */
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTimeOffset? CreatedAt
        {
            get{ return _CreatedAt;}
            set
            {
                _CreatedAt = value;
                _flagCreatedAt = true;
            }
        }
        private DateTimeOffset? _CreatedAt;
        private bool _flagCreatedAt;

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return _flagCreatedAt;
        }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public LoyaltiesPointsExpirationExportCreateResponseBodyParameters Parameters
        {
            get{ return _Parameters;}
            set
            {
                _Parameters = value;
                _flagParameters = true;
            }
        }
        private LoyaltiesPointsExpirationExportCreateResponseBodyParameters _Parameters;
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
        /// Always null.
        /// </summary>
        /// <value>Always null.</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public Object Result
        {
            get{ return _Result;}
            set
            {
                _Result = value;
                _flagResult = true;
            }
        }
        private Object _Result;
        private bool _flagResult;

        /// <summary>
        /// Returns false as Result should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResult()
        {
            return _flagResult;
        }
        /// <summary>
        /// &#x60;user_id&#x60; identifies the specific user who initiated the export through the Voucherify Dashboard. &#x60;user_id&#x60; is returned when the channel value is &#x60;WEBSITE&#x60;.
        /// </summary>
        /// <value>&#x60;user_id&#x60; identifies the specific user who initiated the export through the Voucherify Dashboard. &#x60;user_id&#x60; is returned when the channel value is &#x60;WEBSITE&#x60;.</value>
        /*
        <example>user_g24UoRO3Caxu7FCT4n5tpYEa3zUG0Fr</example>
        */
        [DataMember(Name = "user_id", EmitDefaultValue = true)]
        public string UserId
        {
            get{ return _UserId;}
            set
            {
                _UserId = value;
                _flagUserId = true;
            }
        }
        private string _UserId;
        private bool _flagUserId;

        /// <summary>
        /// Returns false as UserId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserId()
        {
            return _flagUserId;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesPointsExpirationExportCreateResponseBody {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  ExportedObject: ").Append(ExportedObject).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
