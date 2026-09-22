# Voucherify.Api.CampaignsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddVoucherWithSpecificCodeToCampaign**](CampaignsApi.md#addvoucherwithspecificcodetocampaign) | **POST** /v1/campaigns/{campaignId}/vouchers/{code} | Add Voucher with Specific Code to Campaign |
| [**AddVouchersToCampaign**](CampaignsApi.md#addvoucherstocampaign) | **POST** /v1/campaigns/{campaignId}/vouchers | Add Vouchers to Campaign |
| [**CreateCampaign**](CampaignsApi.md#createcampaign) | **POST** /v1/campaigns | Create Campaign |
| [**DeleteCampaign**](CampaignsApi.md#deletecampaign) | **DELETE** /v1/campaigns/{campaignId} | Delete Campaign |
| [**DisableCampaign**](CampaignsApi.md#disablecampaign) | **POST** /v1/campaigns/{campaignId}/disable | Disable Campaign |
| [**EnableCampaign**](CampaignsApi.md#enablecampaign) | **POST** /v1/campaigns/{campaignId}/enable | Enable Campaign |
| [**ExportCampaignTransactions**](CampaignsApi.md#exportcampaigntransactions) | **POST** /v1/campaigns/{campaignId}/transactions/export | Export Campaign Transactions |
| [**GetCampaign**](CampaignsApi.md#getcampaign) | **GET** /v1/campaigns/{campaignId} | Get Campaign |
| [**GetCampaignSummary**](CampaignsApi.md#getcampaignsummary) | **GET** /v1/campaigns/{campaignId}/summary | Get Campaign Summary |
| [**ImportVouchersToCampaign**](CampaignsApi.md#importvoucherstocampaign) | **POST** /v1/campaigns/{campaignId}/import | Import Vouchers to Campaign |
| [**ImportVouchersToCampaignUsingCsv**](CampaignsApi.md#importvoucherstocampaignusingcsv) | **POST** /v1/campaigns/{campaignId}/importCSV | Import Vouchers to Campaign by CSV |
| [**ListCampaignTransactions**](CampaignsApi.md#listcampaigntransactions) | **GET** /v1/campaigns/{campaignId}/transactions | List Campaign Transactions |
| [**ListCampaigns**](CampaignsApi.md#listcampaigns) | **GET** /v1/campaigns | List Campaigns |
| [**UpdateCampaign**](CampaignsApi.md#updatecampaign) | **PUT** /v1/campaigns/{campaignId} | Update Campaign |

<a id="addvoucherwithspecificcodetocampaign"></a>
# **AddVoucherWithSpecificCodeToCampaign**
> CampaignsVouchersCreateResponseBody AddVoucherWithSpecificCodeToCampaign (string campaignId, string code, CampaignsVouchersCreateRequestBody campaignsVouchersCreateRequestBody)

Add Voucher with Specific Code to Campaign

This method gives a possibility to add a new voucher to an existing campaign. The voucher definition will be inherited from the definition kept in the campaign profile. However, you are able to overwrite a few properties inherited from the campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class AddVoucherWithSpecificCodeToCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the campaign to which voucher will be added. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var code = "code_example";  // string | A custom **code** that identifies the voucher.
            var campaignsVouchersCreateRequestBody = new CampaignsVouchersCreateRequestBody(); // CampaignsVouchersCreateRequestBody | Specify the voucher parameters that you would like to overwrite.

            try
            {
                // Add Voucher with Specific Code to Campaign
                CampaignsVouchersCreateResponseBody result = apiInstance.AddVoucherWithSpecificCodeToCampaign(campaignId, code, campaignsVouchersCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.AddVoucherWithSpecificCodeToCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddVoucherWithSpecificCodeToCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Voucher with Specific Code to Campaign
    ApiResponse<CampaignsVouchersCreateResponseBody> response = apiInstance.AddVoucherWithSpecificCodeToCampaignWithHttpInfo(campaignId, code, campaignsVouchersCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.AddVoucherWithSpecificCodeToCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the campaign to which voucher will be added. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **code** | **string** | A custom **code** that identifies the voucher. |  |
| **campaignsVouchersCreateRequestBody** | [**CampaignsVouchersCreateRequestBody**](CampaignsVouchersCreateRequestBody.md) | Specify the voucher parameters that you would like to overwrite. |  |

### Return type

[**CampaignsVouchersCreateResponseBody**](CampaignsVouchersCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a voucher object if the call succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addvoucherstocampaign"></a>
# **AddVouchersToCampaign**
> CampaignsVouchersCreateCombinedResponseBody AddVouchersToCampaign (string campaignId, CampaignsVouchersCreateInBulkRequestBody campaignsVouchersCreateInBulkRequestBody, int? vouchersCount = null)

Add Vouchers to Campaign

This method gives the possibility to push new vouchers to an existing campaign. New vouchers will inherit properties from the campaign profile. However, it is possible to overwrite some of them in the request body. If you provide an optional code_config parameter with a voucher code configuration, then it will be used to generate new voucher codes. Otherwise, the voucher code configuration from the campaign will be used. This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this [API request](/api-reference/async-actions/get-async-action).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class AddVouchersToCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the campaign to which voucher(s) will be added. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var campaignsVouchersCreateInBulkRequestBody = new CampaignsVouchersCreateInBulkRequestBody(); // CampaignsVouchersCreateInBulkRequestBody | Specify the voucher parameters that you would like to overwrite.
            var vouchersCount = 56;  // int? | Number of vouchers that should be added. (optional) 

            try
            {
                // Add Vouchers to Campaign
                CampaignsVouchersCreateCombinedResponseBody result = apiInstance.AddVouchersToCampaign(campaignId, campaignsVouchersCreateInBulkRequestBody, vouchersCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.AddVouchersToCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddVouchersToCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Vouchers to Campaign
    ApiResponse<CampaignsVouchersCreateCombinedResponseBody> response = apiInstance.AddVouchersToCampaignWithHttpInfo(campaignId, campaignsVouchersCreateInBulkRequestBody, vouchersCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.AddVouchersToCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the campaign to which voucher(s) will be added. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **campaignsVouchersCreateInBulkRequestBody** | [**CampaignsVouchersCreateInBulkRequestBody**](CampaignsVouchersCreateInBulkRequestBody.md) | Specify the voucher parameters that you would like to overwrite. |  |
| **vouchersCount** | **int?** | Number of vouchers that should be added. | [optional]  |

### Return type

[**CampaignsVouchersCreateCombinedResponseBody**](CampaignsVouchersCreateCombinedResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a voucher object if the call succeeded for a voucher count of 1. and Returns an &#x60;async_action_id&#x60; if the request was made to create more than 1 voucher. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcampaign"></a>
# **CreateCampaign**
> CampaignsCreateResponseBody CreateCampaign (CampaignsCreateRequestBody campaignsCreateRequestBody)

Create Campaign

Method to create a batch of vouchers aggregated in one campaign. You can choose a variety of voucher types and define a unique pattern for generating codes.   <Note> <Badge color blue>Global uniqueness</Badge> All campaign codes are unique across the whole project. Voucherify will not allow you to generate 2 campaigns with the same coupon code. </Note> <Warning> <Badge color yellow>Code generation status</Badge> This is an asynchronous action; you cant read or modify a newly created campaign until the code generation is completed. See the creation_status field in the [campaign object](/api-reference/campaigns/campaign-object) description. </Warning>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignsCreateRequestBody = new CampaignsCreateRequestBody(); // CampaignsCreateRequestBody | Specify the details of the campaign that you would like to create.

            try
            {
                // Create Campaign
                CampaignsCreateResponseBody result = apiInstance.CreateCampaign(campaignsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Campaign
    ApiResponse<CampaignsCreateResponseBody> response = apiInstance.CreateCampaignWithHttpInfo(campaignsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.CreateCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignsCreateRequestBody** | [**CampaignsCreateRequestBody**](CampaignsCreateRequestBody.md) | Specify the details of the campaign that you would like to create. |  |

### Return type

[**CampaignsCreateResponseBody**](CampaignsCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a campaign object if the call succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecampaign"></a>
# **DeleteCampaign**
> CampaignsDeleteResponseBody DeleteCampaign (string campaignId, bool? force = null)

Delete Campaign

Deletes a campaign and all related vouchers. This action cannot be undone. Also, this method immediately removes any redemptions on the voucher. If the force parameter is set to false or not set at all, the campaign and all related vouchers will be moved to [the bin](/api-reference/bin/list-bin-entries). This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this [API request](/api-reference/async-actions/get-async-action).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var force = true;  // bool? | If this flag is set to true, the campaign and related vouchers will be removed permanently. If it is set to false or not set at all, the campaign and related vouchers will be moved to the bin. Going forward, the user will be able to create the next campaign with exactly the same name. (optional) 

            try
            {
                // Delete Campaign
                CampaignsDeleteResponseBody result = apiInstance.DeleteCampaign(campaignId, force);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeleteCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Campaign
    ApiResponse<CampaignsDeleteResponseBody> response = apiInstance.DeleteCampaignWithHttpInfo(campaignId, force);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.DeleteCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **force** | **bool?** | If this flag is set to true, the campaign and related vouchers will be removed permanently. If it is set to false or not set at all, the campaign and related vouchers will be moved to the bin. Going forward, the user will be able to create the next campaign with exactly the same name. | [optional]  |

### Return type

[**CampaignsDeleteResponseBody**](CampaignsDeleteResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Returns the ID of the scheduled asynchronous action, informing you that your request has been accepted and the campaign will be deleted from the repository asynchronously. To check the deletion status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using [Get Async Action](/api-reference/async-actions/get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="disablecampaign"></a>
# **DisableCampaign**
> Object DisableCampaign (string campaignId)

Disable Campaign

Sets campaign state to **inactive**. The vouchers in this campaign can no longer be redeemed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DisableCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the campaign being disabled. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.

            try
            {
                // Disable Campaign
                Object result = apiInstance.DisableCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.DisableCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable Campaign
    ApiResponse<Object> response = apiInstance.DisableCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.DisableCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the campaign being disabled. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |

### Return type

**Object**

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an empty json &#x60;{}&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="enablecampaign"></a>
# **EnableCampaign**
> Object EnableCampaign (string campaignId)

Enable Campaign

Sets campaign state to **active**. The vouchers in this campaign can be redeemed - only if the redemption occurs after the start date of the campaign and voucher and the voucher and campaign are not expired.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class EnableCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the campaign being enabled. You can either pass the campaign ID, which was assigned by Voucherify or the name of the campaign as the path parameter value.

            try
            {
                // Enable Campaign
                Object result = apiInstance.EnableCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.EnableCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Campaign
    ApiResponse<Object> response = apiInstance.EnableCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.EnableCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the campaign being enabled. You can either pass the campaign ID, which was assigned by Voucherify or the name of the campaign as the path parameter value. |  |

### Return type

**Object**

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an empty json &#x60;{}&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportcampaigntransactions"></a>
# **ExportCampaignTransactions**
> CampaignsTransactionsExportCreateResponseBody ExportCampaignTransactions (string campaignId, CampaignsTransactionsExportCreateRequestBody campaignsTransactionsExportCreateRequestBody)

Export Campaign Transactions

Export transactions is an asynchronous process that generates a CSV file with the data about credit movements on all gift cards or point movements on all loyalty cards in a given campaign. To export transactions: 1. In the export request, use parameters to select which fields will be exported, in what order, and which data will be filtered. 2. Use the returned id to track the export status with the [GET Export](/api-reference/exports/get-export) method. 3. In the GET Export method, when the returned status field has the DONE value, the export file has been generated. 4. Use the URL in the result property to download the file. You must be logged to your Voucherify account on a given cluster in the browser to be able to download the file. An export request will almost always result in a single file being generated by the system. However, when the data volume is large, the system may split the results into multiple files. An example export file can look as follows:   <Tip> <Badge color green>Export Loyalty Campaign Transactions</Badge> For loyalty campaigns, this method works in the same way the [POST Export Loyalty Campaign Transactions](/api-reference/loyalties/export-loyalty-campaign-transactions) does. </Tip>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExportCampaignTransactionsExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var campaignsTransactionsExportCreateRequestBody = new CampaignsTransactionsExportCreateRequestBody(); // CampaignsTransactionsExportCreateRequestBody | Specify the parameters for the transaction export.

            try
            {
                // Export Campaign Transactions
                CampaignsTransactionsExportCreateResponseBody result = apiInstance.ExportCampaignTransactions(campaignId, campaignsTransactionsExportCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.ExportCampaignTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportCampaignTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Campaign Transactions
    ApiResponse<CampaignsTransactionsExportCreateResponseBody> response = apiInstance.ExportCampaignTransactionsWithHttpInfo(campaignId, campaignsTransactionsExportCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.ExportCampaignTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **campaignsTransactionsExportCreateRequestBody** | [**CampaignsTransactionsExportCreateRequestBody**](CampaignsTransactionsExportCreateRequestBody.md) | Specify the parameters for the transaction export. |  |

### Return type

[**CampaignsTransactionsExportCreateResponseBody**](CampaignsTransactionsExportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object representing an export. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcampaign"></a>
# **GetCampaign**
> CampaignsGetResponseBody GetCampaign (string campaignId)

Get Campaign

Retrieves the campaign with the given campaign ID or campaign name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.

            try
            {
                // Get Campaign
                CampaignsGetResponseBody result = apiInstance.GetCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Campaign
    ApiResponse<CampaignsGetResponseBody> response = apiInstance.GetCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.GetCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |

### Return type

[**CampaignsGetResponseBody**](CampaignsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a campaign object if a valid identifier was provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcampaignsummary"></a>
# **GetCampaignSummary**
> CampaignsSummaryGetResponseBody GetCampaignSummary (string campaignId, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)

Get Campaign Summary

Returns data for campaign analytics, covering validations, redemptions, publications, and other details specific to a given campaign type. Use start_date and end_date to narrow down the data to specific periods. <Warning> <Badge color yellow>Campaigns created before 17 June 2025</Badge> This endpoint returns analytics data for campaigns that were created after 17 June 2025. Older campaigns return empty data. </Warning>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetCampaignSummaryExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset? | Timestamp representing the date which results must begin on. Represented in ISO 8601 format. (optional) 
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset? | Timestamp representing the date which results must end on. Represented in ISO 8601 format. (optional) 

            try
            {
                // Get Campaign Summary
                CampaignsSummaryGetResponseBody result = apiInstance.GetCampaignSummary(campaignId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Campaign Summary
    ApiResponse<CampaignsSummaryGetResponseBody> response = apiInstance.GetCampaignSummaryWithHttpInfo(campaignId, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.GetCampaignSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **startDate** | **DateTimeOffset?** | Timestamp representing the date which results must begin on. Represented in ISO 8601 format. | [optional]  |
| **endDate** | **DateTimeOffset?** | Timestamp representing the date which results must end on. Represented in ISO 8601 format. | [optional]  |

### Return type

[**CampaignsSummaryGetResponseBody**](CampaignsSummaryGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns campaign analytics data. Returns different data depending on the campaign type. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importvoucherstocampaign"></a>
# **ImportVouchersToCampaign**
> CampaignsImportCreateResponseBody ImportVouchersToCampaign (string campaignId, List<CampaignsImportVoucherItem> campaignsImportVoucherItem)

Import Vouchers to Campaign

Imports vouchers to an **existing** campaign. This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this [API request](/api-reference/async-actions/get-async-action).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportVouchersToCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | The ID of an existing campaign to which youre importing the codes. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var campaignsImportVoucherItem = new List<CampaignsImportVoucherItem>(); // List<CampaignsImportVoucherItem> | Discount type, expiration date and the remaining attributes will be taken from the [Campaign](/api-reference/campaigns/get-campaign) settings.

            try
            {
                // Import Vouchers to Campaign
                CampaignsImportCreateResponseBody result = apiInstance.ImportVouchersToCampaign(campaignId, campaignsImportVoucherItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.ImportVouchersToCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportVouchersToCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Vouchers to Campaign
    ApiResponse<CampaignsImportCreateResponseBody> response = apiInstance.ImportVouchersToCampaignWithHttpInfo(campaignId, campaignsImportVoucherItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.ImportVouchersToCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The ID of an existing campaign to which youre importing the codes. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **campaignsImportVoucherItem** | [**List&lt;CampaignsImportVoucherItem&gt;**](CampaignsImportVoucherItem.md) | Discount type, expiration date and the remaining attributes will be taken from the [Campaign](/api-reference/campaigns/get-campaign) settings. |  |

### Return type

[**CampaignsImportCreateResponseBody**](CampaignsImportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Returns the ID of the scheduled asynchronous action, informing you that your request has been accepted and the vouchers will be imported to the repository asynchronously. To check the status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using [Get Async Action](/api-reference/async-actions/get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importvoucherstocampaignusingcsv"></a>
# **ImportVouchersToCampaignUsingCsv**
> CampaignsImportCsvCreateResponseBody ImportVouchersToCampaignUsingCsv (string campaignId, System.IO.Stream file = null)

Import Vouchers to Campaign by CSV

Imports vouchers to an **existing** campaign.   The CSV file has to include headers in the first line.  This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this [API request](/api-reference/async-actions/get-async-action).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportVouchersToCampaignUsingCsvExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the campaign being enabled. You can either pass the campaign ID, which was assigned by Voucherify or the name of the campaign as the path parameter value.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File path. (optional) 

            try
            {
                // Import Vouchers to Campaign by CSV
                CampaignsImportCsvCreateResponseBody result = apiInstance.ImportVouchersToCampaignUsingCsv(campaignId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.ImportVouchersToCampaignUsingCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportVouchersToCampaignUsingCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Vouchers to Campaign by CSV
    ApiResponse<CampaignsImportCsvCreateResponseBody> response = apiInstance.ImportVouchersToCampaignUsingCsvWithHttpInfo(campaignId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.ImportVouchersToCampaignUsingCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the campaign being enabled. You can either pass the campaign ID, which was assigned by Voucherify or the name of the campaign as the path parameter value. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File path. | [optional]  |

### Return type

[**CampaignsImportCsvCreateResponseBody**](CampaignsImportCsvCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the ID of the scheduled asynchronous action, informing you that your request has been accepted and the vouchers will be imported to the repository asynchronously. To check the status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using [Get Async Action](/api-reference/async-actions/get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcampaigntransactions"></a>
# **ListCampaignTransactions**
> CampaignsTransactionsListResponseBody ListCampaignTransactions (string campaignId, int? limit = null, ParameterOrderListTransactions? order = null, string startingAfterId = null, ParametersFiltersListCampaignTransactions filters = null)

List Campaign Transactions

Retrieves all transactions for the campaign with the given campaign ID or campaign name. The id filter denotes the unique transaction identifier. <Warning> The endpoint works only for gift card and loyalty campaigns. </Warning>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCampaignTransactionsExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListTransactions) "id";  // ParameterOrderListTransactions? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. (optional) 
            var filters = new ParametersFiltersListCampaignTransactions(); // ParametersFiltersListCampaignTransactions | Filters for listing responses. (optional) 

            try
            {
                // List Campaign Transactions
                CampaignsTransactionsListResponseBody result = apiInstance.ListCampaignTransactions(campaignId, limit, order, startingAfterId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.ListCampaignTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCampaignTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Campaign Transactions
    ApiResponse<CampaignsTransactionsListResponseBody> response = apiInstance.ListCampaignTransactionsWithHttpInfo(campaignId, limit, order, startingAfterId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.ListCampaignTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListTransactions?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. | [optional]  |
| **filters** | [**ParametersFiltersListCampaignTransactions**](ParametersFiltersListCampaignTransactions.md) | Filters for listing responses. | [optional]  |

### Return type

[**CampaignsTransactionsListResponseBody**](CampaignsTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a &#x60;data&#x60; property that contains an array of transactions. The maximum number of transactions returned is determined by the &#x60;limit&#x60; query parameter. Each entry in the array is a separate transaction object. If more results are available, the &#x60;has_more&#x60; flag has value &#x60;true&#x60; and the value of the &#x60;more_starting_after&#x60; property can be used to retrieve another page of results. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcampaigns"></a>
# **ListCampaigns**
> CampaignsListResponseBody ListCampaigns (int? limit = null, int? page = null, ParameterCampaignType? campaignType = null, ParameterExpandListCampaigns? expand = null, ParameterCampaignStatusListCampaigns? campaignStatus = null, bool? isReferralCode = null, ParameterOrderListCampaigns? order = null, ParameterFiltersListCampaigns filters = null, ParameterCampaignsAccessSetttings accessSettings = null)

List Campaigns

Retrieve a list of campaigns in a project.  The campaigns are returned sorted by creation date, with the most recent campaigns appearing first.   When you get a list of campaigns, you can optionally specify query parameters to customize the amount of campaigns returned per call using limit, which page of campaigns to return using page, sort the campaigns using the order query parameter and filter the results by the campaign_type. This method will return an error when trying to return a limit of more than 100 campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCampaignsExample
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

            var apiInstance = new CampaignsApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var campaignType = (ParameterCampaignType) "PROMOTION";  // ParameterCampaignType? | This attribute allows filtering by campaign type. (optional) 
            var expand = (ParameterExpandListCampaigns) "category";  // ParameterExpandListCampaigns? | Includes an expanded categories object in the response. If the [Areas and Stores](/orchestrate/areas-and-stores) Enterprise feature is enabled, add access_settings_assignments to return assigned areas and stores. (optional) 
            var campaignStatus = (ParameterCampaignStatusListCampaigns) "DONE";  // ParameterCampaignStatusListCampaigns? | Sorts the results by the status of the campaign. (optional) 
            var isReferralCode = true;  // bool? | Sorts the results that are or are not referral campaigns. (optional) 
            var order = (ParameterOrderListCampaigns) "created_at";  // ParameterOrderListCampaigns? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var filters = new ParameterFiltersListCampaigns(); // ParameterFiltersListCampaigns | Filters the results by various campaign properties. (optional) 
            var accessSettings = new ParameterCampaignsAccessSetttings(); // ParameterCampaignsAccessSetttings | Filter by areas and stores IDs to return campaigns that are assigned to areas, stores, and all stores in an area. (optional) 

            try
            {
                // List Campaigns
                CampaignsListResponseBody result = apiInstance.ListCampaigns(limit, page, campaignType, expand, campaignStatus, isReferralCode, order, filters, accessSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.ListCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Campaigns
    ApiResponse<CampaignsListResponseBody> response = apiInstance.ListCampaignsWithHttpInfo(limit, page, campaignType, expand, campaignStatus, isReferralCode, order, filters, accessSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.ListCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **campaignType** | **ParameterCampaignType?** | This attribute allows filtering by campaign type. | [optional]  |
| **expand** | **ParameterExpandListCampaigns?** | Includes an expanded categories object in the response. If the [Areas and Stores](/orchestrate/areas-and-stores) Enterprise feature is enabled, add access_settings_assignments to return assigned areas and stores. | [optional]  |
| **campaignStatus** | **ParameterCampaignStatusListCampaigns?** | Sorts the results by the status of the campaign. | [optional]  |
| **isReferralCode** | **bool?** | Sorts the results that are or are not referral campaigns. | [optional]  |
| **order** | **ParameterOrderListCampaigns?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **filters** | [**ParameterFiltersListCampaigns**](ParameterFiltersListCampaigns.md) | Filters the results by various campaign properties. | [optional]  |
| **accessSettings** | [**ParameterCampaignsAccessSetttings**](ParameterCampaignsAccessSetttings.md) | Filter by areas and stores IDs to return campaigns that are assigned to areas, stores, and all stores in an area. | [optional]  |

### Return type

[**CampaignsListResponseBody**](CampaignsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a &#x60;campaign&#x60; property that contains an array of campaigns. The maximum number of campaigns returned is determined by the &#x60;limit&#x60; query parameter. Each entry in the array is a separate campaign object. If no more campaigns are available, the resulting array on a given page will be empty. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecampaign"></a>
# **UpdateCampaign**
> CampaignsUpdateResponseBody UpdateCampaign (string campaignId, CampaignsUpdateRequestBody campaignsUpdateRequestBody)

Update Campaign

Updates the specified campaign by setting the values of the parameters passed in the request body. Any parameters not provided in the payload will be left unchanged.  Fields other than the ones listed in the request body wont be modified. Even if provided, they will be silently skipped.    <Warning> <Badge color yellow>Vouchers will be affected</Badge> This method will update vouchers aggregated in the campaign. It will affect all vouchers that are not published or redeemed yet. </Warning>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateCampaignExample
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

            var apiInstance = new CampaignsApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var campaignsUpdateRequestBody = new CampaignsUpdateRequestBody(); // CampaignsUpdateRequestBody | Specify the campaign parameters to be updated.

            try
            {
                // Update Campaign
                CampaignsUpdateResponseBody result = apiInstance.UpdateCampaign(campaignId, campaignsUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Campaign
    ApiResponse<CampaignsUpdateResponseBody> response = apiInstance.UpdateCampaignWithHttpInfo(campaignId, campaignsUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CampaignsApi.UpdateCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **campaignsUpdateRequestBody** | [**CampaignsUpdateRequestBody**](CampaignsUpdateRequestBody.md) | Specify the campaign parameters to be updated. |  |

### Return type

[**CampaignsUpdateResponseBody**](CampaignsUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the campaign object if the update succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

