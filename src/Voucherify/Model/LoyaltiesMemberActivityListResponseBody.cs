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
    /// Response body schema for retrieving member activity.
    /// </summary>
    [DataContract(Name = "LoyaltiesMemberActivityListResponseBody")]
    public partial class LoyaltiesMemberActivityListResponseBody : IValidatableObject
    {
        /// <summary>
        /// The type of the object represented by JSON. This object stores information about member activities in a dictionary.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about member activities in a dictionary.</value>
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
        /// The type of the object represented by JSON. This object stores information about member activities in a dictionary.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about member activities in a dictionary.</value>

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
        /// Initializes a new instance of the <see cref="LoyaltiesMemberActivityListResponseBody" /> class.
        /// </summary>
        /// <param name="varObject">The type of the object represented by JSON. This object stores information about member activities in a dictionary..</param>
        /// <param name="dataRef">Identifies the name of the attribute that contains the array of member activity objects..</param>
        /// <param name="data">Array of member activity objects..</param>
        /// <param name="hasMore">As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request with a &#x60;starting_after_id&#x60; query or a different limit to get more records returned in the results..</param>
        /// <param name="moreStartingAfter">Returns an ID that can be used to return another page of results. Use the event ID in the &#x60;starting_after_id&#x60; query parameter to display another page of the results starting after the event with that ID..</param>
        public LoyaltiesMemberActivityListResponseBody(ObjectEnum? varObject = default(ObjectEnum?), string dataRef = default(string), List<MemberActivity> data = default(List<MemberActivity>), bool? hasMore = default(bool?), string moreStartingAfter = default(string))
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
            this._Data = data;
            if (this.Data != null)
            {
                this._flagData = true;
            }
            this._HasMore = hasMore;
            if (this.HasMore != null)
            {
                this._flagHasMore = true;
            }
            this._MoreStartingAfter = moreStartingAfter;
            if (this.MoreStartingAfter != null)
            {
                this._flagMoreStartingAfter = true;
            }
        }

        /// <summary>
        /// Identifies the name of the attribute that contains the array of member activity objects.
        /// </summary>
        /// <value>Identifies the name of the attribute that contains the array of member activity objects.</value>
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
        /// Array of member activity objects.
        /// </summary>
        /// <value>Array of member activity objects.</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<MemberActivity> Data
        {
            get{ return _Data;}
            set
            {
                _Data = value;
                _flagData = true;
            }
        }
        private List<MemberActivity> _Data;
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
        /// As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request with a &#x60;starting_after_id&#x60; query or a different limit to get more records returned in the results.
        /// </summary>
        /// <value>As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request with a &#x60;starting_after_id&#x60; query or a different limit to get more records returned in the results.</value>
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
        /// Returns an ID that can be used to return another page of results. Use the event ID in the &#x60;starting_after_id&#x60; query parameter to display another page of the results starting after the event with that ID.
        /// </summary>
        /// <value>Returns an ID that can be used to return another page of results. Use the event ID in the &#x60;starting_after_id&#x60; query parameter to display another page of the results starting after the event with that ID.</value>
        [DataMember(Name = "more_starting_after", EmitDefaultValue = true)]
        public string MoreStartingAfter
        {
            get{ return _MoreStartingAfter;}
            set
            {
                _MoreStartingAfter = value;
                _flagMoreStartingAfter = true;
            }
        }
        private string _MoreStartingAfter;
        private bool _flagMoreStartingAfter;

        /// <summary>
        /// Returns false as MoreStartingAfter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMoreStartingAfter()
        {
            return _flagMoreStartingAfter;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesMemberActivityListResponseBody {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  DataRef: ").Append(DataRef).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  MoreStartingAfter: ").Append(MoreStartingAfter).Append("\n");
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
