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
    /// Redeemable loyalty card object response
    /// </summary>
    [DataContract(Name = "RedeemableLoyaltyCard")]
    public partial class RedeemableLoyaltyCard : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemableLoyaltyCard" /> class.
        /// </summary>
        /// <param name="points">Total number of points added to the loyalty card over its lifespan..</param>
        /// <param name="balance">Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;..</param>
        /// <param name="exchangeRatio">The cash equivalent of the points defined in the points_ratio property..</param>
        /// <param name="pointsRatio">The number of loyalty points that will map to the predefined cash amount defined by the exchange_ratio property..</param>
        /// <param name="transfers">transfers.</param>
        public RedeemableLoyaltyCard(int? points = default(int?), int? balance = default(int?), decimal? exchangeRatio = default(decimal?), int? pointsRatio = default(int?), List<LoyaltiesTransferPoints> transfers = default(List<LoyaltiesTransferPoints>))
        {
            this._Points = points;
            if (this.Points != null)
            {
                this._flagPoints = true;
            }
            this._Balance = balance;
            if (this.Balance != null)
            {
                this._flagBalance = true;
            }
            this._ExchangeRatio = exchangeRatio;
            if (this.ExchangeRatio != null)
            {
                this._flagExchangeRatio = true;
            }
            this._PointsRatio = pointsRatio;
            if (this.PointsRatio != null)
            {
                this._flagPointsRatio = true;
            }
            this._Transfers = transfers;
            if (this.Transfers != null)
            {
                this._flagTransfers = true;
            }
        }

        /// <summary>
        /// Total number of points added to the loyalty card over its lifespan.
        /// </summary>
        /// <value>Total number of points added to the loyalty card over its lifespan.</value>
        /*
        <example>7000</example>
        */
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
        /// Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;.
        /// </summary>
        /// <value>Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;.</value>
        /*
        <example>6970</example>
        */
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
        /// The cash equivalent of the points defined in the points_ratio property.
        /// </summary>
        /// <value>The cash equivalent of the points defined in the points_ratio property.</value>
        [DataMember(Name = "exchange_ratio", EmitDefaultValue = true)]
        public decimal? ExchangeRatio
        {
            get{ return _ExchangeRatio;}
            set
            {
                _ExchangeRatio = value;
                _flagExchangeRatio = true;
            }
        }
        private decimal? _ExchangeRatio;
        private bool _flagExchangeRatio;

        /// <summary>
        /// Returns false as ExchangeRatio should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExchangeRatio()
        {
            return _flagExchangeRatio;
        }
        /// <summary>
        /// The number of loyalty points that will map to the predefined cash amount defined by the exchange_ratio property.
        /// </summary>
        /// <value>The number of loyalty points that will map to the predefined cash amount defined by the exchange_ratio property.</value>
        [DataMember(Name = "points_ratio", EmitDefaultValue = true)]
        public int? PointsRatio
        {
            get{ return _PointsRatio;}
            set
            {
                _PointsRatio = value;
                _flagPointsRatio = true;
            }
        }
        private int? _PointsRatio;
        private bool _flagPointsRatio;

        /// <summary>
        /// Returns false as PointsRatio should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePointsRatio()
        {
            return _flagPointsRatio;
        }
        /// <summary>
        /// Gets or Sets Transfers
        /// </summary>
        [DataMember(Name = "transfers", EmitDefaultValue = true)]
        public List<LoyaltiesTransferPoints> Transfers
        {
            get{ return _Transfers;}
            set
            {
                _Transfers = value;
                _flagTransfers = true;
            }
        }
        private List<LoyaltiesTransferPoints> _Transfers;
        private bool _flagTransfers;

        /// <summary>
        /// Returns false as Transfers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransfers()
        {
            return _flagTransfers;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RedeemableLoyaltyCard {\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  ExchangeRatio: ").Append(ExchangeRatio).Append("\n");
            sb.Append("  PointsRatio: ").Append(PointsRatio).Append("\n");
            sb.Append("  Transfers: ").Append(Transfers).Append("\n");
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
