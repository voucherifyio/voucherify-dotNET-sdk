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
    /// Determines the notification settings.
    /// </summary>
    [DataContract(Name = "ManagementProjectApiUsageNotifications")]
    public partial class ManagementProjectApiUsageNotifications : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectApiUsageNotifications" /> class.
        /// </summary>
        /// <param name="redemptions">redemptions.</param>
        /// <param name="messages">messages.</param>
        /// <param name="apiCalls">apiCalls.</param>
        /// <param name="bulkApiCalls">bulkApiCalls.</param>
        /// <param name="webhookCalls">webhookCalls.</param>
        /// <param name="cycleCalls">cycleCalls.</param>
        public ManagementProjectApiUsageNotifications(UsageNotifications redemptions = default(UsageNotifications), UsageNotifications messages = default(UsageNotifications), UsageNotifications apiCalls = default(UsageNotifications), UsageNotifications bulkApiCalls = default(UsageNotifications), UsageNotifications webhookCalls = default(UsageNotifications), UsageNotifications cycleCalls = default(UsageNotifications))
        {
            this._Redemptions = redemptions;
            if (this.Redemptions != null)
            {
                this._flagRedemptions = true;
            }
            this._Messages = messages;
            if (this.Messages != null)
            {
                this._flagMessages = true;
            }
            this._ApiCalls = apiCalls;
            if (this.ApiCalls != null)
            {
                this._flagApiCalls = true;
            }
            this._BulkApiCalls = bulkApiCalls;
            if (this.BulkApiCalls != null)
            {
                this._flagBulkApiCalls = true;
            }
            this._WebhookCalls = webhookCalls;
            if (this.WebhookCalls != null)
            {
                this._flagWebhookCalls = true;
            }
            this._CycleCalls = cycleCalls;
            if (this.CycleCalls != null)
            {
                this._flagCycleCalls = true;
            }
        }

        /// <summary>
        /// Gets or Sets Redemptions
        /// </summary>
        [DataMember(Name = "redemptions", EmitDefaultValue = true)]
        public UsageNotifications Redemptions
        {
            get{ return _Redemptions;}
            set
            {
                _Redemptions = value;
                _flagRedemptions = true;
            }
        }
        private UsageNotifications _Redemptions;
        private bool _flagRedemptions;

        /// <summary>
        /// Returns false as Redemptions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRedemptions()
        {
            return _flagRedemptions;
        }
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = true)]
        public UsageNotifications Messages
        {
            get{ return _Messages;}
            set
            {
                _Messages = value;
                _flagMessages = true;
            }
        }
        private UsageNotifications _Messages;
        private bool _flagMessages;

        /// <summary>
        /// Returns false as Messages should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMessages()
        {
            return _flagMessages;
        }
        /// <summary>
        /// Gets or Sets ApiCalls
        /// </summary>
        [DataMember(Name = "api_calls", EmitDefaultValue = true)]
        public UsageNotifications ApiCalls
        {
            get{ return _ApiCalls;}
            set
            {
                _ApiCalls = value;
                _flagApiCalls = true;
            }
        }
        private UsageNotifications _ApiCalls;
        private bool _flagApiCalls;

        /// <summary>
        /// Returns false as ApiCalls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApiCalls()
        {
            return _flagApiCalls;
        }
        /// <summary>
        /// Gets or Sets BulkApiCalls
        /// </summary>
        [DataMember(Name = "bulk_api_calls", EmitDefaultValue = true)]
        public UsageNotifications BulkApiCalls
        {
            get{ return _BulkApiCalls;}
            set
            {
                _BulkApiCalls = value;
                _flagBulkApiCalls = true;
            }
        }
        private UsageNotifications _BulkApiCalls;
        private bool _flagBulkApiCalls;

        /// <summary>
        /// Returns false as BulkApiCalls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBulkApiCalls()
        {
            return _flagBulkApiCalls;
        }
        /// <summary>
        /// Gets or Sets WebhookCalls
        /// </summary>
        [DataMember(Name = "webhook_calls", EmitDefaultValue = true)]
        public UsageNotifications WebhookCalls
        {
            get{ return _WebhookCalls;}
            set
            {
                _WebhookCalls = value;
                _flagWebhookCalls = true;
            }
        }
        private UsageNotifications _WebhookCalls;
        private bool _flagWebhookCalls;

        /// <summary>
        /// Returns false as WebhookCalls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWebhookCalls()
        {
            return _flagWebhookCalls;
        }
        /// <summary>
        /// Gets or Sets CycleCalls
        /// </summary>
        [DataMember(Name = "cycle_calls", EmitDefaultValue = true)]
        public UsageNotifications CycleCalls
        {
            get{ return _CycleCalls;}
            set
            {
                _CycleCalls = value;
                _flagCycleCalls = true;
            }
        }
        private UsageNotifications _CycleCalls;
        private bool _flagCycleCalls;

        /// <summary>
        /// Returns false as CycleCalls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCycleCalls()
        {
            return _flagCycleCalls;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManagementProjectApiUsageNotifications {\n");
            sb.Append("  Redemptions: ").Append(Redemptions).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  ApiCalls: ").Append(ApiCalls).Append("\n");
            sb.Append("  BulkApiCalls: ").Append(BulkApiCalls).Append("\n");
            sb.Append("  WebhookCalls: ").Append(WebhookCalls).Append("\n");
            sb.Append("  CycleCalls: ").Append(CycleCalls).Append("\n");
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
