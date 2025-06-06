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
    /// RedemptionsGetResponseBodyRelatedRedemptions
    /// </summary>
    [DataContract(Name = "RedemptionsGetResponseBodyRelatedRedemptions")]
    public partial class RedemptionsGetResponseBodyRelatedRedemptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionsGetResponseBodyRelatedRedemptions" /> class.
        /// </summary>
        /// <param name="rollbacks">rollbacks.</param>
        /// <param name="redemptions">redemptions.</param>
        public RedemptionsGetResponseBodyRelatedRedemptions(List<RedemptionsGetResponseBodyRelatedRedemptionsRollbacksItem> rollbacks = default(List<RedemptionsGetResponseBodyRelatedRedemptionsRollbacksItem>), List<RedemptionsGetResponseBodyRelatedRedemptionsRedemptionsItem> redemptions = default(List<RedemptionsGetResponseBodyRelatedRedemptionsRedemptionsItem>))
        {
            this._Rollbacks = rollbacks;
            if (this.Rollbacks != null)
            {
                this._flagRollbacks = true;
            }
            this._Redemptions = redemptions;
            if (this.Redemptions != null)
            {
                this._flagRedemptions = true;
            }
        }

        /// <summary>
        /// Gets or Sets Rollbacks
        /// </summary>
        [DataMember(Name = "rollbacks", EmitDefaultValue = true)]
        public List<RedemptionsGetResponseBodyRelatedRedemptionsRollbacksItem> Rollbacks
        {
            get{ return _Rollbacks;}
            set
            {
                _Rollbacks = value;
                _flagRollbacks = true;
            }
        }
        private List<RedemptionsGetResponseBodyRelatedRedemptionsRollbacksItem> _Rollbacks;
        private bool _flagRollbacks;

        /// <summary>
        /// Returns false as Rollbacks should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRollbacks()
        {
            return _flagRollbacks;
        }
        /// <summary>
        /// Gets or Sets Redemptions
        /// </summary>
        [DataMember(Name = "redemptions", EmitDefaultValue = true)]
        public List<RedemptionsGetResponseBodyRelatedRedemptionsRedemptionsItem> Redemptions
        {
            get{ return _Redemptions;}
            set
            {
                _Redemptions = value;
                _flagRedemptions = true;
            }
        }
        private List<RedemptionsGetResponseBodyRelatedRedemptionsRedemptionsItem> _Redemptions;
        private bool _flagRedemptions;

        /// <summary>
        /// Returns false as Redemptions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRedemptions()
        {
            return _flagRedemptions;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RedemptionsGetResponseBodyRelatedRedemptions {\n");
            sb.Append("  Rollbacks: ").Append(Rollbacks).Append("\n");
            sb.Append("  Redemptions: ").Append(Redemptions).Append("\n");
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
