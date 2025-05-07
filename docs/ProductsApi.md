# Voucherify.Api.ProductsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateProduct**](ProductsApi.md#createproduct) | **POST** /v1/products | Create Product |
| [**CreateSku**](ProductsApi.md#createsku) | **POST** /v1/products/{productId}/skus | Create SKU |
| [**DeleteProduct**](ProductsApi.md#deleteproduct) | **DELETE** /v1/products/{productId} | Delete Product |
| [**DeleteSku**](ProductsApi.md#deletesku) | **DELETE** /v1/products/{productId}/skus/{skuId} | Delete SKU |
| [**GetProduct**](ProductsApi.md#getproduct) | **GET** /v1/products/{productId} | Get Product |
| [**GetSku**](ProductsApi.md#getsku) | **GET** /v1/skus/{skuId} | Get SKU |
| [**ImportProductsUsingCsv**](ProductsApi.md#importproductsusingcsv) | **POST** /v1/products/importCSV | Import Products using CSV |
| [**ImportSkusUsingCsv**](ProductsApi.md#importskususingcsv) | **POST** /v1/skus/importCSV | Import SKUs using CSV |
| [**ListProducts**](ProductsApi.md#listproducts) | **GET** /v1/products | List Products |
| [**ListSkusInProduct**](ProductsApi.md#listskusinproduct) | **GET** /v1/products/{productId}/skus | List SKUs in Product |
| [**UpdateProduct**](ProductsApi.md#updateproduct) | **PUT** /v1/products/{productId} | Update Product |
| [**UpdateProductsInBulk**](ProductsApi.md#updateproductsinbulk) | **POST** /v1/products/bulk/async | Update Products in Bulk |
| [**UpdateProductsMetadataInBulk**](ProductsApi.md#updateproductsmetadatainbulk) | **POST** /v1/products/metadata/async | Update Products&#39; Metadata in Bulk |
| [**UpdateSku**](ProductsApi.md#updatesku) | **PUT** /v1/products/{productId}/skus/{skuId} | Update SKU |

<a id="createproduct"></a>
# **CreateProduct**
> ProductsCreateResponseBody CreateProduct (ProductsCreateRequestBody productsCreateRequestBody = null)

Create Product

Creates a product object.  📘 Upsert Mode  If you pass an id or a source_id that already exists in the product database, Voucherify will return a related product object with updated fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateProductExample
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

            var apiInstance = new ProductsApi(config);
            var productsCreateRequestBody = new ProductsCreateRequestBody(); // ProductsCreateRequestBody | Specify the product parameters. (optional) 

            try
            {
                // Create Product
                ProductsCreateResponseBody result = apiInstance.CreateProduct(productsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Product
    ApiResponse<ProductsCreateResponseBody> response = apiInstance.CreateProductWithHttpInfo(productsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.CreateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productsCreateRequestBody** | [**ProductsCreateRequestBody**](ProductsCreateRequestBody.md) | Specify the product parameters. | [optional]  |

### Return type

[**ProductsCreateResponseBody**](ProductsCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a product object if the operation succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsku"></a>
# **CreateSku**
> ProductsSkusCreateResponseBody CreateSku (string productId, ProductsSkusCreateRequestBody productsSkusCreateRequestBody = null)

Create SKU

This method adds product variants to a created product.   📘 Upsert Mode  If you pass an id or a source_id that already exists in the sku database, Voucherify will return a related sku object with updated fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateSkuExample
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

            var apiInstance = new ProductsApi(config);
            var productId = "productId_example";  // string | A Voucherify product ID or product source ID.
            var productsSkusCreateRequestBody = new ProductsSkusCreateRequestBody(); // ProductsSkusCreateRequestBody | Specify the SKU parameters to be created. (optional) 

            try
            {
                // Create SKU
                ProductsSkusCreateResponseBody result = apiInstance.CreateSku(productId, productsSkusCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateSku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create SKU
    ApiResponse<ProductsSkusCreateResponseBody> response = apiInstance.CreateSkuWithHttpInfo(productId, productsSkusCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.CreateSkuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | A Voucherify product ID or product source ID. |  |
| **productsSkusCreateRequestBody** | [**ProductsSkusCreateRequestBody**](ProductsSkusCreateRequestBody.md) | Specify the SKU parameters to be created. | [optional]  |

### Return type

[**ProductsSkusCreateResponseBody**](ProductsSkusCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the created SKU object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteproduct"></a>
# **DeleteProduct**
> void DeleteProduct (string productId, bool? force = null)

Delete Product

Deletes a product and all related SKUs. This operation cannot be undone.  If the force parameter is set to false or not set at all, the product and all related SKUs will be moved to the bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteProductExample
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

            var apiInstance = new ProductsApi(config);
            var productId = "productId_example";  // string | A Voucherify product ID or source ID.
            var force = true;  // bool? | If this flag is set to true, the product and all related SKUs will be removed permanently. If it is set to false or not set at all, the product and all related SKUs will be moved to the bin. Going forward, the user will be able to create another product with exactly the same source_id. (optional) 

            try
            {
                // Delete Product
                apiInstance.DeleteProduct(productId, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Product
    apiInstance.DeleteProductWithHttpInfo(productId, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.DeleteProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | A Voucherify product ID or source ID. |  |
| **force** | **bool?** | If this flag is set to true, the product and all related SKUs will be removed permanently. If it is set to false or not set at all, the product and all related SKUs will be moved to the bin. Going forward, the user will be able to create another product with exactly the same source_id. | [optional]  |

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

<a id="deletesku"></a>
# **DeleteSku**
> void DeleteSku (string productId, string skuId, bool? force = null)

Delete SKU

Deletes a product SKU. This operation cannot be undone.  If the force parameter is set to false or not set at all, the SKU will be moved to the bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteSkuExample
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

            var apiInstance = new ProductsApi(config);
            var productId = "productId_example";  // string | A unique Voucherify product ID or product source ID.
            var skuId = "skuId_example";  // string | A Voucherify SKU ID or SKU source ID.
            var force = true;  // bool? | If this flag is set to true, the SKU will be removed permanently. If it is set to false or not set at all, the SKU will be moved to the bin. Going forward, the user will be able to create another SKU with exactly the same source_id. (optional) 

            try
            {
                // Delete SKU
                apiInstance.DeleteSku(productId, skuId, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteSku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SKU
    apiInstance.DeleteSkuWithHttpInfo(productId, skuId, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.DeleteSkuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | A unique Voucherify product ID or product source ID. |  |
| **skuId** | **string** | A Voucherify SKU ID or SKU source ID. |  |
| **force** | **bool?** | If this flag is set to true, the SKU will be removed permanently. If it is set to false or not set at all, the SKU will be moved to the bin. Going forward, the user will be able to create another SKU with exactly the same source_id. | [optional]  |

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

<a id="getproduct"></a>
# **GetProduct**
> ProductsGetResponseBody GetProduct (string productId)

Get Product

Retrieve product details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetProductExample
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

            var apiInstance = new ProductsApi(config);
            var productId = "productId_example";  // string | A Voucherify product ID or source ID.

            try
            {
                // Get Product
                ProductsGetResponseBody result = apiInstance.GetProduct(productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Product
    ApiResponse<ProductsGetResponseBody> response = apiInstance.GetProductWithHttpInfo(productId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.GetProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | A Voucherify product ID or source ID. |  |

### Return type

[**ProductsGetResponseBody**](ProductsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a product object if a valid identifier was provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsku"></a>
# **GetSku**
> SkusGetResponseBody GetSku (string skuId)

Get SKU

Retrieve details of a SKU.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetSkuExample
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

            var apiInstance = new ProductsApi(config);
            var skuId = "skuId_example";  // string | A Voucherify SKU identifier or SKU source ID.

            try
            {
                // Get SKU
                SkusGetResponseBody result = apiInstance.GetSku(skuId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetSku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SKU
    ApiResponse<SkusGetResponseBody> response = apiInstance.GetSkuWithHttpInfo(skuId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.GetSkuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skuId** | **string** | A Voucherify SKU identifier or SKU source ID. |  |

### Return type

[**SkusGetResponseBody**](SkusGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns requested SKU object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importproductsusingcsv"></a>
# **ImportProductsUsingCsv**
> ProductsImportCsvCreateResponseBody ImportProductsUsingCsv (System.IO.Stream file = null)

Import Products using CSV

Import products into the repository using a CSV file.   This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this API request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportProductsUsingCsvExample
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

            var apiInstance = new ProductsApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File path. (optional) 

            try
            {
                // Import Products using CSV
                ProductsImportCsvCreateResponseBody result = apiInstance.ImportProductsUsingCsv(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ImportProductsUsingCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportProductsUsingCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Products using CSV
    ApiResponse<ProductsImportCsvCreateResponseBody> response = apiInstance.ImportProductsUsingCsvWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.ImportProductsUsingCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | File path. | [optional]  |

### Return type

[**ProductsImportCsvCreateResponseBody**](ProductsImportCsvCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns ID of the scheduled async action. The response informs you that your request has been accepted and products will be added to the repository asynchronously. To check the import status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using the &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importskususingcsv"></a>
# **ImportSkusUsingCsv**
> SkusImportCsvCreateResponseBody ImportSkusUsingCsv (System.IO.Stream file = null)

Import SKUs using CSV

Import SKUs into the repository using a CSV file. The CSV file has to include headers in the first line. All properties which cannot be mapped to standard SKU fields will be added to the metadata object. You can find an example template [here](https://s3.amazonaws.com/helpscout.net/docs/assets/5902f1c12c7d3a057f88a36d/attachments/627b98d08c9b585083488a4c/Import_SKUS_template.csv).  This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this API request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportSkusUsingCsvExample
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

            var apiInstance = new ProductsApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File path. (optional) 

            try
            {
                // Import SKUs using CSV
                SkusImportCsvCreateResponseBody result = apiInstance.ImportSkusUsingCsv(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ImportSkusUsingCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportSkusUsingCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import SKUs using CSV
    ApiResponse<SkusImportCsvCreateResponseBody> response = apiInstance.ImportSkusUsingCsvWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.ImportSkusUsingCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | File path. | [optional]  |

### Return type

[**SkusImportCsvCreateResponseBody**](SkusImportCsvCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns ID of the scheduled async action. The response informs you that your request has been accepted and SKUs will be added to the repository asynchronously. To check the import status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using the &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listproducts"></a>
# **ListProducts**
> ProductsListResponseBody ListProducts (int? limit = null, int? page = null, ParameterOrder? order = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)

List Products

Retrieve a list of products.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProductsExample
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

            var apiInstance = new ProductsApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrder) "created_at";  // ParameterOrder? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. (optional) 
            var endDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. (optional) 

            try
            {
                // List Products
                ProductsListResponseBody result = apiInstance.ListProducts(limit, page, order, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ListProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Products
    ApiResponse<ProductsListResponseBody> response = apiInstance.ListProductsWithHttpInfo(limit, page, order, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.ListProductsWithHttpInfo: " + e.Message);
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
| **startDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. | [optional]  |
| **endDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. | [optional]  |

### Return type

[**ProductsListResponseBody**](ProductsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with product objects. The products are returned sorted by creation date by default, with the most recent products appearing last, unless you specify another sequence using the &#x60;order&#x60; query parameter. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listskusinproduct"></a>
# **ListSkusInProduct**
> ProductsSkusListResponseBody ListSkusInProduct (string productId, int? limit = null, int? page = null, ParameterOrder? order = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)

List SKUs in Product

Retrieve all SKUs for a given product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListSkusInProductExample
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

            var apiInstance = new ProductsApi(config);
            var productId = "productId_example";  // string | A Voucherify product ID or product source ID.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrder) "created_at";  // ParameterOrder? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. (optional) 
            var endDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. (optional) 

            try
            {
                // List SKUs in Product
                ProductsSkusListResponseBody result = apiInstance.ListSkusInProduct(productId, limit, page, order, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ListSkusInProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSkusInProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List SKUs in Product
    ApiResponse<ProductsSkusListResponseBody> response = apiInstance.ListSkusInProductWithHttpInfo(productId, limit, page, order, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.ListSkusInProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | A Voucherify product ID or product source ID. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrder?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. | [optional]  |
| **endDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. | [optional]  |

### Return type

[**ProductsSkusListResponseBody**](ProductsSkusListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of SKUs. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproduct"></a>
# **UpdateProduct**
> ProductsUpdateResponseBody UpdateProduct (string productId, ProductsUpdateRequestBody productsUpdateRequestBody = null)

Update Product

Updates the specified product by setting the values of the parameters passed in the request body. Any parameters not provided in the payload will be left unchanged.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateProductExample
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

            var apiInstance = new ProductsApi(config);
            var productId = "productId_example";  // string | A Voucherify product ID or source ID.
            var productsUpdateRequestBody = new ProductsUpdateRequestBody(); // ProductsUpdateRequestBody | Specify the parameters of the product that are to be updated. (optional) 

            try
            {
                // Update Product
                ProductsUpdateResponseBody result = apiInstance.UpdateProduct(productId, productsUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Product
    ApiResponse<ProductsUpdateResponseBody> response = apiInstance.UpdateProductWithHttpInfo(productId, productsUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.UpdateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | A Voucherify product ID or source ID. |  |
| **productsUpdateRequestBody** | [**ProductsUpdateRequestBody**](ProductsUpdateRequestBody.md) | Specify the parameters of the product that are to be updated. | [optional]  |

### Return type

[**ProductsUpdateResponseBody**](ProductsUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an updated product object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproductsinbulk"></a>
# **UpdateProductsInBulk**
> ProductsUpdateInBulkResponseBody UpdateProductsInBulk (List<ProductsUpdateInBulkRequestBody> productsUpdateInBulkRequestBody = null)

Update Products in Bulk

Update products in one asynchronous operation. The request can include up to **10 MB** of data. The response returns a unique asynchronous action ID. Use this ID in the query paramater of the GET Async Action endpoint to check, e.g.: - The status of your request (in queue, in progress, done, or failed) - Resources that failed to be updated - The report file with details about the update If a product object is not found, it is **upserted**. This is shown in the report file in the **GET** Async Action endpoint. The upserted resources have value false in the found column and true in the updated column. This API request starts a process that affects Voucherify data in bulk. In the case of small jobs (like bulk update), the request is put into a queue and processed when every other bulk request placed in the queue prior to this request is finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateProductsInBulkExample
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

            var apiInstance = new ProductsApi(config);
            var productsUpdateInBulkRequestBody = new List<ProductsUpdateInBulkRequestBody>(); // List<ProductsUpdateInBulkRequestBody> | List the product fields to be updated in each customer object. (optional) 

            try
            {
                // Update Products in Bulk
                ProductsUpdateInBulkResponseBody result = apiInstance.UpdateProductsInBulk(productsUpdateInBulkRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductsInBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductsInBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Products in Bulk
    ApiResponse<ProductsUpdateInBulkResponseBody> response = apiInstance.UpdateProductsInBulkWithHttpInfo(productsUpdateInBulkRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.UpdateProductsInBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productsUpdateInBulkRequestBody** | [**List&lt;ProductsUpdateInBulkRequestBody&gt;**](ProductsUpdateInBulkRequestBody.md) | List the product fields to be updated in each customer object. | [optional]  |

### Return type

[**ProductsUpdateInBulkResponseBody**](ProductsUpdateInBulkResponseBody.md)

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

<a id="updateproductsmetadatainbulk"></a>
# **UpdateProductsMetadataInBulk**
> ProductsMetadataUpdateInBulkResponseBody UpdateProductsMetadataInBulk (ProductsMetadataUpdateInBulkRequestBody productsMetadataUpdateInBulkRequestBody = null)

Update Products' Metadata in Bulk

Updates metadata parameters for a list of products. Every resource in the list will receive the metadata defined in the request. The request can include up to **10 MB** of data. The response returns a unique asynchronous action ID. Use this ID in the query paramater of the GET Async Action endpoint to check, e.g.: - The status of your request (in queue, in progress, done, or failed) - Resources that failed to be updated - The report file with details about the update If a product object is not found, it is **upserted**. This is shown in the report file in the **GET** Async Action endpoint. The upserted resources have value false in the found column and true in the updated column. This API request starts a process that affects Voucherify data in bulk. In the case of small jobs (like bulk update), the request is put into a queue and processed when every other bulk request placed in the queue prior to this request is finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateProductsMetadataInBulkExample
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

            var apiInstance = new ProductsApi(config);
            var productsMetadataUpdateInBulkRequestBody = new ProductsMetadataUpdateInBulkRequestBody(); // ProductsMetadataUpdateInBulkRequestBody | List the source_ids of the products you would like to update with the metadata key/value pairs. (optional) 

            try
            {
                // Update Products' Metadata in Bulk
                ProductsMetadataUpdateInBulkResponseBody result = apiInstance.UpdateProductsMetadataInBulk(productsMetadataUpdateInBulkRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductsMetadataInBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductsMetadataInBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Products' Metadata in Bulk
    ApiResponse<ProductsMetadataUpdateInBulkResponseBody> response = apiInstance.UpdateProductsMetadataInBulkWithHttpInfo(productsMetadataUpdateInBulkRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.UpdateProductsMetadataInBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productsMetadataUpdateInBulkRequestBody** | [**ProductsMetadataUpdateInBulkRequestBody**](ProductsMetadataUpdateInBulkRequestBody.md) | List the source_ids of the products you would like to update with the metadata key/value pairs. | [optional]  |

### Return type

[**ProductsMetadataUpdateInBulkResponseBody**](ProductsMetadataUpdateInBulkResponseBody.md)

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

<a id="updatesku"></a>
# **UpdateSku**
> ProductsSkusUpdateResponseBody UpdateSku (string productId, string skuId, ProductsSkusUpdateRequestBody productsSkusUpdateRequestBody = null)

Update SKU

Updates the specified SKU by setting the values of the parameters passed in the request body. Any parameters not provided in the payload will be left unchanged. Fields other than the ones listed in the request body schema wont be modified. Even if provided, they will be silently skipped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateSkuExample
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

            var apiInstance = new ProductsApi(config);
            var productId = "productId_example";  // string | A unique Voucherify product ID or product source ID.
            var skuId = "skuId_example";  // string | A Voucherify SKU ID or SKU source ID.
            var productsSkusUpdateRequestBody = new ProductsSkusUpdateRequestBody(); // ProductsSkusUpdateRequestBody | Specify the parameters to be updated. (optional) 

            try
            {
                // Update SKU
                ProductsSkusUpdateResponseBody result = apiInstance.UpdateSku(productId, skuId, productsSkusUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateSku: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSkuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SKU
    ApiResponse<ProductsSkusUpdateResponseBody> response = apiInstance.UpdateSkuWithHttpInfo(productId, skuId, productsSkusUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.UpdateSkuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | A unique Voucherify product ID or product source ID. |  |
| **skuId** | **string** | A Voucherify SKU ID or SKU source ID. |  |
| **productsSkusUpdateRequestBody** | [**ProductsSkusUpdateRequestBody**](ProductsSkusUpdateRequestBody.md) | Specify the parameters to be updated. | [optional]  |

### Return type

[**ProductsSkusUpdateResponseBody**](ProductsSkusUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the SKU object with the updated parameters. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

