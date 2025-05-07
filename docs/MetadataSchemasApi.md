# Voucherify.Api.MetadataSchemasApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMetadataSchema**](MetadataSchemasApi.md#getmetadataschema) | **GET** /v1/metadata-schemas/{resource} | Get Metadata Schema |
| [**ListMetadataSchemas**](MetadataSchemasApi.md#listmetadataschemas) | **GET** /v1/metadata-schemas | List Metadata Schemas |

<a id="getmetadataschema"></a>
# **GetMetadataSchema**
> MetadataSchemasGetResponseBody GetMetadataSchema (string resource)

Get Metadata Schema

Retrieves a metadata schema per resource type. # Resource types ## Standard You can retrieve metadata schemas for the standard metadata schema definitions listed below. Add one of these types as the resource path parameter. - campaign - customer - earning_rule - loyalty_tier - order - order_item - product - promotion_tier - publication - redemption - reward - voucher ## Custom If you have defined a [custom metadata schema](https://support.voucherify.io/article/99-schema-validation-metadata#add-metadata), provide its name in the resource field to retrieve its details. 📘 Management API If you have Management API enabled, you can also use the Get Metadata Schemas endpoint to retrieve a metadata schema using its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetMetadataSchemaExample
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

            var apiInstance = new MetadataSchemasApi(config);
            var resource = "resource_example";  // string | There is an infinite number of possibilities for retrieving metadata schemas by the resource type because you can define custom metadata schemas.

            try
            {
                // Get Metadata Schema
                MetadataSchemasGetResponseBody result = apiInstance.GetMetadataSchema(resource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataSchemasApi.GetMetadataSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Metadata Schema
    ApiResponse<MetadataSchemasGetResponseBody> response = apiInstance.GetMetadataSchemaWithHttpInfo(resource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataSchemasApi.GetMetadataSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resource** | **string** | There is an infinite number of possibilities for retrieving metadata schemas by the resource type because you can define custom metadata schemas. |  |

### Return type

[**MetadataSchemasGetResponseBody**](MetadataSchemasGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response does not include unknown metadata properties in the response, i.e. those that have been defined outside of the **Project Settings** &gt; **Metadata Schema** definitions. For example, an unknown metadata property can be defined in the campaign manager. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmetadataschemas"></a>
# **ListMetadataSchemas**
> MetadataSchemasListResponseBody ListMetadataSchemas ()

List Metadata Schemas

Retrieve metadata schema definitions. 📘 Management API If you have Management API enabled, you can also use the List Metadata Schemas endpoint to list all metadata schemas.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMetadataSchemasExample
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

            var apiInstance = new MetadataSchemasApi(config);

            try
            {
                // List Metadata Schemas
                MetadataSchemasListResponseBody result = apiInstance.ListMetadataSchemas();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataSchemasApi.ListMetadataSchemas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMetadataSchemasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Metadata Schemas
    ApiResponse<MetadataSchemasListResponseBody> response = apiInstance.ListMetadataSchemasWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataSchemasApi.ListMetadataSchemasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MetadataSchemasListResponseBody**](MetadataSchemasListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an array of metadata schema definitions. The response does not include unknown metadata properties in the response, i.e. those that have been defined outside of the **Project Settings** &gt; **Metadata Schema** definitions. For example, an unknown metadata property can be defined in the campaign manager while creating a campaign. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

