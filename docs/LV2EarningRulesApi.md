# Voucherify.Api.LV2EarningRulesApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEarningRule**](LV2EarningRulesApi.md#getearningrule) | **GET** /v2/loyalties/earning-rules/{earningRuleId} | Get earning rule |

<a id="getearningrule"></a>
# **GetEarningRule**
> V2LoyaltiesEarningRulesGetResponseBody GetEarningRule (string earningRuleId)

Get earning rule

Returns a single earning rule by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetEarningRuleExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2EarningRulesApi(config);
            var earningRuleId = "earningRuleId_example";  // string | Identifies the earning rule. Format lern_[a-f0-9]+.

            try
            {
                // Get earning rule
                V2LoyaltiesEarningRulesGetResponseBody result = apiInstance.GetEarningRule(earningRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2EarningRulesApi.GetEarningRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEarningRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get earning rule
    ApiResponse<V2LoyaltiesEarningRulesGetResponseBody> response = apiInstance.GetEarningRuleWithHttpInfo(earningRuleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2EarningRulesApi.GetEarningRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **earningRuleId** | **string** | Identifies the earning rule. Format lern_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesEarningRulesGetResponseBody**](V2LoyaltiesEarningRulesGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Earning rule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

