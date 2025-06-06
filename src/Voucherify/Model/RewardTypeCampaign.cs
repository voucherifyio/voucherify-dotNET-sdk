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
    /// Objects stores information about the campaign related to the reward.
    /// </summary>
    [DataContract(Name = "RewardTypeCampaign")]
    public partial class RewardTypeCampaign : IValidatableObject
    {
        /// <summary>
        /// Campaign type.
        /// </summary>
        /// <value>Campaign type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DISCOUNTCOUPONS for value: DISCOUNT_COUPONS
            /// </summary>
            [EnumMember(Value = "DISCOUNT_COUPONS")]
            DISCOUNTCOUPONS = 1,

            /// <summary>
            /// Enum GIFTVOUCHERS for value: GIFT_VOUCHERS
            /// </summary>
            [EnumMember(Value = "GIFT_VOUCHERS")]
            GIFTVOUCHERS = 2,

            /// <summary>
            /// Enum LOYALTYPROGRAM for value: LOYALTY_PROGRAM
            /// </summary>
            [EnumMember(Value = "LOYALTY_PROGRAM")]
            LOYALTYPROGRAM = 3
        }


        /// <summary>
        /// Campaign type.
        /// </summary>
        /// <value>Campaign type.</value>

        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type
        {
            get{ return _Type;}
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private TypeEnum? _Type;
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
        /// Initializes a new instance of the <see cref="RewardTypeCampaign" /> class.
        /// </summary>
        /// <param name="id">Unique campaign ID, assigned by Voucherify..</param>
        /// <param name="balance">The number of points to be added to a loyalty card or the amount to be added to the current balance on the gift card.  For gift cards, the value is multiplied by 100 to precisely represent 2 decimal places. For example, $100 amount is written as 10000..</param>
        /// <param name="type">Campaign type..</param>
        public RewardTypeCampaign(string id = default(string), int? balance = default(int?), TypeEnum? type = default(TypeEnum?))
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
        /// Unique campaign ID, assigned by Voucherify.
        /// </summary>
        /// <value>Unique campaign ID, assigned by Voucherify.</value>
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
        /// The number of points to be added to a loyalty card or the amount to be added to the current balance on the gift card.  For gift cards, the value is multiplied by 100 to precisely represent 2 decimal places. For example, $100 amount is written as 10000.
        /// </summary>
        /// <value>The number of points to be added to a loyalty card or the amount to be added to the current balance on the gift card.  For gift cards, the value is multiplied by 100 to precisely represent 2 decimal places. For example, $100 amount is written as 10000.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RewardTypeCampaign {\n");
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
