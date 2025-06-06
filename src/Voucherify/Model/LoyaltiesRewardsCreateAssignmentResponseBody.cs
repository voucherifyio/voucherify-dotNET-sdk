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
    /// Response body schema for **POST** &#x60;v1/v1/loyalties/{campaignId}/rewards&#x60;.
    /// </summary>
    [DataContract(Name = "LoyaltiesRewardsCreateAssignmentResponseBody")]
    public partial class LoyaltiesRewardsCreateAssignmentResponseBody : IValidatableObject
    {
        /// <summary>
        /// The type of the object represented by the JSON. This object stores information about the reward assignment.
        /// </summary>
        /// <value>The type of the object represented by the JSON. This object stores information about the reward assignment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum RewardAssignment for value: reward_assignment
            /// </summary>
            [EnumMember(Value = "reward_assignment")]
            RewardAssignment = 1
        }


        /// <summary>
        /// The type of the object represented by the JSON. This object stores information about the reward assignment.
        /// </summary>
        /// <value>The type of the object represented by the JSON. This object stores information about the reward assignment.</value>

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
        /// Related object type to which the reward was assigned.
        /// </summary>
        /// <value>Related object type to which the reward was assigned.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelatedObjectTypeEnum
        {
            /// <summary>
            /// Enum Campaign for value: campaign
            /// </summary>
            [EnumMember(Value = "campaign")]
            Campaign = 1
        }


        /// <summary>
        /// Related object type to which the reward was assigned.
        /// </summary>
        /// <value>Related object type to which the reward was assigned.</value>

        [DataMember(Name = "related_object_type", EmitDefaultValue = true)]
        public RelatedObjectTypeEnum? RelatedObjectType
        {
            get{ return _RelatedObjectType;}
            set
            {
                _RelatedObjectType = value;
                _flagRelatedObjectType = true;
            }
        }
        private RelatedObjectTypeEnum? _RelatedObjectType;
        private bool _flagRelatedObjectType;

        /// <summary>
        /// Returns false as RelatedObjectType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRelatedObjectType()
        {
            return _flagRelatedObjectType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltiesRewardsCreateAssignmentResponseBody" /> class.
        /// </summary>
        /// <param name="id">Unique reward assignment ID, assigned by Voucherify..</param>
        /// <param name="rewardId">Associated reward ID..</param>
        /// <param name="createdAt">Timestamp representing the date and time when the reward assignment was created. The value is shown in the ISO 8601 format..</param>
        /// <param name="updatedAt">Timestamp representing the date and time when the reward assignment was updated. The value is shown in the ISO 8601 format..</param>
        /// <param name="varObject">The type of the object represented by the JSON. This object stores information about the reward assignment..</param>
        /// <param name="relatedObjectId">Related object ID to which the reward was assigned..</param>
        /// <param name="relatedObjectType">Related object type to which the reward was assigned..</param>
        /// <param name="parameters">parameters.</param>
        public LoyaltiesRewardsCreateAssignmentResponseBody(string id = default(string), string rewardId = default(string), DateTimeOffset? createdAt = default(DateTimeOffset?), DateTimeOffset? updatedAt = default(DateTimeOffset?), ObjectEnum? varObject = default(ObjectEnum?), string relatedObjectId = default(string), RelatedObjectTypeEnum? relatedObjectType = default(RelatedObjectTypeEnum?), LoyaltiesRewardsCreateAssignmentResponseBodyParameters parameters = default(LoyaltiesRewardsCreateAssignmentResponseBodyParameters))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._RewardId = rewardId;
            if (this.RewardId != null)
            {
                this._flagRewardId = true;
            }
            this._CreatedAt = createdAt;
            if (this.CreatedAt != null)
            {
                this._flagCreatedAt = true;
            }
            this._UpdatedAt = updatedAt;
            if (this.UpdatedAt != null)
            {
                this._flagUpdatedAt = true;
            }
            this._Object = varObject;
            if (this.Object != null)
            {
                this._flagObject = true;
            }
            this._RelatedObjectId = relatedObjectId;
            if (this.RelatedObjectId != null)
            {
                this._flagRelatedObjectId = true;
            }
            this._RelatedObjectType = relatedObjectType;
            if (this.RelatedObjectType != null)
            {
                this._flagRelatedObjectType = true;
            }
            this._Parameters = parameters;
            if (this.Parameters != null)
            {
                this._flagParameters = true;
            }
        }

        /// <summary>
        /// Unique reward assignment ID, assigned by Voucherify.
        /// </summary>
        /// <value>Unique reward assignment ID, assigned by Voucherify.</value>
        /*
        <example>rewa_PbIRoMXpwe5QhobW4JKu0VjH</example>
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
        /// Associated reward ID.
        /// </summary>
        /// <value>Associated reward ID.</value>
        /*
        <example>rew_C7wS9eHFDN4CIbXI5PpLSkGY</example>
        */
        [DataMember(Name = "reward_id", EmitDefaultValue = true)]
        public string RewardId
        {
            get{ return _RewardId;}
            set
            {
                _RewardId = value;
                _flagRewardId = true;
            }
        }
        private string _RewardId;
        private bool _flagRewardId;

        /// <summary>
        /// Returns false as RewardId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRewardId()
        {
            return _flagRewardId;
        }
        /// <summary>
        /// Timestamp representing the date and time when the reward assignment was created. The value is shown in the ISO 8601 format.
        /// </summary>
        /// <value>Timestamp representing the date and time when the reward assignment was created. The value is shown in the ISO 8601 format.</value>
        /*
        <example>2022-08-11T14:49:22.586Z</example>
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
        /// Timestamp representing the date and time when the reward assignment was updated. The value is shown in the ISO 8601 format.
        /// </summary>
        /// <value>Timestamp representing the date and time when the reward assignment was updated. The value is shown in the ISO 8601 format.</value>
        /*
        <example>2022-08-11T16:01:34.885Z</example>
        */
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTimeOffset? UpdatedAt
        {
            get{ return _UpdatedAt;}
            set
            {
                _UpdatedAt = value;
                _flagUpdatedAt = true;
            }
        }
        private DateTimeOffset? _UpdatedAt;
        private bool _flagUpdatedAt;

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return _flagUpdatedAt;
        }
        /// <summary>
        /// Related object ID to which the reward was assigned.
        /// </summary>
        /// <value>Related object ID to which the reward was assigned.</value>
        /*
        <example>camp_wciTvaOfYmAa3EmIIW3QpXXZ</example>
        */
        [DataMember(Name = "related_object_id", EmitDefaultValue = true)]
        public string RelatedObjectId
        {
            get{ return _RelatedObjectId;}
            set
            {
                _RelatedObjectId = value;
                _flagRelatedObjectId = true;
            }
        }
        private string _RelatedObjectId;
        private bool _flagRelatedObjectId;

        /// <summary>
        /// Returns false as RelatedObjectId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRelatedObjectId()
        {
            return _flagRelatedObjectId;
        }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public LoyaltiesRewardsCreateAssignmentResponseBodyParameters Parameters
        {
            get{ return _Parameters;}
            set
            {
                _Parameters = value;
                _flagParameters = true;
            }
        }
        private LoyaltiesRewardsCreateAssignmentResponseBodyParameters _Parameters;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesRewardsCreateAssignmentResponseBody {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RewardId: ").Append(RewardId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  RelatedObjectId: ").Append(RelatedObjectId).Append("\n");
            sb.Append("  RelatedObjectType: ").Append(RelatedObjectType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
