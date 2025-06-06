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
    /// A set of filters to return only a specific category or type of redeemable.
    /// </summary>
    [DataContract(Name = "QualificationsOptionFilters")]
    public partial class QualificationsOptionFilters : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Junction
        /// </summary>

        [DataMember(Name = "junction", EmitDefaultValue = true)]
        public Junction? Junction
        {
            get{ return _Junction;}
            set
            {
                _Junction = value;
                _flagJunction = true;
            }
        }
        private Junction? _Junction;
        private bool _flagJunction;

        /// <summary>
        /// Returns false as Junction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJunction()
        {
            return _flagJunction;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualificationsOptionFilters" /> class.
        /// </summary>
        /// <param name="junction">junction.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="campaignType">campaignType.</param>
        /// <param name="resourceId">resourceId.</param>
        /// <param name="resourceType">resourceType.</param>
        /// <param name="voucherType">voucherType.</param>
        /// <param name="code">code.</param>
        /// <param name="holderRole">holderRole.</param>
        public QualificationsOptionFilters(Junction? junction = default(Junction?), QualificationsFieldConditions categoryId = default(QualificationsFieldConditions), QualificationsFieldConditions campaignId = default(QualificationsFieldConditions), QualificationsOptionFiltersCampaignType campaignType = default(QualificationsOptionFiltersCampaignType), QualificationsFieldConditions resourceId = default(QualificationsFieldConditions), QualificationsOptionFiltersResourceType resourceType = default(QualificationsOptionFiltersResourceType), QualificationsFieldConditions voucherType = default(QualificationsFieldConditions), QualificationsFieldConditions code = default(QualificationsFieldConditions), QualificationsOptionFiltersHolderRole holderRole = default(QualificationsOptionFiltersHolderRole))
        {
            this._Junction = junction;
            if (this.Junction != null)
            {
                this._flagJunction = true;
            }
            this._CategoryId = categoryId;
            if (this.CategoryId != null)
            {
                this._flagCategoryId = true;
            }
            this._CampaignId = campaignId;
            if (this.CampaignId != null)
            {
                this._flagCampaignId = true;
            }
            this._CampaignType = campaignType;
            if (this.CampaignType != null)
            {
                this._flagCampaignType = true;
            }
            this._ResourceId = resourceId;
            if (this.ResourceId != null)
            {
                this._flagResourceId = true;
            }
            this._ResourceType = resourceType;
            if (this.ResourceType != null)
            {
                this._flagResourceType = true;
            }
            this._VoucherType = voucherType;
            if (this.VoucherType != null)
            {
                this._flagVoucherType = true;
            }
            this._Code = code;
            if (this.Code != null)
            {
                this._flagCode = true;
            }
            this._HolderRole = holderRole;
            if (this.HolderRole != null)
            {
                this._flagHolderRole = true;
            }
        }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name = "category_id", EmitDefaultValue = true)]
        public QualificationsFieldConditions CategoryId
        {
            get{ return _CategoryId;}
            set
            {
                _CategoryId = value;
                _flagCategoryId = true;
            }
        }
        private QualificationsFieldConditions _CategoryId;
        private bool _flagCategoryId;

        /// <summary>
        /// Returns false as CategoryId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategoryId()
        {
            return _flagCategoryId;
        }
        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name = "campaign_id", EmitDefaultValue = true)]
        public QualificationsFieldConditions CampaignId
        {
            get{ return _CampaignId;}
            set
            {
                _CampaignId = value;
                _flagCampaignId = true;
            }
        }
        private QualificationsFieldConditions _CampaignId;
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
        /// Gets or Sets CampaignType
        /// </summary>
        [DataMember(Name = "campaign_type", EmitDefaultValue = true)]
        public QualificationsOptionFiltersCampaignType CampaignType
        {
            get{ return _CampaignType;}
            set
            {
                _CampaignType = value;
                _flagCampaignType = true;
            }
        }
        private QualificationsOptionFiltersCampaignType _CampaignType;
        private bool _flagCampaignType;

        /// <summary>
        /// Returns false as CampaignType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCampaignType()
        {
            return _flagCampaignType;
        }
        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name = "resource_id", EmitDefaultValue = true)]
        public QualificationsFieldConditions ResourceId
        {
            get{ return _ResourceId;}
            set
            {
                _ResourceId = value;
                _flagResourceId = true;
            }
        }
        private QualificationsFieldConditions _ResourceId;
        private bool _flagResourceId;

        /// <summary>
        /// Returns false as ResourceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceId()
        {
            return _flagResourceId;
        }
        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name = "resource_type", EmitDefaultValue = true)]
        public QualificationsOptionFiltersResourceType ResourceType
        {
            get{ return _ResourceType;}
            set
            {
                _ResourceType = value;
                _flagResourceType = true;
            }
        }
        private QualificationsOptionFiltersResourceType _ResourceType;
        private bool _flagResourceType;

        /// <summary>
        /// Returns false as ResourceType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceType()
        {
            return _flagResourceType;
        }
        /// <summary>
        /// Gets or Sets VoucherType
        /// </summary>
        [DataMember(Name = "voucher_type", EmitDefaultValue = true)]
        public QualificationsFieldConditions VoucherType
        {
            get{ return _VoucherType;}
            set
            {
                _VoucherType = value;
                _flagVoucherType = true;
            }
        }
        private QualificationsFieldConditions _VoucherType;
        private bool _flagVoucherType;

        /// <summary>
        /// Returns false as VoucherType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVoucherType()
        {
            return _flagVoucherType;
        }
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public QualificationsFieldConditions Code
        {
            get{ return _Code;}
            set
            {
                _Code = value;
                _flagCode = true;
            }
        }
        private QualificationsFieldConditions _Code;
        private bool _flagCode;

        /// <summary>
        /// Returns false as Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCode()
        {
            return _flagCode;
        }
        /// <summary>
        /// Gets or Sets HolderRole
        /// </summary>
        [DataMember(Name = "holder_role", EmitDefaultValue = true)]
        public QualificationsOptionFiltersHolderRole HolderRole
        {
            get{ return _HolderRole;}
            set
            {
                _HolderRole = value;
                _flagHolderRole = true;
            }
        }
        private QualificationsOptionFiltersHolderRole _HolderRole;
        private bool _flagHolderRole;

        /// <summary>
        /// Returns false as HolderRole should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHolderRole()
        {
            return _flagHolderRole;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QualificationsOptionFilters {\n");
            sb.Append("  Junction: ").Append(Junction).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CampaignType: ").Append(CampaignType).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  HolderRole: ").Append(HolderRole).Append("\n");
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
