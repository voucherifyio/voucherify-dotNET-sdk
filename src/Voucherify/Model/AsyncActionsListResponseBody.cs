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
    /// Response body schema for **GET** &#x60;v1/async-actions&#x60;.
    /// </summary>
    [DataContract(Name = "AsyncActionsListResponseBody")]
    public partial class AsyncActionsListResponseBody : IValidatableObject
    {
        /// <summary>
        /// The type of the object represented by JSON. This object stores information about asynchronous actions.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about asynchronous actions.</value>
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
        /// The type of the object represented by JSON. This object stores information about asynchronous actions.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about asynchronous actions.</value>

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
        /// Identifies the name of the JSON property that contains the array of asynchronous actions.
        /// </summary>
        /// <value>Identifies the name of the JSON property that contains the array of asynchronous actions.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataRefEnum
        {
            /// <summary>
            /// Enum AsyncActions for value: async_actions
            /// </summary>
            [EnumMember(Value = "async_actions")]
            AsyncActions = 1
        }


        /// <summary>
        /// Identifies the name of the JSON property that contains the array of asynchronous actions.
        /// </summary>
        /// <value>Identifies the name of the JSON property that contains the array of asynchronous actions.</value>

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
        /// Initializes a new instance of the <see cref="AsyncActionsListResponseBody" /> class.
        /// </summary>
        /// <param name="varObject">The type of the object represented by JSON. This object stores information about asynchronous actions..</param>
        /// <param name="dataRef">Identifies the name of the JSON property that contains the array of asynchronous actions..</param>
        /// <param name="asyncActions">asyncActions.</param>
        /// <param name="hasMore">As query results are always limited by parameters, the &#x60;has_more&#x60; flag indicates if there are more records available. This lets you know if you can run another request to get more records returned in the results..</param>
        public AsyncActionsListResponseBody(ObjectEnum? varObject = default(ObjectEnum?), DataRefEnum? dataRef = default(DataRefEnum?), List<AsyncActionBase> asyncActions = default(List<AsyncActionBase>), bool? hasMore = default(bool?))
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
            this._AsyncActions = asyncActions;
            if (this.AsyncActions != null)
            {
                this._flagAsyncActions = true;
            }
            this._HasMore = hasMore;
            if (this.HasMore != null)
            {
                this._flagHasMore = true;
            }
        }

        /// <summary>
        /// Gets or Sets AsyncActions
        /// </summary>
        [DataMember(Name = "async_actions", EmitDefaultValue = true)]
        public List<AsyncActionBase> AsyncActions
        {
            get{ return _AsyncActions;}
            set
            {
                _AsyncActions = value;
                _flagAsyncActions = true;
            }
        }
        private List<AsyncActionBase> _AsyncActions;
        private bool _flagAsyncActions;

        /// <summary>
        /// Returns false as AsyncActions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAsyncActions()
        {
            return _flagAsyncActions;
        }
        /// <summary>
        /// As query results are always limited by parameters, the &#x60;has_more&#x60; flag indicates if there are more records available. This lets you know if you can run another request to get more records returned in the results.
        /// </summary>
        /// <value>As query results are always limited by parameters, the &#x60;has_more&#x60; flag indicates if there are more records available. This lets you know if you can run another request to get more records returned in the results.</value>
        [DataMember(Name = "has_more", EmitDefaultValue = true)]
        public bool? HasMore
        {
            get{ return _HasMore;}
            set
            {
                _HasMore = value;
                _flagHasMore = true;
            }
        }
        private bool? _HasMore;
        private bool _flagHasMore;

        /// <summary>
        /// Returns false as HasMore should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasMore()
        {
            return _flagHasMore;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AsyncActionsListResponseBody {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  DataRef: ").Append(DataRef).Append("\n");
            sb.Append("  AsyncActions: ").Append(AsyncActions).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
