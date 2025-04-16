# Voucherify.Api.CategoriesApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCategory**](CategoriesApi.md#createcategory) | **POST** /v1/categories | Create Category |
| [**DeleteCategory**](CategoriesApi.md#deletecategory) | **DELETE** /v1/categories/{categoryId} | Delete Category |
| [**GetCategory**](CategoriesApi.md#getcategory) | **GET** /v1/categories/{categoryId} | Get Category |
| [**ListCategories**](CategoriesApi.md#listcategories) | **GET** /v1/categories | List Categories |
| [**UpdateCategory**](CategoriesApi.md#updatecategory) | **PUT** /v1/categories/{categoryId} | Update Category |

<a id="createcategory"></a>
# **CreateCategory**
> CategoriesCreateResponseBody CreateCategory (CategoriesCreateRequestBody categoriesCreateRequestBody = null)

Create Category

Create category with a specific name and hierarchy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateCategoryExample
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

            var apiInstance = new CategoriesApi(config);
            var categoriesCreateRequestBody = new CategoriesCreateRequestBody(); // CategoriesCreateRequestBody | Specify the details of the category that you would like to create. (optional) 

            try
            {
                // Create Category
                CategoriesCreateResponseBody result = apiInstance.CreateCategory(categoriesCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Category
    ApiResponse<CategoriesCreateResponseBody> response = apiInstance.CreateCategoryWithHttpInfo(categoriesCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.CreateCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoriesCreateRequestBody** | [**CategoriesCreateRequestBody**](CategoriesCreateRequestBody.md) | Specify the details of the category that you would like to create. | [optional]  |

### Return type

[**CategoriesCreateResponseBody**](CategoriesCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a newly created category object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecategory"></a>
# **DeleteCategory**
> void DeleteCategory (string categoryId)

Delete Category

Delete a category by the category ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteCategoryExample
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

            var apiInstance = new CategoriesApi(config);
            var categoryId = "categoryId_example";  // string | Unique category ID assigned by Voucherify.

            try
            {
                // Delete Category
                apiInstance.DeleteCategory(categoryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Category
    apiInstance.DeleteCategoryWithHttpInfo(categoryId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.DeleteCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** | Unique category ID assigned by Voucherify. |  |

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
| **204** | No content is returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcategory"></a>
# **GetCategory**
> CategoriesGetResponseBody GetCategory (string categoryId)

Get Category

Retrieve a category by the category ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetCategoryExample
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

            var apiInstance = new CategoriesApi(config);
            var categoryId = "categoryId_example";  // string | Unique category ID assigned by Voucherify.

            try
            {
                // Get Category
                CategoriesGetResponseBody result = apiInstance.GetCategory(categoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Category
    ApiResponse<CategoriesGetResponseBody> response = apiInstance.GetCategoryWithHttpInfo(categoryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.GetCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** | Unique category ID assigned by Voucherify. |  |

### Return type

[**CategoriesGetResponseBody**](CategoriesGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a category object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcategories"></a>
# **ListCategories**
> CategoriesListResponseBody ListCategories ()

List Categories

List all categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCategoriesExample
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

            var apiInstance = new CategoriesApi(config);

            try
            {
                // List Categories
                CategoriesListResponseBody result = apiInstance.ListCategories();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.ListCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Categories
    ApiResponse<CategoriesListResponseBody> response = apiInstance.ListCategoriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.ListCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CategoriesListResponseBody**](CategoriesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of category objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecategory"></a>
# **UpdateCategory**
> CategoriesUpdateResponseBody UpdateCategory (string categoryId, CategoriesUpdateRequestBody categoriesUpdateRequestBody = null)

Update Category

Update category using the category ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateCategoryExample
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

            var apiInstance = new CategoriesApi(config);
            var categoryId = "categoryId_example";  // string | Unique category ID assigned by Voucherify.
            var categoriesUpdateRequestBody = new CategoriesUpdateRequestBody(); // CategoriesUpdateRequestBody | Specify the details of the category that you would like to update. (optional) 

            try
            {
                // Update Category
                CategoriesUpdateResponseBody result = apiInstance.UpdateCategory(categoryId, categoriesUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Category
    ApiResponse<CategoriesUpdateResponseBody> response = apiInstance.UpdateCategoryWithHttpInfo(categoryId, categoriesUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.UpdateCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** | Unique category ID assigned by Voucherify. |  |
| **categoriesUpdateRequestBody** | [**CategoriesUpdateRequestBody**](CategoriesUpdateRequestBody.md) | Specify the details of the category that you would like to update. | [optional]  |

### Return type

[**CategoriesUpdateResponseBody**](CategoriesUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a category object with a refreshed &#x60;updated_at&#x60; property. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

