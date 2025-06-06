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
    /// RedemptionsGetResponseBodyOrderItemsItemSku
    /// </summary>
    [DataContract(Name = "RedemptionsGetResponseBodyOrderItemsItemSku")]
    public partial class RedemptionsGetResponseBodyOrderItemsItemSku : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionsGetResponseBodyOrderItemsItemSku" /> class.
        /// </summary>
        /// <param name="id">A unique identifier that represents the SKU and is assigned by Voucherify..</param>
        /// <param name="sourceId">The merchant&#39;s SKU ID (if it is different than Voucherify&#39;s SKU ID). It is really useful in case of integration between multiple systems. It can be an ID from an eCommerce site, a database or a 3rd party service..</param>
        /// <param name="varOverride">The override set to &#x60;true&#x60; is used to store the product information in the system. If the product does not exist, it will be created with a source_id; if it does exist, the provided values for the name, price, and metadata will replace those already stored in the system..</param>
        /// <param name="sku">The SKU name..</param>
        /// <param name="price">SKU price. A positive integer in the smallest currency unit (e.g. 100 cents for $1.00)..</param>
        /// <param name="metadata">A set of custom key/value pairs that you can attach to an SKU. It can be useful for storing additional information about the SKU in a structured format. It can be used to create product collections..</param>
        public RedemptionsGetResponseBodyOrderItemsItemSku(string id = default(string), string sourceId = default(string), bool? varOverride = default(bool?), string sku = default(string), decimal? price = default(decimal?), Object metadata = default(Object))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._SourceId = sourceId;
            if (this.SourceId != null)
            {
                this._flagSourceId = true;
            }
            this._Override = varOverride;
            if (this.Override != null)
            {
                this._flagOverride = true;
            }
            this._Sku = sku;
            if (this.Sku != null)
            {
                this._flagSku = true;
            }
            this._Price = price;
            if (this.Price != null)
            {
                this._flagPrice = true;
            }
            this._Metadata = metadata;
            if (this.Metadata != null)
            {
                this._flagMetadata = true;
            }
        }

        /// <summary>
        /// A unique identifier that represents the SKU and is assigned by Voucherify.
        /// </summary>
        /// <value>A unique identifier that represents the SKU and is assigned by Voucherify.</value>
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
        /// The merchant&#39;s SKU ID (if it is different than Voucherify&#39;s SKU ID). It is really useful in case of integration between multiple systems. It can be an ID from an eCommerce site, a database or a 3rd party service.
        /// </summary>
        /// <value>The merchant&#39;s SKU ID (if it is different than Voucherify&#39;s SKU ID). It is really useful in case of integration between multiple systems. It can be an ID from an eCommerce site, a database or a 3rd party service.</value>
        [DataMember(Name = "source_id", EmitDefaultValue = true)]
        public string SourceId
        {
            get{ return _SourceId;}
            set
            {
                _SourceId = value;
                _flagSourceId = true;
            }
        }
        private string _SourceId;
        private bool _flagSourceId;

        /// <summary>
        /// Returns false as SourceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSourceId()
        {
            return _flagSourceId;
        }
        /// <summary>
        /// The override set to &#x60;true&#x60; is used to store the product information in the system. If the product does not exist, it will be created with a source_id; if it does exist, the provided values for the name, price, and metadata will replace those already stored in the system.
        /// </summary>
        /// <value>The override set to &#x60;true&#x60; is used to store the product information in the system. If the product does not exist, it will be created with a source_id; if it does exist, the provided values for the name, price, and metadata will replace those already stored in the system.</value>
        [DataMember(Name = "override", EmitDefaultValue = true)]
        public bool? Override
        {
            get{ return _Override;}
            set
            {
                _Override = value;
                _flagOverride = true;
            }
        }
        private bool? _Override;
        private bool _flagOverride;

        /// <summary>
        /// Returns false as Override should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOverride()
        {
            return _flagOverride;
        }
        /// <summary>
        /// The SKU name.
        /// </summary>
        /// <value>The SKU name.</value>
        [DataMember(Name = "sku", EmitDefaultValue = true)]
        public string Sku
        {
            get{ return _Sku;}
            set
            {
                _Sku = value;
                _flagSku = true;
            }
        }
        private string _Sku;
        private bool _flagSku;

        /// <summary>
        /// Returns false as Sku should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSku()
        {
            return _flagSku;
        }
        /// <summary>
        /// SKU price. A positive integer in the smallest currency unit (e.g. 100 cents for $1.00).
        /// </summary>
        /// <value>SKU price. A positive integer in the smallest currency unit (e.g. 100 cents for $1.00).</value>
        [DataMember(Name = "price", EmitDefaultValue = true)]
        public decimal? Price
        {
            get{ return _Price;}
            set
            {
                _Price = value;
                _flagPrice = true;
            }
        }
        private decimal? _Price;
        private bool _flagPrice;

        /// <summary>
        /// Returns false as Price should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrice()
        {
            return _flagPrice;
        }
        /// <summary>
        /// A set of custom key/value pairs that you can attach to an SKU. It can be useful for storing additional information about the SKU in a structured format. It can be used to create product collections.
        /// </summary>
        /// <value>A set of custom key/value pairs that you can attach to an SKU. It can be useful for storing additional information about the SKU in a structured format. It can be used to create product collections.</value>
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
            sb.Append("class RedemptionsGetResponseBodyOrderItemsItemSku {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
