# Voucherify.Api.LV2ExamineApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExamineEarningRules**](LV2ExamineApi.md#examineearningrules) | **POST** /v2/loyalties/examine/earning-rules | Examine earning rules |
| [**ExamineRewards**](LV2ExamineApi.md#examinerewards) | **POST** /v2/loyalties/examine/rewards | Examine rewards |

<a id="examineearningrules"></a>
# **ExamineEarningRules**
> LoyaltiesExamineEarningRulesExamineResponseBody ExamineEarningRules (LoyaltiesExamineEarningRulesExamineRequestBody loyaltiesExamineEarningRulesExamineRequestBody)

Examine earning rules

Estimates earning opportunities for a customer without triggering any actual earning for loyalty v2 earning rules. The trigger selects whether all trigger events or one specific event is examined. When a specific event is selected, exactly one matching context object is required: customer_order_paid for customer.order.paid, customer_segment_entered for customer.segment.entered, and customer_custom_event for customer.custom_event. The other context objects must not be present. This endpoint can examine earning rules for all loyalty programs the customer belongs to by using customer_identification with customer_id or customer_source_id. To examine earning rules only for one program, use member_id in customer_identification, as member_id is loyalty program-specific. A customer who exists but has no active membership returns 200 with an empty memberships array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExamineEarningRulesExample
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

            var apiInstance = new LV2ExamineApi(config);
            var loyaltiesExamineEarningRulesExamineRequestBody = new LoyaltiesExamineEarningRulesExamineRequestBody(); // LoyaltiesExamineEarningRulesExamineRequestBody | 

            try
            {
                // Examine earning rules
                LoyaltiesExamineEarningRulesExamineResponseBody result = apiInstance.ExamineEarningRules(loyaltiesExamineEarningRulesExamineRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ExamineApi.ExamineEarningRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExamineEarningRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Examine earning rules
    ApiResponse<LoyaltiesExamineEarningRulesExamineResponseBody> response = apiInstance.ExamineEarningRulesWithHttpInfo(loyaltiesExamineEarningRulesExamineRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ExamineApi.ExamineEarningRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltiesExamineEarningRulesExamineRequestBody** | [**LoyaltiesExamineEarningRulesExamineRequestBody**](LoyaltiesExamineEarningRulesExamineRequestBody.md) |  |  |

### Return type

[**LoyaltiesExamineEarningRulesExamineResponseBody**](LoyaltiesExamineEarningRulesExamineResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Earning rules examination result. An empty &#x60;memberships&#x60; array means no active membership has earning rules for the examined trigger. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="examinerewards"></a>
# **ExamineRewards**
> LoyaltiesExamineRewardsExamineResponseBody ExamineRewards (LoyaltiesExamineRewardsExamineRequestBody loyaltiesExamineRewardsExamineRequestBody)

Examine rewards

Evaluates rewards assigned to a customers active Loyalty v2 program memberships. Applies temporary customer and member metadata overrides without updating stored data. Returns reward availability by card, including points costs and applicable unavailability reasons. Omits a reward when it is inactive, out of stock, has no matching cost, or the member has no card for that cost. This endpoint can examine rewards for all loyalty programs the customer belongs to by using customer_identification with customer_id or customer_source_id. To examine rewards only for one program, use member_id in customer_identification, as member_id is loyalty program-specific. A customer who exists but has no active membership returns 200 with an empty memberships array.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExamineRewardsExample
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

            var apiInstance = new LV2ExamineApi(config);
            var loyaltiesExamineRewardsExamineRequestBody = new LoyaltiesExamineRewardsExamineRequestBody(); // LoyaltiesExamineRewardsExamineRequestBody | 

            try
            {
                // Examine rewards
                LoyaltiesExamineRewardsExamineResponseBody result = apiInstance.ExamineRewards(loyaltiesExamineRewardsExamineRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ExamineApi.ExamineRewards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExamineRewardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Examine rewards
    ApiResponse<LoyaltiesExamineRewardsExamineResponseBody> response = apiInstance.ExamineRewardsWithHttpInfo(loyaltiesExamineRewardsExamineRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ExamineApi.ExamineRewardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltiesExamineRewardsExamineRequestBody** | [**LoyaltiesExamineRewardsExamineRequestBody**](LoyaltiesExamineRewardsExamineRequestBody.md) |  |  |

### Return type

[**LoyaltiesExamineRewardsExamineResponseBody**](LoyaltiesExamineRewardsExamineResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Rewards examination result. An empty &#x60;memberships&#x60; array means the customer has no active membership. An empty &#x60;cards&#x60; array means no assigned reward resolved onto a card. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

