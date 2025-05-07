# Voucherify.Api.PromotionsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPromotionTierToCampaign**](PromotionsApi.md#addpromotiontiertocampaign) | **POST** /v1/promotions/{campaignId}/tiers | Add Promotion Tier to Campaign |
| [**CreatePromotionStack**](PromotionsApi.md#createpromotionstack) | **POST** /v1/promotions/{campaignId}/stacks | Create Promotion Stack |
| [**DeletePromotionStack**](PromotionsApi.md#deletepromotionstack) | **DELETE** /v1/promotions/{campaignId}/stacks/{stackId} | Delete Promotion Stack |
| [**DeletePromotionTier**](PromotionsApi.md#deletepromotiontier) | **DELETE** /v1/promotions/tiers/{promotionTierId} | Delete Promotion Tier |
| [**DisablePromotionTier**](PromotionsApi.md#disablepromotiontier) | **POST** /v1/promotions/tiers/{promotionTierId}/disable | Disable Promotion Tier |
| [**EnablePromotionTier**](PromotionsApi.md#enablepromotiontier) | **POST** /v1/promotions/tiers/{promotionTierId}/enable | Enable Promotion Tier |
| [**GetPromotionStack**](PromotionsApi.md#getpromotionstack) | **GET** /v1/promotions/{campaignId}/stacks/{stackId} | Get Promotion Stack |
| [**GetPromotionTier**](PromotionsApi.md#getpromotiontier) | **GET** /v1/promotions/tiers/{promotionTierId} | Get Promotion Tier |
| [**ListAllPromotionStacks**](PromotionsApi.md#listallpromotionstacks) | **GET** /v1/promotions/stacks | List Promotion Stacks |
| [**ListPromotionStacksInCampaign**](PromotionsApi.md#listpromotionstacksincampaign) | **GET** /v1/promotions/{campaignId}/stacks | List Promotion Stacks in Campaign |
| [**ListPromotionTiers**](PromotionsApi.md#listpromotiontiers) | **GET** /v1/promotions/tiers | List Promotion Tiers |
| [**ListPromotionTiersFromCampaign**](PromotionsApi.md#listpromotiontiersfromcampaign) | **GET** /v1/promotions/{campaignId}/tiers | List Promotion Tiers from Campaign |
| [**UpdatePromotionStack**](PromotionsApi.md#updatepromotionstack) | **PUT** /v1/promotions/{campaignId}/stacks/{stackId} | Update Promotion Stack |
| [**UpdatePromotionTier**](PromotionsApi.md#updatepromotiontier) | **PUT** /v1/promotions/tiers/{promotionTierId} | Update Promotion Tier |

<a id="addpromotiontiertocampaign"></a>
# **AddPromotionTierToCampaign**
> PromotionsTiersCreateResponseBody AddPromotionTierToCampaign (string campaignId, PromotionsTiersCreateRequestBody promotionsTiersCreateRequestBody = null)

Add Promotion Tier to Campaign

This method allows you to add a new promotion tier to an existing campaign. The tier hierarchy will be set as the next consequtive integer following the lowest ranking tier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class AddPromotionTierToCampaignExample
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

            var apiInstance = new PromotionsApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID assigned by Voucherify.
            var promotionsTiersCreateRequestBody = new PromotionsTiersCreateRequestBody(); // PromotionsTiersCreateRequestBody | Specify the promotion tier parameters. (optional) 

            try
            {
                // Add Promotion Tier to Campaign
                PromotionsTiersCreateResponseBody result = apiInstance.AddPromotionTierToCampaign(campaignId, promotionsTiersCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.AddPromotionTierToCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPromotionTierToCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Promotion Tier to Campaign
    ApiResponse<PromotionsTiersCreateResponseBody> response = apiInstance.AddPromotionTierToCampaignWithHttpInfo(campaignId, promotionsTiersCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.AddPromotionTierToCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID assigned by Voucherify. |  |
| **promotionsTiersCreateRequestBody** | [**PromotionsTiersCreateRequestBody**](PromotionsTiersCreateRequestBody.md) | Specify the promotion tier parameters. | [optional]  |

### Return type

[**PromotionsTiersCreateResponseBody**](PromotionsTiersCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a promotion tier object if the promotion tier was successfully added to the campaign. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createpromotionstack"></a>
# **CreatePromotionStack**
> PromotionsStacksCreateResponseBody CreatePromotionStack (string campaignId, PromotionsStacksCreateRequestBody promotionsStacksCreateRequestBody = null)

Create Promotion Stack

This method creates one promotion stack. The sequence of promotion tier IDs will determine the promotion stacking order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreatePromotionStackExample
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

            var apiInstance = new PromotionsApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.
            var promotionsStacksCreateRequestBody = new PromotionsStacksCreateRequestBody(); // PromotionsStacksCreateRequestBody | Specify the order of promotion tiers for the promotion stack. (optional) 

            try
            {
                // Create Promotion Stack
                PromotionsStacksCreateResponseBody result = apiInstance.CreatePromotionStack(campaignId, promotionsStacksCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.CreatePromotionStack: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePromotionStackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Promotion Stack
    ApiResponse<PromotionsStacksCreateResponseBody> response = apiInstance.CreatePromotionStackWithHttpInfo(campaignId, promotionsStacksCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.CreatePromotionStackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |
| **promotionsStacksCreateRequestBody** | [**PromotionsStacksCreateRequestBody**](PromotionsStacksCreateRequestBody.md) | Specify the order of promotion tiers for the promotion stack. | [optional]  |

### Return type

[**PromotionsStacksCreateResponseBody**](PromotionsStacksCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a new stack object if a valid promotion campaign identifier was provided in the path and available promotion IDs in the payload. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletepromotionstack"></a>
# **DeletePromotionStack**
> void DeletePromotionStack (string campaignId, string stackId)

Delete Promotion Stack

This method deletes a promotion stack.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeletePromotionStackExample
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

            var apiInstance = new PromotionsApi(config);
            var campaignId = "campaignId_example";  // string | ID of the promotion campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty Campaign. 
            var stackId = "stackId_example";  // string | Promotion stack ID.

            try
            {
                // Delete Promotion Stack
                apiInstance.DeletePromotionStack(campaignId, stackId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.DeletePromotionStack: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePromotionStackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Promotion Stack
    apiInstance.DeletePromotionStackWithHttpInfo(campaignId, stackId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.DeletePromotionStackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | ID of the promotion campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty Campaign.  |  |
| **stackId** | **string** | Promotion stack ID. |  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletepromotiontier"></a>
# **DeletePromotionTier**
> void DeletePromotionTier (string promotionTierId)

Delete Promotion Tier

This method deletes a promotion tier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeletePromotionTierExample
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

            var apiInstance = new PromotionsApi(config);
            var promotionTierId = "promotionTierId_example";  // string | Unique promotion tier ID.

            try
            {
                // Delete Promotion Tier
                apiInstance.DeletePromotionTier(promotionTierId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.DeletePromotionTier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePromotionTierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Promotion Tier
    apiInstance.DeletePromotionTierWithHttpInfo(promotionTierId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.DeletePromotionTierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **promotionTierId** | **string** | Unique promotion tier ID. |  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disablepromotiontier"></a>
# **DisablePromotionTier**
> PromotionsTiersDisableResponseBody DisablePromotionTier (string promotionTierId)

Disable Promotion Tier

This method disables a promotion tier, i.e. makes the active parameter   false.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DisablePromotionTierExample
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

            var apiInstance = new PromotionsApi(config);
            var promotionTierId = "promotionTierId_example";  // string | Unique promotion tier ID.

            try
            {
                // Disable Promotion Tier
                PromotionsTiersDisableResponseBody result = apiInstance.DisablePromotionTier(promotionTierId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.DisablePromotionTier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisablePromotionTierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable Promotion Tier
    ApiResponse<PromotionsTiersDisableResponseBody> response = apiInstance.DisablePromotionTierWithHttpInfo(promotionTierId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.DisablePromotionTierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **promotionTierId** | **string** | Unique promotion tier ID. |  |

### Return type

[**PromotionsTiersDisableResponseBody**](PromotionsTiersDisableResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the promotion tier object with an updated &#x60;active&#x60; parameter. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="enablepromotiontier"></a>
# **EnablePromotionTier**
> PromotionsTiersEnableResponseBody EnablePromotionTier (string promotionTierId)

Enable Promotion Tier

This method enables a promotion tier, i.e. makes the active parameter   true.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class EnablePromotionTierExample
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

            var apiInstance = new PromotionsApi(config);
            var promotionTierId = "promotionTierId_example";  // string | Unique promotion tier ID.

            try
            {
                // Enable Promotion Tier
                PromotionsTiersEnableResponseBody result = apiInstance.EnablePromotionTier(promotionTierId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.EnablePromotionTier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnablePromotionTierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Promotion Tier
    ApiResponse<PromotionsTiersEnableResponseBody> response = apiInstance.EnablePromotionTierWithHttpInfo(promotionTierId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.EnablePromotionTierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **promotionTierId** | **string** | Unique promotion tier ID. |  |

### Return type

[**PromotionsTiersEnableResponseBody**](PromotionsTiersEnableResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the promotion tier object with an updated &#x60;active&#x60; parameter. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpromotionstack"></a>
# **GetPromotionStack**
> PromotionsStacksGetResponseBody GetPromotionStack (string campaignId, string stackId)

Get Promotion Stack

This method returns the details of a promotion stack, including the promotion tiers grouped within the stack.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetPromotionStackExample
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

            var apiInstance = new PromotionsApi(config);
            var campaignId = "campaignId_example";  // string | ID of the promotion campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty Campaign. 
            var stackId = "stackId_example";  // string | Promotion stack ID.

            try
            {
                // Get Promotion Stack
                PromotionsStacksGetResponseBody result = apiInstance.GetPromotionStack(campaignId, stackId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetPromotionStack: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPromotionStackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Promotion Stack
    ApiResponse<PromotionsStacksGetResponseBody> response = apiInstance.GetPromotionStackWithHttpInfo(campaignId, stackId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.GetPromotionStackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | ID of the promotion campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty Campaign.  |  |
| **stackId** | **string** | Promotion stack ID. |  |

### Return type

[**PromotionsStacksGetResponseBody**](PromotionsStacksGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a stack object if valid identifiers were provided in the path. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpromotiontier"></a>
# **GetPromotionTier**
> PromotionsTiersGetResponseBody GetPromotionTier (string promotionTierId)

Get Promotion Tier

This method enables you to retrieve a specific promotion tier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetPromotionTierExample
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

            var apiInstance = new PromotionsApi(config);
            var promotionTierId = "promotionTierId_example";  // string | Unique promotion tier ID.

            try
            {
                // Get Promotion Tier
                PromotionsTiersGetResponseBody result = apiInstance.GetPromotionTier(promotionTierId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetPromotionTier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPromotionTierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Promotion Tier
    ApiResponse<PromotionsTiersGetResponseBody> response = apiInstance.GetPromotionTierWithHttpInfo(promotionTierId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.GetPromotionTierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **promotionTierId** | **string** | Unique promotion tier ID. |  |

### Return type

[**PromotionsTiersGetResponseBody**](PromotionsTiersGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a promotion tier object. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listallpromotionstacks"></a>
# **ListAllPromotionStacks**
> PromotionsStacksListResponseBody ListAllPromotionStacks (int limit = null, int page = null, ParameterOrderListAllPromotionStacks order = null, ParameterCreatedBeforeAfter createdAt = null, ParameterUpdatedBeforeAfter updatedAt = null)

List Promotion Stacks

This method enables you to list promotion stacks irrespective of the campaign they are associated with.  You can use filters in the query parameters to specify the stacks to be returned in the response. # Advanced filters for fetching promotion stacks  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListAllPromotionStacksExample
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

            var apiInstance = new PromotionsApi(config);
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. (optional) 
            var page = 56;  // int | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListAllPromotionStacks) "created_at";  // ParameterOrderListAllPromotionStacks | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var createdAt = new ParameterCreatedBeforeAfter(); // ParameterCreatedBeforeAfter | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z (optional) 
            var updatedAt = new ParameterUpdatedBeforeAfter(); // ParameterUpdatedBeforeAfter | A filter on the list based on the object updated_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [updated_at][before] 2017-09-08T13:52:18.227Z (optional) 

            try
            {
                // List Promotion Stacks
                PromotionsStacksListResponseBody result = apiInstance.ListAllPromotionStacks(limit, page, order, createdAt, updatedAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ListAllPromotionStacks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllPromotionStacksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Promotion Stacks
    ApiResponse<PromotionsStacksListResponseBody> response = apiInstance.ListAllPromotionStacksWithHttpInfo(limit, page, order, createdAt, updatedAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.ListAllPromotionStacksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. | [optional]  |
| **page** | **int** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListAllPromotionStacks** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **createdAt** | [**ParameterCreatedBeforeAfter**](ParameterCreatedBeforeAfter.md) | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z | [optional]  |
| **updatedAt** | [**ParameterUpdatedBeforeAfter**](ParameterUpdatedBeforeAfter.md) | A filter on the list based on the object updated_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [updated_at][before] 2017-09-08T13:52:18.227Z | [optional]  |

### Return type

[**PromotionsStacksListResponseBody**](PromotionsStacksListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a &#x60;data&#x60; property that contains an array of promotion stacks across all your campaigns. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listpromotionstacksincampaign"></a>
# **ListPromotionStacksInCampaign**
> PromotionsStacksListResponseBody ListPromotionStacksInCampaign (string campaignId)

List Promotion Stacks in Campaign

This method enables you to list promotion stacks from a specified campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListPromotionStacksInCampaignExample
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

            var apiInstance = new PromotionsApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.

            try
            {
                // List Promotion Stacks in Campaign
                PromotionsStacksListResponseBody result = apiInstance.ListPromotionStacksInCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ListPromotionStacksInCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPromotionStacksInCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Promotion Stacks in Campaign
    ApiResponse<PromotionsStacksListResponseBody> response = apiInstance.ListPromotionStacksInCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.ListPromotionStacksInCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |

### Return type

[**PromotionsStacksListResponseBody**](PromotionsStacksListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of promotion stack objects. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listpromotiontiers"></a>
# **ListPromotionTiers**
> PromotionsTiersListResponseBody ListPromotionTiers (bool isAvailable = null, int limit = null, int page = null, ParameterOrderListPromotionTiers order = null)

List Promotion Tiers

This method enables you to list promotion tiers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListPromotionTiersExample
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

            var apiInstance = new PromotionsApi(config);
            var isAvailable = true;  // bool | This parameter allows filtering promotions that are only available at the moment. When set to true, it selects only non-expired and active promotions. (optional) 
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. (optional) 
            var page = 56;  // int | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListPromotionTiers) "created_at";  // ParameterOrderListPromotionTiers | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Promotion Tiers
                PromotionsTiersListResponseBody result = apiInstance.ListPromotionTiers(isAvailable, limit, page, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ListPromotionTiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPromotionTiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Promotion Tiers
    ApiResponse<PromotionsTiersListResponseBody> response = apiInstance.ListPromotionTiersWithHttpInfo(isAvailable, limit, page, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.ListPromotionTiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isAvailable** | **bool** | This parameter allows filtering promotions that are only available at the moment. When set to true, it selects only non-expired and active promotions. | [optional]  |
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. | [optional]  |
| **page** | **int** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListPromotionTiers** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**PromotionsTiersListResponseBody**](PromotionsTiersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a &#x60;tiers&#x60; property that contains an array of promotion tiers. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listpromotiontiersfromcampaign"></a>
# **ListPromotionTiersFromCampaign**
> PromotionsTiersListResponseBody ListPromotionTiersFromCampaign (string campaignId)

List Promotion Tiers from Campaign

This method enables you to list promotion tiers from a specified campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListPromotionTiersFromCampaignExample
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

            var apiInstance = new PromotionsApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID assigned by Voucherify.

            try
            {
                // List Promotion Tiers from Campaign
                PromotionsTiersListResponseBody result = apiInstance.ListPromotionTiersFromCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ListPromotionTiersFromCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPromotionTiersFromCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Promotion Tiers from Campaign
    ApiResponse<PromotionsTiersListResponseBody> response = apiInstance.ListPromotionTiersFromCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.ListPromotionTiersFromCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID assigned by Voucherify. |  |

### Return type

[**PromotionsTiersListResponseBody**](PromotionsTiersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a &#x60;tiers&#x60; property that contains an array of promotion tiers. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatepromotionstack"></a>
# **UpdatePromotionStack**
> PromotionsStacksUpdateResponseBody UpdatePromotionStack (string campaignId, string stackId, PromotionsStacksUpdateRequestBody promotionsStacksUpdateRequestBody = null)

Update Promotion Stack

This methods allows for editing an existing stack.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdatePromotionStackExample
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

            var apiInstance = new PromotionsApi(config);
            var campaignId = "campaignId_example";  // string | ID of the promotion campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty Campaign. 
            var stackId = "stackId_example";  // string | Promotion stack ID.
            var promotionsStacksUpdateRequestBody = new PromotionsStacksUpdateRequestBody(); // PromotionsStacksUpdateRequestBody | Specify the promotion stack parameters that you would like to update. (optional) 

            try
            {
                // Update Promotion Stack
                PromotionsStacksUpdateResponseBody result = apiInstance.UpdatePromotionStack(campaignId, stackId, promotionsStacksUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.UpdatePromotionStack: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePromotionStackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Promotion Stack
    ApiResponse<PromotionsStacksUpdateResponseBody> response = apiInstance.UpdatePromotionStackWithHttpInfo(campaignId, stackId, promotionsStacksUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.UpdatePromotionStackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | ID of the promotion campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty Campaign.  |  |
| **stackId** | **string** | Promotion stack ID. |  |
| **promotionsStacksUpdateRequestBody** | [**PromotionsStacksUpdateRequestBody**](PromotionsStacksUpdateRequestBody.md) | Specify the promotion stack parameters that you would like to update. | [optional]  |

### Return type

[**PromotionsStacksUpdateResponseBody**](PromotionsStacksUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a promotion stack with updated parameters if the update was successful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatepromotiontier"></a>
# **UpdatePromotionTier**
> PromotionsTiersUpdateResponseBody UpdatePromotionTier (string promotionTierId, PromotionsTiersUpdateRequestBody promotionsTiersUpdateRequestBody = null)

Update Promotion Tier

This method updates a promotion tier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdatePromotionTierExample
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

            var apiInstance = new PromotionsApi(config);
            var promotionTierId = "promotionTierId_example";  // string | Unique promotion tier ID.
            var promotionsTiersUpdateRequestBody = new PromotionsTiersUpdateRequestBody(); // PromotionsTiersUpdateRequestBody | Specify the promotion tier parameters that you would like to update. (optional) 

            try
            {
                // Update Promotion Tier
                PromotionsTiersUpdateResponseBody result = apiInstance.UpdatePromotionTier(promotionTierId, promotionsTiersUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.UpdatePromotionTier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePromotionTierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Promotion Tier
    ApiResponse<PromotionsTiersUpdateResponseBody> response = apiInstance.UpdatePromotionTierWithHttpInfo(promotionTierId, promotionsTiersUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.UpdatePromotionTierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **promotionTierId** | **string** | Unique promotion tier ID. |  |
| **promotionsTiersUpdateRequestBody** | [**PromotionsTiersUpdateRequestBody**](PromotionsTiersUpdateRequestBody.md) | Specify the promotion tier parameters that you would like to update. | [optional]  |

### Return type

[**PromotionsTiersUpdateResponseBody**](PromotionsTiersUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a promotion tier object if the update was successful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

