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
    /// Defines ParameterExpandListCampaigns
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParameterExpandListCampaigns
    {
        /// <summary>
        /// Enum Category for value: category
        /// </summary>
        [EnumMember(Value = "category")]
        Category = 1,

        /// <summary>
        /// Enum AccessSettingsAssignments for value: access_settings_assignments
        /// </summary>
        [EnumMember(Value = "access_settings_assignments")]
        AccessSettingsAssignments = 2
    }

}
