# Voucherify.Api.ManagementApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignUser**](ManagementApi.md#assignuser) | **POST** /management/v1/projects/{projectId}/users | Assign User |
| [**CreateBrand**](ManagementApi.md#createbrand) | **POST** /management/v1/projects/{projectId}/branding | Create Brand |
| [**CreateCustomEventSchema**](ManagementApi.md#createcustomeventschema) | **POST** /management/v1/projects/{projectId}/custom-event-schemas | Create Custom Event Schema |
| [**CreateMetadataSchema**](ManagementApi.md#createmetadataschema) | **POST** /management/v1/projects/{projectId}/metadata-schemas | Create Metadata Schema |
| [**CreateProject**](ManagementApi.md#createproject) | **POST** /management/v1/projects | Create Project |
| [**CreateStackingRules**](ManagementApi.md#createstackingrules) | **POST** /management/v1/projects/{projectId}/stacking-rules | Create Stacking Rules |
| [**CreateWebhook**](ManagementApi.md#createwebhook) | **POST** /management/v1/projects/{projectId}/webhooks | Create Webhook |
| [**DeleteBrand**](ManagementApi.md#deletebrand) | **DELETE** /management/v1/projects/{projectId}/branding/{brandingId} | Delete Brand |
| [**DeleteCustomEventSchema**](ManagementApi.md#deletecustomeventschema) | **DELETE** /management/v1/projects/{projectId}/custom-event-schemas/{customEventSchemaId} | Delete Custom Event Schema |
| [**DeleteMetadataSchema**](ManagementApi.md#deletemetadataschema) | **DELETE** /management/v1/projects/{projectId}/metadata-schemas/{metadataSchemaId} | Delete Metadata Schema |
| [**DeleteProject**](ManagementApi.md#deleteproject) | **DELETE** /management/v1/projects/{projectId} | Delete Project |
| [**DeleteStackingRules**](ManagementApi.md#deletestackingrules) | **DELETE** /management/v1/projects/{projectId}/stacking-rules/{stackingRulesId} | Delete Stacking Rules |
| [**DeleteWebhook**](ManagementApi.md#deletewebhook) | **DELETE** /management/v1/projects/{projectId}/webhooks/{webhookId} | Delete Webhook |
| [**GetBrand**](ManagementApi.md#getbrand) | **GET** /management/v1/projects/{projectId}/branding/{brandingId} | Get Brand |
| [**GetCustomEventSchema**](ManagementApi.md#getcustomeventschema) | **GET** /management/v1/projects/{projectId}/custom-event-schemas/{customEventSchemaId} | Get Custom Event Schema |
| [**GetMetadataSchema1**](ManagementApi.md#getmetadataschema1) | **GET** /management/v1/projects/{projectId}/metadata-schemas/{metadataSchemaId} | Get Metadata Schema |
| [**GetProject**](ManagementApi.md#getproject) | **GET** /management/v1/projects/{projectId} | Get Project |
| [**GetStackingRules**](ManagementApi.md#getstackingrules) | **GET** /management/v1/projects/{projectId}/stacking-rules/{stackingRulesId} | Get Stacking Rules |
| [**GetUser**](ManagementApi.md#getuser) | **GET** /management/v1/projects/{projectId}/users/{userId} | Get User |
| [**GetWebhook**](ManagementApi.md#getwebhook) | **GET** /management/v1/projects/{projectId}/webhooks/{webhookId} | Get Webhook |
| [**InviteUser**](ManagementApi.md#inviteuser) | **POST** /management/v1/projects/users/invite | Invite a New User |
| [**ListBrands**](ManagementApi.md#listbrands) | **GET** /management/v1/projects/{projectId}/branding | List Brands |
| [**ListCustomEventSchemas**](ManagementApi.md#listcustomeventschemas) | **GET** /management/v1/projects/{projectId}/custom-event-schemas | List Custom Event Schemas |
| [**ListMetadataSchemas1**](ManagementApi.md#listmetadataschemas1) | **GET** /management/v1/projects/{projectId}/metadata-schemas | List Metadata Schemas |
| [**ListProjects**](ManagementApi.md#listprojects) | **GET** /management/v1/projects | List Projects |
| [**ListStackingRules**](ManagementApi.md#liststackingrules) | **GET** /management/v1/projects/{projectId}/stacking-rules | List Stacking Rules |
| [**ListUsers**](ManagementApi.md#listusers) | **GET** /management/v1/projects/{projectId}/users | List Users |
| [**ListWebhooks**](ManagementApi.md#listwebhooks) | **GET** /management/v1/projects/{projectId}/webhooks | List Webhooks |
| [**ManagementCopyCampaignTemplate**](ManagementApi.md#managementcopycampaigntemplate) | **POST** /management/v1/projects/{projectId}/templates/campaigns/{campaignTemplateId}/copy | Copy Campaign Template to a Project |
| [**ManagementListCampaignTemplates**](ManagementApi.md#managementlistcampaigntemplates) | **GET** /management/v1/projects/{projectId}/templates/campaigns | List Campaign Templates |
| [**UnassignUser**](ManagementApi.md#unassignuser) | **DELETE** /management/v1/projects/{projectId}/users/{userId} | Unassign User |
| [**UpdateBrand**](ManagementApi.md#updatebrand) | **PUT** /management/v1/projects/{projectId}/branding/{brandingId} | Update Brand |
| [**UpdateCustomEventSchema**](ManagementApi.md#updatecustomeventschema) | **PUT** /management/v1/projects/{projectId}/custom-event-schemas/{customEventSchemaId} | Update Custom Event Schema |
| [**UpdateMetadataSchema**](ManagementApi.md#updatemetadataschema) | **PUT** /management/v1/projects/{projectId}/metadata-schemas/{metadataSchemaId} | Update Metadata Schema |
| [**UpdateProject**](ManagementApi.md#updateproject) | **PUT** /management/v1/projects/{projectId} | Update Project |
| [**UpdateStackingRules**](ManagementApi.md#updatestackingrules) | **PUT** /management/v1/projects/{projectId}/stacking-rules/{stackingRulesId} | Update Stacking Rules |
| [**UpdateUser**](ManagementApi.md#updateuser) | **PUT** /management/v1/projects/{projectId}/users/{userId} | Update User |
| [**UpdateWebhook**](ManagementApi.md#updatewebhook) | **PUT** /management/v1/projects/{projectId}/webhooks/{webhookId} | Update Webhook |

<a id="assignuser"></a>
# **AssignUser**
> ManagementProjectsUsersAssignResponseBody AssignUser (string projectId, ManagementProjectsUsersAssignRequestBody managementProjectsUsersAssignRequestBody = null)

Assign User

Assigns a user to a given project. The user must be an existing user in Voucherify.  🚧 Correct Use of Data To avoid errors, use the role key with either id or login keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class AssignUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var managementProjectsUsersAssignRequestBody = new ManagementProjectsUsersAssignRequestBody(); // ManagementProjectsUsersAssignRequestBody | Defines the user details. (optional) 

            try
            {
                // Assign User
                ManagementProjectsUsersAssignResponseBody result = apiInstance.AssignUser(projectId, managementProjectsUsersAssignRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.AssignUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssignUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign User
    ApiResponse<ManagementProjectsUsersAssignResponseBody> response = apiInstance.AssignUserWithHttpInfo(projectId, managementProjectsUsersAssignRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.AssignUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **managementProjectsUsersAssignRequestBody** | [**ManagementProjectsUsersAssignRequestBody**](ManagementProjectsUsersAssignRequestBody.md) | Defines the user details. | [optional]  |

### Return type

[**ManagementProjectsUsersAssignResponseBody**](ManagementProjectsUsersAssignResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the user assigned to the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbrand"></a>
# **CreateBrand**
> ManagementProjectsBrandingCreateResponseBody CreateBrand (string projectId, ManagementProjectsBrandingCreateRequestBody managementProjectsBrandingCreateRequestBody = null)

Create Brand

Creates a new brand configuration. You can have only one brand configured for a project.  📘 White Labelling  The white labelling settings which can be found in Project Settings > Brand Details and which are available only for Enterprise clients as a separate service can be configured only in the user interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var managementProjectsBrandingCreateRequestBody = new ManagementProjectsBrandingCreateRequestBody(); // ManagementProjectsBrandingCreateRequestBody | Defines a brand configuration. (optional) 

            try
            {
                // Create Brand
                ManagementProjectsBrandingCreateResponseBody result = apiInstance.CreateBrand(projectId, managementProjectsBrandingCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateBrand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBrandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Brand
    ApiResponse<ManagementProjectsBrandingCreateResponseBody> response = apiInstance.CreateBrandWithHttpInfo(projectId, managementProjectsBrandingCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateBrandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **managementProjectsBrandingCreateRequestBody** | [**ManagementProjectsBrandingCreateRequestBody**](ManagementProjectsBrandingCreateRequestBody.md) | Defines a brand configuration. | [optional]  |

### Return type

[**ManagementProjectsBrandingCreateResponseBody**](ManagementProjectsBrandingCreateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the brand configuration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcustomeventschema"></a>
# **CreateCustomEventSchema**
> ManagementProjectsCustomEventSchemasCreateResponseBody CreateCustomEventSchema (string projectId, ManagementProjectsCustomEventSchemasCreateRequestBody managementProjectsCustomEventSchemasCreateRequestBody = null)

Create Custom Event Schema

Creates a custom event schema. The properties object is required, but it can be empty, however. This object is for optional custom properties (metadata).  📘 Custom Event Documentation  Read [Custom Events](https://support.voucherify.io/article/111-custom-events) article to learn how custom events work in Voucherify. Read also the details about the Track Custom Event endpoint and the Custom Event Object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateCustomEventSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var managementProjectsCustomEventSchemasCreateRequestBody = new ManagementProjectsCustomEventSchemasCreateRequestBody(); // ManagementProjectsCustomEventSchemasCreateRequestBody | Defines the custom event schema. (optional) 

            try
            {
                // Create Custom Event Schema
                ManagementProjectsCustomEventSchemasCreateResponseBody result = apiInstance.CreateCustomEventSchema(projectId, managementProjectsCustomEventSchemasCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateCustomEventSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomEventSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Custom Event Schema
    ApiResponse<ManagementProjectsCustomEventSchemasCreateResponseBody> response = apiInstance.CreateCustomEventSchemaWithHttpInfo(projectId, managementProjectsCustomEventSchemasCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateCustomEventSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **managementProjectsCustomEventSchemasCreateRequestBody** | [**ManagementProjectsCustomEventSchemasCreateRequestBody**](ManagementProjectsCustomEventSchemasCreateRequestBody.md) | Defines the custom event schema. | [optional]  |

### Return type

[**ManagementProjectsCustomEventSchemasCreateResponseBody**](ManagementProjectsCustomEventSchemasCreateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the custom event schema. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmetadataschema"></a>
# **CreateMetadataSchema**
> ManagementProjectsMetadataSchemasCreateResponseBody CreateMetadataSchema (string projectId, ManagementProjectsMetadataSchemasCreateRequestBody managementProjectsMetadataSchemasCreateRequestBody = null)

Create Metadata Schema

Creates a new metadata (custom attribute) schema. The schema consists of a set of key-value pairs to customize Voucherify resources.  You can nest your object within a standard metadata schema, e.g. within a campaign or customer schema. However, your nested object cannot include another nested object. The standard metadata schemas are: - Campaign - Voucher - Publication - Redemption - Product - Customer - Order - Order line item - Loyalty Tier - Promotion Tier - Earning rule - Reward  📘 Metadata Documentation  Read the Getting Started with Metadata articles to learn how metadata work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateMetadataSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var managementProjectsMetadataSchemasCreateRequestBody = new ManagementProjectsMetadataSchemasCreateRequestBody(); // ManagementProjectsMetadataSchemasCreateRequestBody | Defines the metadata schema. (optional) 

            try
            {
                // Create Metadata Schema
                ManagementProjectsMetadataSchemasCreateResponseBody result = apiInstance.CreateMetadataSchema(projectId, managementProjectsMetadataSchemasCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateMetadataSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMetadataSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Metadata Schema
    ApiResponse<ManagementProjectsMetadataSchemasCreateResponseBody> response = apiInstance.CreateMetadataSchemaWithHttpInfo(projectId, managementProjectsMetadataSchemasCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateMetadataSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **managementProjectsMetadataSchemasCreateRequestBody** | [**ManagementProjectsMetadataSchemasCreateRequestBody**](ManagementProjectsMetadataSchemasCreateRequestBody.md) | Defines the metadata schema. | [optional]  |

### Return type

[**ManagementProjectsMetadataSchemasCreateResponseBody**](ManagementProjectsMetadataSchemasCreateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the metadata schema. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createproject"></a>
# **CreateProject**
> ManagementProjectsCreateResponseBody CreateProject (ManagementProjectsCreateRequestBody managementProjectsCreateRequestBody = null)

Create Project

Creates a new project. You can add users, specify the cluster, timezone, currency, and other details. All owners are added to the project by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var managementProjectsCreateRequestBody = new ManagementProjectsCreateRequestBody(); // ManagementProjectsCreateRequestBody | Define project details. (optional) 

            try
            {
                // Create Project
                ManagementProjectsCreateResponseBody result = apiInstance.CreateProject(managementProjectsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Project
    ApiResponse<ManagementProjectsCreateResponseBody> response = apiInstance.CreateProjectWithHttpInfo(managementProjectsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **managementProjectsCreateRequestBody** | [**ManagementProjectsCreateRequestBody**](ManagementProjectsCreateRequestBody.md) | Define project details. | [optional]  |

### Return type

[**ManagementProjectsCreateResponseBody**](ManagementProjectsCreateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details of a created project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createstackingrules"></a>
# **CreateStackingRules**
> ManagementProjectsStackingRulesCreateResponseBody CreateStackingRules (string projectId, ManagementProjectsStackingRulesCreateRequestBody managementProjectsStackingRulesCreateRequestBody = null)

Create Stacking Rules

Overwrites the default stacking rules. If new stacking rules have been created for the project earlier (e.g. in the user interface), it returns an error. Use Update Stacking Rules endpoint to change the rules.  📘 Stacking Rules Documentation  Read [the Stacking Rules article](https://support.voucherify.io/article/604-stacking-rules) to learn how they work.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateStackingRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var managementProjectsStackingRulesCreateRequestBody = new ManagementProjectsStackingRulesCreateRequestBody(); // ManagementProjectsStackingRulesCreateRequestBody | Defines the stacking rule parameters. (optional) 

            try
            {
                // Create Stacking Rules
                ManagementProjectsStackingRulesCreateResponseBody result = apiInstance.CreateStackingRules(projectId, managementProjectsStackingRulesCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateStackingRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStackingRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Stacking Rules
    ApiResponse<ManagementProjectsStackingRulesCreateResponseBody> response = apiInstance.CreateStackingRulesWithHttpInfo(projectId, managementProjectsStackingRulesCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateStackingRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **managementProjectsStackingRulesCreateRequestBody** | [**ManagementProjectsStackingRulesCreateRequestBody**](ManagementProjectsStackingRulesCreateRequestBody.md) | Defines the stacking rule parameters. | [optional]  |

### Return type

[**ManagementProjectsStackingRulesCreateResponseBody**](ManagementProjectsStackingRulesCreateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the stacking rules assigned to the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createwebhook"></a>
# **CreateWebhook**
> ManagementProjectsWebhooksCreateResponseBody CreateWebhook (string projectId, ManagementProjectsWebhooksCreateRequestBody managementProjectsWebhooksCreateRequestBody = null)

Create Webhook

Creates a new webhook configuration.  📘 Webhook Documentation  Read Webhooks v2024-01-01 article to learn how webhooks work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var managementProjectsWebhooksCreateRequestBody = new ManagementProjectsWebhooksCreateRequestBody(); // ManagementProjectsWebhooksCreateRequestBody | Defines a webhook configuration. (optional) 

            try
            {
                // Create Webhook
                ManagementProjectsWebhooksCreateResponseBody result = apiInstance.CreateWebhook(projectId, managementProjectsWebhooksCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CreateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Webhook
    ApiResponse<ManagementProjectsWebhooksCreateResponseBody> response = apiInstance.CreateWebhookWithHttpInfo(projectId, managementProjectsWebhooksCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.CreateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **managementProjectsWebhooksCreateRequestBody** | [**ManagementProjectsWebhooksCreateRequestBody**](ManagementProjectsWebhooksCreateRequestBody.md) | Defines a webhook configuration. | [optional]  |

### Return type

[**ManagementProjectsWebhooksCreateResponseBody**](ManagementProjectsWebhooksCreateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the webhook configuration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebrand"></a>
# **DeleteBrand**
> void DeleteBrand (string projectId, string brandingId)

Delete Brand

Deletes permanently a brand configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var brandingId = "brandingId_example";  // string | Provide the unique identifier of the brand configuration.

            try
            {
                // Delete Brand
                apiInstance.DeleteBrand(projectId, brandingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteBrand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBrandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Brand
    apiInstance.DeleteBrandWithHttpInfo(projectId, brandingId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteBrandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **brandingId** | **string** | Provide the unique identifier of the brand configuration. |  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the brand configuration has been successfully deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomeventschema"></a>
# **DeleteCustomEventSchema**
> void DeleteCustomEventSchema (string projectId, string customEventSchemaId)

Delete Custom Event Schema

Deletes permanently the custom event schema with its custom properties (metadata).  📘 Custom Event Documentation  Read [Custom Events](https://support.voucherify.io/article/111-custom-events) article to learn how custom events work in Voucherify. Read also the details about the Track Custom Event endpoint and the Custom Event Object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteCustomEventSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var customEventSchemaId = "customEventSchemaId_example";  // string | Provide the unique identifier of the custom event schema.

            try
            {
                // Delete Custom Event Schema
                apiInstance.DeleteCustomEventSchema(projectId, customEventSchemaId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteCustomEventSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomEventSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Custom Event Schema
    apiInstance.DeleteCustomEventSchemaWithHttpInfo(projectId, customEventSchemaId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteCustomEventSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **customEventSchemaId** | **string** | Provide the unique identifier of the custom event schema. |  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the custom event schema has been successfully deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemetadataschema"></a>
# **DeleteMetadataSchema**
> void DeleteMetadataSchema (string projectId, string metadataSchemaId)

Delete Metadata Schema

Deletes permanently the metadata schema. In standard metadata schemas, this endpoint removes permanently all definitions. The standard metadata schemas are: - Campaign - Voucher - Publication - Redemption - Product - Customer - Order - Order line item - Loyalty Tier - Promotion Tier - Earning rule - Reward If you want to delete only one definition, use the Update Metadata Schema endpoint. In the request, provide the deleted: true pair in the definition object. This definition will be moved to Removed definitions. If you want to create a new standard metadata schema, use the Create Metadata Schema endpoint.  🚧 Metadata Purging This endpoint deletes permanently the metadata schemas only. However, it does not purge the metadata from associated entities, so the metadata added to those entities will remain. If you want to purge metadata from the entities: 1. Remove all the definitions you want to purge. You can do this either in Voucherify Project Settings > Metadata Schema tab or with the Update Metadata Schema endpoint. 2. In Voucherify Project Settings > Metadata Schema tab, go to the relevant metadata schema. 3. In Removed definitions, click the bin button next to the definitions whose metadata you want to purge from entities. Note: - This is an asynchronous action. You will be notified when it has been completed. - You cannot purge metadata for the Redemption and Publication schemas. 4. Use the Delete Metadata Schema request to delete the metadata schema from Voucherify.  📘 Metadata Documentation  Read the Getting Started with Metadata articles to learn how metadata work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteMetadataSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var metadataSchemaId = "metadataSchemaId_example";  // string | Provide the unique identifier of the metadata schema.

            try
            {
                // Delete Metadata Schema
                apiInstance.DeleteMetadataSchema(projectId, metadataSchemaId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteMetadataSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMetadataSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Metadata Schema
    apiInstance.DeleteMetadataSchemaWithHttpInfo(projectId, metadataSchemaId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteMetadataSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **metadataSchemaId** | **string** | Provide the unique identifier of the metadata schema. |  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the metadata schema has been successfully deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteproject"></a>
# **DeleteProject**
> void DeleteProject (string projectId)

Delete Project

Deletes an existing project. The users currently using the deleted project will be automatically logged out.  🚧 Sandbox Project The sandbox project cannot be deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // Delete Project
                apiInstance.DeleteProject(projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Project
    apiInstance.DeleteProjectWithHttpInfo(projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if deletion is successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletestackingrules"></a>
# **DeleteStackingRules**
> void DeleteStackingRules (string projectId, string stackingRulesId)

Delete Stacking Rules

Deletes permanently the current settings for the stacking rules. The stacking rules are restored to default values.  📘 Stacking Rules Documentation  Read [the Stacking Rules article](https://support.voucherify.io/article/604-stacking-rules) to learn how they work.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteStackingRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var stackingRulesId = "stackingRulesId_example";  // string | Provide the unique identifier of the stacking rules.

            try
            {
                // Delete Stacking Rules
                apiInstance.DeleteStackingRules(projectId, stackingRulesId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteStackingRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStackingRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Stacking Rules
    apiInstance.DeleteStackingRulesWithHttpInfo(projectId, stackingRulesId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteStackingRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **stackingRulesId** | **string** | Provide the unique identifier of the stacking rules. |  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the stacking rules have been successfully deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (string projectId, string webhookId)

Delete Webhook

Deletes a webhook configuration.  📘 Webhook Documentation  Read Webhooks v2024-01-1 article to learn how webhooks work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var webhookId = "webhookId_example";  // string | Provide the unique identifier of the webhook configuration.

            try
            {
                // Delete Webhook
                apiInstance.DeleteWebhook(projectId, webhookId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.DeleteWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Webhook
    apiInstance.DeleteWebhookWithHttpInfo(projectId, webhookId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.DeleteWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **webhookId** | **string** | Provide the unique identifier of the webhook configuration. |  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the webhook configuration has been successfully deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbrand"></a>
# **GetBrand**
> ManagementProjectsBrandingGetResponseBody GetBrand (string projectId, string brandingId)

Get Brand

Retrieves a brand configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var brandingId = "brandingId_example";  // string | Provide the unique identifier of the brand configuration.

            try
            {
                // Get Brand
                ManagementProjectsBrandingGetResponseBody result = apiInstance.GetBrand(projectId, brandingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetBrand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Brand
    ApiResponse<ManagementProjectsBrandingGetResponseBody> response = apiInstance.GetBrandWithHttpInfo(projectId, brandingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetBrandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **brandingId** | **string** | Provide the unique identifier of the brand configuration. |  |

### Return type

[**ManagementProjectsBrandingGetResponseBody**](ManagementProjectsBrandingGetResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the brand configuration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomeventschema"></a>
# **GetCustomEventSchema**
> ManagementProjectsCustomEventSchemasGetResponseBody GetCustomEventSchema (string projectId, string customEventSchemaId)

Get Custom Event Schema

Retrieves a custom event schema.  📘 Custom Event Documentation  Read [Custom Events](https://support.voucherify.io/article/111-custom-events) article to learn how custom events work in Voucherify. Read also the details about the Track Custom Event endpoint and the Custom Event Object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetCustomEventSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var customEventSchemaId = "customEventSchemaId_example";  // string | Provide the unique identifier of the custom event schema.

            try
            {
                // Get Custom Event Schema
                ManagementProjectsCustomEventSchemasGetResponseBody result = apiInstance.GetCustomEventSchema(projectId, customEventSchemaId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetCustomEventSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomEventSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Custom Event Schema
    ApiResponse<ManagementProjectsCustomEventSchemasGetResponseBody> response = apiInstance.GetCustomEventSchemaWithHttpInfo(projectId, customEventSchemaId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetCustomEventSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **customEventSchemaId** | **string** | Provide the unique identifier of the custom event schema. |  |

### Return type

[**ManagementProjectsCustomEventSchemasGetResponseBody**](ManagementProjectsCustomEventSchemasGetResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the custom event schema. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmetadataschema1"></a>
# **GetMetadataSchema1**
> ManagementProjectsMetadataSchemasGetResponseBody GetMetadataSchema1 (string projectId, string metadataSchemaId)

Get Metadata Schema

Retrieves a metadata schema.  📘 Metadata Documentation  Read the Getting Started with Metadata articles to learn how metadata work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetMetadataSchema1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var metadataSchemaId = "metadataSchemaId_example";  // string | Provide the unique identifier of the metadata schema.

            try
            {
                // Get Metadata Schema
                ManagementProjectsMetadataSchemasGetResponseBody result = apiInstance.GetMetadataSchema1(projectId, metadataSchemaId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetMetadataSchema1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataSchema1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Metadata Schema
    ApiResponse<ManagementProjectsMetadataSchemasGetResponseBody> response = apiInstance.GetMetadataSchema1WithHttpInfo(projectId, metadataSchemaId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetMetadataSchema1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **metadataSchemaId** | **string** | Provide the unique identifier of the metadata schema. |  |

### Return type

[**ManagementProjectsMetadataSchemasGetResponseBody**](ManagementProjectsMetadataSchemasGetResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the metadata schema. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproject"></a>
# **GetProject**
> ManagementProjectsGetResponseBody GetProject (string projectId)

Get Project

Retrieves an existing project.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // Get Project
                ManagementProjectsGetResponseBody result = apiInstance.GetProject(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Project
    ApiResponse<ManagementProjectsGetResponseBody> response = apiInstance.GetProjectWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

[**ManagementProjectsGetResponseBody**](ManagementProjectsGetResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details of a project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstackingrules"></a>
# **GetStackingRules**
> ManagementProjectsStackingRulesGetResponseBody GetStackingRules (string projectId, string stackingRulesId)

Get Stacking Rules

Retrieves the stacking rules for the project.  📘 Stacking Rules Documentation  Read [the Stacking Rules article](https://support.voucherify.io/article/604-stacking-rules) to learn how they work.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetStackingRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var stackingRulesId = "stackingRulesId_example";  // string | Provide the unique identifier of the stacking rules.

            try
            {
                // Get Stacking Rules
                ManagementProjectsStackingRulesGetResponseBody result = apiInstance.GetStackingRules(projectId, stackingRulesId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetStackingRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStackingRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Stacking Rules
    ApiResponse<ManagementProjectsStackingRulesGetResponseBody> response = apiInstance.GetStackingRulesWithHttpInfo(projectId, stackingRulesId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetStackingRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **stackingRulesId** | **string** | Provide the unique identifier of the stacking rules. |  |

### Return type

[**ManagementProjectsStackingRulesGetResponseBody**](ManagementProjectsStackingRulesGetResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the stacking rules for the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuser"></a>
# **GetUser**
> ManagementProjectsUsersGetUserResponseBody GetUser (string projectId, string userId)

Get User

Retrieves the project users details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var userId = "userId_example";  // string | Provide the unique identifier of the user. Alternatively, provide the users login.

            try
            {
                // Get User
                ManagementProjectsUsersGetUserResponseBody result = apiInstance.GetUser(projectId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User
    ApiResponse<ManagementProjectsUsersGetUserResponseBody> response = apiInstance.GetUserWithHttpInfo(projectId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **userId** | **string** | Provide the unique identifier of the user. Alternatively, provide the users login. |  |

### Return type

[**ManagementProjectsUsersGetUserResponseBody**](ManagementProjectsUsersGetUserResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the project user&#39;s details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhook"></a>
# **GetWebhook**
> ManagementProjectsWebhooksGetResponseBody GetWebhook (string projectId, string webhookId)

Get Webhook

Retrieves a webhook configuration.  📘 Webhook Documentation  Read Webhooks v2024-01-1 article to learn how webhooks work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var webhookId = "webhookId_example";  // string | Provide the unique identifier of the webhook configuration.

            try
            {
                // Get Webhook
                ManagementProjectsWebhooksGetResponseBody result = apiInstance.GetWebhook(projectId, webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.GetWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Webhook
    ApiResponse<ManagementProjectsWebhooksGetResponseBody> response = apiInstance.GetWebhookWithHttpInfo(projectId, webhookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.GetWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **webhookId** | **string** | Provide the unique identifier of the webhook configuration. |  |

### Return type

[**ManagementProjectsWebhooksGetResponseBody**](ManagementProjectsWebhooksGetResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the webhook configuration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inviteuser"></a>
# **InviteUser**
> void InviteUser (ManagementProjectsUsersInviteCreateRequestBody managementProjectsUsersInviteCreateRequestBody = null)

Invite a New User

Sends an invitation to an email address that has not been used yet as a Voucherify user login. You can specify the projects to which the invited user will be assigned and define their roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class InviteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var managementProjectsUsersInviteCreateRequestBody = new ManagementProjectsUsersInviteCreateRequestBody(); // ManagementProjectsUsersInviteCreateRequestBody | Defines the details of the invitation, the project, and roles to which the user will be assigned. (optional) 

            try
            {
                // Invite a New User
                apiInstance.InviteUser(managementProjectsUsersInviteCreateRequestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.InviteUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InviteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite a New User
    apiInstance.InviteUserWithHttpInfo(managementProjectsUsersInviteCreateRequestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.InviteUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **managementProjectsUsersInviteCreateRequestBody** | [**ManagementProjectsUsersInviteCreateRequestBody**](ManagementProjectsUsersInviteCreateRequestBody.md) | Defines the details of the invitation, the project, and roles to which the user will be assigned. | [optional]  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the invitation has been sent successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listbrands"></a>
# **ListBrands**
> ManagementProjectsBrandingListResponseBody ListBrands (string projectId)

List Brands

Lists all brand configurations. Because a project can have only one brand, it always returns a list with one item. This endpoint can be used to retrieve the brand configuration created with the Voucherify Dashboard and the ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListBrandsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // List Brands
                ManagementProjectsBrandingListResponseBody result = apiInstance.ListBrands(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListBrands: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBrandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Brands
    ApiResponse<ManagementProjectsBrandingListResponseBody> response = apiInstance.ListBrandsWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListBrandsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

[**ManagementProjectsBrandingListResponseBody**](ManagementProjectsBrandingListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the brand created in the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcustomeventschemas"></a>
# **ListCustomEventSchemas**
> ManagementProjectsCustomEventSchemasListResponseBody ListCustomEventSchemas (string projectId)

List Custom Event Schemas

Lists all custom event schemas available in the project.  📘 Custom Event Documentation  Read [Custom Events](https://support.voucherify.io/article/111-custom-events) article to learn how custom events work in Voucherify. Read also the details about the Track Custom Event endpoint and the Custom Event Object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCustomEventSchemasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // List Custom Event Schemas
                ManagementProjectsCustomEventSchemasListResponseBody result = apiInstance.ListCustomEventSchemas(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListCustomEventSchemas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustomEventSchemasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Custom Event Schemas
    ApiResponse<ManagementProjectsCustomEventSchemasListResponseBody> response = apiInstance.ListCustomEventSchemasWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListCustomEventSchemasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

[**ManagementProjectsCustomEventSchemasListResponseBody**](ManagementProjectsCustomEventSchemasListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the custom event schemas created in the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmetadataschemas1"></a>
# **ListMetadataSchemas1**
> ManagementProjectsMetadataSchemasListResponseBody ListMetadataSchemas1 (string projectId)

List Metadata Schemas

Lists all metadata schemas available in the project.  📘 Metadata Documentation  Read the Getting Started with Metadata articles to learn how metadata work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMetadataSchemas1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // List Metadata Schemas
                ManagementProjectsMetadataSchemasListResponseBody result = apiInstance.ListMetadataSchemas1(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListMetadataSchemas1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMetadataSchemas1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Metadata Schemas
    ApiResponse<ManagementProjectsMetadataSchemasListResponseBody> response = apiInstance.ListMetadataSchemas1WithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListMetadataSchemas1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

[**ManagementProjectsMetadataSchemasListResponseBody**](ManagementProjectsMetadataSchemasListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the metadata schemas created in the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprojects"></a>
# **ListProjects**
> ManagementProjectsListResponseBody ListProjects ()

List Projects

Lists all projects for the organization. The endpoint does not require any query parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // List Projects
                ManagementProjectsListResponseBody result = apiInstance.ListProjects();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListProjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Projects
    ApiResponse<ManagementProjectsListResponseBody> response = apiInstance.ListProjectsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListProjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ManagementProjectsListResponseBody**](ManagementProjectsListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the list of all projects with their details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="liststackingrules"></a>
# **ListStackingRules**
> ManagementProjectsStackingRulesListResponseBody ListStackingRules (string projectId)

List Stacking Rules

Lists all stacking rules. Returns always a list with one item. This endpoint can be used to retrieve the default stacking rules. The default stacking rules do not have an ID that could be used with the Get Stacking Rules or Update Stacking Rules endpoints.  📘 Stacking Rules Documentation  Read [the Stacking Rules article](https://support.voucherify.io/article/604-stacking-rules) to learn how they work.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListStackingRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // List Stacking Rules
                ManagementProjectsStackingRulesListResponseBody result = apiInstance.ListStackingRules(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListStackingRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListStackingRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Stacking Rules
    ApiResponse<ManagementProjectsStackingRulesListResponseBody> response = apiInstance.ListStackingRulesWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListStackingRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

[**ManagementProjectsStackingRulesListResponseBody**](ManagementProjectsStackingRulesListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the stacking rules assigned to the project. These can be either the default stacking rules or the created ones. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listusers"></a>
# **ListUsers**
> ManagementProjectsUsersListResponseBody ListUsers (string projectId)

List Users

Lists all users assigned to the project.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // List Users
                ManagementProjectsUsersListResponseBody result = apiInstance.ListUsers(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Users
    ApiResponse<ManagementProjectsUsersListResponseBody> response = apiInstance.ListUsersWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

[**ManagementProjectsUsersListResponseBody**](ManagementProjectsUsersListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the list of all the users assigned to the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listwebhooks"></a>
# **ListWebhooks**
> ManagementProjectsWebhooksListResponseBody ListWebhooks (string projectId)

List Webhooks

Lists all webhook configurations for the project.  📘 Webhook Documentation  Read Webhooks v2024-01-1 article to learn how webhooks work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.

            try
            {
                // List Webhooks
                ManagementProjectsWebhooksListResponseBody result = apiInstance.ListWebhooks(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ListWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Webhooks
    ApiResponse<ManagementProjectsWebhooksListResponseBody> response = apiInstance.ListWebhooksWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ListWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |

### Return type

[**ManagementProjectsWebhooksListResponseBody**](ManagementProjectsWebhooksListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about webhook configurations created in the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="managementcopycampaigntemplate"></a>
# **ManagementCopyCampaignTemplate**
> ManagementProjectsTemplatesCampaignsCopyCreateResponseBody ManagementCopyCampaignTemplate (string projectId, string campaignTemplateId, ManagementProjectsTemplatesCampaignsCopyCreateRequestBody managementProjectsTemplatesCampaignsCopyCreateRequestBody = null)

Copy Campaign Template to a Project

Copies a campaign template to another project. The resources, like validation rules or products, will not be copied to the destination project yet. When the template is used to create a new campaign or add a new promotion tier, the resources will be created in the destination project.  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ManagementCopyCampaignTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var campaignTemplateId = "campaignTemplateId_example";  // string | Provide the unique identifier of the campaign template.
            var managementProjectsTemplatesCampaignsCopyCreateRequestBody = new ManagementProjectsTemplatesCampaignsCopyCreateRequestBody(); // ManagementProjectsTemplatesCampaignsCopyCreateRequestBody | Determines the details about the template in the destination project as well as the destination project itself. (optional) 

            try
            {
                // Copy Campaign Template to a Project
                ManagementProjectsTemplatesCampaignsCopyCreateResponseBody result = apiInstance.ManagementCopyCampaignTemplate(projectId, campaignTemplateId, managementProjectsTemplatesCampaignsCopyCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ManagementCopyCampaignTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ManagementCopyCampaignTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy Campaign Template to a Project
    ApiResponse<ManagementProjectsTemplatesCampaignsCopyCreateResponseBody> response = apiInstance.ManagementCopyCampaignTemplateWithHttpInfo(projectId, campaignTemplateId, managementProjectsTemplatesCampaignsCopyCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ManagementCopyCampaignTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **campaignTemplateId** | **string** | Provide the unique identifier of the campaign template. |  |
| **managementProjectsTemplatesCampaignsCopyCreateRequestBody** | [**ManagementProjectsTemplatesCampaignsCopyCreateRequestBody**](ManagementProjectsTemplatesCampaignsCopyCreateRequestBody.md) | Determines the details about the template in the destination project as well as the destination project itself. | [optional]  |

### Return type

[**ManagementProjectsTemplatesCampaignsCopyCreateResponseBody**](ManagementProjectsTemplatesCampaignsCopyCreateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the copied campaign template. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="managementlistcampaigntemplates"></a>
# **ManagementListCampaignTemplates**
> ManagementProjectsTemplatesCampaignsListResponseBody ManagementListCampaignTemplates (string projectId, int? limit = null, string startingAfterId = null, ParameterTemplatesList? order = null, bool? includeTotal = null, ParameterFiltersListTemplates filters = null)

List Campaign Templates

Lists all campaign templates available in the project.  👍 List Campaign Templates  This endpoint works in the same way as the List Campaign Templates endpoint.  📘 Campaign Templates – Documentation Read the [Campaign Templates documentation](https://support.voucherify.io/article/620-campaign-templates) to learn more about this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ManagementListCampaignTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the campaign templates created after a template with the given ID. (optional) 
            var order = (ParameterTemplatesList) "id";  // ParameterTemplatesList? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var includeTotal = true;  // bool? | If set to true, the response returns the number of all campaign templates, regardless of the applied filters or limits. Set to false by default. (optional) 
            var filters = new ParameterFiltersListTemplates(); // ParameterFiltersListTemplates | Filters for listing templates. (optional) 

            try
            {
                // List Campaign Templates
                ManagementProjectsTemplatesCampaignsListResponseBody result = apiInstance.ManagementListCampaignTemplates(projectId, limit, startingAfterId, order, includeTotal, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.ManagementListCampaignTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ManagementListCampaignTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Campaign Templates
    ApiResponse<ManagementProjectsTemplatesCampaignsListResponseBody> response = apiInstance.ManagementListCampaignTemplatesWithHttpInfo(projectId, limit, startingAfterId, order, includeTotal, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.ManagementListCampaignTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the campaign templates created after a template with the given ID. | [optional]  |
| **order** | **ParameterTemplatesList?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **includeTotal** | **bool?** | If set to true, the response returns the number of all campaign templates, regardless of the applied filters or limits. Set to false by default. | [optional]  |
| **filters** | [**ParameterFiltersListTemplates**](ParameterFiltersListTemplates.md) | Filters for listing templates. | [optional]  |

### Return type

[**ManagementProjectsTemplatesCampaignsListResponseBody**](ManagementProjectsTemplatesCampaignsListResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of campaign template objects. The templates are returned by creation date by default. The most recent objects appear last unless specified otherwise with the &#x60;order&#x60; parameter. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unassignuser"></a>
# **UnassignUser**
> void UnassignUser (string projectId, string userId)

Unassign User

Unassigns the user from the project. If the user is currently logged in, they are automatically logged out. If the user is assigned to only one project, they cannot be unassigned from that project.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UnassignUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var userId = "userId_example";  // string | Provide the unique identifier of the user. Alternatively, provide the users login.

            try
            {
                // Unassign User
                apiInstance.UnassignUser(projectId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UnassignUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnassignUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unassign User
    apiInstance.UnassignUserWithHttpInfo(projectId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UnassignUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **userId** | **string** | Provide the unique identifier of the user. Alternatively, provide the users login. |  |

### Return type

void (empty response body)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the user has been successfully unnassigned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatebrand"></a>
# **UpdateBrand**
> ManagementProjectsBrandingUpdateResponseBody UpdateBrand (string projectId, string brandingId, ManagementProjectsBrandingUpdateRequestBody managementProjectsBrandingUpdateRequestBody = null)

Update Brand

Updates a brand configuration. Only the fields sent in the request will be updated. The fields omitted in the request will remain unchanged.  📘 White Labelling  The white labelling settings which can be found in Project Settings > Brand Details and which are available only for Enterprise clients as a separate service can be configured only in the user interface.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var brandingId = "brandingId_example";  // string | Provide the unique identifier of the brand configuration.
            var managementProjectsBrandingUpdateRequestBody = new ManagementProjectsBrandingUpdateRequestBody(); // ManagementProjectsBrandingUpdateRequestBody | Defines the brand configuration to be updated. (optional) 

            try
            {
                // Update Brand
                ManagementProjectsBrandingUpdateResponseBody result = apiInstance.UpdateBrand(projectId, brandingId, managementProjectsBrandingUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateBrand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBrandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Brand
    ApiResponse<ManagementProjectsBrandingUpdateResponseBody> response = apiInstance.UpdateBrandWithHttpInfo(projectId, brandingId, managementProjectsBrandingUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateBrandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **brandingId** | **string** | Provide the unique identifier of the brand configuration. |  |
| **managementProjectsBrandingUpdateRequestBody** | [**ManagementProjectsBrandingUpdateRequestBody**](ManagementProjectsBrandingUpdateRequestBody.md) | Defines the brand configuration to be updated. | [optional]  |

### Return type

[**ManagementProjectsBrandingUpdateResponseBody**](ManagementProjectsBrandingUpdateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the updated brand configuration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecustomeventschema"></a>
# **UpdateCustomEventSchema**
> ManagementProjectsCustomEventSchemasUpdateResponseBody UpdateCustomEventSchema (string projectId, string customEventSchemaId, ManagementProjectsCustomEventSchemasUpdateRequestBody managementProjectsCustomEventSchemasUpdateRequestBody = null)

Update Custom Event Schema

Updates a custom event schema. With this request, you can: - Add a nonexistent property to a custom event schema. - Update an existing property. In the request, you can provide only those properties you want to add or update. Definitions omitted in the request remain unchanged.  👍 Additional Notes - You can change the type of an existing property, e.g. from string to number. - You can remove a custom property with this endpoint by providing deleted: true in the request. However, you cannot permanently remove an event definition or its property with this endpoint.  📘 Custom Event Documentation  Read [Custom Events](https://support.voucherify.io/article/111-custom-events) article to learn how custom events work in Voucherify. Read also the details about the Track Custom Event endpoint and the Custom Event Object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateCustomEventSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var customEventSchemaId = "customEventSchemaId_example";  // string | Provide the unique identifier of the custom event schema.
            var managementProjectsCustomEventSchemasUpdateRequestBody = new ManagementProjectsCustomEventSchemasUpdateRequestBody(); // ManagementProjectsCustomEventSchemasUpdateRequestBody | Defines the custom event schema to be updated. (optional) 

            try
            {
                // Update Custom Event Schema
                ManagementProjectsCustomEventSchemasUpdateResponseBody result = apiInstance.UpdateCustomEventSchema(projectId, customEventSchemaId, managementProjectsCustomEventSchemasUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateCustomEventSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomEventSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Custom Event Schema
    ApiResponse<ManagementProjectsCustomEventSchemasUpdateResponseBody> response = apiInstance.UpdateCustomEventSchemaWithHttpInfo(projectId, customEventSchemaId, managementProjectsCustomEventSchemasUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateCustomEventSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **customEventSchemaId** | **string** | Provide the unique identifier of the custom event schema. |  |
| **managementProjectsCustomEventSchemasUpdateRequestBody** | [**ManagementProjectsCustomEventSchemasUpdateRequestBody**](ManagementProjectsCustomEventSchemasUpdateRequestBody.md) | Defines the custom event schema to be updated. | [optional]  |

### Return type

[**ManagementProjectsCustomEventSchemasUpdateResponseBody**](ManagementProjectsCustomEventSchemasUpdateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the updated custom event schema. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemetadataschema"></a>
# **UpdateMetadataSchema**
> ManagementProjectsMetadataSchemasUpdateResponseBody UpdateMetadataSchema (string projectId, string metadataSchemaId, ManagementProjectsMetadataSchemasUpdateRequestBody managementProjectsMetadataSchemasUpdateRequestBody = null)

Update Metadata Schema

Updates a metadata schema. With this request, you can: - Add a nonexistent attribute definition to the metadata schema. - Update an existing attribute definition by overwriting its current values. In the request, you can provide only those definitions you want to add or update. Definitions omitted in the request remain unchanged. However, if you want to update a definition, you will have to add all its current key-value pairs as well. Only the pairs sent in the request are saved for this definition. This means that the key-value pairs that are not sent in a request are restored to default values. For example, if your definition has an array with values and it is not sent in an update request, the array values will be deleted.  👍 Additional Notes - You cannot change the type of an existing schema, e.g. from string to number. - You can remove a definition with this endpoint by providing deleted: true in the request. It will be moved to the Removed definitions section in the user interface. However, you cannot permanently remove a definition with this endpoint.  📘 Metadata Documentation  Read the Getting Started with Metadata articles to learn how metadata work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateMetadataSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var metadataSchemaId = "metadataSchemaId_example";  // string | Provide the unique identifier of the metadata schema.
            var managementProjectsMetadataSchemasUpdateRequestBody = new ManagementProjectsMetadataSchemasUpdateRequestBody(); // ManagementProjectsMetadataSchemasUpdateRequestBody | Defines the metadata schema to be updated. (optional) 

            try
            {
                // Update Metadata Schema
                ManagementProjectsMetadataSchemasUpdateResponseBody result = apiInstance.UpdateMetadataSchema(projectId, metadataSchemaId, managementProjectsMetadataSchemasUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateMetadataSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMetadataSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Metadata Schema
    ApiResponse<ManagementProjectsMetadataSchemasUpdateResponseBody> response = apiInstance.UpdateMetadataSchemaWithHttpInfo(projectId, metadataSchemaId, managementProjectsMetadataSchemasUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateMetadataSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **metadataSchemaId** | **string** | Provide the unique identifier of the metadata schema. |  |
| **managementProjectsMetadataSchemasUpdateRequestBody** | [**ManagementProjectsMetadataSchemasUpdateRequestBody**](ManagementProjectsMetadataSchemasUpdateRequestBody.md) | Defines the metadata schema to be updated. | [optional]  |

### Return type

[**ManagementProjectsMetadataSchemasUpdateResponseBody**](ManagementProjectsMetadataSchemasUpdateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the updated metadata schema. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproject"></a>
# **UpdateProject**
> ManagementProjectsUpdateResponseBody UpdateProject (string projectId, ManagementProjectsUpdateRequestBody managementProjectsUpdateRequestBody = null)

Update Project

Updates an existing project. You can add or modify settings for timezone, currency, notifications, and other details. Only the fields sent in the request will be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var managementProjectsUpdateRequestBody = new ManagementProjectsUpdateRequestBody(); // ManagementProjectsUpdateRequestBody | Define the project details to be updated. (optional) 

            try
            {
                // Update Project
                ManagementProjectsUpdateResponseBody result = apiInstance.UpdateProject(projectId, managementProjectsUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Project
    ApiResponse<ManagementProjectsUpdateResponseBody> response = apiInstance.UpdateProjectWithHttpInfo(projectId, managementProjectsUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **managementProjectsUpdateRequestBody** | [**ManagementProjectsUpdateRequestBody**](ManagementProjectsUpdateRequestBody.md) | Define the project details to be updated. | [optional]  |

### Return type

[**ManagementProjectsUpdateResponseBody**](ManagementProjectsUpdateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details of an updated project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatestackingrules"></a>
# **UpdateStackingRules**
> ManagementProjectsStackingRulesUpdateResponseBody UpdateStackingRules (string projectId, string stackingRulesId, ManagementProjectsStackingRulesUpdateRequestBody managementProjectsStackingRulesUpdateRequestBody = null)

Update Stacking Rules

Updates the stacking rules. Only the provided fields will be updated. However, if you update an array, the content of the array is overwritten. This means that if you want to add new values to an array and retain existing ones, you need to provide both the existing and new values in the request.  📘 Stacking Rules Documentation  Read [the Stacking Rules article](https://support.voucherify.io/article/604-stacking-rules) to learn how they work.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateStackingRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var stackingRulesId = "stackingRulesId_example";  // string | Provide the unique identifier of the stacking rules.
            var managementProjectsStackingRulesUpdateRequestBody = new ManagementProjectsStackingRulesUpdateRequestBody(); // ManagementProjectsStackingRulesUpdateRequestBody | Defines the stacking rules to be updated. (optional) 

            try
            {
                // Update Stacking Rules
                ManagementProjectsStackingRulesUpdateResponseBody result = apiInstance.UpdateStackingRules(projectId, stackingRulesId, managementProjectsStackingRulesUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateStackingRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateStackingRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Stacking Rules
    ApiResponse<ManagementProjectsStackingRulesUpdateResponseBody> response = apiInstance.UpdateStackingRulesWithHttpInfo(projectId, stackingRulesId, managementProjectsStackingRulesUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateStackingRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **stackingRulesId** | **string** | Provide the unique identifier of the stacking rules. |  |
| **managementProjectsStackingRulesUpdateRequestBody** | [**ManagementProjectsStackingRulesUpdateRequestBody**](ManagementProjectsStackingRulesUpdateRequestBody.md) | Defines the stacking rules to be updated. | [optional]  |

### Return type

[**ManagementProjectsStackingRulesUpdateResponseBody**](ManagementProjectsStackingRulesUpdateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the updated stacking rules. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateuser"></a>
# **UpdateUser**
> ManagementProjectsUsersUpdateRoleResponseBody UpdateUser (string projectId, string userId, ManagementProjectsUsersUpdateRoleRequestBody managementProjectsUsersUpdateRoleRequestBody = null)

Update User

Updates the users role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var userId = "userId_example";  // string | Provide the unique identifier of the user. Alternatively, provide the users login.
            var managementProjectsUsersUpdateRoleRequestBody = new ManagementProjectsUsersUpdateRoleRequestBody(); // ManagementProjectsUsersUpdateRoleRequestBody | Defines the users new role. (optional) 

            try
            {
                // Update User
                ManagementProjectsUsersUpdateRoleResponseBody result = apiInstance.UpdateUser(projectId, userId, managementProjectsUsersUpdateRoleRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User
    ApiResponse<ManagementProjectsUsersUpdateRoleResponseBody> response = apiInstance.UpdateUserWithHttpInfo(projectId, userId, managementProjectsUsersUpdateRoleRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **userId** | **string** | Provide the unique identifier of the user. Alternatively, provide the users login. |  |
| **managementProjectsUsersUpdateRoleRequestBody** | [**ManagementProjectsUsersUpdateRoleRequestBody**](ManagementProjectsUsersUpdateRoleRequestBody.md) | Defines the users new role. | [optional]  |

### Return type

[**ManagementProjectsUsersUpdateRoleResponseBody**](ManagementProjectsUsersUpdateRoleResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the user assigned to the project. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewebhook"></a>
# **UpdateWebhook**
> ManagementProjectsWebhooksUpdateResponseBody UpdateWebhook (string projectId, string webhookId, ManagementProjectsWebhooksUpdateRequestBody managementProjectsWebhooksUpdateRequestBody = null)

Update Webhook

Updates a webhook configuration. The events listed in the request are overwritten. If you want to add more events, provide also the events that are already in the webhook configuration.  📘 Webhook Documentation  Read Webhooks v2024-01-1 article to learn how webhooks work in Voucherify.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-Management-Token
            config.AddApiKey("X-Management-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Token", "Bearer");
            // Configure API key authorization: X-Management-Id
            config.AddApiKey("X-Management-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Management-Id", "Bearer");

            var apiInstance = new ManagementApi(config);
            var projectId = "projectId_example";  // string | Provide the unique identifier of the project.
            var webhookId = "webhookId_example";  // string | Provide the unique identifier of the webhook configuration.
            var managementProjectsWebhooksUpdateRequestBody = new ManagementProjectsWebhooksUpdateRequestBody(); // ManagementProjectsWebhooksUpdateRequestBody | Defines the webhook configuration to be updated. (optional) 

            try
            {
                // Update Webhook
                ManagementProjectsWebhooksUpdateResponseBody result = apiInstance.UpdateWebhook(projectId, webhookId, managementProjectsWebhooksUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Webhook
    ApiResponse<ManagementProjectsWebhooksUpdateResponseBody> response = apiInstance.UpdateWebhookWithHttpInfo(projectId, webhookId, managementProjectsWebhooksUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagementApi.UpdateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Provide the unique identifier of the project. |  |
| **webhookId** | **string** | Provide the unique identifier of the webhook configuration. |  |
| **managementProjectsWebhooksUpdateRequestBody** | [**ManagementProjectsWebhooksUpdateRequestBody**](ManagementProjectsWebhooksUpdateRequestBody.md) | Defines the webhook configuration to be updated. | [optional]  |

### Return type

[**ManagementProjectsWebhooksUpdateResponseBody**](ManagementProjectsWebhooksUpdateResponseBody.md)

### Authorization

[X-Management-Token](../README.md#X-Management-Token), [X-Management-Id](../README.md#X-Management-Id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the details about the updated webhook configuration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

