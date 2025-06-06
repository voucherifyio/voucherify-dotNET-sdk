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
    /// Response body schema for **PUT** &#x60;v1/products/{productId}/skus/{skuId}&#x60;.
    /// </summary>
    [DataContract(Name = "ProductsSkusUpdateResponseBody")]
    public partial class ProductsSkusUpdateResponseBody : IValidatableObject
    {
        /// <summary>
        /// The type of the object represented by JSON. This object stores information about the &#x60;SKU&#x60;.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about the &#x60;SKU&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Sku for value: sku
            /// </summary>
            [EnumMember(Value = "sku")]
            Sku = 1
        }


        /// <summary>
        /// The type of the object represented by JSON. This object stores information about the &#x60;SKU&#x60;.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about the &#x60;SKU&#x60;.</value>

        [DataMember(Name = "object", EmitDefaultValue = true)]
        public ObjectEnum? Object
        {
            get{ return _Object;}
            set
            {
                _Object = value;
                _flagObject = true;
            }
        }
        private ObjectEnum? _Object;
        private bool _flagObject;

        /// <summary>
        /// Returns false as Object should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObject()
        {
            return _flagObject;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsSkusUpdateResponseBody" /> class.
        /// </summary>
        /// <param name="id">A unique identifier that represents the SKU and is assigned by Voucherify..</param>
        /// <param name="sourceId">A unique SKU identifier from your inventory system..</param>
        /// <param name="productId">The parent product&#39;s unique ID..</param>
        /// <param name="sku">Unique user-defined SKU name..</param>
        /// <param name="price">Unit price. It is represented by a value multiplied by 100 to accurately reflect 2 decimal places, such as &#x60;$100.00&#x60; being expressed as &#x60;10000&#x60;..</param>
        /// <param name="currency">SKU price currency..</param>
        /// <param name="attributes">The attributes object stores values for all custom attributes inherited by the SKU from the parent product. A set of key/value pairs that are attached to a SKU object and are unique to each SKU within a product family..</param>
        /// <param name="imageUrl">The HTTPS URL pointing to the .png or .jpg file that will be used to render the SKU image..</param>
        /// <param name="metadata">The metadata object stores all custom attributes assigned to the SKU. A set of key/value pairs that you can attach to a SKU object. It can be useful for storing additional information about the SKU in a structured format. It can be used to create product collections..</param>
        /// <param name="createdAt">Timestamp representing the date and time when the SKU was created. The value is shown in the ISO 8601 format..</param>
        /// <param name="updatedAt">Timestamp representing the date and time when the SKU was updated. The value is shown in the ISO 8601 format..</param>
        /// <param name="varObject">The type of the object represented by JSON. This object stores information about the &#x60;SKU&#x60;..</param>
        public ProductsSkusUpdateResponseBody(string id = default(string), string sourceId = default(string), string productId = default(string), string sku = default(string), int? price = default(int?), string currency = default(string), Object attributes = default(Object), string imageUrl = default(string), Object metadata = default(Object), DateTimeOffset? createdAt = default(DateTimeOffset?), DateTimeOffset? updatedAt = default(DateTimeOffset?), ObjectEnum? varObject = default(ObjectEnum?))
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
            this._ProductId = productId;
            if (this.ProductId != null)
            {
                this._flagProductId = true;
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
            this._Currency = currency;
            if (this.Currency != null)
            {
                this._flagCurrency = true;
            }
            this._Attributes = attributes;
            if (this.Attributes != null)
            {
                this._flagAttributes = true;
            }
            this._ImageUrl = imageUrl;
            if (this.ImageUrl != null)
            {
                this._flagImageUrl = true;
            }
            this._Metadata = metadata;
            if (this.Metadata != null)
            {
                this._flagMetadata = true;
            }
            this._CreatedAt = createdAt;
            if (this.CreatedAt != null)
            {
                this._flagCreatedAt = true;
            }
            this._UpdatedAt = updatedAt;
            if (this.UpdatedAt != null)
            {
                this._flagUpdatedAt = true;
            }
            this._Object = varObject;
            if (this.Object != null)
            {
                this._flagObject = true;
            }
        }

        /// <summary>
        /// A unique identifier that represents the SKU and is assigned by Voucherify.
        /// </summary>
        /// <value>A unique identifier that represents the SKU and is assigned by Voucherify.</value>
        /*
        <example>sku_0b1621b319d248b79f</example>
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
        /// A unique SKU identifier from your inventory system.
        /// </summary>
        /// <value>A unique SKU identifier from your inventory system.</value>
        /*
        <example>sku_source_id_4</example>
        */
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
        /// The parent product&#39;s unique ID.
        /// </summary>
        /// <value>The parent product&#39;s unique ID.</value>
        /*
        <example>prod_0b15f6b9f650c16990</example>
        */
        [DataMember(Name = "product_id", EmitDefaultValue = true)]
        public string ProductId
        {
            get{ return _ProductId;}
            set
            {
                _ProductId = value;
                _flagProductId = true;
            }
        }
        private string _ProductId;
        private bool _flagProductId;

        /// <summary>
        /// Returns false as ProductId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProductId()
        {
            return _flagProductId;
        }
        /// <summary>
        /// Unique user-defined SKU name.
        /// </summary>
        /// <value>Unique user-defined SKU name.</value>
        /*
        <example>Large Pink Shirt</example>
        */
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
        /// Unit price. It is represented by a value multiplied by 100 to accurately reflect 2 decimal places, such as &#x60;$100.00&#x60; being expressed as &#x60;10000&#x60;.
        /// </summary>
        /// <value>Unit price. It is represented by a value multiplied by 100 to accurately reflect 2 decimal places, such as &#x60;$100.00&#x60; being expressed as &#x60;10000&#x60;.</value>
        [DataMember(Name = "price", EmitDefaultValue = true)]
        public int? Price
        {
            get{ return _Price;}
            set
            {
                _Price = value;
                _flagPrice = true;
            }
        }
        private int? _Price;
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
        /// SKU price currency.
        /// </summary>
        /// <value>SKU price currency.</value>
        /*
        <example>USD</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency
        {
            get{ return _Currency;}
            set
            {
                _Currency = value;
                _flagCurrency = true;
            }
        }
        private string _Currency;
        private bool _flagCurrency;

        /// <summary>
        /// Returns false as Currency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrency()
        {
            return _flagCurrency;
        }
        /// <summary>
        /// The attributes object stores values for all custom attributes inherited by the SKU from the parent product. A set of key/value pairs that are attached to a SKU object and are unique to each SKU within a product family.
        /// </summary>
        /// <value>The attributes object stores values for all custom attributes inherited by the SKU from the parent product. A set of key/value pairs that are attached to a SKU object and are unique to each SKU within a product family.</value>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public Object Attributes
        {
            get{ return _Attributes;}
            set
            {
                _Attributes = value;
                _flagAttributes = true;
            }
        }
        private Object _Attributes;
        private bool _flagAttributes;

        /// <summary>
        /// Returns false as Attributes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttributes()
        {
            return _flagAttributes;
        }
        /// <summary>
        /// The HTTPS URL pointing to the .png or .jpg file that will be used to render the SKU image.
        /// </summary>
        /// <value>The HTTPS URL pointing to the .png or .jpg file that will be used to render the SKU image.</value>
        [DataMember(Name = "image_url", EmitDefaultValue = true)]
        public string ImageUrl
        {
            get{ return _ImageUrl;}
            set
            {
                _ImageUrl = value;
                _flagImageUrl = true;
            }
        }
        private string _ImageUrl;
        private bool _flagImageUrl;

        /// <summary>
        /// Returns false as ImageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeImageUrl()
        {
            return _flagImageUrl;
        }
        /// <summary>
        /// The metadata object stores all custom attributes assigned to the SKU. A set of key/value pairs that you can attach to a SKU object. It can be useful for storing additional information about the SKU in a structured format. It can be used to create product collections.
        /// </summary>
        /// <value>The metadata object stores all custom attributes assigned to the SKU. A set of key/value pairs that you can attach to a SKU object. It can be useful for storing additional information about the SKU in a structured format. It can be used to create product collections.</value>
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
        /// Timestamp representing the date and time when the SKU was created. The value is shown in the ISO 8601 format.
        /// </summary>
        /// <value>Timestamp representing the date and time when the SKU was created. The value is shown in the ISO 8601 format.</value>
        /*
        <example>2022-05-17T10:36:30.187Z</example>
        */
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTimeOffset? CreatedAt
        {
            get{ return _CreatedAt;}
            set
            {
                _CreatedAt = value;
                _flagCreatedAt = true;
            }
        }
        private DateTimeOffset? _CreatedAt;
        private bool _flagCreatedAt;

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return _flagCreatedAt;
        }
        /// <summary>
        /// Timestamp representing the date and time when the SKU was updated. The value is shown in the ISO 8601 format.
        /// </summary>
        /// <value>Timestamp representing the date and time when the SKU was updated. The value is shown in the ISO 8601 format.</value>
        /*
        <example>2022-05-17T10:55:09.137Z</example>
        */
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public DateTimeOffset? UpdatedAt
        {
            get{ return _UpdatedAt;}
            set
            {
                _UpdatedAt = value;
                _flagUpdatedAt = true;
            }
        }
        private DateTimeOffset? _UpdatedAt;
        private bool _flagUpdatedAt;

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return _flagUpdatedAt;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductsSkusUpdateResponseBody {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
