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
    /// ValidationsValidateResponseBodyRedeemablesItemResult
    /// </summary>
    [DataContract(Name = "ValidationsValidateResponseBodyRedeemablesItemResult")]
    public partial class ValidationsValidateResponseBodyRedeemablesItemResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationsValidateResponseBodyRedeemablesItemResult" /> class.
        /// </summary>
        /// <param name="discount">discount.</param>
        /// <param name="gift">gift.</param>
        /// <param name="loyaltyCard">loyaltyCard.</param>
        /// <param name="error">error.</param>
        /// <param name="details">details.</param>
        public ValidationsValidateResponseBodyRedeemablesItemResult(ValidationsValidateResponseBodyRedeemablesItemResultDiscount discount = default(ValidationsValidateResponseBodyRedeemablesItemResultDiscount), ValidationsValidateResponseBodyRedeemablesItemResultGift gift = default(ValidationsValidateResponseBodyRedeemablesItemResultGift), ValidationsValidateResponseBodyRedeemablesItemResultLoyaltyCard loyaltyCard = default(ValidationsValidateResponseBodyRedeemablesItemResultLoyaltyCard), Error error = default(Error), ValidationsValidateResponseBodyRedeemablesItemResultDetails details = default(ValidationsValidateResponseBodyRedeemablesItemResultDetails))
        {
            this._Discount = discount;
            if (this.Discount != null)
            {
                this._flagDiscount = true;
            }
            this._Gift = gift;
            if (this.Gift != null)
            {
                this._flagGift = true;
            }
            this._LoyaltyCard = loyaltyCard;
            if (this.LoyaltyCard != null)
            {
                this._flagLoyaltyCard = true;
            }
            this._Error = error;
            if (this.Error != null)
            {
                this._flagError = true;
            }
            this._Details = details;
            if (this.Details != null)
            {
                this._flagDetails = true;
            }
        }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name = "discount", EmitDefaultValue = true)]
        public ValidationsValidateResponseBodyRedeemablesItemResultDiscount Discount
        {
            get{ return _Discount;}
            set
            {
                _Discount = value;
                _flagDiscount = true;
            }
        }
        private ValidationsValidateResponseBodyRedeemablesItemResultDiscount _Discount;
        private bool _flagDiscount;

        /// <summary>
        /// Returns false as Discount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscount()
        {
            return _flagDiscount;
        }
        /// <summary>
        /// Gets or Sets Gift
        /// </summary>
        [DataMember(Name = "gift", EmitDefaultValue = true)]
        public ValidationsValidateResponseBodyRedeemablesItemResultGift Gift
        {
            get{ return _Gift;}
            set
            {
                _Gift = value;
                _flagGift = true;
            }
        }
        private ValidationsValidateResponseBodyRedeemablesItemResultGift _Gift;
        private bool _flagGift;

        /// <summary>
        /// Returns false as Gift should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGift()
        {
            return _flagGift;
        }
        /// <summary>
        /// Gets or Sets LoyaltyCard
        /// </summary>
        [DataMember(Name = "loyalty_card", EmitDefaultValue = true)]
        public ValidationsValidateResponseBodyRedeemablesItemResultLoyaltyCard LoyaltyCard
        {
            get{ return _LoyaltyCard;}
            set
            {
                _LoyaltyCard = value;
                _flagLoyaltyCard = true;
            }
        }
        private ValidationsValidateResponseBodyRedeemablesItemResultLoyaltyCard _LoyaltyCard;
        private bool _flagLoyaltyCard;

        /// <summary>
        /// Returns false as LoyaltyCard should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLoyaltyCard()
        {
            return _flagLoyaltyCard;
        }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public Error Error
        {
            get{ return _Error;}
            set
            {
                _Error = value;
                _flagError = true;
            }
        }
        private Error _Error;
        private bool _flagError;

        /// <summary>
        /// Returns false as Error should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeError()
        {
            return _flagError;
        }
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public ValidationsValidateResponseBodyRedeemablesItemResultDetails Details
        {
            get{ return _Details;}
            set
            {
                _Details = value;
                _flagDetails = true;
            }
        }
        private ValidationsValidateResponseBodyRedeemablesItemResultDetails _Details;
        private bool _flagDetails;

        /// <summary>
        /// Returns false as Details should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDetails()
        {
            return _flagDetails;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidationsValidateResponseBodyRedeemablesItemResult {\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Gift: ").Append(Gift).Append("\n");
            sb.Append("  LoyaltyCard: ").Append(LoyaltyCard).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
