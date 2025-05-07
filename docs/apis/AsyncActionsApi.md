# Voucherify.Api.AsyncActionsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAsyncAction**](AsyncActionsApi.md#getasyncaction) | **GET** /v1/async-actions/{asyncActionId} | Get Async Action |
| [**ListAsyncActions**](AsyncActionsApi.md#listasyncactions) | **GET** /v1/async-actions | List Async Actions |

<a id="getasyncaction"></a>
# **GetAsyncAction**
> AsyncActionGetResponseBody GetAsyncAction (string asyncActionId)

Get Async Action

Check the result of a scheduled asynchronous operation.   The table below lists the possible types of async actions. The types are different for each endpoint generating the async action. If you would like to learn more about importing data into Voucherify, read more [here](https://support.voucherify.io/article/574-data-import).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetAsyncActionExample
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

            var apiInstance = new AsyncActionsApi(config);
            var asyncActionId = "asyncActionId_example";  // string | Unique ID of the asynchronous operation.

            try
            {
                // Get Async Action
                AsyncActionGetResponseBody result = apiInstance.GetAsyncAction(asyncActionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AsyncActionsApi.GetAsyncAction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAsyncActionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Async Action
    ApiResponse<AsyncActionGetResponseBody> response = apiInstance.GetAsyncActionWithHttpInfo(asyncActionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AsyncActionsApi.GetAsyncActionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asyncActionId** | **string** | Unique ID of the asynchronous operation. |  |

### Return type

[**AsyncActionGetResponseBody**](AsyncActionGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns detailed information about the async action result. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listasyncactions"></a>
# **ListAsyncActions**
> AsyncActionsListResponseBody ListAsyncActions (int limit = null, DateTimeOffset endDate = null)

List Async Actions

Track asynchronous operations scheduled in your project.   The table below lists the possible types of async actions. The types are different for each endpoint generating the async action. If you would like to learn more about importing data into Voucherify, read more [here](https://support.voucherify.io/article/574-data-import).       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListAsyncActionsExample
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

            var apiInstance = new AsyncActionsApi(config);
            var limit = 56;  // int | Limit the number of asynchronous actions that the API returns in the response. (optional) 
            var endDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | Limits results to actions scheduled before the end_date. The date format needs to be consistent with ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16).  (optional) 

            try
            {
                // List Async Actions
                AsyncActionsListResponseBody result = apiInstance.ListAsyncActions(limit, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AsyncActionsApi.ListAsyncActions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAsyncActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Async Actions
    ApiResponse<AsyncActionsListResponseBody> response = apiInstance.ListAsyncActionsWithHttpInfo(limit, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AsyncActionsApi.ListAsyncActionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Limit the number of asynchronous actions that the API returns in the response. | [optional]  |
| **endDate** | **DateTimeOffset** | Limits results to actions scheduled before the end_date. The date format needs to be consistent with ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16).  | [optional]  |

### Return type

[**AsyncActionsListResponseBody**](AsyncActionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of all scheduled asynchronous actions and detailed information for each scheduled action. Note that a status &#x60;DONE&#x60;doesn&#39;t include the result of the completed action. If you need more information about the result, use the ID of the respective async action to call the &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

