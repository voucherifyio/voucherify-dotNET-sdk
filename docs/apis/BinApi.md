# Voucherify.Api.BinApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteBinEntry**](BinApi.md#deletebinentry) | **DELETE** /v1/trash-bin/{binEntryId} | Delete Bin Entry |
| [**ListBinEntries**](BinApi.md#listbinentries) | **GET** /v1/trash-bin | List Bin Entries |

<a id="deletebinentry"></a>
# **DeleteBinEntry**
> void DeleteBinEntry (string binEntryId)

Delete Bin Entry

Deletes permanently a bin entry with a given ID.The following resources can be moved to the bin and permanently deleted: - campaigns - vouchers - products - SKUs To use this endpoint and delete a given resource type, you must have the following permissions: - vouchers.delete to delete a voucher, - campaigns.delete to delete a campaign, - products.delete to delete a product or SKU.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteBinEntryExample
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

            var apiInstance = new BinApi(config);
            var binEntryId = "binEntryId_example";  // string | Provide the unique identifier of the bin entry.

            try
            {
                // Delete Bin Entry
                apiInstance.DeleteBinEntry(binEntryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BinApi.DeleteBinEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBinEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Bin Entry
    apiInstance.DeleteBinEntryWithHttpInfo(binEntryId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BinApi.DeleteBinEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **binEntryId** | **string** | Provide the unique identifier of the bin entry. |  |

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

<a id="listbinentries"></a>
# **ListBinEntries**
> TrashBinListResponseBody ListBinEntries (int limit = null, ParameterOrderListBin order = null, string startingAfterId = null, ParameterFiltersListBin filters = null)

List Bin Entries

Retrieves a list of resources moved to the bin. The following resources can be moved to the bin: - campaigns - vouchers - products - SKUs To use this endpoint, you must have the following permissions: - vouchers.read - campaigns.read - products.read

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListBinEntriesExample
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

            var apiInstance = new BinApi(config);
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListBin) "id";  // ParameterOrderListBin | Orders the bin entries according to the bin entry ID. The dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the results starting after a result with the given ID. (optional) 
            var filters = new ParameterFiltersListBin(); // ParameterFiltersListBin | Filters for listing bin entries. (optional) 

            try
            {
                // List Bin Entries
                TrashBinListResponseBody result = apiInstance.ListBinEntries(limit, order, startingAfterId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BinApi.ListBinEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBinEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Bin Entries
    ApiResponse<TrashBinListResponseBody> response = apiInstance.ListBinEntriesWithHttpInfo(limit, order, startingAfterId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BinApi.ListBinEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListBin** | Orders the bin entries according to the bin entry ID. The dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the results starting after a result with the given ID. | [optional]  |
| **filters** | [**ParameterFiltersListBin**](ParameterFiltersListBin.md) | Filters for listing bin entries. | [optional]  |

### Return type

[**TrashBinListResponseBody**](TrashBinListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the list of all the bin entries matching the query parameters. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

