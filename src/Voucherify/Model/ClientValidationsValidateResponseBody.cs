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
    /// Response body schema for **POST** &#x60;/validations&#x60;.
    /// </summary>
    [DataContract(Name = "ClientValidationsValidateResponseBody")]
    public partial class ClientValidationsValidateResponseBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientValidationsValidateResponseBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientValidationsValidateResponseBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientValidationsValidateResponseBody" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the validation, assigned by Voucherify..</param>
        /// <param name="valid">The result of the validation. It takes all of the redeemables into account and returns a &#x60;false&#x60; if at least one redeemable is inapplicable. Returns &#x60;true&#x60; if all redeemables are applicable..</param>
        /// <param name="redeemables">redeemables.</param>
        /// <param name="skippedRedeemables">Lists validation results of each skipped redeemable..</param>
        /// <param name="inapplicableRedeemables">Lists validation results of each inapplicable redeemable..</param>
        /// <param name="order">order.</param>
        /// <param name="trackingId">Hashed customer source ID..</param>
        /// <param name="session">session.</param>
        /// <param name="stackingRules">stackingRules (required).</param>
        public ClientValidationsValidateResponseBody(string id = default(string), bool? valid = default(bool?), List<ClientValidationsValidateResponseBodyRedeemablesItem> redeemables = default(List<ClientValidationsValidateResponseBodyRedeemablesItem>), List<ValidationsRedeemableSkipped> skippedRedeemables = default(List<ValidationsRedeemableSkipped>), List<ValidationsRedeemableInapplicable> inapplicableRedeemables = default(List<ValidationsRedeemableInapplicable>), ClientValidationsValidateResponseBodyOrder order = default(ClientValidationsValidateResponseBodyOrder), string trackingId = default(string), Session session = default(Session), StackingRules stackingRules = default(StackingRules))
        {
            // to ensure "stackingRules" is required (not null)
            if (stackingRules == null)
            {
                throw new ArgumentNullException("stackingRules is a required property for ClientValidationsValidateResponseBody and cannot be null");
            }
            this._StackingRules = stackingRules;
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Valid = valid;
            if (this.Valid != null)
            {
                this._flagValid = true;
            }
            this._Redeemables = redeemables;
            if (this.Redeemables != null)
            {
                this._flagRedeemables = true;
            }
            this._SkippedRedeemables = skippedRedeemables;
            if (this.SkippedRedeemables != null)
            {
                this._flagSkippedRedeemables = true;
            }
            this._InapplicableRedeemables = inapplicableRedeemables;
            if (this.InapplicableRedeemables != null)
            {
                this._flagInapplicableRedeemables = true;
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
            this._Session = session;
            if (this.Session != null)
            {
                this._flagSession = true;
            }
        }

        /// <summary>
        /// Unique identifier of the validation, assigned by Voucherify.
        /// </summary>
        /// <value>Unique identifier of the validation, assigned by Voucherify.</value>
        /*
        <example>valid_101740aa2869354c6d</example>
        */
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
        /// The result of the validation. It takes all of the redeemables into account and returns a &#x60;false&#x60; if at least one redeemable is inapplicable. Returns &#x60;true&#x60; if all redeemables are applicable.
        /// </summary>
        /// <value>The result of the validation. It takes all of the redeemables into account and returns a &#x60;false&#x60; if at least one redeemable is inapplicable. Returns &#x60;true&#x60; if all redeemables are applicable.</value>
        [DataMember(Name = "valid", EmitDefaultValue = true)]
        public bool? Valid
        {
            get{ return _Valid;}
            set
            {
                _Valid = value;
                _flagValid = true;
            }
        }
        private bool? _Valid;
        private bool _flagValid;

        /// <summary>
        /// Returns false as Valid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValid()
        {
            return _flagValid;
        }
        /// <summary>
        /// Gets or Sets Redeemables
        /// </summary>
        [DataMember(Name = "redeemables", EmitDefaultValue = true)]
        public List<ClientValidationsValidateResponseBodyRedeemablesItem> Redeemables
        {
            get{ return _Redeemables;}
            set
            {
                _Redeemables = value;
                _flagRedeemables = true;
            }
        }
        private List<ClientValidationsValidateResponseBodyRedeemablesItem> _Redeemables;
        private bool _flagRedeemables;

        /// <summary>
        /// Returns false as Redeemables should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRedeemables()
        {
            return _flagRedeemables;
        }
        /// <summary>
        /// Lists validation results of each skipped redeemable.
        /// </summary>
        /// <value>Lists validation results of each skipped redeemable.</value>
        [DataMember(Name = "skipped_redeemables", EmitDefaultValue = true)]
        public List<ValidationsRedeemableSkipped> SkippedRedeemables
        {
            get{ return _SkippedRedeemables;}
            set
            {
                _SkippedRedeemables = value;
                _flagSkippedRedeemables = true;
            }
        }
        private List<ValidationsRedeemableSkipped> _SkippedRedeemables;
        private bool _flagSkippedRedeemables;

        /// <summary>
        /// Returns false as SkippedRedeemables should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSkippedRedeemables()
        {
            return _flagSkippedRedeemables;
        }
        /// <summary>
        /// Lists validation results of each inapplicable redeemable.
        /// </summary>
        /// <value>Lists validation results of each inapplicable redeemable.</value>
        [DataMember(Name = "inapplicable_redeemables", EmitDefaultValue = true)]
        public List<ValidationsRedeemableInapplicable> InapplicableRedeemables
        {
            get{ return _InapplicableRedeemables;}
            set
            {
                _InapplicableRedeemables = value;
                _flagInapplicableRedeemables = true;
            }
        }
        private List<ValidationsRedeemableInapplicable> _InapplicableRedeemables;
        private bool _flagInapplicableRedeemables;

        /// <summary>
        /// Returns false as InapplicableRedeemables should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInapplicableRedeemables()
        {
            return _flagInapplicableRedeemables;
        }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public ClientValidationsValidateResponseBodyOrder Order
        {
            get{ return _Order;}
            set
            {
                _Order = value;
                _flagOrder = true;
            }
        }
        private ClientValidationsValidateResponseBodyOrder _Order;
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
        /// Hashed customer source ID.
        /// </summary>
        /// <value>Hashed customer source ID.</value>
        /*
        <example>track_VAVo1/z+G2GI2LPw&#x3D;&#x3D;</example>
        */
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
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = true)]
        public Session Session
        {
            get{ return _Session;}
            set
            {
                _Session = value;
                _flagSession = true;
            }
        }
        private Session _Session;
        private bool _flagSession;

        /// <summary>
        /// Returns false as Session should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSession()
        {
            return _flagSession;
        }
        /// <summary>
        /// Gets or Sets StackingRules
        /// </summary>
        [DataMember(Name = "stacking_rules", IsRequired = true, EmitDefaultValue = true)]
        public StackingRules StackingRules
        {
            get{ return _StackingRules;}
            set
            {
                _StackingRules = value;
                _flagStackingRules = true;
            }
        }
        private StackingRules _StackingRules;
        private bool _flagStackingRules;

        /// <summary>
        /// Returns false as StackingRules should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStackingRules()
        {
            return _flagStackingRules;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientValidationsValidateResponseBody {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Redeemables: ").Append(Redeemables).Append("\n");
            sb.Append("  SkippedRedeemables: ").Append(SkippedRedeemables).Append("\n");
            sb.Append("  InapplicableRedeemables: ").Append(InapplicableRedeemables).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  StackingRules: ").Append(StackingRules).Append("\n");
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
