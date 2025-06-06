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
    /// Contains the custom earning rule name.
    /// </summary>
    [DataContract(Name = "VoucherTransactionDetailsEarningRuleSource")]
    public partial class VoucherTransactionDetailsEarningRuleSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherTransactionDetailsEarningRuleSource" /> class.
        /// </summary>
        /// <param name="banner">Name of the earning rule. This is displayed as a header for the earning rule in the Dashboard..</param>
        public VoucherTransactionDetailsEarningRuleSource(string banner = default(string))
        {
            this._Banner = banner;
            if (this.Banner != null)
            {
                this._flagBanner = true;
            }
        }

        /// <summary>
        /// Name of the earning rule. This is displayed as a header for the earning rule in the Dashboard.
        /// </summary>
        /// <value>Name of the earning rule. This is displayed as a header for the earning rule in the Dashboard.</value>
        [DataMember(Name = "banner", EmitDefaultValue = true)]
        public string Banner
        {
            get{ return _Banner;}
            set
            {
                _Banner = value;
                _flagBanner = true;
            }
        }
        private string _Banner;
        private bool _flagBanner;

        /// <summary>
        /// Returns false as Banner should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBanner()
        {
            return _flagBanner;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherTransactionDetailsEarningRuleSource {\n");
            sb.Append("  Banner: ").Append(Banner).Append("\n");
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
