# Voucherify.Api.ClientSideApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckEligibilityClientSide**](ClientSideApi.md#checkeligibilityclientside) | **POST** /client/v1/qualifications | Check Eligibility (client-side) |
| [**ListPromotionTiersClientSide**](ClientSideApi.md#listpromotiontiersclientside) | **GET** /client/v1/promotions/tiers | List Promotion Tiers (client-side) |
| [**RedeemStackedDiscountsClientSide**](ClientSideApi.md#redeemstackeddiscountsclientside) | **POST** /client/v1/redemptions | Redeem Stackable Discounts (client-side) |
| [**TrackCustomEventClientSide**](ClientSideApi.md#trackcustomeventclientside) | **POST** /client/v1/events | Track Custom Event (client-side) |
| [**ValidateStackedDiscountsClientSide**](ClientSideApi.md#validatestackeddiscountsclientside) | **POST** /client/v1/validations | Validate Stackable Discounts (client-side) |

<a id="checkeligibilityclientside"></a>
# **CheckEligibilityClientSide**
> ClientQualificationsCheckEligibilityResponseBody CheckEligibilityClientSide (ClientQualificationsCheckEligibilityRequestBody clientQualificationsCheckEligibilityRequestBody = null)

Check Eligibility (client-side)

Generate a list of redeemables that are applicable in the context of the customer and order. The new qualifications method is an improved version of Campaign Qualifications, Voucher Qualifications, and Promotions Validation API requests. The new qualification method introduces the following improvements: - Qualification results are returned faster - No limit on the number of returned redeemables - Introduces new qualification scenarios, not available in the previous version  👍 Scenario Guide  Read our dedicated guide to learn about some use cases this endpoint can cover here. # Paging  The Voucherify Qualifications API request will return to you all of the redeemables available for the customer in batches of up to 50 redeemables. To get the next batch of redeemables, you need to use the starting_after cursor. To process of paging the redeemables works in the following manner: - You send the first API request for Qualifications without the starting_after parameter. - The response will contain a parameter named has_more. If the parameters value is set to true, then more redeemables are available. - Get the value of the created_at parameter of the last returned redeemable. The value of this parameter will be used as a cursor to retrieve the next page of redeemables. - Send another API request for Qualification with the starting_after parameter set to the value taken from the created_at parameter from the last returned redeemable. - Voucherify will return the next page of redeemables. - If the has_more parameter is set to true, apply steps 3-5 to get the next page of redeemables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CheckEligibilityClientSideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Client-Application-Id
            config.AddApiKey("X-Client-Application-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Application-Id", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: X-Client-Token
            config.AddApiKey("X-Client-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Token", "Bearer");

            var apiInstance = new ClientSideApi(config);
            var clientQualificationsCheckEligibilityRequestBody = new ClientQualificationsCheckEligibilityRequestBody(); // ClientQualificationsCheckEligibilityRequestBody | Define order and customer context. (optional) 

            try
            {
                // Check Eligibility (client-side)
                ClientQualificationsCheckEligibilityResponseBody result = apiInstance.CheckEligibilityClientSide(clientQualificationsCheckEligibilityRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientSideApi.CheckEligibilityClientSide: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckEligibilityClientSideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Eligibility (client-side)
    ApiResponse<ClientQualificationsCheckEligibilityResponseBody> response = apiInstance.CheckEligibilityClientSideWithHttpInfo(clientQualificationsCheckEligibilityRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientSideApi.CheckEligibilityClientSideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientQualificationsCheckEligibilityRequestBody** | [**ClientQualificationsCheckEligibilityRequestBody**](ClientQualificationsCheckEligibilityRequestBody.md) | Define order and customer context. | [optional]  |

### Return type

[**ClientQualificationsCheckEligibilityResponseBody**](ClientQualificationsCheckEligibilityResponseBody.md)

### Authorization

[X-Client-Application-Id](../README.md#X-Client-Application-Id), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth), [X-Client-Token](../README.md#X-Client-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a qualifications object. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listpromotiontiersclientside"></a>
# **ListPromotionTiersClientSide**
> ClientPromotionsTiersListResponseBody ListPromotionTiersClientSide (string origin, bool isAvailable = null, int limit = null, int page = null, ParameterOrderListPromotionTiersClientSide order = null)

List Promotion Tiers (client-side)

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
    public class ListPromotionTiersClientSideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Client-Application-Id
            config.AddApiKey("X-Client-Application-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Application-Id", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: X-Client-Token
            config.AddApiKey("X-Client-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Token", "Bearer");

            var apiInstance = new ClientSideApi(config);
            var origin = "origin_example";  // string | Indicates the origin (scheme, hostname, and port).
            var isAvailable = true;  // bool | This parameter allows filtering promotions that are only available at the moment. When set to true, it selects only non-expired and active promotions. (optional) 
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. (optional) 
            var page = 56;  // int | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListPromotionTiersClientSide) "created_at";  // ParameterOrderListPromotionTiersClientSide | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Promotion Tiers (client-side)
                ClientPromotionsTiersListResponseBody result = apiInstance.ListPromotionTiersClientSide(origin, isAvailable, limit, page, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientSideApi.ListPromotionTiersClientSide: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPromotionTiersClientSideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Promotion Tiers (client-side)
    ApiResponse<ClientPromotionsTiersListResponseBody> response = apiInstance.ListPromotionTiersClientSideWithHttpInfo(origin, isAvailable, limit, page, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientSideApi.ListPromotionTiersClientSideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **origin** | **string** | Indicates the origin (scheme, hostname, and port). |  |
| **isAvailable** | **bool** | This parameter allows filtering promotions that are only available at the moment. When set to true, it selects only non-expired and active promotions. | [optional]  |
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. | [optional]  |
| **page** | **int** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListPromotionTiersClientSide** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**ClientPromotionsTiersListResponseBody**](ClientPromotionsTiersListResponseBody.md)

### Authorization

[X-Client-Application-Id](../README.md#X-Client-Application-Id), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth), [X-Client-Token](../README.md#X-Client-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a &#x60;tiers&#x60; property that contains an array of promotion tiers. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="redeemstackeddiscountsclientside"></a>
# **RedeemStackedDiscountsClientSide**
> ClientRedemptionsRedeemResponseBody RedeemStackedDiscountsClientSide (string origin, ClientRedemptionsRedeemRequestBody clientRedemptionsRedeemRequestBody = null)

Redeem Stackable Discounts (client-side)

This method is accessible through public keys which you can use in client side requests coming from mobile and web browser applications. # How API returns calculated discounts and order amounts in the response In the table below, you can see the logic the API follows to calculate discounts and amounts:    📘 Rollbacks  You cant roll back a child redemption. When you call rollback on a stacked redemption, all child redemptions will be rolled back. You need to refer to a parent redemption ID in your rollback request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class RedeemStackedDiscountsClientSideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Client-Application-Id
            config.AddApiKey("X-Client-Application-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Application-Id", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: X-Client-Token
            config.AddApiKey("X-Client-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Token", "Bearer");

            var apiInstance = new ClientSideApi(config);
            var origin = "origin_example";  // string | Indicates the origin (scheme, hostname, and port).
            var clientRedemptionsRedeemRequestBody = new ClientRedemptionsRedeemRequestBody(); // ClientRedemptionsRedeemRequestBody |  (optional) 

            try
            {
                // Redeem Stackable Discounts (client-side)
                ClientRedemptionsRedeemResponseBody result = apiInstance.RedeemStackedDiscountsClientSide(origin, clientRedemptionsRedeemRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientSideApi.RedeemStackedDiscountsClientSide: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RedeemStackedDiscountsClientSideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Redeem Stackable Discounts (client-side)
    ApiResponse<ClientRedemptionsRedeemResponseBody> response = apiInstance.RedeemStackedDiscountsClientSideWithHttpInfo(origin, clientRedemptionsRedeemRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientSideApi.RedeemStackedDiscountsClientSideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **origin** | **string** | Indicates the origin (scheme, hostname, and port). |  |
| **clientRedemptionsRedeemRequestBody** | [**ClientRedemptionsRedeemRequestBody**](ClientRedemptionsRedeemRequestBody.md) |  | [optional]  |

### Return type

[**ClientRedemptionsRedeemResponseBody**](ClientRedemptionsRedeemResponseBody.md)

### Authorization

[X-Client-Application-Id](../README.md#X-Client-Application-Id), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth), [X-Client-Token](../README.md#X-Client-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Depending on your project settings: all redeemables must be valid or just one must be valid to result as valid redemption. Read more in the [Stacking Rule Documentation](https://support.voucherify.io/article/604-stacking-rules). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="trackcustomeventclientside"></a>
# **TrackCustomEventClientSide**
> ClientEventsCreateResponseBody TrackCustomEventClientSide (string origin, ClientEventsCreateRequestBody clientEventsCreateRequestBody = null)

Track Custom Event (client-side)

To track a custom event, you create an event object.   The event object must be linked to the customer who performs the action. If a customer doesnt exist in Voucherify, the customer will be created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class TrackCustomEventClientSideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Client-Application-Id
            config.AddApiKey("X-Client-Application-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Application-Id", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: X-Client-Token
            config.AddApiKey("X-Client-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Token", "Bearer");

            var apiInstance = new ClientSideApi(config);
            var origin = "origin_example";  // string | Indicates the origin (scheme, hostname, and port).
            var clientEventsCreateRequestBody = new ClientEventsCreateRequestBody(); // ClientEventsCreateRequestBody | Specify the details of the custom event. (optional) 

            try
            {
                // Track Custom Event (client-side)
                ClientEventsCreateResponseBody result = apiInstance.TrackCustomEventClientSide(origin, clientEventsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientSideApi.TrackCustomEventClientSide: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrackCustomEventClientSideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Track Custom Event (client-side)
    ApiResponse<ClientEventsCreateResponseBody> response = apiInstance.TrackCustomEventClientSideWithHttpInfo(origin, clientEventsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientSideApi.TrackCustomEventClientSideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **origin** | **string** | Indicates the origin (scheme, hostname, and port). |  |
| **clientEventsCreateRequestBody** | [**ClientEventsCreateRequestBody**](ClientEventsCreateRequestBody.md) | Specify the details of the custom event. | [optional]  |

### Return type

[**ClientEventsCreateResponseBody**](ClientEventsCreateResponseBody.md)

### Authorization

[X-Client-Application-Id](../README.md#X-Client-Application-Id), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth), [X-Client-Token](../README.md#X-Client-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the event type if the event was received by the application. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="validatestackeddiscountsclientside"></a>
# **ValidateStackedDiscountsClientSide**
> ClientValidationsValidateResponseBody ValidateStackedDiscountsClientSide (string origin, ClientValidationsValidateRequestBody clientValidationsValidateRequestBody = null)

Validate Stackable Discounts (client-side)

Verify redeemables provided in the request. This method is accessible through public keys which you can use in client side requests coming from mobile and web browser applications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ValidateStackedDiscountsClientSideExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Client-Application-Id
            config.AddApiKey("X-Client-Application-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Application-Id", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: X-Client-Token
            config.AddApiKey("X-Client-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Client-Token", "Bearer");

            var apiInstance = new ClientSideApi(config);
            var origin = "origin_example";  // string | Indicates the origin (scheme, hostname, and port).
            var clientValidationsValidateRequestBody = new ClientValidationsValidateRequestBody(); // ClientValidationsValidateRequestBody |  (optional) 

            try
            {
                // Validate Stackable Discounts (client-side)
                ClientValidationsValidateResponseBody result = apiInstance.ValidateStackedDiscountsClientSide(origin, clientValidationsValidateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientSideApi.ValidateStackedDiscountsClientSide: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateStackedDiscountsClientSideWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate Stackable Discounts (client-side)
    ApiResponse<ClientValidationsValidateResponseBody> response = apiInstance.ValidateStackedDiscountsClientSideWithHttpInfo(origin, clientValidationsValidateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientSideApi.ValidateStackedDiscountsClientSideWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **origin** | **string** | Indicates the origin (scheme, hostname, and port). |  |
| **clientValidationsValidateRequestBody** | [**ClientValidationsValidateRequestBody**](ClientValidationsValidateRequestBody.md) |  | [optional]  |

### Return type

[**ClientValidationsValidateResponseBody**](ClientValidationsValidateResponseBody.md)

### Authorization

[X-Client-Application-Id](../README.md#X-Client-Application-Id), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth), [X-Client-Token](../README.md#X-Client-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Depending on your project settings: all redeemables must be valid or just one must be valid to result as valid validation. Read more in the [Stacking Rule Documentation](https://support.voucherify.io/article/604-stacking-rules). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

