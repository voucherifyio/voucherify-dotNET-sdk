# Voucherify.Api.CustomersApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomer**](CustomersApi.md#createcustomer) | **POST** /v1/customers | Create Customer |
| [**CustomerPermanentlyDeletion**](CustomersApi.md#customerpermanentlydeletion) | **POST** /v1/customers/{customerId}/permanent-deletion | Delete Customer Permanently |
| [**DeleteCustomer**](CustomersApi.md#deletecustomer) | **DELETE** /v1/customers/{customerId} | Delete Customer |
| [**GetCustomer**](CustomersApi.md#getcustomer) | **GET** /v1/customers/{customerId} | Get Customer |
| [**ImportCustomersUsingCsv**](CustomersApi.md#importcustomersusingcsv) | **POST** /v1/customers/importCSV | Import and Update Customers using CSV |
| [**ListCustomerActivity**](CustomersApi.md#listcustomeractivity) | **GET** /v1/customers/{customerId}/activity | List Customer Activity |
| [**ListCustomerRedeemables**](CustomersApi.md#listcustomerredeemables) | **GET** /v1/customers/{customerId}/redeemables | List Customer&#39;s Redeemables |
| [**ListCustomerSegments**](CustomersApi.md#listcustomersegments) | **GET** /v1/customers/{customerId}/segments | List Customer&#39;s Segments |
| [**ListCustomers**](CustomersApi.md#listcustomers) | **GET** /v1/customers | List Customers |
| [**UpdateCustomer**](CustomersApi.md#updatecustomer) | **PUT** /v1/customers/{customerId} | Update Customer |
| [**UpdateCustomersInBulk**](CustomersApi.md#updatecustomersinbulk) | **POST** /v1/customers/bulk/async | Update Customers in Bulk |
| [**UpdateCustomersMetadataInBulk**](CustomersApi.md#updatecustomersmetadatainbulk) | **POST** /v1/customers/metadata/async | Update Customers&#39; Metadata in Bulk |

<a id="createcustomer"></a>
# **CreateCustomer**
> CustomersCreateResponseBody CreateCustomer (CustomersCreateRequestBody customersCreateRequestBody = null)

Create Customer

Creates a customer object.  📘 Upsert Mode  If you pass an id or a source_id that already exists in the customer database, Voucherify will return a related customer object with updated fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateCustomerExample
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

            var apiInstance = new CustomersApi(config);
            var customersCreateRequestBody = new CustomersCreateRequestBody(); // CustomersCreateRequestBody | Create a customer with specified parameters. (optional) 

            try
            {
                // Create Customer
                CustomersCreateResponseBody result = apiInstance.CreateCustomer(customersCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Customer
    ApiResponse<CustomersCreateResponseBody> response = apiInstance.CreateCustomerWithHttpInfo(customersCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CreateCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customersCreateRequestBody** | [**CustomersCreateRequestBody**](CustomersCreateRequestBody.md) | Create a customer with specified parameters. | [optional]  |

### Return type

[**CustomersCreateResponseBody**](CustomersCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a customer object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="customerpermanentlydeletion"></a>
# **CustomerPermanentlyDeletion**
> CustomersPermanentDeletionCreateResponseBody CustomerPermanentlyDeletion (string customerId)

Delete Customer Permanently

The organization user can remove consumer data permanently from the Voucherify system by using this API method. It deletes all customer data and connected resources. It makes the customer profile forgotten by Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CustomerPermanentlyDeletionExample
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

            var apiInstance = new CustomersApi(config);
            var customerId = "customerId_example";  // string | A Voucherify customers id or source_id.

            try
            {
                // Delete Customer Permanently
                CustomersPermanentDeletionCreateResponseBody result = apiInstance.CustomerPermanentlyDeletion(customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomerPermanentlyDeletion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerPermanentlyDeletionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Customer Permanently
    ApiResponse<CustomersPermanentDeletionCreateResponseBody> response = apiInstance.CustomerPermanentlyDeletionWithHttpInfo(customerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CustomerPermanentlyDeletionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | A Voucherify customers id or source_id. |  |

### Return type

[**CustomersPermanentDeletionCreateResponseBody**](CustomersPermanentDeletionCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a permanent deletion object and status of the deletion. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomer"></a>
# **DeleteCustomer**
> void DeleteCustomer (string customerId)

Delete Customer

This method deletes a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteCustomerExample
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

            var apiInstance = new CustomersApi(config);
            var customerId = "customerId_example";  // string | A Voucherify customers id or source_id.

            try
            {
                // Delete Customer
                apiInstance.DeleteCustomer(customerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Customer
    apiInstance.DeleteCustomerWithHttpInfo(customerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.DeleteCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | A Voucherify customers id or source_id. |  |

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

<a id="getcustomer"></a>
# **GetCustomer**
> CustomersGetResponseBody GetCustomer (string customerId)

Get Customer

Retrieve customer details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetCustomerExample
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

            var apiInstance = new CustomersApi(config);
            var customerId = "customerId_example";  // string | A Voucherify customers id or source_id.

            try
            {
                // Get Customer
                CustomersGetResponseBody result = apiInstance.GetCustomer(customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Customer
    ApiResponse<CustomersGetResponseBody> response = apiInstance.GetCustomerWithHttpInfo(customerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.GetCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | A Voucherify customers id or source_id. |  |

### Return type

[**CustomersGetResponseBody**](CustomersGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a customer object if a valid identifier was provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importcustomersusingcsv"></a>
# **ImportCustomersUsingCsv**
> CustomersImportCsvCreateResponseBody ImportCustomersUsingCsv (System.IO.Stream file = null)

Import and Update Customers using CSV

This API method lets you import or update customer data. To get a proper and valid response, please send a CSV file with data separated by commas.   # Request Example # CSV File Format The CSV file has to include headers in the first line. All properties which cannot be mapped to standard customer fields will be added to the metadata object.  📘 Standard customer fields mapping  **No spaces allowed in field names**    Id, Name, Email, Phone, Birthdate, Source_id, Address_line_1, Address_line_2, Address_Postal_Code, Address_City, Address_State, Address_Country, Description, Metadata_name_1, Metadata_name_2 # Update Customers using CSV If you would like to update customers data, you can do it using the CSV file with new data. However, remember to include a source_id in your CSV file to manage the update successfully. This API request starts a process that affects Voucherify data in bulk.  In case of small jobs (like bulk update) the request is put into a queue and processed once every other bulk request placed in the queue prior to this request is finished. However, when the job takes a longer time (like vouchers generation) then it is processed in small portions in a round-robin fashion. When there is a list of vouchers generation scheduled, then they will all have the IN_PROGRESS status shortly. This way, small jobs added just after scheduling big jobs of the same type will be processed in a short time window.  The result will return the async ID. You can verify the status of your request via this API request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ImportCustomersUsingCsvExample
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

            var apiInstance = new CustomersApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File path. (optional) 

            try
            {
                // Import and Update Customers using CSV
                CustomersImportCsvCreateResponseBody result = apiInstance.ImportCustomersUsingCsv(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ImportCustomersUsingCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportCustomersUsingCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import and Update Customers using CSV
    ApiResponse<CustomersImportCsvCreateResponseBody> response = apiInstance.ImportCustomersUsingCsvWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.ImportCustomersUsingCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | File path. | [optional]  |

### Return type

[**CustomersImportCsvCreateResponseBody**](CustomersImportCsvCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Returns ID of the scheduled async action. The response informs you that your request has been accepted and customers will be added to the repository asynchronously. To check the import status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using the &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcustomeractivity"></a>
# **ListCustomerActivity**
> CustomersActivityListResponseBody ListCustomerActivity (string customerId, int? limit = null, ParameterOrderCreatedAt? order = null, string startingAfterId = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, string campaignId = null, ParameterCampaignType? campaignType = null, ParameterActivityCategory? category = null, ParameterCustomerEvent? type = null)

List Customer Activity

Retrieve customer activities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCustomerActivityExample
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

            var apiInstance = new CustomersApi(config);
            var customerId = "customerId_example";  // string | A Voucherify customers id or source ID of the customer who performed the activities.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderCreatedAt) "created_at";  // ParameterOrderCreatedAt? | Apply this filter to order the events according the date and time when it was created.  (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the events starting after an event with the given ID. (optional) 
            var startDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must begin on. Represented in ISO 8601 format. (optional) 
            var endDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. (optional) 
            var campaignId = "campaignId_example";  // string | Requests only events related to specific campaign identified by its ID. (optional) 
            var campaignType = (ParameterCampaignType) "PROMOTION";  // ParameterCampaignType? | Filters related customers activity for the selected campaign types. Allowed values:  DISCOUNT_COUPONS, REFERRAL_PROGRAM, GIFT_VOUCHERS, PROMOTION, LOYALTY_PROGRAM. (optional) 
            var category = (ParameterActivityCategory) "ACTION";  // ParameterActivityCategory? | Filters activities for actions or effects. Allowed values:  ACTION, EFFECT. (optional) 
            var type = (ParameterCustomerEvent) "customer.confirmed";  // ParameterCustomerEvent? | Event name of the customer event. (optional) 

            try
            {
                // List Customer Activity
                CustomersActivityListResponseBody result = apiInstance.ListCustomerActivity(customerId, limit, order, startingAfterId, startDate, endDate, campaignId, campaignType, category, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListCustomerActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustomerActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Customer Activity
    ApiResponse<CustomersActivityListResponseBody> response = apiInstance.ListCustomerActivityWithHttpInfo(customerId, limit, order, startingAfterId, startDate, endDate, campaignId, campaignType, category, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.ListCustomerActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | A Voucherify customers id or source ID of the customer who performed the activities. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderCreatedAt?** | Apply this filter to order the events according the date and time when it was created.  | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the events starting after an event with the given ID. | [optional]  |
| **startDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must begin on. Represented in ISO 8601 format. | [optional]  |
| **endDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. | [optional]  |
| **campaignId** | **string** | Requests only events related to specific campaign identified by its ID. | [optional]  |
| **campaignType** | **ParameterCampaignType?** | Filters related customers activity for the selected campaign types. Allowed values:  DISCOUNT_COUPONS, REFERRAL_PROGRAM, GIFT_VOUCHERS, PROMOTION, LOYALTY_PROGRAM. | [optional]  |
| **category** | **ParameterActivityCategory?** | Filters activities for actions or effects. Allowed values:  ACTION, EFFECT. | [optional]  |
| **type** | **ParameterCustomerEvent?** | Event name of the customer event. | [optional]  |

### Return type

[**CustomersActivityListResponseBody**](CustomersActivityListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with customer activities. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcustomerredeemables"></a>
# **ListCustomerRedeemables**
> CustomersRedeemablesListResponseBody ListCustomerRedeemables (string customerId, int? limit = null, ParameterOrderListRedeemables? order = null, string startingAfterId = null, ParameterFiltersListCustomerRedeemables filters = null)

List Customer's Redeemables

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
    public class ListCustomerRedeemablesExample
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

            var apiInstance = new CustomersApi(config);
            var customerId = "customerId_example";  // string | Unique identifier of a customer represented by an internal customer ID or customer source ID.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListRedeemables) "id";  // ParameterOrderListRedeemables? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the events starting after an event with the given ID. (optional) 
            var filters = new ParameterFiltersListCustomerRedeemables(); // ParameterFiltersListCustomerRedeemables | Filters for listing customer redeemables. (optional) 

            try
            {
                // List Customer's Redeemables
                CustomersRedeemablesListResponseBody result = apiInstance.ListCustomerRedeemables(customerId, limit, order, startingAfterId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListCustomerRedeemables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustomerRedeemablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Customer's Redeemables
    ApiResponse<CustomersRedeemablesListResponseBody> response = apiInstance.ListCustomerRedeemablesWithHttpInfo(customerId, limit, order, startingAfterId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.ListCustomerRedeemablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | Unique identifier of a customer represented by an internal customer ID or customer source ID. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListRedeemables?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the events starting after an event with the given ID. | [optional]  |
| **filters** | [**ParameterFiltersListCustomerRedeemables**](ParameterFiltersListCustomerRedeemables.md) | Filters for listing customer redeemables. | [optional]  |

### Return type

[**CustomersRedeemablesListResponseBody**](CustomersRedeemablesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The method returns redeemable(s) to which the given customer is assigned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcustomersegments"></a>
# **ListCustomerSegments**
> CustomersSegmentsListResponseBody ListCustomerSegments (string customerId)

List Customer's Segments

Returns the list of segments IDs to which the customer belongs to.   If you pass a customerId which is not stored and recognized by Voucherify as an existing customer in the system, the response will generate a list of segments that the customer would potentialy qualify for if they were to become a customer tracked in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCustomerSegmentsExample
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

            var apiInstance = new CustomersApi(config);
            var customerId = "customerId_example";  // string | Unique identifier of a customer represented by an internal customer ID or customer source ID.

            try
            {
                // List Customer's Segments
                CustomersSegmentsListResponseBody result = apiInstance.ListCustomerSegments(customerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListCustomerSegments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustomerSegmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Customer's Segments
    ApiResponse<CustomersSegmentsListResponseBody> response = apiInstance.ListCustomerSegmentsWithHttpInfo(customerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.ListCustomerSegmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | Unique identifier of a customer represented by an internal customer ID or customer source ID. |  |

### Return type

[**CustomersSegmentsListResponseBody**](CustomersSegmentsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The method returns segment(s) to which the given customer belongs to. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcustomers"></a>
# **ListCustomers**
> CustomersListResponseBody ListCustomers (int? limit = null, int? page = null, string email = null, string city = null, string name = null, string segmentId = null, DateTimeOffset? createdAtBefore = null, DateTimeOffset? createdAtAfter = null, DateTimeOffset? updatedAtBefore = null, DateTimeOffset? updatedAtAfter = null, ParameterOrderListCustomers? order = null, DateTimeOffset? startingAfter = null)

List Customers

Returns a list of customers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCustomersExample
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

            var apiInstance = new CustomersApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1, the highest value is 99. (optional) 
            var email = "email_example";  // string | Limit the customers to the ones that have this specific email address. (optional) 
            var city = "city_example";  // string | Limit the customers to the ones that are located in the specified city. (optional) 
            var name = "name_example";  // string | Filter customers by the name property. (optional) 
            var segmentId = "segmentId_example";  // string | Filter customers by the segment id. (optional) 
            var createdAtBefore = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Filter customers by date customer was created. (optional) 
            var createdAtAfter = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Filter customers by date customer was created. (optional) 
            var updatedAtBefore = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Filter customers by date customer was updated last time. (optional) 
            var updatedAtAfter = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Filter customers by date customer was updated last time. (optional) 
            var order = (ParameterOrderListCustomers) "created_at";  // ParameterOrderListCustomers? | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfter = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | A cursor for pagination. This is a date-time value that defines your place in the list based on created_at property from the customer object. For instance, if you make a list request and receive 100 objects, ending with an object created at 2020-05-24T13:43:09.024Z, your subsequent call can include starting_after 2020-05-24T13:43:09.024Z in order to fetch the next page of the list.   (optional) 

            try
            {
                // List Customers
                CustomersListResponseBody result = apiInstance.ListCustomers(limit, page, email, city, name, segmentId, createdAtBefore, createdAtAfter, updatedAtBefore, updatedAtAfter, order, startingAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.ListCustomers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustomersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Customers
    ApiResponse<CustomersListResponseBody> response = apiInstance.ListCustomersWithHttpInfo(limit, page, email, city, name, segmentId, createdAtBefore, createdAtAfter, updatedAtBefore, updatedAtAfter, order, startingAfter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.ListCustomersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1, the highest value is 99. | [optional]  |
| **email** | **string** | Limit the customers to the ones that have this specific email address. | [optional]  |
| **city** | **string** | Limit the customers to the ones that are located in the specified city. | [optional]  |
| **name** | **string** | Filter customers by the name property. | [optional]  |
| **segmentId** | **string** | Filter customers by the segment id. | [optional]  |
| **createdAtBefore** | **DateTimeOffset?** | Filter customers by date customer was created. | [optional]  |
| **createdAtAfter** | **DateTimeOffset?** | Filter customers by date customer was created. | [optional]  |
| **updatedAtBefore** | **DateTimeOffset?** | Filter customers by date customer was updated last time. | [optional]  |
| **updatedAtAfter** | **DateTimeOffset?** | Filter customers by date customer was updated last time. | [optional]  |
| **order** | **ParameterOrderListCustomers?** | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfter** | **DateTimeOffset?** | A cursor for pagination. This is a date-time value that defines your place in the list based on created_at property from the customer object. For instance, if you make a list request and receive 100 objects, ending with an object created at 2020-05-24T13:43:09.024Z, your subsequent call can include starting_after 2020-05-24T13:43:09.024Z in order to fetch the next page of the list.   | [optional]  |

### Return type

[**CustomersListResponseBody**](CustomersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with customer objects. The customers are returned sorted by creation date, with the most recent customers appearing first. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecustomer"></a>
# **UpdateCustomer**
> CustomersUpdateResponseBody UpdateCustomer (string customerId, CustomersUpdateRequestBody customersUpdateRequestBody = null)

Update Customer

Updates the specified customer by setting the values of the parameters passed in the request body. Any parameters not provided in the payload will be left unchanged.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateCustomerExample
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

            var apiInstance = new CustomersApi(config);
            var customerId = "customerId_example";  // string | A Voucherify customers id or source_id.
            var customersUpdateRequestBody = new CustomersUpdateRequestBody(); // CustomersUpdateRequestBody | Specify the parameters to be updated. (optional) 

            try
            {
                // Update Customer
                CustomersUpdateResponseBody result = apiInstance.UpdateCustomer(customerId, customersUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Customer
    ApiResponse<CustomersUpdateResponseBody> response = apiInstance.UpdateCustomerWithHttpInfo(customerId, customersUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.UpdateCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | A Voucherify customers id or source_id. |  |
| **customersUpdateRequestBody** | [**CustomersUpdateRequestBody**](CustomersUpdateRequestBody.md) | Specify the parameters to be updated. | [optional]  |

### Return type

[**CustomersUpdateResponseBody**](CustomersUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a customer object if updates were successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecustomersinbulk"></a>
# **UpdateCustomersInBulk**
> CustomersUpdateInBulkResponseBody UpdateCustomersInBulk (List<CustomersUpdateInBulkRequestBody> customersUpdateInBulkRequestBody = null)

Update Customers in Bulk

Updates customers in one asynchronous operation. The request can include up to **10 MB** of data. The response returns a unique asynchronous action ID. Use this ID in the query paramater of the GET Async Action endpoint to check, e.g.: - The status of your request (in queue, in progress, done, or failed) - Resources that failed to be updated - The report file with details about the update If a customer object is not found, it is **upserted**. This is shown in the report file in the **GET** Async Action endpoint. The upserted resources have value false in the found column and true in the updated column. This API request starts a process that affects Voucherify data in bulk. In the case of small jobs (like bulk update), the request is put into a queue and processed when every other bulk request placed in the queue prior to this request is finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateCustomersInBulkExample
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

            var apiInstance = new CustomersApi(config);
            var customersUpdateInBulkRequestBody = new List<CustomersUpdateInBulkRequestBody>(); // List<CustomersUpdateInBulkRequestBody> | List the customer fields to be updated in each customer object. (optional) 

            try
            {
                // Update Customers in Bulk
                CustomersUpdateInBulkResponseBody result = apiInstance.UpdateCustomersInBulk(customersUpdateInBulkRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomersInBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomersInBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Customers in Bulk
    ApiResponse<CustomersUpdateInBulkResponseBody> response = apiInstance.UpdateCustomersInBulkWithHttpInfo(customersUpdateInBulkRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.UpdateCustomersInBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customersUpdateInBulkRequestBody** | [**List&lt;CustomersUpdateInBulkRequestBody&gt;**](CustomersUpdateInBulkRequestBody.md) | List the customer fields to be updated in each customer object. | [optional]  |

### Return type

[**CustomersUpdateInBulkResponseBody**](CustomersUpdateInBulkResponseBody.md)

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

<a id="updatecustomersmetadatainbulk"></a>
# **UpdateCustomersMetadataInBulk**
> CustomersMetadataUpdateInBulkResponseBody UpdateCustomersMetadataInBulk (CustomersMetadataUpdateInBulkRequestBody customersMetadataUpdateInBulkRequestBody = null)

Update Customers' Metadata in Bulk

Updates metadata parameters for a list of customers. Every resource in the list will receive the metadata defined in the request. The request can include up to **10 MB** of data. The response returns a unique asynchronous action ID. Use this ID in the query paramater of the GET Async Action endpoint to check, e.g.: - The status of your request (in queue, in progress, done, or failed) - Resources that failed to be updated - The report file with details about the update If a product object is not found, it is **upserted**. This is shown in the report file in the **GET** Async Action endpoint. The upserted resources have value false in the found column and true in the updated column. This API request starts a process that affects Voucherify data in bulk. In the case of small jobs (like bulk update), the request is put into a queue and processed when every other bulk request placed in the queue prior to this request is finished.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateCustomersMetadataInBulkExample
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

            var apiInstance = new CustomersApi(config);
            var customersMetadataUpdateInBulkRequestBody = new CustomersMetadataUpdateInBulkRequestBody(); // CustomersMetadataUpdateInBulkRequestBody | List the source_ids of the customers you would like to update with the metadata key/value pairs. (optional) 

            try
            {
                // Update Customers' Metadata in Bulk
                CustomersMetadataUpdateInBulkResponseBody result = apiInstance.UpdateCustomersMetadataInBulk(customersMetadataUpdateInBulkRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomersMetadataInBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomersMetadataInBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Customers' Metadata in Bulk
    ApiResponse<CustomersMetadataUpdateInBulkResponseBody> response = apiInstance.UpdateCustomersMetadataInBulkWithHttpInfo(customersMetadataUpdateInBulkRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.UpdateCustomersMetadataInBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customersMetadataUpdateInBulkRequestBody** | [**CustomersMetadataUpdateInBulkRequestBody**](CustomersMetadataUpdateInBulkRequestBody.md) | List the source_ids of the customers you would like to update with the metadata key/value pairs. | [optional]  |

### Return type

[**CustomersMetadataUpdateInBulkResponseBody**](CustomersMetadataUpdateInBulkResponseBody.md)

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

