# Voucherify.Api.ReferralsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReferralsAddHolders**](ReferralsApi.md#referralsaddholders) | **POST** /v1/referrals/members/{memberId}/holders | Add Referral Code Holders |
| [**ReferralsAddHolders1**](ReferralsApi.md#referralsaddholders1) | **POST** /v1/referrals/{campaignId}/members/{memberId}/holders | Add Referral Code Holders |
| [**ReferralsCodeHolders**](ReferralsApi.md#referralscodeholders) | **GET** /v1/referrals/{campaignId}/members/{memberId}/holders | List Referral Code Holders |
| [**ReferralsCodeHolders1**](ReferralsApi.md#referralscodeholders1) | **GET** /v1/referrals/members/{memberId}/holders | List Referral Code Holders |
| [**ReferralsRemoveHolder**](ReferralsApi.md#referralsremoveholder) | **DELETE** /v1/referrals/members/{memberId}/holders/{holderId} | Remove Referral Card Holder |
| [**ReferralsRemoveHolder1**](ReferralsApi.md#referralsremoveholder1) | **DELETE** /v1/referrals/{campaignId}/members/{memberId}/holders/{holderId} | Remove Referral Card Holder |

<a id="referralsaddholders"></a>
# **ReferralsAddHolders**
> ReferralsMembersHoldersCreateInBulkResponseBody ReferralsAddHolders (string memberId, ReferralsMembersHoldersCreateInBulkRequestBody referralsMembersHoldersCreateInBulkRequestBody = null)

Add Referral Code Holders

Adds new holders to a referral code as **referees**. The data sent in the request is upserted into the customer data. If the request returns an error even for one customer, you have to resend the whole request. Customer data is upserted if the data for all customers is correct. To use this endpoint, you must have the following permissions: - Create and modify Customers and Segments (customers.modify) - Publish Voucher (vouchers.publish)  👍 To add a holder as a referer, use the Create Publication endpoint.  📘 Alternative endpoint This endpoint is an alternative to the Add Referral Code Holders endpoint. The URL was re-designed to retrieve the referral member holders without providing the campaignId as a path paremeter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ReferralsAddHoldersExample
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

            var apiInstance = new ReferralsApi(config);
            var memberId = "memberId_example";  // string | Unique referral code or its identifier.
            var referralsMembersHoldersCreateInBulkRequestBody = new ReferralsMembersHoldersCreateInBulkRequestBody(); // ReferralsMembersHoldersCreateInBulkRequestBody | Specify the customer data to be upserted as redeemable holders. (optional) 

            try
            {
                // Add Referral Code Holders
                ReferralsMembersHoldersCreateInBulkResponseBody result = apiInstance.ReferralsAddHolders(memberId, referralsMembersHoldersCreateInBulkRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferralsApi.ReferralsAddHolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferralsAddHoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Referral Code Holders
    ApiResponse<ReferralsMembersHoldersCreateInBulkResponseBody> response = apiInstance.ReferralsAddHoldersWithHttpInfo(memberId, referralsMembersHoldersCreateInBulkRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferralsApi.ReferralsAddHoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique referral code or its identifier. |  |
| **referralsMembersHoldersCreateInBulkRequestBody** | [**ReferralsMembersHoldersCreateInBulkRequestBody**](ReferralsMembersHoldersCreateInBulkRequestBody.md) | Specify the customer data to be upserted as redeemable holders. | [optional]  |

### Return type

[**ReferralsMembersHoldersCreateInBulkResponseBody**](ReferralsMembersHoldersCreateInBulkResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of redeemable holder objects. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="referralsaddholders1"></a>
# **ReferralsAddHolders1**
> ReferralsMembersHoldersCreateInBulkResponseBody ReferralsAddHolders1 (string campaignId, string memberId, ReferralsMembersHoldersCreateInBulkRequestBody referralsMembersHoldersCreateInBulkRequestBody = null)

Add Referral Code Holders

Adds new holders to a referral code as **referees**. The data sent in the request is upserted into the customer data. If the request returns an error even for one customer, you have to resend the whole request. Customer data is upserted if the data for all customers is correct. To use this endpoint, you must have the following permissions: - Create and modify Customers and Segments (customers.modify) - Publish Voucher (vouchers.publish)  👍 To add a holder as a referer, use the Create Publication endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ReferralsAddHolders1Example
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

            var apiInstance = new ReferralsApi(config);
            var campaignId = "campaignId_example";  // string | Unique identifier of a referral program campaign.
            var memberId = "memberId_example";  // string | Unique referral code or its identifier.
            var referralsMembersHoldersCreateInBulkRequestBody = new ReferralsMembersHoldersCreateInBulkRequestBody(); // ReferralsMembersHoldersCreateInBulkRequestBody | Specify the customer data to be upserted as redeemable holders. (optional) 

            try
            {
                // Add Referral Code Holders
                ReferralsMembersHoldersCreateInBulkResponseBody result = apiInstance.ReferralsAddHolders1(campaignId, memberId, referralsMembersHoldersCreateInBulkRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferralsApi.ReferralsAddHolders1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferralsAddHolders1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Referral Code Holders
    ApiResponse<ReferralsMembersHoldersCreateInBulkResponseBody> response = apiInstance.ReferralsAddHolders1WithHttpInfo(campaignId, memberId, referralsMembersHoldersCreateInBulkRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferralsApi.ReferralsAddHolders1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique identifier of a referral program campaign. |  |
| **memberId** | **string** | Unique referral code or its identifier. |  |
| **referralsMembersHoldersCreateInBulkRequestBody** | [**ReferralsMembersHoldersCreateInBulkRequestBody**](ReferralsMembersHoldersCreateInBulkRequestBody.md) | Specify the customer data to be upserted as redeemable holders. | [optional]  |

### Return type

[**ReferralsMembersHoldersCreateInBulkResponseBody**](ReferralsMembersHoldersCreateInBulkResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of redeemable holder objects. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="referralscodeholders"></a>
# **ReferralsCodeHolders**
> ReferralsMembersHoldersListResponseBody ReferralsCodeHolders (string campaignId, string memberId, int limit = null, ParameterOrderListRedeemables order = null, string startingAfterId = null, ParameterFiltersListReferralsRedeemableHolders filters = null)

List Referral Code Holders

Retrieves all the redeemables that have been assigned to the customer. To use this endpoint, you must have the following permissions: - Read Customers (customers.details.read)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ReferralsCodeHoldersExample
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

            var apiInstance = new ReferralsApi(config);
            var campaignId = "campaignId_example";  // string | Unique identifier of a referral program campaign.
            var memberId = "memberId_example";  // string | Unique referral code or its identifier.
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListRedeemables) "id";  // ParameterOrderListRedeemables | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the events starting after an event with the given ID. (optional) 
            var filters = new ParameterFiltersListReferralsRedeemableHolders(); // ParameterFiltersListReferralsRedeemableHolders | Filters for listing customer redeemables. (optional) 

            try
            {
                // List Referral Code Holders
                ReferralsMembersHoldersListResponseBody result = apiInstance.ReferralsCodeHolders(campaignId, memberId, limit, order, startingAfterId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferralsApi.ReferralsCodeHolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferralsCodeHoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Referral Code Holders
    ApiResponse<ReferralsMembersHoldersListResponseBody> response = apiInstance.ReferralsCodeHoldersWithHttpInfo(campaignId, memberId, limit, order, startingAfterId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferralsApi.ReferralsCodeHoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique identifier of a referral program campaign. |  |
| **memberId** | **string** | Unique referral code or its identifier. |  |
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListRedeemables** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the events starting after an event with the given ID. | [optional]  |
| **filters** | [**ParameterFiltersListReferralsRedeemableHolders**](ParameterFiltersListReferralsRedeemableHolders.md) | Filters for listing customer redeemables. | [optional]  |

### Return type

[**ReferralsMembersHoldersListResponseBody**](ReferralsMembersHoldersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the holders of the redeemable that is assigned to the referral campaign. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="referralscodeholders1"></a>
# **ReferralsCodeHolders1**
> ReferralsMembersHoldersListResponseBody ReferralsCodeHolders1 (string memberId, int limit = null, ParameterOrderListRedeemables order = null, string startingAfterId = null, ParameterFiltersListReferralsRedeemableHolders filters = null)

List Referral Code Holders

Retrieves the holders of the referral code from a referral campaign. To use this endpoint, you must have the following permissions: - Read Customers (customers.details.read)  📘 Alternative endpoint This endpoint is an alternative to the List Member Holders endpoint. The URL was re-designed to retrieve the referral member holders without providing the campaignId as a path paremeter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ReferralsCodeHolders1Example
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

            var apiInstance = new ReferralsApi(config);
            var memberId = "memberId_example";  // string | Unique referral code or its identifier.
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListRedeemables) "id";  // ParameterOrderListRedeemables | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the events starting after an event with the given ID. (optional) 
            var filters = new ParameterFiltersListReferralsRedeemableHolders(); // ParameterFiltersListReferralsRedeemableHolders | Filters for listing customer redeemables. (optional) 

            try
            {
                // List Referral Code Holders
                ReferralsMembersHoldersListResponseBody result = apiInstance.ReferralsCodeHolders1(memberId, limit, order, startingAfterId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferralsApi.ReferralsCodeHolders1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferralsCodeHolders1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Referral Code Holders
    ApiResponse<ReferralsMembersHoldersListResponseBody> response = apiInstance.ReferralsCodeHolders1WithHttpInfo(memberId, limit, order, startingAfterId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferralsApi.ReferralsCodeHolders1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique referral code or its identifier. |  |
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListRedeemables** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the events starting after an event with the given ID. | [optional]  |
| **filters** | [**ParameterFiltersListReferralsRedeemableHolders**](ParameterFiltersListReferralsRedeemableHolders.md) | Filters for listing customer redeemables. | [optional]  |

### Return type

[**ReferralsMembersHoldersListResponseBody**](ReferralsMembersHoldersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the holders of the redeemable that is assigned to the referral campaign. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="referralsremoveholder"></a>
# **ReferralsRemoveHolder**
> void ReferralsRemoveHolder (string memberId, string holderId)

Remove Referral Card Holder

Removes the holder from a referral card. You can remove a referee only. To use this endpoint, you must have the following permissions: - Create and modify Customers and Segments (customers.modify) - Publish Voucher (vouchers.publish)  📘 Alternative endpoint This endpoint is an alternative to the Remove Referral Card Holder endpoint. The URL was re-designed to retrieve the referral member holders without providing the campaignId as a path paremeter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ReferralsRemoveHolderExample
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

            var apiInstance = new ReferralsApi(config);
            var memberId = "memberId_example";  // string | Unique referral code or its identifier.
            var holderId = "holderId_example";  // string | Unique identifier of a redeemable holder.

            try
            {
                // Remove Referral Card Holder
                apiInstance.ReferralsRemoveHolder(memberId, holderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferralsApi.ReferralsRemoveHolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferralsRemoveHolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Referral Card Holder
    apiInstance.ReferralsRemoveHolderWithHttpInfo(memberId, holderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferralsApi.ReferralsRemoveHolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique referral code or its identifier. |  |
| **holderId** | **string** | Unique identifier of a redeemable holder. |  |

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
| **204** | Returns no content if removal is successful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="referralsremoveholder1"></a>
# **ReferralsRemoveHolder1**
> void ReferralsRemoveHolder1 (string campaignId, string memberId, string holderId)

Remove Referral Card Holder

Removes the holder from a referral card. You can remove a referee only. To use this endpoint, you must have the following permissions: - Create and modify Customers and Segments (customers.modify) - Publish Voucher (vouchers.publish)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ReferralsRemoveHolder1Example
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

            var apiInstance = new ReferralsApi(config);
            var campaignId = "campaignId_example";  // string | Unique identifier of a referral program campaign.
            var memberId = "memberId_example";  // string | Unique referral code or its identifier.
            var holderId = "holderId_example";  // string | Unique identifier of a redeemable holder.

            try
            {
                // Remove Referral Card Holder
                apiInstance.ReferralsRemoveHolder1(campaignId, memberId, holderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferralsApi.ReferralsRemoveHolder1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferralsRemoveHolder1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Referral Card Holder
    apiInstance.ReferralsRemoveHolder1WithHttpInfo(campaignId, memberId, holderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferralsApi.ReferralsRemoveHolder1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique identifier of a referral program campaign. |  |
| **memberId** | **string** | Unique referral code or its identifier. |  |
| **holderId** | **string** | Unique identifier of a redeemable holder. |  |

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
| **204** | Returns no content if removal is successful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

