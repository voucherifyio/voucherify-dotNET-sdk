# Voucherify.Api.ProductCollectionsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateProductCollection**](ProductCollectionsApi.md#createproductcollection) | **POST** /v1/product-collections | Create Product Collection |
| [**DeleteProductCollection**](ProductCollectionsApi.md#deleteproductcollection) | **DELETE** /v1/product-collections/{productCollectionId} | Delete Product Collection |
| [**GetProductCollection**](ProductCollectionsApi.md#getproductcollection) | **GET** /v1/product-collections/{productCollectionId} | Get Product Collection |
| [**ListProductCollections**](ProductCollectionsApi.md#listproductcollections) | **GET** /v1/product-collections | List Product Collections |
| [**ListProductsInCollection**](ProductCollectionsApi.md#listproductsincollection) | **GET** /v1/product-collections/{productCollectionId}/products | List Products in Collection |

<a id="createproductcollection"></a>
# **CreateProductCollection**
> ProductCollectionsCreateResponseBody CreateProductCollection (ProductCollectionsCreateRequestBody productCollectionsCreateRequestBody = null)

Create Product Collection

This method creates a new product collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateProductCollectionExample
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

            var apiInstance = new ProductCollectionsApi(config);
            var productCollectionsCreateRequestBody = new ProductCollectionsCreateRequestBody(); // ProductCollectionsCreateRequestBody |  (optional) 

            try
            {
                // Create Product Collection
                ProductCollectionsCreateResponseBody result = apiInstance.CreateProductCollection(productCollectionsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCollectionsApi.CreateProductCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Product Collection
    ApiResponse<ProductCollectionsCreateResponseBody> response = apiInstance.CreateProductCollectionWithHttpInfo(productCollectionsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCollectionsApi.CreateProductCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productCollectionsCreateRequestBody** | [**ProductCollectionsCreateRequestBody**](ProductCollectionsCreateRequestBody.md) |  | [optional]  |

### Return type

[**ProductCollectionsCreateResponseBody**](ProductCollectionsCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns information about the newly created collection, as well as an array containing the products. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteproductcollection"></a>
# **DeleteProductCollection**
> void DeleteProductCollection (string productCollectionId)

Delete Product Collection

This method deletes a product collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteProductCollectionExample
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

            var apiInstance = new ProductCollectionsApi(config);
            var productCollectionId = "productCollectionId_example";  // string | A unique product collection ID.

            try
            {
                // Delete Product Collection
                apiInstance.DeleteProductCollection(productCollectionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCollectionsApi.DeleteProductCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProductCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Product Collection
    apiInstance.DeleteProductCollectionWithHttpInfo(productCollectionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCollectionsApi.DeleteProductCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productCollectionId** | **string** | A unique product collection ID. |  |

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

<a id="getproductcollection"></a>
# **GetProductCollection**
> ProductCollectionsGetResponseBody GetProductCollection (string productCollectionId)

Get Product Collection

Retrieves the product collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetProductCollectionExample
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

            var apiInstance = new ProductCollectionsApi(config);
            var productCollectionId = "productCollectionId_example";  // string | A unique product collection ID.

            try
            {
                // Get Product Collection
                ProductCollectionsGetResponseBody result = apiInstance.GetProductCollection(productCollectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCollectionsApi.GetProductCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Product Collection
    ApiResponse<ProductCollectionsGetResponseBody> response = apiInstance.GetProductCollectionWithHttpInfo(productCollectionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCollectionsApi.GetProductCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productCollectionId** | **string** | A unique product collection ID. |  |

### Return type

[**ProductCollectionsGetResponseBody**](ProductCollectionsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a product collection object if a valid identifier was provided in the path. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproductcollections"></a>
# **ListProductCollections**
> ProductCollectionsListResponseBody ListProductCollections (int? limit = null, int? page = null, ParameterOrder? order = null)

List Product Collections

This method returns a list of product collections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProductCollectionsExample
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

            var apiInstance = new ProductCollectionsApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrder) "created_at";  // ParameterOrder? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Product Collections
                ProductCollectionsListResponseBody result = apiInstance.ListProductCollections(limit, page, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCollectionsApi.ListProductCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Product Collections
    ApiResponse<ProductCollectionsListResponseBody> response = apiInstance.ListProductCollectionsWithHttpInfo(limit, page, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCollectionsApi.ListProductCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrder?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**ProductCollectionsListResponseBody**](ProductCollectionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary containing a list of product collections and details about each product collection. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproductsincollection"></a>
# **ListProductsInCollection**
> ProductCollectionsProductsListResponseBody ListProductsInCollection (string productCollectionId, int? limit = null, int? page = null, ParameterOrder? order = null, DateTimeOffset? startingAfter = null)

List Products in Collection

Retrieves list of products from a product collection; works for both dynamic and static product collections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProductsInCollectionExample
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

            var apiInstance = new ProductCollectionsApi(config);
            var productCollectionId = "productCollectionId_example";  // string | Unique product collection ID.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrder) "created_at";  // ParameterOrder? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfter = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time to use in starting_after cursor to get more data. Represented in ISO 8601 format. (optional) 

            try
            {
                // List Products in Collection
                ProductCollectionsProductsListResponseBody result = apiInstance.ListProductsInCollection(productCollectionId, limit, page, order, startingAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCollectionsApi.ListProductsInCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductsInCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Products in Collection
    ApiResponse<ProductCollectionsProductsListResponseBody> response = apiInstance.ListProductsInCollectionWithHttpInfo(productCollectionId, limit, page, order, startingAfter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCollectionsApi.ListProductsInCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productCollectionId** | **string** | Unique product collection ID. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrder?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfter** | **DateTimeOffset?** | Timestamp representing the date and time to use in starting_after cursor to get more data. Represented in ISO 8601 format. | [optional]  |

### Return type

[**ProductCollectionsProductsListResponseBody**](ProductCollectionsProductsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of products and/or SKUs grouped in the collection with each product&#39;s/SKU&#39;s details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

