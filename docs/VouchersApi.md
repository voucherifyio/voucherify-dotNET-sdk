# Voucherify.Api.VouchersApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateVoucher**](VouchersApi.md#createvoucher) | **POST** /v1/vouchers/{code} | Create Voucher |
| [**DeleteVoucher**](VouchersApi.md#deletevoucher) | **DELETE** /v1/vouchers/{code} | Delete Voucher |
| [**DisableVoucher**](VouchersApi.md#disablevoucher) | **POST** /v1/vouchers/{code}/disable | Disable Voucher |
| [**EnableVoucher**](VouchersApi.md#enablevoucher) | **POST** /v1/vouchers/{code}/enable | Enable Voucher |
| [**ExportVoucherTransactions**](VouchersApi.md#exportvouchertransactions) | **POST** /v1/vouchers/{code}/transactions/export | Export Voucher Transactions |
| [**GenerateRandomCode**](VouchersApi.md#generaterandomcode) | **POST** /v1/vouchers | Generate Random Code |
| [**GetVoucher**](VouchersApi.md#getvoucher) | **GET** /v1/vouchers/{code} | Get Voucher |
| [**ImportVouchers**](VouchersApi.md#importvouchers) | **POST** /v1/vouchers/import | Import Vouchers |
| [**ImportVouchersUsingCsv**](VouchersApi.md#importvouchersusingcsv) | **POST** /v1/vouchers/importCSV | Import Vouchers using CSV |
| [**ListVoucherTransactions**](VouchersApi.md#listvouchertransactions) | **GET** /v1/vouchers/{code}/transactions | List Voucher Transactions |
| [**ListVouchers**](VouchersApi.md#listvouchers) | **GET** /v1/vouchers | List Vouchers |
| [**ReleaseValidationSession**](VouchersApi.md#releasevalidationsession) | **DELETE** /v1/vouchers/{code}/sessions/{sessionKey} | Release Validation Session |
| [**UpdateVoucher**](VouchersApi.md#updatevoucher) | **PUT** /v1/vouchers/{code} | Update Voucher |
| [**UpdateVoucherBalance**](VouchersApi.md#updatevoucherbalance) | **POST** /v1/vouchers/{code}/balance | Adjust Voucher Balance |
| [**UpdateVouchersInBulk**](VouchersApi.md#updatevouchersinbulk) | **POST** /v1/vouchers/bulk/async | Update Vouchers in Bulk |
| [**UpdateVouchersMetadataInBulk**](VouchersApi.md#updatevouchersmetadatainbulk) | **POST** /v1/vouchers/metadata/async | Update Vouchers&#39; Metadata in Bulk |

<a id="createvoucher"></a>
# **CreateVoucher**
> VouchersCreateResponseBody CreateVoucher (string code, VouchersCreateWithSpecificCodeRequestBody vouchersCreateWithSpecificCodeRequestBody = null)

Create Voucher

Create a standalone voucher. You can choose to create a GIFT_VOUCHER, a DISCOUNT_VOUCHER, or a LOYALTY_CARD. The code path parameter can use all letters of the English alphabet, Arabic numerals and special characters. When you create a new voucher, you can specify a type to create it. Creating a new voucher will create a new standalone voucher if no campaign name or campaign_id is provided. However, if an ID or name of a campaign with the type set to STANDALONE is provided, the voucher will be added to such campaign. In the case of the loyalty card, a campaign name or ID is required. 🚧 Standalone Vouchers and Campaigns In version [v20241004](https://support.voucherify.io/article/23-whats-new-in-voucherify#v20241004), standalone vouchers created through the Voucherify dashboard create a campaign for that voucher. However, vouchers created through the API do not have a campaign attached, so the values for campaign and campaign_id are null. Voucherify developers work on adding an optional feature to create a standalone voucher campaign through the API. Follow the [Voucherify Release Notes](https://support.voucherify.io/article/23-whats-new-in-voucherify#v20241004) for more details about released features.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateVoucherExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A unique **code** that identifies the voucher.
            var vouchersCreateWithSpecificCodeRequestBody = new VouchersCreateWithSpecificCodeRequestBody(); // VouchersCreateWithSpecificCodeRequestBody | Specify the details of the voucher that you would like to create. (optional) 

            try
            {
                // Create Voucher
                VouchersCreateResponseBody result = apiInstance.CreateVoucher(code, vouchersCreateWithSpecificCodeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.CreateVoucher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVoucherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Voucher
    ApiResponse<VouchersCreateResponseBody> response = apiInstance.CreateVoucherWithHttpInfo(code, vouchersCreateWithSpecificCodeRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.CreateVoucherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A unique **code** that identifies the voucher. |  |
| **vouchersCreateWithSpecificCodeRequestBody** | [**VouchersCreateWithSpecificCodeRequestBody**](VouchersCreateWithSpecificCodeRequestBody.md) | Specify the details of the voucher that you would like to create. | [optional]  |

### Return type

[**VouchersCreateResponseBody**](VouchersCreateResponseBody.md)

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

<a id="deletevoucher"></a>
# **DeleteVoucher**
> void DeleteVoucher (string code, bool? force = null)

Delete Voucher

Deletes a voucher. This operation cannot be undone. Additionally, this operation removes any redemptions on the voucher. If the force parameter is set to false or not set at all, the voucher will be moved to the bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteVoucherExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A unique **code** that identifies the voucher.
            var force = true;  // bool? | If this flag is set to true, the voucher will be removed permanently. If it is set to false or not set at all, the voucher will be moved to the bin. Going forward, the user will be able to create another voucher with exactly the same code. (optional) 

            try
            {
                // Delete Voucher
                apiInstance.DeleteVoucher(code, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.DeleteVoucher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVoucherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Voucher
    apiInstance.DeleteVoucherWithHttpInfo(code, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.DeleteVoucherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A unique **code** that identifies the voucher. |  |
| **force** | **bool?** | If this flag is set to true, the voucher will be removed permanently. If it is set to false or not set at all, the voucher will be moved to the bin. Going forward, the user will be able to create another voucher with exactly the same code. | [optional]  |

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

<a id="disablevoucher"></a>
# **DisableVoucher**
> VouchersDisableResponseBody DisableVoucher (string code)

Disable Voucher

There are various times when youll want to manage a vouchers accessibility. This can be done by two API methods for managing the voucher state - *enable* and *disable*.   ___ This method sets the voucher state to **inactive**. The voucher cannot be redeemed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DisableVoucherExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u.

            try
            {
                // Disable Voucher
                VouchersDisableResponseBody result = apiInstance.DisableVoucher(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.DisableVoucher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableVoucherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable Voucher
    ApiResponse<VouchersDisableResponseBody> response = apiInstance.DisableVoucherWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.DisableVoucherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u. |  |

### Return type

[**VouchersDisableResponseBody**](VouchersDisableResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a voucher object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="enablevoucher"></a>
# **EnableVoucher**
> VouchersEnableResponseBody EnableVoucher (string code)

Enable Voucher

There are various times when youll want to manage a vouchers accessibility. This can be done by two API methods for managing the voucher state - *enable* and *disable*.   ___ The method sets the voucher state to **active**. The voucher can be redeemed - only if the redemption occurs after the start date and the voucher is not expired.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class EnableVoucherExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u.

            try
            {
                // Enable Voucher
                VouchersEnableResponseBody result = apiInstance.EnableVoucher(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.EnableVoucher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableVoucherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Voucher
    ApiResponse<VouchersEnableResponseBody> response = apiInstance.EnableVoucherWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.EnableVoucherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u. |  |

### Return type

[**VouchersEnableResponseBody**](VouchersEnableResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a voucher object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportvouchertransactions"></a>
# **ExportVoucherTransactions**
> VouchersTransactionsExportCreateResponseBody ExportVoucherTransactions (string code, VouchersTransactionsExportCreateRequestBody vouchersTransactionsExportCreateRequestBody = null)

Export Voucher Transactions

Export transactions that are associated with credit movements on a gift card or loyalty card.   

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExportVoucherTransactionsExample
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

            var apiInstance = new VouchersApi(config);
            var code = GIFT-CARD-1;  // string | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u.
            var vouchersTransactionsExportCreateRequestBody = new VouchersTransactionsExportCreateRequestBody(); // VouchersTransactionsExportCreateRequestBody | Specify the parameters for the camapign transaction export. (optional) 

            try
            {
                // Export Voucher Transactions
                VouchersTransactionsExportCreateResponseBody result = apiInstance.ExportVoucherTransactions(code, vouchersTransactionsExportCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.ExportVoucherTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportVoucherTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Voucher Transactions
    ApiResponse<VouchersTransactionsExportCreateResponseBody> response = apiInstance.ExportVoucherTransactionsWithHttpInfo(code, vouchersTransactionsExportCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.ExportVoucherTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u. |  |
| **vouchersTransactionsExportCreateRequestBody** | [**VouchersTransactionsExportCreateRequestBody**](VouchersTransactionsExportCreateRequestBody.md) | Specify the parameters for the camapign transaction export. | [optional]  |

### Return type

[**VouchersTransactionsExportCreateResponseBody**](VouchersTransactionsExportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an export object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generaterandomcode"></a>
# **GenerateRandomCode**
> VouchersCreateResponseBody GenerateRandomCode (VouchersCreateRequestBody vouchersCreateRequestBody = null)

Generate Random Code

Create a standalone voucher. You can choose to create a GIFT_VOUCHER, a DISCOUNT_VOUCHER, or a LOYALTY_CARD.  When you create a new voucher, you can specify a type to create it. Creating a new voucher will create a new standalone voucher if no campaign name or campaign_id is provided. However, if an ID or name of a campaign with the type set to STANDALONE is provided, the voucher will be added to such campaign. In case of the loyalty card, a campaign name is required. You can optionally use the code parameter to define a specific code or the code_config parameter to design rules for Voucherify API to create a random code. If neither of the two parameters are passed, then a random code is generated by the Voucherify API. This method will return an error when trying to create a voucher that already exists. 🚧 Standalone Vouchers and Campaigns In version [v20241004](https://support.voucherify.io/article/23-whats-new-in-voucherify#v20241004), standalone vouchers created through the Voucherify dashboard create a campaign for that voucher. However, vouchers created through the API do not have a campaign attached, so the values for campaign and campaign_id are null. Voucherify developers work on adding an optional feature to create a standalone voucher campaign through the API. Follow the [Voucherify Release Notes](https://support.voucherify.io/article/23-whats-new-in-voucherify#v20241004) for more details about released features.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GenerateRandomCodeExample
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

            var apiInstance = new VouchersApi(config);
            var vouchersCreateRequestBody = new VouchersCreateRequestBody(); // VouchersCreateRequestBody | Specify the details of the voucher that you would like to create. (optional) 

            try
            {
                // Generate Random Code
                VouchersCreateResponseBody result = apiInstance.GenerateRandomCode(vouchersCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.GenerateRandomCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateRandomCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate Random Code
    ApiResponse<VouchersCreateResponseBody> response = apiInstance.GenerateRandomCodeWithHttpInfo(vouchersCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.GenerateRandomCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vouchersCreateRequestBody** | [**VouchersCreateRequestBody**](VouchersCreateRequestBody.md) | Specify the details of the voucher that you would like to create. | [optional]  |

### Return type

[**VouchersCreateResponseBody**](VouchersCreateResponseBody.md)

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

<a id="getvoucher"></a>
# **GetVoucher**
> VouchersGetResponseBody GetVoucher (string code)

Get Voucher

Retrieves the voucher with the given code or unique Voucherify ID. You can either pass the voucher ID which was assigned by Voucherify, e.g., v_7HxHkf4VAkMuc8u4lZs78lyRwhRze5UE, or the code of the voucher as the path parameter value, e.g., 7fjWdr.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetVoucherExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A unique **code** that identifies the voucher.

            try
            {
                // Get Voucher
                VouchersGetResponseBody result = apiInstance.GetVoucher(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.GetVoucher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVoucherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Voucher
    ApiResponse<VouchersGetResponseBody> response = apiInstance.GetVoucherWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.GetVoucherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A unique **code** that identifies the voucher. |  |

### Return type

[**VouchersGetResponseBody**](VouchersGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a voucher object if a valid identifier was provided.   Additionally, the response returns validation rules related to the voucher object. They can be inherited from a campaign. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importvouchers"></a>
# **ImportVouchers**
> VouchersImportCreateResponseBody ImportVouchers (List<VouchersImportCreateItemRequestBody> vouchersImportCreateItemRequestBody)

Import Vouchers

Import standalone vouchers and gift cards into the repository.  📘 Important notes  - **Start and expiration dates** need to be provided in compliance with the ISO 8601 norms. For example, 2020-03-11T09:00:00.000Z.  - Custom code attributes (not supported by-default) need to be added as code **metadata**.  - You **cannot import the same codes** to a single Voucherify Project. Any parameters not provided in the payload will be left blank or null. For both **standalone discount vouchers and gift cards**, you can import the following fields:   - code - category - active - type - start_date - expiration_date - redemption.quantity - additional_info - metadata For **gift cards**, you can also import the following field: - gift.amount For **discount vouchers**, you can import the discount object. The object will slightly vary depending on the type of discount. Each discount type **requires** the type to be defined in the import.   Fields other than the ones listed above wont be imported. Even if provided, they will be silently skipped. This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this API request. 🚧 Standalone Vouchers and Campaigns In version [v20241004](https://support.voucherify.io/article/23-whats-new-in-voucherify#v20241004), standalone vouchers created through the Voucherify dashboard create a campaign for that voucher. However, vouchers imported through the dashboard in the Vouchers section or through the API do not have a campaign attached, so the values for campaign and campaign_id are null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportVouchersExample
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

            var apiInstance = new VouchersApi(config);
            var vouchersImportCreateItemRequestBody = new List<VouchersImportCreateItemRequestBody>(); // List<VouchersImportCreateItemRequestBody> | The request body is an array of objects. Each object contains details about a specific voucher. 

            try
            {
                // Import Vouchers
                VouchersImportCreateResponseBody result = apiInstance.ImportVouchers(vouchersImportCreateItemRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.ImportVouchers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportVouchersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Vouchers
    ApiResponse<VouchersImportCreateResponseBody> response = apiInstance.ImportVouchersWithHttpInfo(vouchersImportCreateItemRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.ImportVouchersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vouchersImportCreateItemRequestBody** | [**List&lt;VouchersImportCreateItemRequestBody&gt;**](VouchersImportCreateItemRequestBody.md) | The request body is an array of objects. Each object contains details about a specific voucher.  |  |

### Return type

[**VouchersImportCreateResponseBody**](VouchersImportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Returns ID of the scheduled async action. The response informs you that your request has been accepted and vouchers will be added to the repository asynchronously. To check the import status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using the &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importvouchersusingcsv"></a>
# **ImportVouchersUsingCsv**
> VouchersImportCsvCreateResponseBody ImportVouchersUsingCsv (System.IO.Stream file = null)

Import Vouchers using CSV

Import standalone vouchers into the repository using a CSV file. The CSV file has to include headers in the first line. All properties listed in the file headers that cannot be mapped to standard voucher fields will be added to the metadata object.   You can find an example CSV file [here](https://support.voucherify.io/article/45-import-codes-and-share-them-digitally#coupons). ___  📘 Standard voucher fields mapping  - Go to the import vouchers endpoint to see all standard CSV fields description (body params section).  - Supported CSV file headers: Code,Voucher Type,Value,Discount Type,Category,Start Date,Expiration Date,Redemption Limit,Redeemed Quantity, Redeemed Amount,Active,Additional Info,Custom Metadata Property Name - **Start and expiration dates** need to be provided in compliance with the ISO 8601 norms. For example, 2020-03-11T09:00:00.000Z.       - YYYY-MM-DD     - YYYY-MM-DDTHH     - YYYY-MM-DDTHH:mm     - YYYY-MM-DDTHH:mm:ss     - YYYY-MM-DDTHH:mm:ssZ     - YYYY-MM-DDTHH:mm:ssZ     - YYYY-MM-DDTHH:mm:ss.SSSZ  - Custom code attributes (not supported by-default) need to be added as code **metadata**.  - You **cannot import the same codes** to a single Voucherify Project.  📘 Categories  In the structure representing your data, you can define a category that the voucher belongs to. You can later use the category of a voucher to group and search by specific criteria in the Dashboard and using the List Vouchers endpoint. This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this API request. 🚧 Standalone Vouchers and Campaigns In version [v20241004](https://support.voucherify.io/article/23-whats-new-in-voucherify#v20241004), standalone vouchers created through the Voucherify dashboard create a campaign for that voucher. However, vouchers imported through the dashboard in the Vouchers section or through the API do not have a campaign attached, so the values for campaign and campaign_id are null.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportVouchersUsingCsvExample
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

            var apiInstance = new VouchersApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File path. (optional) 

            try
            {
                // Import Vouchers using CSV
                VouchersImportCsvCreateResponseBody result = apiInstance.ImportVouchersUsingCsv(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.ImportVouchersUsingCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportVouchersUsingCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Vouchers using CSV
    ApiResponse<VouchersImportCsvCreateResponseBody> response = apiInstance.ImportVouchersUsingCsvWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.ImportVouchersUsingCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | File path. | [optional]  |

### Return type

[**VouchersImportCsvCreateResponseBody**](VouchersImportCsvCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Returns ID of the scheduled async action. The response informs you that your request has been accepted and vouchers will be added to the repository asynchronously. To check the import status and result, copy the &#x60;async_action_id&#x60; from the **response** and pass it using the &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listvouchertransactions"></a>
# **ListVoucherTransactions**
> VouchersTransactionsListResponseBody ListVoucherTransactions (string code, int? limit = null, ParameterOrderListTransactions? order = null, string startingAfterId = null)

List Voucher Transactions

List transactions that are associated with credit movements on a gift card or loyalty card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListVoucherTransactionsExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListTransactions) "id";  // ParameterOrderListTransactions? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. (optional) 

            try
            {
                // List Voucher Transactions
                VouchersTransactionsListResponseBody result = apiInstance.ListVoucherTransactions(code, limit, order, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.ListVoucherTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListVoucherTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Voucher Transactions
    ApiResponse<VouchersTransactionsListResponseBody> response = apiInstance.ListVoucherTransactionsWithHttpInfo(code, limit, order, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.ListVoucherTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListTransactions?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. | [optional]  |

### Return type

[**VouchersTransactionsListResponseBody**](VouchersTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of transaction objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listvouchers"></a>
# **ListVouchers**
> VouchersListResponseBody ListVouchers (int? limit = null, int? page = null, string category = null, string campaignId = null, string customer = null, string campaign = null, ParameterCreatedBeforeAfter createdAt = null, ParameterUpdatedBeforeAfter updatedAt = null, ParameterOrderVouchers? order = null, string code = null, List<string> ids = null)

List Vouchers

Returns a list of vouchers. By default, the vouchers are returned sorted by creation date, with the most recent vouchers appearing first. A maximum of 100 vouchers are returned in the response. When you get a list of vouchers, you can optionally specify query parameters to customize the number of vouchers returned per call using limit, which page of vouchers to return using page, sort the vouchers using the order query parameter and more. This method will return an error when trying to return a limit of more than 100 vouchers. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListVouchersExample
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

            var apiInstance = new VouchersApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1, the highest value is 99. (optional) 
            var category = "category_example";  // string | Limit search results to vouchers within the specified category. (optional) 
            var campaignId = "campaignId_example";  // string | Limit search results to vouchers within the specified campaign (optional) 
            var customer = "customer_example";  // string | A tracking identifier of a customer who is the holder of the vouchers. It can be an id generated by Voucherify or the source_id. Remember to use the proper URL escape codes if the source_id contains special characters. (optional) 
            var campaign = "campaign_example";  // string | A unique campaign name, identifies the parent campaign. (optional) 
            var createdAt = new ParameterCreatedBeforeAfter(); // ParameterCreatedBeforeAfter | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z (optional) 
            var updatedAt = new ParameterUpdatedBeforeAfter(); // ParameterUpdatedBeforeAfter | A filter on the list based on the object updated_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [updated_at][before] 2017-09-08T13:52:18.227Z (optional) 
            var order = (ParameterOrderVouchers) "created_at";  // ParameterOrderVouchers? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var code = "code_example";  // string |  (optional) 
            var ids = new List<string>(); // List<string> |  (optional) 

            try
            {
                // List Vouchers
                VouchersListResponseBody result = apiInstance.ListVouchers(limit, page, category, campaignId, customer, campaign, createdAt, updatedAt, order, code, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.ListVouchers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListVouchersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Vouchers
    ApiResponse<VouchersListResponseBody> response = apiInstance.ListVouchersWithHttpInfo(limit, page, category, campaignId, customer, campaign, createdAt, updatedAt, order, code, ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.ListVouchersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1, the highest value is 99. | [optional]  |
| **category** | **string** | Limit search results to vouchers within the specified category. | [optional]  |
| **campaignId** | **string** | Limit search results to vouchers within the specified campaign | [optional]  |
| **customer** | **string** | A tracking identifier of a customer who is the holder of the vouchers. It can be an id generated by Voucherify or the source_id. Remember to use the proper URL escape codes if the source_id contains special characters. | [optional]  |
| **campaign** | **string** | A unique campaign name, identifies the parent campaign. | [optional]  |
| **createdAt** | [**ParameterCreatedBeforeAfter**](ParameterCreatedBeforeAfter.md) | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z | [optional]  |
| **updatedAt** | [**ParameterUpdatedBeforeAfter**](ParameterUpdatedBeforeAfter.md) | A filter on the list based on the object updated_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [updated_at][before] 2017-09-08T13:52:18.227Z | [optional]  |
| **order** | **ParameterOrderVouchers?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **code** | **string** |  | [optional]  |
| **ids** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**VouchersListResponseBody**](VouchersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary that contains an array of vouchers. Each entry in the array is a separate voucher object. If no more vouchers are available (query parameter &#x60;page&#x60; incremented over and above the voucher count), the resulting array will be empty. The result can be narrowed down according to specified (or default) filters. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="releasevalidationsession"></a>
# **ReleaseValidationSession**
> void ReleaseValidationSession (string code, string sessionKey)

Release Validation Session

Manually release a validation session that has been set up for the voucher. This method undos the actions that are explained in our guide on how a validation session was established, you can read more here.   📘 Release Session using Dashboard  You can also use the Validations Manager in the Dashboard to unlock sessions. [Read more](https://support.voucherify.io/article/16-dashboard-sections#validations).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ReleaseValidationSessionExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify.
            var sessionKey = ssn_yQGMTeKBSw8OOuFPwlBEjzGy8d8VA9Ts;  // string | A unique session identifier.

            try
            {
                // Release Validation Session
                apiInstance.ReleaseValidationSession(code, sessionKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.ReleaseValidationSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReleaseValidationSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Release Validation Session
    apiInstance.ReleaseValidationSessionWithHttpInfo(code, sessionKey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.ReleaseValidationSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify. |  |
| **sessionKey** | **string** | A unique session identifier. |  |

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
| **204** | Returns no content if the validation session was released successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatevoucher"></a>
# **UpdateVoucher**
> VouchersUpdateResponseBody UpdateVoucher (string code, VouchersUpdateRequestBody vouchersUpdateRequestBody)

Update Voucher

Updates the specified voucher by setting the values of the parameters passed in the request body. Any parameters not provided in the payload will be left unchanged. Fields other than the ones listed in the request body wont be modified. Even if provided, they will be silently skipped. If you want to change the amount on a gift card or the number of points on a loyalty card, use the Add or remove voucher balance endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateVoucherExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A unique **code** that identifies the voucher.
            var vouchersUpdateRequestBody = new VouchersUpdateRequestBody(); // VouchersUpdateRequestBody | Specify the parameters to be updated.

            try
            {
                // Update Voucher
                VouchersUpdateResponseBody result = apiInstance.UpdateVoucher(code, vouchersUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.UpdateVoucher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVoucherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Voucher
    ApiResponse<VouchersUpdateResponseBody> response = apiInstance.UpdateVoucherWithHttpInfo(code, vouchersUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.UpdateVoucherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A unique **code** that identifies the voucher. |  |
| **vouchersUpdateRequestBody** | [**VouchersUpdateRequestBody**](VouchersUpdateRequestBody.md) | Specify the parameters to be updated. |  |

### Return type

[**VouchersUpdateResponseBody**](VouchersUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the voucher object if the update succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatevoucherbalance"></a>
# **UpdateVoucherBalance**
> VouchersBalanceUpdateResponseBody UpdateVoucherBalance (string code, VouchersBalanceUpdateRequestBody vouchersBalanceUpdateRequestBody)

Adjust Voucher Balance

Add balance to an existing gift card or loyalty card. For loyalty cards, it must be assigned to a holder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateVoucherBalanceExample
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

            var apiInstance = new VouchersApi(config);
            var code = "code_example";  // string | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u.
            var vouchersBalanceUpdateRequestBody = new VouchersBalanceUpdateRequestBody(); // VouchersBalanceUpdateRequestBody | Provide the amount to be added to/subtracted from the voucher.

            try
            {
                // Adjust Voucher Balance
                VouchersBalanceUpdateResponseBody result = apiInstance.UpdateVoucherBalance(code, vouchersBalanceUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.UpdateVoucherBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVoucherBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust Voucher Balance
    ApiResponse<VouchersBalanceUpdateResponseBody> response = apiInstance.UpdateVoucherBalanceWithHttpInfo(code, vouchersBalanceUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.UpdateVoucherBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | A **code** that identifies the voucher or a unique voucher ID assigned by Voucherify, i.e. v_TzD19aeNiqGc9LWciMWknyEZT8IW7u4u. |  |
| **vouchersBalanceUpdateRequestBody** | [**VouchersBalanceUpdateRequestBody**](VouchersBalanceUpdateRequestBody.md) | Provide the amount to be added to/subtracted from the voucher. |  |

### Return type

[**VouchersBalanceUpdateResponseBody**](VouchersBalanceUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a balance object if the operation succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatevouchersinbulk"></a>
# **UpdateVouchersInBulk**
> VouchersUpdateInBulkResponseBody UpdateVouchersInBulk (List<VouchersUpdateInBulkItemRequestBody> vouchersUpdateInBulkItemRequestBody)

Update Vouchers in Bulk

Updates specific metadata parameters for each code, respectively, in one asynchronous operation. The request can include up to **10 MB** of data. Upserts are not supported.  🚧    Currently, only **metadata** updates are supported. The response returns a unique asynchronous action ID. Use this ID in the query paramater of the GET Async Action endpoint to check, e.g.: - The status of your request (in queue, in progress, done, or failed) - Resources that failed to be updated - The report file with details about the update This API request starts a process that affects Voucherify data in bulk. In the case of small jobs (like bulk update), the request is put into a queue and processed when every other bulk request placed in the queue prior to this request is finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateVouchersInBulkExample
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

            var apiInstance = new VouchersApi(config);
            var vouchersUpdateInBulkItemRequestBody = new List<VouchersUpdateInBulkItemRequestBody>(); // List<VouchersUpdateInBulkItemRequestBody> | List the codes to be updated with the metadata key/value pairs for that code.

            try
            {
                // Update Vouchers in Bulk
                VouchersUpdateInBulkResponseBody result = apiInstance.UpdateVouchersInBulk(vouchersUpdateInBulkItemRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.UpdateVouchersInBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVouchersInBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Vouchers in Bulk
    ApiResponse<VouchersUpdateInBulkResponseBody> response = apiInstance.UpdateVouchersInBulkWithHttpInfo(vouchersUpdateInBulkItemRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.UpdateVouchersInBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vouchersUpdateInBulkItemRequestBody** | [**List&lt;VouchersUpdateInBulkItemRequestBody&gt;**](VouchersUpdateInBulkItemRequestBody.md) | List the codes to be updated with the metadata key/value pairs for that code. |  |

### Return type

[**VouchersUpdateInBulkResponseBody**](VouchersUpdateInBulkResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Returns the ID of the scheduled asynchronous action. The response informs you that the request has been accepted and the resources will be updated in the repository asynchronously. To check the status and result, copy the &#x60;async_action_id&#x60; from the response and use it as a query parameter in the [GET Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatevouchersmetadatainbulk"></a>
# **UpdateVouchersMetadataInBulk**
> VouchersMetadataUpdateInBulkResponseBody UpdateVouchersMetadataInBulk (VouchersMetadataUpdateInBulkRequestBody vouchersMetadataUpdateInBulkRequestBody)

Update Vouchers' Metadata in Bulk

Updates metadata parameters for a list of codes. Every resource in the list will receive the metadata defined in the request. The request can include up to **10 MB** of data. Upserts are not supported. The response returns a unique asynchronous action ID. Use this ID in the query paramater of the GET Async Action endpoint to check, e.g.: - The status of your request (in queue, in progress, done, or failed) - Resources that failed to be updated - The report file with details about the update This API request starts a process that affects Voucherify data in bulk. In the case of small jobs (like bulk update), the request is put into a queue and processed when every other bulk request placed in the queue prior to this request is finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateVouchersMetadataInBulkExample
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

            var apiInstance = new VouchersApi(config);
            var vouchersMetadataUpdateInBulkRequestBody = new VouchersMetadataUpdateInBulkRequestBody(); // VouchersMetadataUpdateInBulkRequestBody | List the codes of the vouchers you would like to update with the metadata key/value pairs.

            try
            {
                // Update Vouchers' Metadata in Bulk
                VouchersMetadataUpdateInBulkResponseBody result = apiInstance.UpdateVouchersMetadataInBulk(vouchersMetadataUpdateInBulkRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VouchersApi.UpdateVouchersMetadataInBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVouchersMetadataInBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Vouchers' Metadata in Bulk
    ApiResponse<VouchersMetadataUpdateInBulkResponseBody> response = apiInstance.UpdateVouchersMetadataInBulkWithHttpInfo(vouchersMetadataUpdateInBulkRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VouchersApi.UpdateVouchersMetadataInBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vouchersMetadataUpdateInBulkRequestBody** | [**VouchersMetadataUpdateInBulkRequestBody**](VouchersMetadataUpdateInBulkRequestBody.md) | List the codes of the vouchers you would like to update with the metadata key/value pairs. |  |

### Return type

[**VouchersMetadataUpdateInBulkResponseBody**](VouchersMetadataUpdateInBulkResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Returns the ID of the scheduled asynchronous action. The response informs you that the request has been accepted and the resources will be updated in the repository asynchronously. To check the status and result, copy the &#x60;async_action_id&#x60; from the response and use it as a query parameter in the [GET Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

