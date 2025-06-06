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
    /// List of fields and filters that were passed in the request body to create the export.
    /// </summary>
    [DataContract(Name = "LoyaltiesPointsExpirationExportCreateResponseBodyParameters")]
    public partial class LoyaltiesPointsExpirationExportCreateResponseBodyParameters : IValidatableObject
    {
        /// <summary>
        /// How the export is filtered, where the dash &#x60;-&#x60; preceding a sorting option means sorting in a descending order.
        /// </summary>
        /// <value>How the export is filtered, where the dash &#x60;-&#x60; preceding a sorting option means sorting in a descending order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            /// <summary>
            /// Enum ExpiresAt for value: expires_at
            /// </summary>
            [EnumMember(Value = "expires_at")]
            ExpiresAt = 1,

            /// <summary>
            /// Enum ExpiresAt2 for value: -expires_at
            /// </summary>
            [EnumMember(Value = "-expires_at")]
            ExpiresAt2 = 2
        }


        /// <summary>
        /// How the export is filtered, where the dash &#x60;-&#x60; preceding a sorting option means sorting in a descending order.
        /// </summary>
        /// <value>How the export is filtered, where the dash &#x60;-&#x60; preceding a sorting option means sorting in a descending order.</value>

        [DataMember(Name = "order", EmitDefaultValue = true)]
        public OrderEnum? Order
        {
            get{ return _Order;}
            set
            {
                _Order = value;
                _flagOrder = true;
            }
        }
        private OrderEnum? _Order;
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
        /// Defines Fields
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldsEnum
        {
            /// <summary>
            /// Enum Id for value: id
            /// </summary>
            [EnumMember(Value = "id")]
            Id = 1,

            /// <summary>
            /// Enum CampaignId for value: campaign_id
            /// </summary>
            [EnumMember(Value = "campaign_id")]
            CampaignId = 2,

            /// <summary>
            /// Enum VoucherId for value: voucher_id
            /// </summary>
            [EnumMember(Value = "voucher_id")]
            VoucherId = 3,

            /// <summary>
            /// Enum Points for value: points
            /// </summary>
            [EnumMember(Value = "points")]
            Points = 4,

            /// <summary>
            /// Enum Status for value: status
            /// </summary>
            [EnumMember(Value = "status")]
            Status = 5,

            /// <summary>
            /// Enum ExpiresAt for value: expires_at
            /// </summary>
            [EnumMember(Value = "expires_at")]
            ExpiresAt = 6
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltiesPointsExpirationExportCreateResponseBodyParameters" /> class.
        /// </summary>
        /// <param name="order">How the export is filtered, where the dash &#x60;-&#x60; preceding a sorting option means sorting in a descending order..</param>
        /// <param name="fields">Array of strings containing the data that was exported. These fields define the headers in the CSV file.    The array can be a combination of any of the following available fields:    | **Field** | **Definition** | **Example Export** | |:- --|:- --|:- --| | id | Loyalty points bucket ID. | lopb_Wl1o3EjJIHSNjvO5BDLy4z1n | | campaign_id | Campaign ID of the parent loyalty campaign. | camp_7s3uXI44aKfIk5IhmeOPr6ic | | voucher_id | Voucher ID of the parent loyalty card. | v_YLn0WVWXSXbUfDvxgrgUbtfJ3SQIY655 | | status | Status of the loyalty points bucket. | &#x60;ACTIVE&#x60; or &#x60;INACTIVE&#x60; | | expires_at | Timestamp in ISO 8601 format representing the date when the points expire. | 2022-06-30 | | points | Number of points. | 1000 |.</param>
        /// <param name="filters">filters.</param>
        public LoyaltiesPointsExpirationExportCreateResponseBodyParameters(OrderEnum? order = default(OrderEnum?), List<FieldsEnum> fields = default(List<FieldsEnum>), LoyaltiesPointsExpirationExportCreateResponseBodyParametersFilters filters = default(LoyaltiesPointsExpirationExportCreateResponseBodyParametersFilters))
        {
            this._Order = order;
            if (this.Order != null)
            {
                this._flagOrder = true;
            }
            this._Fields = fields;
            if (this.Fields != null)
            {
                this._flagFields = true;
            }
            this._Filters = filters;
            if (this.Filters != null)
            {
                this._flagFilters = true;
            }
        }

        /// <summary>
        /// Array of strings containing the data that was exported. These fields define the headers in the CSV file.    The array can be a combination of any of the following available fields:    | **Field** | **Definition** | **Example Export** | |:- --|:- --|:- --| | id | Loyalty points bucket ID. | lopb_Wl1o3EjJIHSNjvO5BDLy4z1n | | campaign_id | Campaign ID of the parent loyalty campaign. | camp_7s3uXI44aKfIk5IhmeOPr6ic | | voucher_id | Voucher ID of the parent loyalty card. | v_YLn0WVWXSXbUfDvxgrgUbtfJ3SQIY655 | | status | Status of the loyalty points bucket. | &#x60;ACTIVE&#x60; or &#x60;INACTIVE&#x60; | | expires_at | Timestamp in ISO 8601 format representing the date when the points expire. | 2022-06-30 | | points | Number of points. | 1000 |
        /// </summary>
        /// <value>Array of strings containing the data that was exported. These fields define the headers in the CSV file.    The array can be a combination of any of the following available fields:    | **Field** | **Definition** | **Example Export** | |:- --|:- --|:- --| | id | Loyalty points bucket ID. | lopb_Wl1o3EjJIHSNjvO5BDLy4z1n | | campaign_id | Campaign ID of the parent loyalty campaign. | camp_7s3uXI44aKfIk5IhmeOPr6ic | | voucher_id | Voucher ID of the parent loyalty card. | v_YLn0WVWXSXbUfDvxgrgUbtfJ3SQIY655 | | status | Status of the loyalty points bucket. | &#x60;ACTIVE&#x60; or &#x60;INACTIVE&#x60; | | expires_at | Timestamp in ISO 8601 format representing the date when the points expire. | 2022-06-30 | | points | Number of points. | 1000 |</value>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<LoyaltiesPointsExpirationExportCreateResponseBodyParameters.FieldsEnum> Fields
        {
            get{ return _Fields;}
            set
            {
                _Fields = value;
                _flagFields = true;
            }
        }
        private List<LoyaltiesPointsExpirationExportCreateResponseBodyParameters.FieldsEnum> _Fields;
        private bool _flagFields;

        /// <summary>
        /// Returns false as Fields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFields()
        {
            return _flagFields;
        }
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public LoyaltiesPointsExpirationExportCreateResponseBodyParametersFilters Filters
        {
            get{ return _Filters;}
            set
            {
                _Filters = value;
                _flagFilters = true;
            }
        }
        private LoyaltiesPointsExpirationExportCreateResponseBodyParametersFilters _Filters;
        private bool _flagFilters;

        /// <summary>
        /// Returns false as Filters should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFilters()
        {
            return _flagFilters;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoyaltiesPointsExpirationExportCreateResponseBodyParameters {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
