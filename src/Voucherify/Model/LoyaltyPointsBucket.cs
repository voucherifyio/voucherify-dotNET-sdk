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
    /// Contains the details about expiring loyalty points.
    /// </summary>
    [DataContract(Name = "LoyaltyPointsBucket")]
    public partial class LoyaltyPointsBucket : IValidatableObject
    {
        /// <summary>
        /// The type of the object represented by JSON. This object stores information about the loyalty point bucket.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about the loyalty point bucket.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum LoyaltyPointsBucket for value: loyalty_points_bucket
            /// </summary>
            [EnumMember(Value = "loyalty_points_bucket")]
            LoyaltyPointsBucket = 1
        }


        /// <summary>
        /// The type of the object represented by JSON. This object stores information about the loyalty point bucket.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about the loyalty point bucket.</value>

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
        /// Initializes a new instance of the <see cref="LoyaltyPointsBucket" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the loyalty points bucket..</param>
        /// <param name="voucherId">Unique identifier of the parent loyalty card..</param>
        /// <param name="campaignId">Unique identifier of the parent campaign..</param>
        /// <param name="bucket">bucket.</param>
        /// <param name="status">Loyalty point point bucket status..</param>
        /// <param name="expiresAt">Date when the number of points defined in the bucket object are due to expire..</param>
        /// <param name="createdAt">Timestamp representing the date and time when the loyalty point bucket object was created in ISO 8601 format..</param>
        /// <param name="updatedAt">Timestamp representing the date and time when the loyalty point bucket object was updated in ISO 8601 format..</param>
        /// <param name="varObject">The type of the object represented by JSON. This object stores information about the loyalty point bucket..</param>
        public LoyaltyPointsBucket(string id = default(string), string voucherId = default(string), string campaignId = default(string), LoyaltyPointsBucketBucket bucket = default(LoyaltyPointsBucketBucket), string status = default(string), DateTime? expiresAt = default(DateTime?), DateTimeOffset? createdAt = default(DateTimeOffset?), DateTimeOffset? updatedAt = default(DateTimeOffset?), ObjectEnum? varObject = default(ObjectEnum?))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._VoucherId = voucherId;
            if (this.VoucherId != null)
            {
                this._flagVoucherId = true;
            }
            this._CampaignId = campaignId;
            if (this.CampaignId != null)
            {
                this._flagCampaignId = true;
            }
            this._Bucket = bucket;
            if (this.Bucket != null)
            {
                this._flagBucket = true;
            }
            this._Status = status;
            if (this.Status != null)
            {
                this._flagStatus = true;
            }
            this._ExpiresAt = expiresAt;
            if (this.ExpiresAt != null)
            {
                this._flagExpiresAt = true;
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
        }

        /// <summary>
        /// Unique identifier of the loyalty points bucket.
        /// </summary>
        /// <value>Unique identifier of the loyalty points bucket.</value>
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
        /// Unique identifier of the parent loyalty card.
        /// </summary>
        /// <value>Unique identifier of the parent loyalty card.</value>
        [DataMember(Name = "voucher_id", EmitDefaultValue = true)]
        public string VoucherId
        {
            get{ return _VoucherId;}
            set
            {
                _VoucherId = value;
                _flagVoucherId = true;
            }
        }
        private string _VoucherId;
        private bool _flagVoucherId;

        /// <summary>
        /// Returns false as VoucherId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVoucherId()
        {
            return _flagVoucherId;
        }
        /// <summary>
        /// Unique identifier of the parent campaign.
        /// </summary>
        /// <value>Unique identifier of the parent campaign.</value>
        [DataMember(Name = "campaign_id", EmitDefaultValue = true)]
        public string CampaignId
        {
            get{ return _CampaignId;}
            set
            {
                _CampaignId = value;
                _flagCampaignId = true;
            }
        }
        private string _CampaignId;
        private bool _flagCampaignId;

        /// <summary>
        /// Returns false as CampaignId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCampaignId()
        {
            return _flagCampaignId;
        }
        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name = "bucket", EmitDefaultValue = true)]
        public LoyaltyPointsBucketBucket Bucket
        {
            get{ return _Bucket;}
            set
            {
                _Bucket = value;
                _flagBucket = true;
            }
        }
        private LoyaltyPointsBucketBucket _Bucket;
        private bool _flagBucket;

        /// <summary>
        /// Returns false as Bucket should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBucket()
        {
            return _flagBucket;
        }
        /// <summary>
        /// Loyalty point point bucket status.
        /// </summary>
        /// <value>Loyalty point point bucket status.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status
        {
            get{ return _Status;}
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private string _Status;
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
        /// Date when the number of points defined in the bucket object are due to expire.
        /// </summary>
        /// <value>Date when the number of points defined in the bucket object are due to expire.</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "expires_at", EmitDefaultValue = true)]
        public DateTime? ExpiresAt
        {
            get{ return _ExpiresAt;}
            set
            {
                _ExpiresAt = value;
                _flagExpiresAt = true;
            }
        }
        private DateTime? _ExpiresAt;
        private bool _flagExpiresAt;

        /// <summary>
        /// Returns false as ExpiresAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return _flagExpiresAt;
        }
        /// <summary>
        /// Timestamp representing the date and time when the loyalty point bucket object was created in ISO 8601 format.
        /// </summary>
        /// <value>Timestamp representing the date and time when the loyalty point bucket object was created in ISO 8601 format.</value>
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
        /// Timestamp representing the date and time when the loyalty point bucket object was updated in ISO 8601 format.
        /// </summary>
        /// <value>Timestamp representing the date and time when the loyalty point bucket object was updated in ISO 8601 format.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltyPointsBucket {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
