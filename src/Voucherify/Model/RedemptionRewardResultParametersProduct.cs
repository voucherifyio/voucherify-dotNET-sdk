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
    [DataContract(Name = "RedemptionRewardResultParametersProduct")]
    public partial class RedemptionRewardResultParametersProduct : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionRewardResultParametersProduct" /> class.
        /// </summary>
        /// <param name="id">Unique product ID, assigned by Voucherify. .</param>
        /// <param name="skuId">Unique identifier of the SKU. It is assigned by Voucherify..</param>
        public RedemptionRewardResultParametersProduct(string id = default(string), string skuId = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._SkuId = skuId;
            if (this.SkuId != null)
            {
                this._flagSkuId = true;
            }
        }

        /// <summary>
        /// Unique product ID, assigned by Voucherify. 
        /// </summary>
        /// <value>Unique product ID, assigned by Voucherify. </value>
        /*
        <example>prod_0b7d7dfb05cbe5c616</example>
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
        /// Unique identifier of the SKU. It is assigned by Voucherify.
        /// </summary>
        /// <value>Unique identifier of the SKU. It is assigned by Voucherify.</value>
        /*
        <example>sku_0a41e31c7b41c28358</example>
        */
        [DataMember(Name = "sku_id", EmitDefaultValue = true)]
        public string SkuId
        {
            get{ return _SkuId;}
            set
            {
                _SkuId = value;
                _flagSkuId = true;
            }
        }
        private string _SkuId;
        private bool _flagSkuId;

        /// <summary>
        /// Returns false as SkuId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSkuId()
        {
            return _flagSkuId;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RedemptionRewardResultParametersProduct {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SkuId: ").Append(SkuId).Append("\n");
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
