# Voucherify.Api.TemplatesApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTierFromTemplate**](TemplatesApi.md#addtierfromtemplate) | **POST** /v1/templates/campaigns/{campaignTemplateId}/tier-setup | Add Promotion Tier From Template |
| [**CreateCampaignFromTemplate**](TemplatesApi.md#createcampaignfromtemplate) | **POST** /v1/templates/campaigns/{campaignTemplateId}/campaign-setup | Create Campaign From Template |
| [**CreateCampaignTemplate**](TemplatesApi.md#createcampaigntemplate) | **POST** /v1/templates/campaigns | Create Campaign Template |
| [**DeleteCampaignTemplate**](TemplatesApi.md#deletecampaigntemplate) | **DELETE** /v1/templates/campaigns/{campaignTemplateId} | Delete Campaign Template |
| [**GetCampaignTemplate**](TemplatesApi.md#getcampaigntemplate) | **GET** /v1/templates/campaigns/{campaignTemplateId} | Get Campaign Template |
| [**ListCampaignTemplates**](TemplatesApi.md#listcampaigntemplates) | **GET** /v1/templates/campaigns | List Campaign Templates |
| [**UpdateCampaignTemplate**](TemplatesApi.md#updatecampaigntemplate) | **PUT** /v1/templates/campaigns/{campaignTemplateId} | Update Campaign Template |

<a id="addtierfromtemplate"></a>
# **AddTierFromTemplate**
> TemplatesCampaignsTierSetupCreateResponseBody AddTierFromTemplate (string campaignTemplateId, TemplatesCampaignsTierSetupCreateRequestBody templatesCampaignsTierSetupCreateRequestBody = null)

Add Promotion Tier From Template

Creates a promotion tier out of a discount campaign template and adds it to an existing promotion campaign. To add a promotion tier to a campaign, you need to provide the name in the request and the campaign ID. Other fields are optional. If no other fields are sent, the configuration from the template will be used. You can send new values of the fields listed below to replace the settings saved in the template. However, you cannot assign an action or an existing validation rule or create a new one in the request. If the template has a validation rule, a new validation rule is always created for the promotion tier. When the promotion tier has been created, then you can: - Update the validation rule, - Unassign the validation rule, - Assign an existing validation rule.  👍 Promotion Tiers and Campaign Templates You can create a campaign template out of a promotion tier. Promotion tiers are converted to a discount campaign with the DISCOUNT_COUPON type. You can use this template to create: - Discount campaign - Promotion tier  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class AddTierFromTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplatesApi(config);
            var campaignTemplateId = "campaignTemplateId_example";  // string | Pass the campaign template ID that was assigned by Voucherify.
            var templatesCampaignsTierSetupCreateRequestBody = new TemplatesCampaignsTierSetupCreateRequestBody(); // TemplatesCampaignsTierSetupCreateRequestBody | Only name and campaign_id are required. The rest of the fields will overwrite the template configuration. (optional) 

            try
            {
                // Add Promotion Tier From Template
                TemplatesCampaignsTierSetupCreateResponseBody result = apiInstance.AddTierFromTemplate(campaignTemplateId, templatesCampaignsTierSetupCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.AddTierFromTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTierFromTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Promotion Tier From Template
    ApiResponse<TemplatesCampaignsTierSetupCreateResponseBody> response = apiInstance.AddTierFromTemplateWithHttpInfo(campaignTemplateId, templatesCampaignsTierSetupCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.AddTierFromTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignTemplateId** | **string** | Pass the campaign template ID that was assigned by Voucherify. |  |
| **templatesCampaignsTierSetupCreateRequestBody** | [**TemplatesCampaignsTierSetupCreateRequestBody**](TemplatesCampaignsTierSetupCreateRequestBody.md) | Only name and campaign_id are required. The rest of the fields will overwrite the template configuration. | [optional]  |

### Return type

[**TemplatesCampaignsTierSetupCreateResponseBody**](TemplatesCampaignsTierSetupCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the added promotion tier and about the resources that have been created out of the template and added to the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcampaignfromtemplate"></a>
# **CreateCampaignFromTemplate**
> TemplatesCampaignsCampaignSetupCreateResponseBody CreateCampaignFromTemplate (string campaignTemplateId, TemplatesCampaignsCampaignSetupCreateRequestBody templatesCampaignsCampaignSetupCreateRequestBody = null)

Create Campaign From Template

Creates a campaign out of a campaign template. To create a campaign, you need to provide the name in the request, while other fields are optional. If no other fields are sent, the configuration from the template will be used. You can send new values of the fields listed below to replace the settings saved in the template. However, you cannot assign an existing validation rule or create a new one in the request. If the template has a validation rule, a new validation rule is always created for the campaign. When the campaign has been created, then you can: - Update the validation rule, - Unassign the validation rule, - Assign an existing validation rule.  👍 Promotion Tiers and Campaign Templates You can create a campaign template out of a promotion tier. Promotion tiers are converted to a discount campaign with the DISCOUNT_COUPON type. You can use this template to create: - Discount campaign - Promotion tier  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateCampaignFromTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplatesApi(config);
            var campaignTemplateId = "campaignTemplateId_example";  // string | Pass the campaign template ID that was assigned by Voucherify.
            var templatesCampaignsCampaignSetupCreateRequestBody = new TemplatesCampaignsCampaignSetupCreateRequestBody(); // TemplatesCampaignsCampaignSetupCreateRequestBody | Only name is required. The rest of the fields will overwrite the template configuration. (optional) 

            try
            {
                // Create Campaign From Template
                TemplatesCampaignsCampaignSetupCreateResponseBody result = apiInstance.CreateCampaignFromTemplate(campaignTemplateId, templatesCampaignsCampaignSetupCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateCampaignFromTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCampaignFromTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Campaign From Template
    ApiResponse<TemplatesCampaignsCampaignSetupCreateResponseBody> response = apiInstance.CreateCampaignFromTemplateWithHttpInfo(campaignTemplateId, templatesCampaignsCampaignSetupCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.CreateCampaignFromTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignTemplateId** | **string** | Pass the campaign template ID that was assigned by Voucherify. |  |
| **templatesCampaignsCampaignSetupCreateRequestBody** | [**TemplatesCampaignsCampaignSetupCreateRequestBody**](TemplatesCampaignsCampaignSetupCreateRequestBody.md) | Only name is required. The rest of the fields will overwrite the template configuration. | [optional]  |

### Return type

[**TemplatesCampaignsCampaignSetupCreateResponseBody**](TemplatesCampaignsCampaignSetupCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the created campaign and about the resources that have been created out of the template and added to the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcampaigntemplate"></a>
# **CreateCampaignTemplate**
> TemplatesCampaignsCreateTemplateResponseBody CreateCampaignTemplate (TemplatesCampaignsCreateRequestBody templatesCampaignsCreateRequestBody = null)

Create Campaign Template

Creates a template for a discount or gift campaign, or a promotion tier. A template stores campaign configuration **without** the following details: - Campaign name - Category - Code count The following elements are not supported by campaign templates: - Redeeming API keys - Redeeming users - Customer loyalty tier - Static segments  👍 Promotion Tiers and Campaign Templates You can create a campaign template out of a promotion tier. Promotion tiers are converted to a discount campaign with the DISCOUNT_COUPON type. You can use this template to create: - Discount campaign, - Promotion tier.  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateCampaignTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplatesApi(config);
            var templatesCampaignsCreateRequestBody = new TemplatesCampaignsCreateRequestBody(); // TemplatesCampaignsCreateRequestBody | Provide details for a campaign template (optional) 

            try
            {
                // Create Campaign Template
                TemplatesCampaignsCreateTemplateResponseBody result = apiInstance.CreateCampaignTemplate(templatesCampaignsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateCampaignTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCampaignTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Campaign Template
    ApiResponse<TemplatesCampaignsCreateTemplateResponseBody> response = apiInstance.CreateCampaignTemplateWithHttpInfo(templatesCampaignsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.CreateCampaignTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templatesCampaignsCreateRequestBody** | [**TemplatesCampaignsCreateRequestBody**](TemplatesCampaignsCreateRequestBody.md) | Provide details for a campaign template | [optional]  |

### Return type

[**TemplatesCampaignsCreateTemplateResponseBody**](TemplatesCampaignsCreateTemplateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details of a created campaign template. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecampaigntemplate"></a>
# **DeleteCampaignTemplate**
> void DeleteCampaignTemplate (string campaignTemplateId)

Delete Campaign Template

Deletes the campaign template permanently.  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteCampaignTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplatesApi(config);
            var campaignTemplateId = "campaignTemplateId_example";  // string | Pass the campaign template ID that was assigned by Voucherify.

            try
            {
                // Delete Campaign Template
                apiInstance.DeleteCampaignTemplate(campaignTemplateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteCampaignTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCampaignTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Campaign Template
    apiInstance.DeleteCampaignTemplateWithHttpInfo(campaignTemplateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.DeleteCampaignTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignTemplateId** | **string** | Pass the campaign template ID that was assigned by Voucherify. |  |

### Return type

void (empty response body)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if deletion is successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcampaigntemplate"></a>
# **GetCampaignTemplate**
> TemplatesCampaignsGetResponseBody GetCampaignTemplate (string campaignTemplateId)

Get Campaign Template

Retrieves a campaign template available in the project.  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetCampaignTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplatesApi(config);
            var campaignTemplateId = "campaignTemplateId_example";  // string | Pass the campaign template ID that was assigned by Voucherify.

            try
            {
                // Get Campaign Template
                TemplatesCampaignsGetResponseBody result = apiInstance.GetCampaignTemplate(campaignTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetCampaignTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Campaign Template
    ApiResponse<TemplatesCampaignsGetResponseBody> response = apiInstance.GetCampaignTemplateWithHttpInfo(campaignTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.GetCampaignTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignTemplateId** | **string** | Pass the campaign template ID that was assigned by Voucherify. |  |

### Return type

[**TemplatesCampaignsGetResponseBody**](TemplatesCampaignsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about a campaign template. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcampaigntemplates"></a>
# **ListCampaignTemplates**
> TemplatesCampaignsListResponseBody ListCampaignTemplates (int? limit = null, string startingAfterId = null, ParameterTemplatesList? order = null, bool? includeTotal = null, ParameterFiltersListTemplates filters = null)

List Campaign Templates

Lists all campaign templates available in the project.  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCampaignTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplatesApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the campaign templates created after a template with the given ID. (optional) 
            var order = (ParameterTemplatesList) "id";  // ParameterTemplatesList? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var includeTotal = true;  // bool? | If set to true, the response returns the number of all campaign templates, regardless of the applied filters or limits. Set to false by default. (optional) 
            var filters = new ParameterFiltersListTemplates(); // ParameterFiltersListTemplates | Filters for listing templates. (optional) 

            try
            {
                // List Campaign Templates
                TemplatesCampaignsListResponseBody result = apiInstance.ListCampaignTemplates(limit, startingAfterId, order, includeTotal, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListCampaignTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCampaignTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Campaign Templates
    ApiResponse<TemplatesCampaignsListResponseBody> response = apiInstance.ListCampaignTemplatesWithHttpInfo(limit, startingAfterId, order, includeTotal, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.ListCampaignTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the campaign templates created after a template with the given ID. | [optional]  |
| **order** | **ParameterTemplatesList?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **includeTotal** | **bool?** | If set to true, the response returns the number of all campaign templates, regardless of the applied filters or limits. Set to false by default. | [optional]  |
| **filters** | [**ParameterFiltersListTemplates**](ParameterFiltersListTemplates.md) | Filters for listing templates. | [optional]  |

### Return type

[**TemplatesCampaignsListResponseBody**](TemplatesCampaignsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of campaign template objects. The templates are returned by creation date by default. The most recent objects appear last unless specified otherwise with the &#x60;order&#x60; parameter. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecampaigntemplate"></a>
# **UpdateCampaignTemplate**
> TemplatesCampaignsUpdateResponseBody UpdateCampaignTemplate (string campaignTemplateId, TemplatesCampaignsUpdateRequestBody templatesCampaignsUpdateRequestBody = null)

Update Campaign Template

Updates the name or description of the campaign template.  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateCampaignTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplatesApi(config);
            var campaignTemplateId = "campaignTemplateId_example";  // string | Pass the campaign template ID that was assigned by Voucherify.
            var templatesCampaignsUpdateRequestBody = new TemplatesCampaignsUpdateRequestBody(); // TemplatesCampaignsUpdateRequestBody | Provide the new name or description for the campaign template (optional) 

            try
            {
                // Update Campaign Template
                TemplatesCampaignsUpdateResponseBody result = apiInstance.UpdateCampaignTemplate(campaignTemplateId, templatesCampaignsUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateCampaignTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCampaignTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Campaign Template
    ApiResponse<TemplatesCampaignsUpdateResponseBody> response = apiInstance.UpdateCampaignTemplateWithHttpInfo(campaignTemplateId, templatesCampaignsUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.UpdateCampaignTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignTemplateId** | **string** | Pass the campaign template ID that was assigned by Voucherify. |  |
| **templatesCampaignsUpdateRequestBody** | [**TemplatesCampaignsUpdateRequestBody**](TemplatesCampaignsUpdateRequestBody.md) | Provide the new name or description for the campaign template | [optional]  |

### Return type

[**TemplatesCampaignsUpdateResponseBody**](TemplatesCampaignsUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details of an updated campaign template. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

