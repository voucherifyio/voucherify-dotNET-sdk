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
    /// Defines the product redeemed as a reward.
    /// </summary>
    [DataContract(Name = "RedemptionRewardResultParametersCampaign")]
    public partial class RedemptionRewardResultParametersCampaign : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionRewardResultParametersCampaign" /> class.
        /// </summary>
        /// <param name="id">Campaign unique ID..</param>
        /// <param name="balance">Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;..</param>
        /// <param name="type">Defines the type of the campaign..</param>
        public RedemptionRewardResultParametersCampaign(string id = default(string), int? balance = default(int?), string type = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Balance = balance;
            if (this.Balance != null)
            {
                this._flagBalance = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
        }

        /// <summary>
        /// Campaign unique ID.
        /// </summary>
        /// <value>Campaign unique ID.</value>
        /*
        <example>camp_13BbZ0kQsNinhqsX3wUts2UP</example>
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
        /// Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;.
        /// </summary>
        /// <value>Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;.</value>
        [DataMember(Name = "balance", EmitDefaultValue = true)]
        public int? Balance
        {
            get{ return _Balance;}
            set
            {
                _Balance = value;
                _flagBalance = true;
            }
        }
        private int? _Balance;
        private bool _flagBalance;

        /// <summary>
        /// Returns false as Balance should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBalance()
        {
            return _flagBalance;
        }
        /// <summary>
        /// Defines the type of the campaign.
        /// </summary>
        /// <value>Defines the type of the campaign.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type
        {
            get{ return _Type;}
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private string _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RedemptionRewardResultParametersCampaign {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
