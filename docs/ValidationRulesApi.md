# Voucherify.Api.ValidationRulesApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateValidationRuleAssignment**](ValidationRulesApi.md#createvalidationruleassignment) | **POST** /v1/validation-rules/{validationRuleId}/assignments | Create Validation Rules Assignments |
| [**CreateValidationRules**](ValidationRulesApi.md#createvalidationrules) | **POST** /v1/validation-rules | Create Validation Rules |
| [**DeleteValidationRuleAssignment**](ValidationRulesApi.md#deletevalidationruleassignment) | **DELETE** /v1/validation-rules/{validationRuleId}/assignments/{assignmentId} | Delete Validation Rule Assignment |
| [**DeleteValidationRules**](ValidationRulesApi.md#deletevalidationrules) | **DELETE** /v1/validation-rules/{validationRuleId} | Delete Validation Rule |
| [**GetValidationRule**](ValidationRulesApi.md#getvalidationrule) | **GET** /v1/validation-rules/{validationRuleId} | Get Validation Rule |
| [**ListValidationRuleAssignments**](ValidationRulesApi.md#listvalidationruleassignments) | **GET** /v1/validation-rules/{validationRuleId}/assignments | List Validation Rule Assignments |
| [**ListValidationRules**](ValidationRulesApi.md#listvalidationrules) | **GET** /v1/validation-rules | List Validation Rules |
| [**ListValidationRulesAssignments**](ValidationRulesApi.md#listvalidationrulesassignments) | **GET** /v1/validation-rules-assignments | List Validation Rules&#39; Assignment(s) |
| [**UpdateValidationRule**](ValidationRulesApi.md#updatevalidationrule) | **PUT** /v1/validation-rules/{validationRuleId} | Update Validation Rule |

<a id="createvalidationruleassignment"></a>
# **CreateValidationRuleAssignment**
> ValidationRulesAssignmentsCreateResponseBody CreateValidationRuleAssignment (string validationRuleId, bool? force = null, ValidationRulesAssignmentsCreateRequestBody validationRulesAssignmentsCreateRequestBody = null)

Create Validation Rules Assignments

Assign validation rule to either one of the following objects: voucher, campaign, promotion tier, earning rule, reward, distribution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateValidationRuleAssignmentExample
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

            var apiInstance = new ValidationRulesApi(config);
            var validationRuleId = "validationRuleId_example";  // string | Unique validation rule ID.
            var force = true;  // bool? | If this flag is set to true, the previous assignment with the same data will be deleted and a new one will be added. (optional) 
            var validationRulesAssignmentsCreateRequestBody = new ValidationRulesAssignmentsCreateRequestBody(); // ValidationRulesAssignmentsCreateRequestBody | Specify the resource that you would like to assign the validation rule to. (optional) 

            try
            {
                // Create Validation Rules Assignments
                ValidationRulesAssignmentsCreateResponseBody result = apiInstance.CreateValidationRuleAssignment(validationRuleId, force, validationRulesAssignmentsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.CreateValidationRuleAssignment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateValidationRuleAssignmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Validation Rules Assignments
    ApiResponse<ValidationRulesAssignmentsCreateResponseBody> response = apiInstance.CreateValidationRuleAssignmentWithHttpInfo(validationRuleId, force, validationRulesAssignmentsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.CreateValidationRuleAssignmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validationRuleId** | **string** | Unique validation rule ID. |  |
| **force** | **bool?** | If this flag is set to true, the previous assignment with the same data will be deleted and a new one will be added. | [optional]  |
| **validationRulesAssignmentsCreateRequestBody** | [**ValidationRulesAssignmentsCreateRequestBody**](ValidationRulesAssignmentsCreateRequestBody.md) | Specify the resource that you would like to assign the validation rule to. | [optional]  |

### Return type

[**ValidationRulesAssignmentsCreateResponseBody**](ValidationRulesAssignmentsCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a validation rules assignment object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createvalidationrules"></a>
# **CreateValidationRules**
> ValidationRulesCreateResponseBody CreateValidationRules (ValidationRulesCreateRequestBody validationRulesCreateRequestBody = null)

Create Validation Rules

Create validation rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateValidationRulesExample
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

            var apiInstance = new ValidationRulesApi(config);
            var validationRulesCreateRequestBody = new ValidationRulesCreateRequestBody(); // ValidationRulesCreateRequestBody | Specify the validation rules parameters. (optional) 

            try
            {
                // Create Validation Rules
                ValidationRulesCreateResponseBody result = apiInstance.CreateValidationRules(validationRulesCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.CreateValidationRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateValidationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Validation Rules
    ApiResponse<ValidationRulesCreateResponseBody> response = apiInstance.CreateValidationRulesWithHttpInfo(validationRulesCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.CreateValidationRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validationRulesCreateRequestBody** | [**ValidationRulesCreateRequestBody**](ValidationRulesCreateRequestBody.md) | Specify the validation rules parameters. | [optional]  |

### Return type

[**ValidationRulesCreateResponseBody**](ValidationRulesCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a validation rule object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletevalidationruleassignment"></a>
# **DeleteValidationRuleAssignment**
> void DeleteValidationRuleAssignment (string validationRuleId, string assignmentId)

Delete Validation Rule Assignment

This method deletes a validation rule assignment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteValidationRuleAssignmentExample
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

            var apiInstance = new ValidationRulesApi(config);
            var validationRuleId = "validationRuleId_example";  // string | A unique validation rule ID.
            var assignmentId = "assignmentId_example";  // string | A unique validation rule assignment ID.

            try
            {
                // Delete Validation Rule Assignment
                apiInstance.DeleteValidationRuleAssignment(validationRuleId, assignmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.DeleteValidationRuleAssignment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteValidationRuleAssignmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Validation Rule Assignment
    apiInstance.DeleteValidationRuleAssignmentWithHttpInfo(validationRuleId, assignmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.DeleteValidationRuleAssignmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validationRuleId** | **string** | A unique validation rule ID. |  |
| **assignmentId** | **string** | A unique validation rule assignment ID. |  |

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

<a id="deletevalidationrules"></a>
# **DeleteValidationRules**
> void DeleteValidationRules (string validationRuleId)

Delete Validation Rule

This method deletes a validation rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteValidationRulesExample
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

            var apiInstance = new ValidationRulesApi(config);
            var validationRuleId = "validationRuleId_example";  // string | A unique validation rule ID.

            try
            {
                // Delete Validation Rule
                apiInstance.DeleteValidationRules(validationRuleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.DeleteValidationRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteValidationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Validation Rule
    apiInstance.DeleteValidationRulesWithHttpInfo(validationRuleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.DeleteValidationRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validationRuleId** | **string** | A unique validation rule ID. |  |

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

<a id="getvalidationrule"></a>
# **GetValidationRule**
> ValidationRulesGetResponseBody GetValidationRule (string validationRuleId)

Get Validation Rule

Retrieve the details of a validation rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetValidationRuleExample
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

            var apiInstance = new ValidationRulesApi(config);
            var validationRuleId = "validationRuleId_example";  // string | A unique validation rule ID.

            try
            {
                // Get Validation Rule
                ValidationRulesGetResponseBody result = apiInstance.GetValidationRule(validationRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.GetValidationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValidationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Validation Rule
    ApiResponse<ValidationRulesGetResponseBody> response = apiInstance.GetValidationRuleWithHttpInfo(validationRuleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.GetValidationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validationRuleId** | **string** | A unique validation rule ID. |  |

### Return type

[**ValidationRulesGetResponseBody**](ValidationRulesGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the validation rule object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listvalidationruleassignments"></a>
# **ListValidationRuleAssignments**
> ValidationRulesAssignmentsListResponseBody ListValidationRuleAssignments (string validationRuleId, int? limit = null, int? page = null, ParameterOrderListValidationRuleAssignments? order = null)

List Validation Rule Assignments

Retrieve validation rule assignments for a specific validation rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListValidationRuleAssignmentsExample
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

            var apiInstance = new ValidationRulesApi(config);
            var validationRuleId = "validationRuleId_example";  // string | Unique validation rule ID.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListValidationRuleAssignments) "created_at";  // ParameterOrderListValidationRuleAssignments? | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Validation Rule Assignments
                ValidationRulesAssignmentsListResponseBody result = apiInstance.ListValidationRuleAssignments(validationRuleId, limit, page, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.ListValidationRuleAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListValidationRuleAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Validation Rule Assignments
    ApiResponse<ValidationRulesAssignmentsListResponseBody> response = apiInstance.ListValidationRuleAssignmentsWithHttpInfo(validationRuleId, limit, page, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.ListValidationRuleAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validationRuleId** | **string** | Unique validation rule ID. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListValidationRuleAssignments?** | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**ValidationRulesAssignmentsListResponseBody**](ValidationRulesAssignmentsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of validation rule assignments.  If the validation rule ID provided in the path parameter cannot be found, the endpoint will return an empty &#x60;data&#x60; array and a total of &#x60;0&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listvalidationrules"></a>
# **ListValidationRules**
> ValidationRulesListResponseBody ListValidationRules (int? limit = null, int? page = null, ParameterOrderListValidationRules? order = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)

List Validation Rules

Retrieve validation rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListValidationRulesExample
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

            var apiInstance = new ValidationRulesApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListValidationRules) "created_at";  // ParameterOrderListValidationRules? | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must start on. Represented in ISO 8601 format. (optional) 
            var endDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. (optional) 

            try
            {
                // List Validation Rules
                ValidationRulesListResponseBody result = apiInstance.ListValidationRules(limit, page, order, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.ListValidationRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListValidationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Validation Rules
    ApiResponse<ValidationRulesListResponseBody> response = apiInstance.ListValidationRulesWithHttpInfo(limit, page, order, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.ListValidationRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListValidationRules?** | This is a property that controls the sorting direction of the results. Sort the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must start on. Represented in ISO 8601 format. | [optional]  |
| **endDate** | **DateTimeOffset?** | Timestamp representing the date and time which results must end on. Represented in ISO 8601 format. | [optional]  |

### Return type

[**ValidationRulesListResponseBody**](ValidationRulesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of validation rules. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listvalidationrulesassignments"></a>
# **ListValidationRulesAssignments**
> ValidationRulesAssignmentsListResponseBody ListValidationRulesAssignments (string relatedObjectId = null, string rule = null, int? page = null, int? limit = null, string order = null)

List Validation Rules' Assignment(s)

List all validation rules assignments or filter the results using the related object ID or the validation rule ID query parameters.  # How to retrieve specific validation rule assignments(s) ## Related object ID To find an assignment for a particular resource, you can use the ID of the object to which the validation rule was assigned. This could be, for example, an ID of a: voucher, campaign, distribution, reward assignment, earning rule, promotion tier.    ## Validation rule ID You can use the validation rule ID to find assignment(s) for a specific validation rule.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListValidationRulesAssignmentsExample
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

            var apiInstance = new ValidationRulesApi(config);
            var relatedObjectId = "relatedObjectId_example";  // string | The resource ID to which the validation rule was assigned; this could be, for example, a resource ID of a voucher, campaign, earning rule, reward assignment, promotion tier, or distribution. (optional) 
            var rule = "rule_example";  // string | Validation rule ID. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = "order_example";  // string | Sorts the results using one of the filtering options: -created_at, created_at, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Validation Rules' Assignment(s)
                ValidationRulesAssignmentsListResponseBody result = apiInstance.ListValidationRulesAssignments(relatedObjectId, rule, page, limit, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.ListValidationRulesAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListValidationRulesAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Validation Rules' Assignment(s)
    ApiResponse<ValidationRulesAssignmentsListResponseBody> response = apiInstance.ListValidationRulesAssignmentsWithHttpInfo(relatedObjectId, rule, page, limit, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.ListValidationRulesAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relatedObjectId** | **string** | The resource ID to which the validation rule was assigned; this could be, for example, a resource ID of a voucher, campaign, earning rule, reward assignment, promotion tier, or distribution. | [optional]  |
| **rule** | **string** | Validation rule ID. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **string** | Sorts the results using one of the filtering options: -created_at, created_at, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**ValidationRulesAssignmentsListResponseBody**](ValidationRulesAssignmentsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a data property that contains an array of validation rule assignments. Each entry in the array is a separate object. If no more validation rule assignments are available, the resulting array will be empty. The result can be narrowed down according to default filters. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatevalidationrule"></a>
# **UpdateValidationRule**
> ValidationRulesUpdateResponseBody UpdateValidationRule (string validationRuleId, ValidationRulesUpdateRequestBody validationRulesUpdateRequestBody = null)

Update Validation Rule

Update validation rule parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateValidationRuleExample
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

            var apiInstance = new ValidationRulesApi(config);
            var validationRuleId = "validationRuleId_example";  // string | A unique validation rule ID.
            var validationRulesUpdateRequestBody = new ValidationRulesUpdateRequestBody(); // ValidationRulesUpdateRequestBody | Specify the parameters to be updated. (optional) 

            try
            {
                // Update Validation Rule
                ValidationRulesUpdateResponseBody result = apiInstance.UpdateValidationRule(validationRuleId, validationRulesUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationRulesApi.UpdateValidationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateValidationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Validation Rule
    ApiResponse<ValidationRulesUpdateResponseBody> response = apiInstance.UpdateValidationRuleWithHttpInfo(validationRuleId, validationRulesUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidationRulesApi.UpdateValidationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validationRuleId** | **string** | A unique validation rule ID. |  |
| **validationRulesUpdateRequestBody** | [**ValidationRulesUpdateRequestBody**](ValidationRulesUpdateRequestBody.md) | Specify the parameters to be updated. | [optional]  |

### Return type

[**ValidationRulesUpdateResponseBody**](ValidationRulesUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the validation rule object with the updated parameters. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

