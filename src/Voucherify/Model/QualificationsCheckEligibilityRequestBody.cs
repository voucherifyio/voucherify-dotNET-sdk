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
    /// Request body schema for **POST** &#x60;v1/qualifications&#x60;.
    /// </summary>
    [DataContract(Name = "QualificationsCheckEligibilityRequestBody")]
    public partial class QualificationsCheckEligibilityRequestBody : IValidatableObject
    {
        /// <summary>
        /// Defines the scenario Voucherify should consider during the qualification process.  - &#x60;ALL&#x60; - Scenario that returns all redeemables available for the customer in one API request. This scenario is used by default when no value is selected. - &#x60;CUSTOMER_WALLET&#x60; - returns vouchers applicable to the customer&#39;s cart based on the vouchers assigned to the customer&#39;s profile. - &#x60;AUDIENCE_ONLY&#x60; - returns all vouchers, promotion tiers, and campaigns available to the customer. Voucherify validates the rules based on the customer profile only. - &#x60;PRODUCTS&#x60; - returns all promotions available for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT&#x60; - returns all promotions available for products when a discount is defined as applicable to specific item(s). - &#x60;PROMOTION_STACKS&#x60; - returns the applicable promotion stacks. - &#x60;PRODUCTS_BY_CUSTOMER&#x60; - returns all promotions available for a customer for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT_BY_CUSTOMER&#x60; - returns all promotions available for a customer for products when a discount is defined as applicable to specific item(s).
        /// </summary>
        /// <value>Defines the scenario Voucherify should consider during the qualification process.  - &#x60;ALL&#x60; - Scenario that returns all redeemables available for the customer in one API request. This scenario is used by default when no value is selected. - &#x60;CUSTOMER_WALLET&#x60; - returns vouchers applicable to the customer&#39;s cart based on the vouchers assigned to the customer&#39;s profile. - &#x60;AUDIENCE_ONLY&#x60; - returns all vouchers, promotion tiers, and campaigns available to the customer. Voucherify validates the rules based on the customer profile only. - &#x60;PRODUCTS&#x60; - returns all promotions available for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT&#x60; - returns all promotions available for products when a discount is defined as applicable to specific item(s). - &#x60;PROMOTION_STACKS&#x60; - returns the applicable promotion stacks. - &#x60;PRODUCTS_BY_CUSTOMER&#x60; - returns all promotions available for a customer for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT_BY_CUSTOMER&#x60; - returns all promotions available for a customer for products when a discount is defined as applicable to specific item(s).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScenarioEnum
        {
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 1,

            /// <summary>
            /// Enum CUSTOMERWALLET for value: CUSTOMER_WALLET
            /// </summary>
            [EnumMember(Value = "CUSTOMER_WALLET")]
            CUSTOMERWALLET = 2,

            /// <summary>
            /// Enum AUDIENCEONLY for value: AUDIENCE_ONLY
            /// </summary>
            [EnumMember(Value = "AUDIENCE_ONLY")]
            AUDIENCEONLY = 3,

            /// <summary>
            /// Enum PRODUCTS for value: PRODUCTS
            /// </summary>
            [EnumMember(Value = "PRODUCTS")]
            PRODUCTS = 4,

            /// <summary>
            /// Enum PRODUCTSDISCOUNT for value: PRODUCTS_DISCOUNT
            /// </summary>
            [EnumMember(Value = "PRODUCTS_DISCOUNT")]
            PRODUCTSDISCOUNT = 5,

            /// <summary>
            /// Enum PROMOTIONSTACKS for value: PROMOTION_STACKS
            /// </summary>
            [EnumMember(Value = "PROMOTION_STACKS")]
            PROMOTIONSTACKS = 6,

            /// <summary>
            /// Enum PRODUCTSBYCUSTOMER for value: PRODUCTS_BY_CUSTOMER
            /// </summary>
            [EnumMember(Value = "PRODUCTS_BY_CUSTOMER")]
            PRODUCTSBYCUSTOMER = 7,

            /// <summary>
            /// Enum PRODUCTSDISCOUNTBYCUSTOMER for value: PRODUCTS_DISCOUNT_BY_CUSTOMER
            /// </summary>
            [EnumMember(Value = "PRODUCTS_DISCOUNT_BY_CUSTOMER")]
            PRODUCTSDISCOUNTBYCUSTOMER = 8
        }


        /// <summary>
        /// Defines the scenario Voucherify should consider during the qualification process.  - &#x60;ALL&#x60; - Scenario that returns all redeemables available for the customer in one API request. This scenario is used by default when no value is selected. - &#x60;CUSTOMER_WALLET&#x60; - returns vouchers applicable to the customer&#39;s cart based on the vouchers assigned to the customer&#39;s profile. - &#x60;AUDIENCE_ONLY&#x60; - returns all vouchers, promotion tiers, and campaigns available to the customer. Voucherify validates the rules based on the customer profile only. - &#x60;PRODUCTS&#x60; - returns all promotions available for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT&#x60; - returns all promotions available for products when a discount is defined as applicable to specific item(s). - &#x60;PROMOTION_STACKS&#x60; - returns the applicable promotion stacks. - &#x60;PRODUCTS_BY_CUSTOMER&#x60; - returns all promotions available for a customer for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT_BY_CUSTOMER&#x60; - returns all promotions available for a customer for products when a discount is defined as applicable to specific item(s).
        /// </summary>
        /// <value>Defines the scenario Voucherify should consider during the qualification process.  - &#x60;ALL&#x60; - Scenario that returns all redeemables available for the customer in one API request. This scenario is used by default when no value is selected. - &#x60;CUSTOMER_WALLET&#x60; - returns vouchers applicable to the customer&#39;s cart based on the vouchers assigned to the customer&#39;s profile. - &#x60;AUDIENCE_ONLY&#x60; - returns all vouchers, promotion tiers, and campaigns available to the customer. Voucherify validates the rules based on the customer profile only. - &#x60;PRODUCTS&#x60; - returns all promotions available for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT&#x60; - returns all promotions available for products when a discount is defined as applicable to specific item(s). - &#x60;PROMOTION_STACKS&#x60; - returns the applicable promotion stacks. - &#x60;PRODUCTS_BY_CUSTOMER&#x60; - returns all promotions available for a customer for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT_BY_CUSTOMER&#x60; - returns all promotions available for a customer for products when a discount is defined as applicable to specific item(s).</value>

        [DataMember(Name = "scenario", EmitDefaultValue = true)]
        public ScenarioEnum? Scenario
        {
            get{ return _Scenario;}
            set
            {
                _Scenario = value;
                _flagScenario = true;
            }
        }
        private ScenarioEnum? _Scenario;
        private bool _flagScenario;

        /// <summary>
        /// Returns false as Scenario should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScenario()
        {
            return _flagScenario;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualificationsCheckEligibilityRequestBody" /> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="order">order.</param>
        /// <param name="trackingId">Is correspondent to Customer&#39;s source_id.</param>
        /// <param name="scenario">Defines the scenario Voucherify should consider during the qualification process.  - &#x60;ALL&#x60; - Scenario that returns all redeemables available for the customer in one API request. This scenario is used by default when no value is selected. - &#x60;CUSTOMER_WALLET&#x60; - returns vouchers applicable to the customer&#39;s cart based on the vouchers assigned to the customer&#39;s profile. - &#x60;AUDIENCE_ONLY&#x60; - returns all vouchers, promotion tiers, and campaigns available to the customer. Voucherify validates the rules based on the customer profile only. - &#x60;PRODUCTS&#x60; - returns all promotions available for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT&#x60; - returns all promotions available for products when a discount is defined as applicable to specific item(s). - &#x60;PROMOTION_STACKS&#x60; - returns the applicable promotion stacks. - &#x60;PRODUCTS_BY_CUSTOMER&#x60; - returns all promotions available for a customer for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT_BY_CUSTOMER&#x60; - returns all promotions available for a customer for products when a discount is defined as applicable to specific item(s)..</param>
        /// <param name="options">options.</param>
        /// <param name="metadata">A set of key/value pairs that you can send in the request body to check against redeemables requiring **redemption** metadata validation rules to be satisfied. The validation runs against rules that are defined through the &lt;!- - [Create Validation Rules](https://docs.voucherify.io/reference/create-validation-rules) - -&gt;[Create Validation Rules](ref:create-validation-rules) endpoint or via the Dashboard; in the _Advanced Rule Builder_ &amp;rarr; _Advanced_ &amp;rarr; _Redemption metadata satisfy_ or _Basic Builder_ &amp;rarr; _Attributes match_ &amp;rarr; _REDEMPTION METADATA_. [Read more](https://support.voucherify.io/article/148-how-to-build-a-rule)..</param>
        public QualificationsCheckEligibilityRequestBody(Customer customer = default(Customer), Order order = default(Order), string trackingId = default(string), ScenarioEnum? scenario = default(ScenarioEnum?), QualificationsOption options = default(QualificationsOption), Object metadata = default(Object))
        {
            this._Customer = customer;
            if (this.Customer != null)
            {
                this._flagCustomer = true;
            }
            this._Order = order;
            if (this.Order != null)
            {
                this._flagOrder = true;
            }
            this._TrackingId = trackingId;
            if (this.TrackingId != null)
            {
                this._flagTrackingId = true;
            }
            this._Scenario = scenario;
            if (this.Scenario != null)
            {
                this._flagScenario = true;
            }
            this._Options = options;
            if (this.Options != null)
            {
                this._flagOptions = true;
            }
            this._Metadata = metadata;
            if (this.Metadata != null)
            {
                this._flagMetadata = true;
            }
        }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = true)]
        public Customer Customer
        {
            get{ return _Customer;}
            set
            {
                _Customer = value;
                _flagCustomer = true;
            }
        }
        private Customer _Customer;
        private bool _flagCustomer;

        /// <summary>
        /// Returns false as Customer should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomer()
        {
            return _flagCustomer;
        }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public Order Order
        {
            get{ return _Order;}
            set
            {
                _Order = value;
                _flagOrder = true;
            }
        }
        private Order _Order;
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
        /// Is correspondent to Customer&#39;s source_id
        /// </summary>
        /// <value>Is correspondent to Customer&#39;s source_id</value>
        [DataMember(Name = "tracking_id", EmitDefaultValue = true)]
        public string TrackingId
        {
            get{ return _TrackingId;}
            set
            {
                _TrackingId = value;
                _flagTrackingId = true;
            }
        }
        private string _TrackingId;
        private bool _flagTrackingId;

        /// <summary>
        /// Returns false as TrackingId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTrackingId()
        {
            return _flagTrackingId;
        }
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public QualificationsOption Options
        {
            get{ return _Options;}
            set
            {
                _Options = value;
                _flagOptions = true;
            }
        }
        private QualificationsOption _Options;
        private bool _flagOptions;

        /// <summary>
        /// Returns false as Options should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOptions()
        {
            return _flagOptions;
        }
        /// <summary>
        /// A set of key/value pairs that you can send in the request body to check against redeemables requiring **redemption** metadata validation rules to be satisfied. The validation runs against rules that are defined through the &lt;!- - [Create Validation Rules](https://docs.voucherify.io/reference/create-validation-rules) - -&gt;[Create Validation Rules](ref:create-validation-rules) endpoint or via the Dashboard; in the _Advanced Rule Builder_ &amp;rarr; _Advanced_ &amp;rarr; _Redemption metadata satisfy_ or _Basic Builder_ &amp;rarr; _Attributes match_ &amp;rarr; _REDEMPTION METADATA_. [Read more](https://support.voucherify.io/article/148-how-to-build-a-rule).
        /// </summary>
        /// <value>A set of key/value pairs that you can send in the request body to check against redeemables requiring **redemption** metadata validation rules to be satisfied. The validation runs against rules that are defined through the &lt;!- - [Create Validation Rules](https://docs.voucherify.io/reference/create-validation-rules) - -&gt;[Create Validation Rules](ref:create-validation-rules) endpoint or via the Dashboard; in the _Advanced Rule Builder_ &amp;rarr; _Advanced_ &amp;rarr; _Redemption metadata satisfy_ or _Basic Builder_ &amp;rarr; _Attributes match_ &amp;rarr; _REDEMPTION METADATA_. [Read more](https://support.voucherify.io/article/148-how-to-build-a-rule).</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Object Metadata
        {
            get{ return _Metadata;}
            set
            {
                _Metadata = value;
                _flagMetadata = true;
            }
        }
        private Object _Metadata;
        private bool _flagMetadata;

        /// <summary>
        /// Returns false as Metadata should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetadata()
        {
            return _flagMetadata;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QualificationsCheckEligibilityRequestBody {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  Scenario: ").Append(Scenario).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
