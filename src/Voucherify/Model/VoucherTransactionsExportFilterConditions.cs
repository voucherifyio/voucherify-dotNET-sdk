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
    /// Filter condition.
    /// </summary>
    [DataContract(Name = "VoucherTransactionsExportFilterConditions")]
    public partial class VoucherTransactionsExportFilterConditions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherTransactionsExportFilterConditions" /> class.
        /// </summary>
        /// <param name="voucherId">voucherId.</param>
        public VoucherTransactionsExportFilterConditions(VoucherTransactionsExportFilterConditionsVoucherId voucherId = default(VoucherTransactionsExportFilterConditionsVoucherId))
        {
            this._VoucherId = voucherId;
            if (this.VoucherId != null)
            {
                this._flagVoucherId = true;
            }
        }

        /// <summary>
        /// Gets or Sets VoucherId
        /// </summary>
        [DataMember(Name = "voucher_id", EmitDefaultValue = true)]
        public VoucherTransactionsExportFilterConditionsVoucherId VoucherId
        {
            get{ return _VoucherId;}
            set
            {
                _VoucherId = value;
                _flagVoucherId = true;
            }
        }
        private VoucherTransactionsExportFilterConditionsVoucherId _VoucherId;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherTransactionsExportFilterConditions {\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
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
