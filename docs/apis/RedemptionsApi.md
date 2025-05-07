# Voucherify.Api.RedemptionsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRedemption**](RedemptionsApi.md#getredemption) | **GET** /v1/redemptions/{redemptionId} | Get Redemption |
| [**GetVoucherRedemptions**](RedemptionsApi.md#getvoucherredemptions) | **GET** /v1/vouchers/{code}/redemption | Get Voucher&#39;s Redemptions |
| [**ListRedemptions**](RedemptionsApi.md#listredemptions) | **GET** /v1/redemptions | List Redemptions |
| [**RedeemStackedDiscounts**](RedemptionsApi.md#redeemstackeddiscounts) | **POST** /v1/redemptions | Redeem Stackable Discounts |
| [**RollbackRedemption**](RedemptionsApi.md#rollbackredemption) | **POST** /v1/redemptions/{redemptionId}/rollback | Rollback Redemption |
| [**RollbackStackedRedemptions**](RedemptionsApi.md#rollbackstackedredemptions) | **POST** /v1/redemptions/{parentRedemptionId}/rollbacks | Rollback Stackable Redemptions |

<a id="getredemption"></a>
# **GetRedemption**
> RedemptionsGetResponseBody GetRedemption (string redemptionId)

Get Redemption

Return a redemption or redemption rollback object. This object can either be a successfull or failed redemption or redemption rollback.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetRedemptionExample
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

            var apiInstance = new RedemptionsApi(config);
            var redemptionId = "redemptionId_example";  // string | ID of previously created redemption.

            try
            {
                // Get Redemption
                RedemptionsGetResponseBody result = apiInstance.GetRedemption(redemptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedemptionsApi.GetRedemption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRedemptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Redemption
    ApiResponse<RedemptionsGetResponseBody> response = apiInstance.GetRedemptionWithHttpInfo(redemptionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedemptionsApi.GetRedemptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **redemptionId** | **string** | ID of previously created redemption. |  |

### Return type

[**RedemptionsGetResponseBody**](RedemptionsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a redemption object. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getvoucherredemptions"></a>
# **GetVoucherRedemptions**
> VouchersRedemptionGetResponseBody GetVoucherRedemptions (string code)

Get Voucher's Redemptions

Retrieve the number of times a voucher was redeemed and each of the redemption details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetVoucherRedemptionsExample
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

            var apiInstance = new RedemptionsApi(config);
            var code = "code_example";  // string | A **code** that identifies the voucher.

            try
            {
                // Get Voucher's Redemptions
                VouchersRedemptionGetResponseBody result = apiInstance.GetVoucherRedemptions(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedemptionsApi.GetVoucherRedemptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVoucherRedemptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Voucher's Redemptions
    ApiResponse<VouchersRedemptionGetResponseBody> response = apiInstance.GetVoucherRedemptionsWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedemptionsApi.GetVoucherRedemptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A **code** that identifies the voucher. |  |

### Return type

[**VouchersRedemptionGetResponseBody**](VouchersRedemptionGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A dictionary with a &#x60;redemption_entries&#x60; property that contains an array of voucher&#39;s redemptions. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listredemptions"></a>
# **ListRedemptions**
> RedemptionsListResponseBody ListRedemptions (int limit = null, int page = null, string result = null, string campaign = null, string customer = null, ParameterOrderListRedemptions order = null, ParameterCreatedBeforeAfter createdAt = null, ParameterFiltersListRedemptions filters = null)

List Redemptions

Returns a list of redemptions previously created. The redemptions are returned in a sorted order, with the most recent redemptions appearing first. The response returns a list of redemptions of all vouchers.  # Filtering results The result can be narrowed according to specified (or default) filters, for example, you can sort redemptions by date: https://api.voucherify.io/v1/redemptions?limit 3&[created_at][before] 2017-09-08T13:52:18.227Z. A filter based on the object created_at field narrows down the results and lists redemptions done before or after a particular date time. You can use the following options: [created_at][after], [created_at][before]. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z. # Failed Redemptions A redemption may fail for various reasons. You can figure out an exact reason from the failure_code: - resource_not_found - voucher with given code does not exist - voucher_not_active - voucher is not active yet (before start date) - voucher_expired - voucher has already expired (after expiration date) - voucher_disabled -  voucher has been disabled (active: false) - quantity_exceeded - vouchers redemptions limit has been exceeded - gift_amount_exceeded - gift amount has been exceeded - customer_rules_violated - customer did not match the segment - order_rules_violated - order did not match validation rules - invalid_order - order was specified incorrectly - invalid_amount - order amount was specified incorrectly - missing_amount - order amount was not specified - missing_order_items - order items were not specified - missing_customer - customer was not specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListRedemptionsExample
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

            var apiInstance = new RedemptionsApi(config);
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int | Which page of results to return. The lowest value is 1, the highest value is 99. (optional) 
            var result = "result_example";  // string | A filter on the list based on the redemption result. Available options are: SUCCESS, FAILURE. You can provide multiple values by repeating the param. (optional) 
            var campaign = "campaign_example";  // string | A filter by the campaign **name** that the redemption resources originate from. (optional) 
            var customer = "customer_example";  // string | Return redemptions performed by the customer with given id or source_id. (optional) 
            var order = (ParameterOrderListRedemptions) "created_at";  // ParameterOrderListRedemptions | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var createdAt = new ParameterCreatedBeforeAfter(); // ParameterCreatedBeforeAfter | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z (optional) 
            var filters = new ParameterFiltersListRedemptions(); // ParameterFiltersListRedemptions | Filters for listing responses. (optional) 

            try
            {
                // List Redemptions
                RedemptionsListResponseBody result = apiInstance.ListRedemptions(limit, page, result, campaign, customer, order, createdAt, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedemptionsApi.ListRedemptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRedemptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Redemptions
    ApiResponse<RedemptionsListResponseBody> response = apiInstance.ListRedemptionsWithHttpInfo(limit, page, result, campaign, customer, order, createdAt, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedemptionsApi.ListRedemptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int** | Which page of results to return. The lowest value is 1, the highest value is 99. | [optional]  |
| **result** | **string** | A filter on the list based on the redemption result. Available options are: SUCCESS, FAILURE. You can provide multiple values by repeating the param. | [optional]  |
| **campaign** | **string** | A filter by the campaign **name** that the redemption resources originate from. | [optional]  |
| **customer** | **string** | Return redemptions performed by the customer with given id or source_id. | [optional]  |
| **order** | **ParameterOrderListRedemptions** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **createdAt** | [**ParameterCreatedBeforeAfter**](ParameterCreatedBeforeAfter.md) | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z | [optional]  |
| **filters** | [**ParameterFiltersListRedemptions**](ParameterFiltersListRedemptions.md) | Filters for listing responses. | [optional]  |

### Return type

[**RedemptionsListResponseBody**](RedemptionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of redemption objects. Each entry in the array is a separate redemption object. If no more redemptions are available, the resulting array will be empty. If you provide a non-existent customer ID, this call returns an empty object. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="redeemstackeddiscounts"></a>
# **RedeemStackedDiscounts**
> RedemptionsRedeemResponseBody RedeemStackedDiscounts (RedemptionsRedeemRequestBody redemptionsRedeemRequestBody = null)

Redeem Stackable Discounts

# How API returns calculated discounts and order amounts in the response In the table below, you can see the logic the API follows to calculate discounts and amounts:    📘 Rollbacks  You cant roll back a child redemption. When you call rollback on a stacked redemption, all child redemptions will be rolled back. You need to refer to a parent redemption ID in your rollback request.      📘 Also available on client-side  This method is also accessible through public keys which you can use in client-side​ apps: mobile and web browser apps. Go to the dedicated endpoint to learn more.  - Use X-Client-Application-Id as the application ID header.  - Use X-Client-Token as the appliction secret key header.  - Use client-side base URL.  - Use an origin header for your custom domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class RedeemStackedDiscountsExample
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

            var apiInstance = new RedemptionsApi(config);
            var redemptionsRedeemRequestBody = new RedemptionsRedeemRequestBody(); // RedemptionsRedeemRequestBody |  (optional) 

            try
            {
                // Redeem Stackable Discounts
                RedemptionsRedeemResponseBody result = apiInstance.RedeemStackedDiscounts(redemptionsRedeemRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedemptionsApi.RedeemStackedDiscounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RedeemStackedDiscountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Redeem Stackable Discounts
    ApiResponse<RedemptionsRedeemResponseBody> response = apiInstance.RedeemStackedDiscountsWithHttpInfo(redemptionsRedeemRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedemptionsApi.RedeemStackedDiscountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **redemptionsRedeemRequestBody** | [**RedemptionsRedeemRequestBody**](RedemptionsRedeemRequestBody.md) |  | [optional]  |

### Return type

[**RedemptionsRedeemResponseBody**](RedemptionsRedeemResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Depending on your project settings: all redeemables must be valid or just one must be valid to result as valid redemption. Read more in the [Stacking Rule Documentation](https://support.voucherify.io/article/604-stacking-rules). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rollbackredemption"></a>
# **RollbackRedemption**
> RedemptionsRollbackCreateResponseBody RollbackRedemption (string redemptionId, string reason = null, string trackingId = null, RedemptionsRollbackCreateRequestBody redemptionsRollbackCreateRequestBody = null)

Rollback Redemption

Your business logic may include a case when you need to undo a redemption. You can revert a redemption by calling this API endpoint. This endpoint rolls back only single redemptions, meaning those that are not stacked. Stacked redemptions belong to a parent redemption. To roll back a parent redemption, including all of its individual redemptions, use the POST Rollback Stackable Redemptions  🚧  You can roll back a redemption up to 3 months back.   # Effect  The operation  - creates a rollback entry in vouchers redemption history (redemption.redemption_entries) and  - gives 1 redemption back to the pool (decreases redeemed_quantity by 1).  # Returned funds  In case of *gift card vouchers*, this method returns funds back according to the source redemption. In case of *loyalty card vouchers*, this method returns points back according to the source redemption.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class RollbackRedemptionExample
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

            var apiInstance = new RedemptionsApi(config);
            var redemptionId = "redemptionId_example";  // string | The original redemption ID to be rolled back (undone).
            var reason = "reason_example";  // string | Reason for the rollback. (optional) 
            var trackingId = "trackingId_example";  // string | Customers source_id. (optional) 
            var redemptionsRollbackCreateRequestBody = new RedemptionsRollbackCreateRequestBody(); // RedemptionsRollbackCreateRequestBody | Add information about the original customer and order. Customer data and Redemption metadata can be updated in Voucherify when passing the customer data in the request body. (optional) 

            try
            {
                // Rollback Redemption
                RedemptionsRollbackCreateResponseBody result = apiInstance.RollbackRedemption(redemptionId, reason, trackingId, redemptionsRollbackCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedemptionsApi.RollbackRedemption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RollbackRedemptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rollback Redemption
    ApiResponse<RedemptionsRollbackCreateResponseBody> response = apiInstance.RollbackRedemptionWithHttpInfo(redemptionId, reason, trackingId, redemptionsRollbackCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedemptionsApi.RollbackRedemptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **redemptionId** | **string** | The original redemption ID to be rolled back (undone). |  |
| **reason** | **string** | Reason for the rollback. | [optional]  |
| **trackingId** | **string** | Customers source_id. | [optional]  |
| **redemptionsRollbackCreateRequestBody** | [**RedemptionsRollbackCreateRequestBody**](RedemptionsRollbackCreateRequestBody.md) | Add information about the original customer and order. Customer data and Redemption metadata can be updated in Voucherify when passing the customer data in the request body. | [optional]  |

### Return type

[**RedemptionsRollbackCreateResponseBody**](RedemptionsRollbackCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a redemption rollback object indicating the result of the rollback. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rollbackstackedredemptions"></a>
# **RollbackStackedRedemptions**
> RedemptionsRollbacksCreateResponseBody RollbackStackedRedemptions (string parentRedemptionId, string reason = null, string trackingId = null, RedemptionsRollbacksCreateRequestBody redemptionsRollbacksCreateRequestBody = null)

Rollback Stackable Redemptions

Rollback a stackable redemption. When you roll back a stacked redemption, all child redemptions will be rolled back. Provide the parent redemption ID as the path parameter. However, you can use this endpoint to roll back a single redemption that does not have a parent, similarly to POST Rollback redemption. 🚧   You can roll back a redemption up to 3 months back.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class RollbackStackedRedemptionsExample
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

            var apiInstance = new RedemptionsApi(config);
            var parentRedemptionId = "parentRedemptionId_example";  // string | Unique identifier of a parent redemption, e.g. r_JQfm73zWSJFQxs3bGxweYjgm.
            var reason = "reason_example";  // string | Reason for the rollback. (optional) 
            var trackingId = "trackingId_example";  // string | Customers source_id. (optional) 
            var redemptionsRollbacksCreateRequestBody = new RedemptionsRollbacksCreateRequestBody(); // RedemptionsRollbacksCreateRequestBody | Add information about the original customer and order. Customer data and Redemption metadata can be updated in Voucherify when passing the customer data in the request body. (optional) 

            try
            {
                // Rollback Stackable Redemptions
                RedemptionsRollbacksCreateResponseBody result = apiInstance.RollbackStackedRedemptions(parentRedemptionId, reason, trackingId, redemptionsRollbacksCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedemptionsApi.RollbackStackedRedemptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RollbackStackedRedemptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rollback Stackable Redemptions
    ApiResponse<RedemptionsRollbacksCreateResponseBody> response = apiInstance.RollbackStackedRedemptionsWithHttpInfo(parentRedemptionId, reason, trackingId, redemptionsRollbacksCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedemptionsApi.RollbackStackedRedemptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentRedemptionId** | **string** | Unique identifier of a parent redemption, e.g. r_JQfm73zWSJFQxs3bGxweYjgm. |  |
| **reason** | **string** | Reason for the rollback. | [optional]  |
| **trackingId** | **string** | Customers source_id. | [optional]  |
| **redemptionsRollbacksCreateRequestBody** | [**RedemptionsRollbacksCreateRequestBody**](RedemptionsRollbacksCreateRequestBody.md) | Add information about the original customer and order. Customer data and Redemption metadata can be updated in Voucherify when passing the customer data in the request body. | [optional]  |

### Return type

[**RedemptionsRollbacksCreateResponseBody**](RedemptionsRollbacksCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an array with the individual redemption rollback results along with the parent rollback result and related order. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

