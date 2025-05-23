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
    /// Configure parameters returned in the response.
    /// </summary>
    [DataContract(Name = "QualificationsOption")]
    public partial class QualificationsOption : IValidatableObject
    {
        /// <summary>
        /// Defines Expand
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExpandEnum
        {
            /// <summary>
            /// Enum Redeemable for value: redeemable
            /// </summary>
            [EnumMember(Value = "redeemable")]
            Redeemable = 1,

            /// <summary>
            /// Enum Category for value: category
            /// </summary>
            [EnumMember(Value = "category")]
            Category = 2,

            /// <summary>
            /// Enum ValidationRules for value: validation_rules
            /// </summary>
            [EnumMember(Value = "validation_rules")]
            ValidationRules = 3
        }

        /// <summary>
        /// Is used to determine the order in which data is displayed in the result array.    - &#x60;DEFAULT&#x60; - Sorting descending by &#x60;created_at&#x60;   - &#x60;BEST_DEAL&#x60; - Sorting descending by &#x60;total_applied_discount_amount&#x60;   - &#x60;LEAST_DEAL&#x60; - Sorting ascending by &#x60;total_applied_discount_amount&#x60;
        /// </summary>
        /// <value>Is used to determine the order in which data is displayed in the result array.    - &#x60;DEFAULT&#x60; - Sorting descending by &#x60;created_at&#x60;   - &#x60;BEST_DEAL&#x60; - Sorting descending by &#x60;total_applied_discount_amount&#x60;   - &#x60;LEAST_DEAL&#x60; - Sorting ascending by &#x60;total_applied_discount_amount&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortingRuleEnum
        {
            /// <summary>
            /// Enum BESTDEAL for value: BEST_DEAL
            /// </summary>
            [EnumMember(Value = "BEST_DEAL")]
            BESTDEAL = 1,

            /// <summary>
            /// Enum LEASTDEAL for value: LEAST_DEAL
            /// </summary>
            [EnumMember(Value = "LEAST_DEAL")]
            LEASTDEAL = 2,

            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT = 3
        }


        /// <summary>
        /// Is used to determine the order in which data is displayed in the result array.    - &#x60;DEFAULT&#x60; - Sorting descending by &#x60;created_at&#x60;   - &#x60;BEST_DEAL&#x60; - Sorting descending by &#x60;total_applied_discount_amount&#x60;   - &#x60;LEAST_DEAL&#x60; - Sorting ascending by &#x60;total_applied_discount_amount&#x60;
        /// </summary>
        /// <value>Is used to determine the order in which data is displayed in the result array.    - &#x60;DEFAULT&#x60; - Sorting descending by &#x60;created_at&#x60;   - &#x60;BEST_DEAL&#x60; - Sorting descending by &#x60;total_applied_discount_amount&#x60;   - &#x60;LEAST_DEAL&#x60; - Sorting ascending by &#x60;total_applied_discount_amount&#x60;</value>

        [DataMember(Name = "sorting_rule", EmitDefaultValue = true)]
        public SortingRuleEnum? SortingRule
        {
            get{ return _SortingRule;}
            set
            {
                _SortingRule = value;
                _flagSortingRule = true;
            }
        }
        private SortingRuleEnum? _SortingRule;
        private bool _flagSortingRule;

        /// <summary>
        /// Returns false as SortingRule should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSortingRule()
        {
            return _flagSortingRule;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualificationsOption" /> class.
        /// </summary>
        /// <param name="limit">The maximum number of redeemables to be returned in the API request. The actual number of returned redeemables will be determined by the API. The default value is set to 5.</param>
        /// <param name="startingAfter">Cursor used for paging..</param>
        /// <param name="filters">filters.</param>
        /// <param name="expand">The expand array lets you configure the parameters included in the response. Depending on the strings included in the array, the response will contain different details.   | **Expand Option** | **Response Body** | |:- --|:- --| | [&#x60;\&quot;redeemable\&quot;&#x60;] | Returns the redeemables&#39;:&lt;br&gt;- metadata&lt;br&gt;- redeemable name,&lt;br&gt;- campaign name,&lt;br&gt;- campaign ID| | [&#x60;\&quot;category\&quot;&#x60;] | - Returns an expanded &#x60;categories&#x60; object, showing details about the category. | | [&#x60;\&quot;validation_rules\&quot;&#x60;] | - Returns an expanded &#x60;validation_rules&#x60; object, showing details about the validation rules. |.</param>
        /// <param name="sortingRule">Is used to determine the order in which data is displayed in the result array.    - &#x60;DEFAULT&#x60; - Sorting descending by &#x60;created_at&#x60;   - &#x60;BEST_DEAL&#x60; - Sorting descending by &#x60;total_applied_discount_amount&#x60;   - &#x60;LEAST_DEAL&#x60; - Sorting ascending by &#x60;total_applied_discount_amount&#x60;.</param>
        public QualificationsOption(int? limit = default(int?), DateTimeOffset? startingAfter = default(DateTimeOffset?), QualificationsOptionFilters filters = default(QualificationsOptionFilters), List<ExpandEnum> expand = default(List<ExpandEnum>), SortingRuleEnum? sortingRule = default(SortingRuleEnum?))
        {
            this._Limit = limit;
            if (this.Limit != null)
            {
                this._flagLimit = true;
            }
            this._StartingAfter = startingAfter;
            if (this.StartingAfter != null)
            {
                this._flagStartingAfter = true;
            }
            this._Filters = filters;
            if (this.Filters != null)
            {
                this._flagFilters = true;
            }
            this._Expand = expand;
            if (this.Expand != null)
            {
                this._flagExpand = true;
            }
            this._SortingRule = sortingRule;
            if (this.SortingRule != null)
            {
                this._flagSortingRule = true;
            }
        }

        /// <summary>
        /// The maximum number of redeemables to be returned in the API request. The actual number of returned redeemables will be determined by the API. The default value is set to 5
        /// </summary>
        /// <value>The maximum number of redeemables to be returned in the API request. The actual number of returned redeemables will be determined by the API. The default value is set to 5</value>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public int? Limit
        {
            get{ return _Limit;}
            set
            {
                _Limit = value;
                _flagLimit = true;
            }
        }
        private int? _Limit;
        private bool _flagLimit;

        /// <summary>
        /// Returns false as Limit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLimit()
        {
            return _flagLimit;
        }
        /// <summary>
        /// Cursor used for paging.
        /// </summary>
        /// <value>Cursor used for paging.</value>
        /*
        <example>2021-09-08T13:52:18.227Z</example>
        */
        [DataMember(Name = "starting_after", EmitDefaultValue = true)]
        public DateTimeOffset? StartingAfter
        {
            get{ return _StartingAfter;}
            set
            {
                _StartingAfter = value;
                _flagStartingAfter = true;
            }
        }
        private DateTimeOffset? _StartingAfter;
        private bool _flagStartingAfter;

        /// <summary>
        /// Returns false as StartingAfter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartingAfter()
        {
            return _flagStartingAfter;
        }
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public QualificationsOptionFilters Filters
        {
            get{ return _Filters;}
            set
            {
                _Filters = value;
                _flagFilters = true;
            }
        }
        private QualificationsOptionFilters _Filters;
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
        /// The expand array lets you configure the parameters included in the response. Depending on the strings included in the array, the response will contain different details.   | **Expand Option** | **Response Body** | |:- --|:- --| | [&#x60;\&quot;redeemable\&quot;&#x60;] | Returns the redeemables&#39;:&lt;br&gt;- metadata&lt;br&gt;- redeemable name,&lt;br&gt;- campaign name,&lt;br&gt;- campaign ID| | [&#x60;\&quot;category\&quot;&#x60;] | - Returns an expanded &#x60;categories&#x60; object, showing details about the category. | | [&#x60;\&quot;validation_rules\&quot;&#x60;] | - Returns an expanded &#x60;validation_rules&#x60; object, showing details about the validation rules. |
        /// </summary>
        /// <value>The expand array lets you configure the parameters included in the response. Depending on the strings included in the array, the response will contain different details.   | **Expand Option** | **Response Body** | |:- --|:- --| | [&#x60;\&quot;redeemable\&quot;&#x60;] | Returns the redeemables&#39;:&lt;br&gt;- metadata&lt;br&gt;- redeemable name,&lt;br&gt;- campaign name,&lt;br&gt;- campaign ID| | [&#x60;\&quot;category\&quot;&#x60;] | - Returns an expanded &#x60;categories&#x60; object, showing details about the category. | | [&#x60;\&quot;validation_rules\&quot;&#x60;] | - Returns an expanded &#x60;validation_rules&#x60; object, showing details about the validation rules. |</value>
        [DataMember(Name = "expand", EmitDefaultValue = true)]
        public List<QualificationsOption.ExpandEnum> Expand
        {
            get{ return _Expand;}
            set
            {
                _Expand = value;
                _flagExpand = true;
            }
        }
        private List<QualificationsOption.ExpandEnum> _Expand;
        private bool _flagExpand;

        /// <summary>
        /// Returns false as Expand should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpand()
        {
            return _flagExpand;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QualificationsOption {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  StartingAfter: ").Append(StartingAfter).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Expand: ").Append(Expand).Append("\n");
            sb.Append("  SortingRule: ").Append(SortingRule).Append("\n");
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
            // Limit (int?) maximum
            if (this.Limit > (int?)50)
            {
                yield return new ValidationResult("Invalid value for Limit, must be a value less than or equal to 50.", new [] { "Limit" });
            }

            yield break;
        }
    }

}
