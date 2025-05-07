# Voucherify.Api.PublicationsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePublication**](PublicationsApi.md#createpublication) | **POST** /v1/publications | Create Publication |
| [**CreatePublication1**](PublicationsApi.md#createpublication1) | **GET** /v1/publications/create | Create Publication |
| [**ListPublications**](PublicationsApi.md#listpublications) | **GET** /v1/publications | List Publications |

<a id="createpublication"></a>
# **CreatePublication**
> PublicationsCreateResponseBody CreatePublication (bool? joinOnce = null, PublicationsCreateRequestBody publicationsCreateRequestBody = null)

Create Publication

This method selects vouchers that are suitable for publication, adds a publish entry and returns the publication. A voucher is suitable for publication when its active and hasnt been published yet.    🚧 Clearly define the source of the voucher  You must clearly define which source you want to publish the voucher code from. It can either be a code from a campaign or a specific voucher identified by a code.    🚧 Publish multiple vouchers  In case you want to publish multiple vouchers within a single publication, you need to specify the campaign name and number of vouchers you want to publish.    📘 Auto-update campaign  In case you want to ensure the number of publishable codes increases automatically with the number of customers, you should use an **auto-update** campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreatePublicationExample
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

            var apiInstance = new PublicationsApi(config);
            var joinOnce = true;  // bool? | Through this flag, you can control if a particular person gets only one and always the same code even if the app sends multiple publication requests. It means that if you have a referral program, a referrer is assigned only to one code if an integration sends publication requests more than once for the same customer. (optional) 
            var publicationsCreateRequestBody = new PublicationsCreateRequestBody(); // PublicationsCreateRequestBody | Specify the publication parameters. (optional) 

            try
            {
                // Create Publication
                PublicationsCreateResponseBody result = apiInstance.CreatePublication(joinOnce, publicationsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicationsApi.CreatePublication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePublicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Publication
    ApiResponse<PublicationsCreateResponseBody> response = apiInstance.CreatePublicationWithHttpInfo(joinOnce, publicationsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicationsApi.CreatePublicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **joinOnce** | **bool?** | Through this flag, you can control if a particular person gets only one and always the same code even if the app sends multiple publication requests. It means that if you have a referral program, a referrer is assigned only to one code if an integration sends publication requests more than once for the same customer. | [optional]  |
| **publicationsCreateRequestBody** | [**PublicationsCreateRequestBody**](PublicationsCreateRequestBody.md) | Specify the publication parameters. | [optional]  |

### Return type

[**PublicationsCreateResponseBody**](PublicationsCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a publication object if a valid identifier was provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpublication1"></a>
# **CreatePublication1**
> PublicationsCreateResponseBody CreatePublication1 (Customer customer, bool? joinOnce = null, string voucher = null, CreatePublicationCampaign campaign = null, string sourceId = null, Object metadata = null)

Create Publication

This method selects vouchers that are suitable for publication, adds a publish entry and returns the publication. A voucher is suitable for publication when its active and hasnt been published yet.  ❗️ Limited access  Access to this endpoint is limited. This endpoint is designed for specific integrations and the API keys need to be configured to access this endpoint. Navigate to the **Dashboard** &rarr; **Project Settings** &rarr; **General** &rarr; **Integration Keys** to set up a pair of API keys and use them to send the request.    🚧 Clearly define the source of the voucher  You must clearly define which source you want to publish the voucher code from. It can either be a code from a campaign or a specific voucher identified by a code.    🚧 Publish multiple vouchers  This endpoint does not support the publishing of multiple vouchers from a single campaign. In case you want to publish multiple vouchers within a single publication, you need to use a dedicated endpoint.    📘 Auto-update campaign  In case you want to ensure the number of publishable codes increases automatically with the number of customers, you should use an **auto-update** campaign.   # Example Request      ❗️ Required    Query param voucher OR campaign MUST be filled out. If you provide both, campaign param will be skipped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreatePublication1Example
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

            var apiInstance = new PublicationsApi(config);
            var customer = new Customer(); // Customer | Contains information about the customer to whom the publication was directed.
            var joinOnce = true;  // bool? | Through this flag, you can control if a particular person gets only one and always the same code even if the app sends multiple publication requests. It means that if you have a referral program, a referrer is assigned only to one code if an integration sends publication requests more than once for the same customer. (optional) 
            var voucher = "voucher_example";  // string | Code of voucher being published. (optional) 
            var campaign = new CreatePublicationCampaign(); // CreatePublicationCampaign | Create publication with campaign. (optional) 
            var sourceId = "sourceId_example";  // string | The merchants publication ID if it is different from the Voucherify publication ID. Its an optional tracking identifier of a publication. It is really useful in case of an integration between multiple systems. It can be a publication ID from a CRM system, database or 3rd-party service. If source_id is provided only 1 voucher can be published per request. (optional) 
            var metadata = new Object(); // Object | The metadata object stores all custom attributes assigned to the publication. A set of key/value pairs that you can attach to a publication object. It can be useful for storing additional information about the publication in a structured format. (optional) 

            try
            {
                // Create Publication
                PublicationsCreateResponseBody result = apiInstance.CreatePublication1(customer, joinOnce, voucher, campaign, sourceId, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicationsApi.CreatePublication1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePublication1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Publication
    ApiResponse<PublicationsCreateResponseBody> response = apiInstance.CreatePublication1WithHttpInfo(customer, joinOnce, voucher, campaign, sourceId, metadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicationsApi.CreatePublication1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customer** | [**Customer**](Customer.md) | Contains information about the customer to whom the publication was directed. |  |
| **joinOnce** | **bool?** | Through this flag, you can control if a particular person gets only one and always the same code even if the app sends multiple publication requests. It means that if you have a referral program, a referrer is assigned only to one code if an integration sends publication requests more than once for the same customer. | [optional]  |
| **voucher** | **string** | Code of voucher being published. | [optional]  |
| **campaign** | [**CreatePublicationCampaign**](CreatePublicationCampaign.md) | Create publication with campaign. | [optional]  |
| **sourceId** | **string** | The merchants publication ID if it is different from the Voucherify publication ID. Its an optional tracking identifier of a publication. It is really useful in case of an integration between multiple systems. It can be a publication ID from a CRM system, database or 3rd-party service. If source_id is provided only 1 voucher can be published per request. | [optional]  |
| **metadata** | [**Object**](Object.md) | The metadata object stores all custom attributes assigned to the publication. A set of key/value pairs that you can attach to a publication object. It can be useful for storing additional information about the publication in a structured format. | [optional]  |

### Return type

[**PublicationsCreateResponseBody**](PublicationsCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a publication object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpublications"></a>
# **ListPublications**
> PublicationsListResponseBody ListPublications (int? limit = null, int? page = null, ParameterOrderListPublications? order = null, string campaign = null, string customer = null, string voucher = null, ParameterResultListPublications? result = null, ParameterVoucherTypeListPublications? voucherType = null, bool? isReferralCode = null, ParameterFiltersListPublications filters = null, string sourceId = null)

List Publications

Retrieve a list of publications. To return a **particular** publication, you can use the source_id query parameter and provide the source_id of the publication you are looking for specifically. # Pagination  🚧 Important!  If you want to scroll through a huge set of records, it is recommended to use the Exports API. This API will return an error page_over_limit if you reach a page above 1000. # Filter Query The filters query parameter allows for joining multiple parameters with logical operators. The syntax looks as follows:  ## Operators:  ## Examples  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListPublicationsExample
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

            var apiInstance = new PublicationsApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListPublications) "id";  // ParameterOrderListPublications? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var campaign = "campaign_example";  // string | Filters by a given campaign name. (optional) 
            var customer = "customer_example";  // string | Filters by a unique customer ID. (optional) 
            var voucher = "voucher_example";  // string | Filters by a given voucher code. (optional) 
            var result = (ParameterResultListPublications) "SUCCESS";  // ParameterResultListPublications? | Filters by a publication result. (optional) 
            var voucherType = (ParameterVoucherTypeListPublications) "discount";  // ParameterVoucherTypeListPublications? | Filters by a voucher type. (optional) 
            var isReferralCode = true;  // bool? | This filter works only for the true option. If set to true, the query returns only publications of codes from referral campaigns.  (optional) 
            var filters = new ParameterFiltersListPublications(); // ParameterFiltersListPublications | Filters for listing publications. (optional) 
            var sourceId = "sourceId_example";  // string | Using this endpoint with a particular publication source_id, which was sent with the original request to create a publication, returns in the response, exactly the same code published initially because the code was assigned to the given publication. As a result, you can use this endpoint as a reference and return a code that was assigned in a publication by using a particular source_id. (optional) 

            try
            {
                // List Publications
                PublicationsListResponseBody result = apiInstance.ListPublications(limit, page, order, campaign, customer, voucher, result, voucherType, isReferralCode, filters, sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicationsApi.ListPublications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPublicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Publications
    ApiResponse<PublicationsListResponseBody> response = apiInstance.ListPublicationsWithHttpInfo(limit, page, order, campaign, customer, voucher, result, voucherType, isReferralCode, filters, sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicationsApi.ListPublicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListPublications?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **campaign** | **string** | Filters by a given campaign name. | [optional]  |
| **customer** | **string** | Filters by a unique customer ID. | [optional]  |
| **voucher** | **string** | Filters by a given voucher code. | [optional]  |
| **result** | **ParameterResultListPublications?** | Filters by a publication result. | [optional]  |
| **voucherType** | **ParameterVoucherTypeListPublications?** | Filters by a voucher type. | [optional]  |
| **isReferralCode** | **bool?** | This filter works only for the true option. If set to true, the query returns only publications of codes from referral campaigns.  | [optional]  |
| **filters** | [**ParameterFiltersListPublications**](ParameterFiltersListPublications.md) | Filters for listing publications. | [optional]  |
| **sourceId** | **string** | Using this endpoint with a particular publication source_id, which was sent with the original request to create a publication, returns in the response, exactly the same code published initially because the code was assigned to the given publication. As a result, you can use this endpoint as a reference and return a code that was assigned in a publication by using a particular source_id. | [optional]  |

### Return type

[**PublicationsListResponseBody**](PublicationsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of publications you&#39;ve previously created with &lt;!- - [create publication](OpenAPI.json/paths/~1publications/post) - -&gt;[create publication](ref:create-publication) or implicitly by the distribution manager. The publications are returned in sorted order, with the most recent ones appearing first. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

