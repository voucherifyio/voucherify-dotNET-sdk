# Voucherify.Api.OrdersApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrder**](OrdersApi.md#createorder) | **POST** /v1/orders | Create Order |
| [**CreateOrderExport**](OrdersApi.md#createorderexport) | **POST** /v1/orders/export | Create Orders Export |
| [**GetOrder**](OrdersApi.md#getorder) | **GET** /v1/orders/{orderId} | Get Order |
| [**ImportOrders**](OrdersApi.md#importorders) | **POST** /v1/orders/import | Import Orders |
| [**ListOrders**](OrdersApi.md#listorders) | **GET** /v1/orders | List Orders |
| [**UpdateOrder**](OrdersApi.md#updateorder) | **PUT** /v1/orders/{orderId} | Update Order |

<a id="createorder"></a>
# **CreateOrder**
> OrdersCreateResponseBody CreateOrder (OrdersCreateRequestBody ordersCreateRequestBody = null)

Create Order

Creates an order object and triggers an order creation event.  📘 Upsert Mode  If you pass an id or a source_id that already exists in the order database, Voucherify will return a related order object with updated fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateOrderExample
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

            var apiInstance = new OrdersApi(config);
            var ordersCreateRequestBody = new OrdersCreateRequestBody(); // OrdersCreateRequestBody | Specify the order parameters. (optional) 

            try
            {
                // Create Order
                OrdersCreateResponseBody result = apiInstance.CreateOrder(ordersCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Order
    ApiResponse<OrdersCreateResponseBody> response = apiInstance.CreateOrderWithHttpInfo(ordersCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.CreateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordersCreateRequestBody** | [**OrdersCreateRequestBody**](OrdersCreateRequestBody.md) | Specify the order parameters. | [optional]  |

### Return type

[**OrdersCreateResponseBody**](OrdersCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an order object if the operation succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createorderexport"></a>
# **CreateOrderExport**
> OrdersExportCreateResponseBody CreateOrderExport (OrdersExportCreateRequestBody ordersExportCreateRequestBody = null)

Create Orders Export

Creates a downloadable CSV file containing a list of orders. The parameters listed in the payload resembles headers in the CSV file. To include a parameter to the file, add it to the parameters.fields object in the request body. The available filters are all order object attributes. Additionally, any metadata defined in the metadata schema can be exported. Passing an empty JSON will generate a file containing three default fields: id, source_id, and status. The fields array is an array of strings containing the data in the export. These fields define the headers in the CSV file. The array can be a combination of any of the following available fields:    

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateOrderExportExample
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

            var apiInstance = new OrdersApi(config);
            var ordersExportCreateRequestBody = new OrdersExportCreateRequestBody(); // OrdersExportCreateRequestBody | Specify which order parameters you would like to export. (optional) 

            try
            {
                // Create Orders Export
                OrdersExportCreateResponseBody result = apiInstance.CreateOrderExport(ordersExportCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrderExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Orders Export
    ApiResponse<OrdersExportCreateResponseBody> response = apiInstance.CreateOrderExportWithHttpInfo(ordersExportCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.CreateOrderExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordersExportCreateRequestBody** | [**OrdersExportCreateRequestBody**](OrdersExportCreateRequestBody.md) | Specify which order parameters you would like to export. | [optional]  |

### Return type

[**OrdersExportCreateResponseBody**](OrdersExportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the &#x60;id&#x60; of the export object and &#x60;status&#x60; of the file generation process. The &#x60;id&#x60; is used in the &lt;!- - [Get Export](OpenAPI.json/paths/~1exports~1{exportId}/get) - -&gt;[Get Export](ref:get-export) method to generate the url for the downloadable CSV file or in the &lt;!- - [Download Export](OpenAPI.json/paths/~1exports~1{export_Id}/get) - -&gt;[Download Export](ref:download-export) method to return the contents of the CSV file. The status indicates whether the file has been scheduled for creation. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getorder"></a>
# **GetOrder**
> OrdersGetResponseBody GetOrder (string orderId)

Get Order

Retrieve an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetOrderExample
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

            var apiInstance = new OrdersApi(config);
            var orderId = "orderId_example";  // string | Unique Voucherify order ID or order source ID.

            try
            {
                // Get Order
                OrdersGetResponseBody result = apiInstance.GetOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order
    ApiResponse<OrdersGetResponseBody> response = apiInstance.GetOrderWithHttpInfo(orderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **string** | Unique Voucherify order ID or order source ID. |  |

### Return type

[**OrdersGetResponseBody**](OrdersGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an order object if a valid identifier was provided.  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="importorders"></a>
# **ImportOrders**
> OrdersImportCreateResponseBody ImportOrders (List<OrdersImportCreateRequestBodyItem> ordersImportCreateRequestBodyItem = null)

Import Orders

  🚧 Historical orders  This endpoint should only be used to import historical orders into Voucherify. For on-going synchronization, the create order and update order endpoints should be used. This is critical because this endpoint does not store events or launch distributions. # Limitations ## Import volume There can be only a single on-going order import per tenant per project at a given time. The user can schedule more imports but those extra imports will be scheduled to run in sequence one by one.   ## Maximum count of orders in single import There is a 2000 limit but we might decide to change it to a lower / higher value at any given time depending if we find this value is too high or too low with time. # Notifications There are no notifications on the Dashboard because this import is launched via the API. # Triggered actions    If you import orders with customers, then a logic will be scheduled responsible for placing these customers into segments and refreshing the segments summary. Consequently, this update will trigger  - **customers entering into segments**  - **distributions** based on any rules tied to customer entering segment(s) - **earning rules** based on the customer entering segment(s) # What is not triggered 1. No webhooks are triggered during the import of orders - for both orders and upserted products / skus.   2. Distributions based on Order Update, Order Paid, Order Created and Order Cancelled. In other words if you have a distribution based on Order Paid and you import an order with a PAID status, the distribution is not going to be triggered.     3. No events are created during the import of orders - for both orders and upserted products / skus. In other words you wont see any events in the Activity tab in the Dashboard such as Order created or Order paid. If you are additionally upserting products / skus, then you wont see the Product created events listed, etc.    4. Earning rules based on Order Paid wont be triggered. This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this API request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportOrdersExample
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

            var apiInstance = new OrdersApi(config);
            var ordersImportCreateRequestBodyItem = new List<OrdersImportCreateRequestBodyItem>(); // List<OrdersImportCreateRequestBodyItem> | The request body is sent in the form of an array of order objects. (optional) 

            try
            {
                // Import Orders
                OrdersImportCreateResponseBody result = apiInstance.ImportOrders(ordersImportCreateRequestBodyItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ImportOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Orders
    ApiResponse<OrdersImportCreateResponseBody> response = apiInstance.ImportOrdersWithHttpInfo(ordersImportCreateRequestBodyItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.ImportOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordersImportCreateRequestBodyItem** | [**List&lt;OrdersImportCreateRequestBodyItem&gt;**](OrdersImportCreateRequestBodyItem.md) | The request body is sent in the form of an array of order objects. | [optional]  |

### Return type

[**OrdersImportCreateResponseBody**](OrdersImportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the ID of the scheduled asynchronous action, informing you that your request has been accepted and the order(s) will be added to the repository asynchronously. To check the status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listorders"></a>
# **ListOrders**
> OrdersListResponseBody ListOrders (int limit = null, int page = null, ParameterOrderListOrders order = null)

List Orders

Returns a list of orders. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListOrdersExample
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

            var apiInstance = new OrdersApi(config);
            var limit = 56;  // int | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListOrders) "created_at";  // ParameterOrderListOrders | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Orders
                OrdersListResponseBody result = apiInstance.ListOrders(limit, page, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ListOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Orders
    ApiResponse<OrdersListResponseBody> response = apiInstance.ListOrdersWithHttpInfo(limit, page, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.ListOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListOrders** | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**OrdersListResponseBody**](OrdersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with order objects. The orders are returned sorted by creation date by default, with the most recent orders appearing last, unless you specify another sequence using the order query parameter. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateorder"></a>
# **UpdateOrder**
> OrdersUpdateResponseBody UpdateOrder (string orderId, OrdersUpdateRequestBody ordersUpdateRequestBody = null)

Update Order

Updates the specified order by setting the values of the parameters passed in the request body. Any parameters not provided will be left unchanged.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateOrderExample
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

            var apiInstance = new OrdersApi(config);
            var orderId = "orderId_example";  // string | Unique Voucherify order ID or order source ID.
            var ordersUpdateRequestBody = new OrdersUpdateRequestBody(); // OrdersUpdateRequestBody | Specify the parameters of the order that are to be updated. (optional) 

            try
            {
                // Update Order
                OrdersUpdateResponseBody result = apiInstance.UpdateOrder(orderId, ordersUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Order
    ApiResponse<OrdersUpdateResponseBody> response = apiInstance.UpdateOrderWithHttpInfo(orderId, ordersUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.UpdateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **string** | Unique Voucherify order ID or order source ID. |  |
| **ordersUpdateRequestBody** | [**OrdersUpdateRequestBody**](OrdersUpdateRequestBody.md) | Specify the parameters of the order that are to be updated. | [optional]  |

### Return type

[**OrdersUpdateResponseBody**](OrdersUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the order object if the update succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

