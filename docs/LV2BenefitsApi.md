# Voucherify.Api.LV2BenefitsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBenefit**](LV2BenefitsApi.md#getbenefit) | **GET** /v2/loyalties/benefits/{benefitId} | Get benefit |

<a id="getbenefit"></a>
# **GetBenefit**
> V2LoyaltiesBenefitsGetResponseBody GetBenefit (string benefitId)

Get benefit

Returns a single benefit by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetBenefitExample
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

            var apiInstance = new LV2BenefitsApi(config);
            var benefitId = "benefitId_example";  // string | Unique benefit ID, prefixed with lben_.

            try
            {
                // Get benefit
                V2LoyaltiesBenefitsGetResponseBody result = apiInstance.GetBenefit(benefitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2BenefitsApi.GetBenefit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBenefitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get benefit
    ApiResponse<V2LoyaltiesBenefitsGetResponseBody> response = apiInstance.GetBenefitWithHttpInfo(benefitId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2BenefitsApi.GetBenefitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **benefitId** | **string** | Unique benefit ID, prefixed with lben_. |  |

### Return type

[**V2LoyaltiesBenefitsGetResponseBody**](V2LoyaltiesBenefitsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The benefit |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

