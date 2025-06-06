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
    /// Response body schema for **POST** &#x60;/redemptions/{parentRedemptionID}/rollbacks&#x60;.
    /// </summary>
    [DataContract(Name = "RedemptionsRollbacksCreateResponseBody")]
    public partial class RedemptionsRollbacksCreateResponseBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionsRollbacksCreateResponseBody" /> class.
        /// </summary>
        /// <param name="rollbacks">Contains the rollback redemption objects of the particular incentives..</param>
        /// <param name="parentRollback">parentRollback.</param>
        /// <param name="order">order.</param>
        public RedemptionsRollbacksCreateResponseBody(List<RedemptionRollback> rollbacks = default(List<RedemptionRollback>), RedemptionRollback parentRollback = default(RedemptionRollback), RedemptionsRollbacksCreateResponseBodyOrder order = default(RedemptionsRollbacksCreateResponseBodyOrder))
        {
            this._Rollbacks = rollbacks;
            if (this.Rollbacks != null)
            {
                this._flagRollbacks = true;
            }
            this._ParentRollback = parentRollback;
            if (this.ParentRollback != null)
            {
                this._flagParentRollback = true;
            }
            this._Order = order;
            if (this.Order != null)
            {
                this._flagOrder = true;
            }
        }

        /// <summary>
        /// Contains the rollback redemption objects of the particular incentives.
        /// </summary>
        /// <value>Contains the rollback redemption objects of the particular incentives.</value>
        [DataMember(Name = "rollbacks", EmitDefaultValue = true)]
        public List<RedemptionRollback> Rollbacks
        {
            get{ return _Rollbacks;}
            set
            {
                _Rollbacks = value;
                _flagRollbacks = true;
            }
        }
        private List<RedemptionRollback> _Rollbacks;
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
        /// Gets or Sets ParentRollback
        /// </summary>
        [DataMember(Name = "parent_rollback", EmitDefaultValue = true)]
        public RedemptionRollback ParentRollback
        {
            get{ return _ParentRollback;}
            set
            {
                _ParentRollback = value;
                _flagParentRollback = true;
            }
        }
        private RedemptionRollback _ParentRollback;
        private bool _flagParentRollback;

        /// <summary>
        /// Returns false as ParentRollback should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParentRollback()
        {
            return _flagParentRollback;
        }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public RedemptionsRollbacksCreateResponseBodyOrder Order
        {
            get{ return _Order;}
            set
            {
                _Order = value;
                _flagOrder = true;
            }
        }
        private RedemptionsRollbacksCreateResponseBodyOrder _Order;
        private bool _flagOrder;

        /// <summary>
        /// Returns false as Order should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrder()
        {
            return _flagOrder;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RedemptionsRollbacksCreateResponseBody {\n");
            sb.Append("  Rollbacks: ").Append(Rollbacks).Append("\n");
            sb.Append("  ParentRollback: ").Append(ParentRollback).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
