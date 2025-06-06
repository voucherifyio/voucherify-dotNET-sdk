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
    /// Response body schema for **GET** &#x60;v1/client/v1/promotions/tiers&#x60;.
    /// </summary>
    [DataContract(Name = "ClientPromotionsTiersListResponseBody")]
    public partial class ClientPromotionsTiersListResponseBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPromotionsTiersListResponseBody" /> class.
        /// </summary>
        /// <param name="varObject">The type of the object represented by JSON. This object stores information about promotion tiers in a dictionary..</param>
        /// <param name="dataRef">Identifies the name of the attribute that contains the array of promotion tier objects..</param>
        /// <param name="tiers">Contains array of promotion tier objects..</param>
        /// <param name="total">Total number of promotion tiers..</param>
        /// <param name="hasMore">As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request to get more records returned in the results..</param>
        public ClientPromotionsTiersListResponseBody(string varObject = default(string), string dataRef = default(string), List<PromotionTier> tiers = default(List<PromotionTier>), int? total = default(int?), bool? hasMore = default(bool?))
        {
            this._Object = varObject;
            if (this.Object != null)
            {
                this._flagObject = true;
            }
            this._DataRef = dataRef;
            if (this.DataRef != null)
            {
                this._flagDataRef = true;
            }
            this._Tiers = tiers;
            if (this.Tiers != null)
            {
                this._flagTiers = true;
            }
            this._Total = total;
            if (this.Total != null)
            {
                this._flagTotal = true;
            }
            this._HasMore = hasMore;
            if (this.HasMore != null)
            {
                this._flagHasMore = true;
            }
        }

        /// <summary>
        /// The type of the object represented by JSON. This object stores information about promotion tiers in a dictionary.
        /// </summary>
        /// <value>The type of the object represented by JSON. This object stores information about promotion tiers in a dictionary.</value>
        [DataMember(Name = "object", EmitDefaultValue = true)]
        public string Object
        {
            get{ return _Object;}
            set
            {
                _Object = value;
                _flagObject = true;
            }
        }
        private string _Object;
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
        /// Identifies the name of the attribute that contains the array of promotion tier objects.
        /// </summary>
        /// <value>Identifies the name of the attribute that contains the array of promotion tier objects.</value>
        [DataMember(Name = "data_ref", EmitDefaultValue = true)]
        public string DataRef
        {
            get{ return _DataRef;}
            set
            {
                _DataRef = value;
                _flagDataRef = true;
            }
        }
        private string _DataRef;
        private bool _flagDataRef;

        /// <summary>
        /// Returns false as DataRef should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDataRef()
        {
            return _flagDataRef;
        }
        /// <summary>
        /// Contains array of promotion tier objects.
        /// </summary>
        /// <value>Contains array of promotion tier objects.</value>
        [DataMember(Name = "tiers", EmitDefaultValue = true)]
        public List<PromotionTier> Tiers
        {
            get{ return _Tiers;}
            set
            {
                _Tiers = value;
                _flagTiers = true;
            }
        }
        private List<PromotionTier> _Tiers;
        private bool _flagTiers;

        /// <summary>
        /// Returns false as Tiers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTiers()
        {
            return _flagTiers;
        }
        /// <summary>
        /// Total number of promotion tiers.
        /// </summary>
        /// <value>Total number of promotion tiers.</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public int? Total
        {
            get{ return _Total;}
            set
            {
                _Total = value;
                _flagTotal = true;
            }
        }
        private int? _Total;
        private bool _flagTotal;

        /// <summary>
        /// Returns false as Total should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotal()
        {
            return _flagTotal;
        }
        /// <summary>
        /// As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request to get more records returned in the results.
        /// </summary>
        /// <value>As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request to get more records returned in the results.</value>
        [DataMember(Name = "has_more", EmitDefaultValue = true)]
        public bool? HasMore
        {
            get{ return _HasMore;}
            set
            {
                _HasMore = value;
                _flagHasMore = true;
            }
        }
        private bool? _HasMore;
        private bool _flagHasMore;

        /// <summary>
        /// Returns false as HasMore should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasMore()
        {
            return _flagHasMore;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientPromotionsTiersListResponseBody {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  DataRef: ").Append(DataRef).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
