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
    /// Defines the equivalent points value of the reward.
    /// </summary>
    [DataContract(Name = "RewardAssignmentParametersLoyalty")]
    public partial class RewardAssignmentParametersLoyalty : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RewardAssignmentParametersLoyalty" /> class.
        /// </summary>
        /// <param name="points">The number of points required to redeem the reward..</param>
        /// <param name="autoRedeem">Determines if the reward is redeemed automatically when the customer reaches the sufficient number of points to redeem it. Value &#x60;true&#x60; means that the automatic reward redemption is active. Only one reward can be set to be redeemed automatically in a loyalty campaign, i.e. only one can have the value &#x60;true&#x60;..</param>
        public RewardAssignmentParametersLoyalty(int? points = default(int?), bool? autoRedeem = default(bool?))
        {
            this._Points = points;
            if (this.Points != null)
            {
                this._flagPoints = true;
            }
            this._AutoRedeem = autoRedeem;
            if (this.AutoRedeem != null)
            {
                this._flagAutoRedeem = true;
            }
        }

        /// <summary>
        /// The number of points required to redeem the reward.
        /// </summary>
        /// <value>The number of points required to redeem the reward.</value>
        [DataMember(Name = "points", EmitDefaultValue = true)]
        public int? Points
        {
            get{ return _Points;}
            set
            {
                _Points = value;
                _flagPoints = true;
            }
        }
        private int? _Points;
        private bool _flagPoints;

        /// <summary>
        /// Returns false as Points should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePoints()
        {
            return _flagPoints;
        }
        /// <summary>
        /// Determines if the reward is redeemed automatically when the customer reaches the sufficient number of points to redeem it. Value &#x60;true&#x60; means that the automatic reward redemption is active. Only one reward can be set to be redeemed automatically in a loyalty campaign, i.e. only one can have the value &#x60;true&#x60;.
        /// </summary>
        /// <value>Determines if the reward is redeemed automatically when the customer reaches the sufficient number of points to redeem it. Value &#x60;true&#x60; means that the automatic reward redemption is active. Only one reward can be set to be redeemed automatically in a loyalty campaign, i.e. only one can have the value &#x60;true&#x60;.</value>
        [DataMember(Name = "auto_redeem", EmitDefaultValue = true)]
        public bool? AutoRedeem
        {
            get{ return _AutoRedeem;}
            set
            {
                _AutoRedeem = value;
                _flagAutoRedeem = true;
            }
        }
        private bool? _AutoRedeem;
        private bool _flagAutoRedeem;

        /// <summary>
        /// Returns false as AutoRedeem should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAutoRedeem()
        {
            return _flagAutoRedeem;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RewardAssignmentParametersLoyalty {\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  AutoRedeem: ").Append(AutoRedeem).Append("\n");
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
