# Voucherify.Api.LV2ProgramsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchCreateProgramMembers**](LV2ProgramsApi.md#batchcreateprogrammembers) | **POST** /v2/loyalties/programs/{programId}/members/batch | Batch create program members |
| [**CreateMemberOrderPayment**](LV2ProgramsApi.md#creatememberorderpayment) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/orders/payments | Pay for order with points |
| [**CreateProgramMember**](LV2ProgramsApi.md#createprogrammember) | **POST** /v2/loyalties/programs/{programId}/members | Create program member |
| [**GetProgramMember**](LV2ProgramsApi.md#getprogrammember) | **GET** /v2/loyalties/programs/{programId}/members/{memberId} | Get program member |
| [**GetProgramMembership**](LV2ProgramsApi.md#getprogrammembership) | **GET** /v2/loyalties/programs/{programId}/memberships/{customerId} | Get program membership |
| [**ListCardTransactions**](LV2ProgramsApi.md#listcardtransactions) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/transactions | List card transactions |
| [**ListMemberOrderPayments**](LV2ProgramsApi.md#listmemberorderpayments) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/orders/payments | List member order payments |
| [**ListMemberRewardPurchases**](LV2ProgramsApi.md#listmemberrewardpurchases) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/rewards/purchases | List member reward purchases |
| [**PurchaseMemberReward**](LV2ProgramsApi.md#purchasememberreward) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/rewards/purchases | Purchase reward with points |

<a id="batchcreateprogrammembers"></a>
# **BatchCreateProgramMembers**
> LoyaltiesProgramsMembersCreateInBulkResponseBody BatchCreateProgramMembers (string programId, List<MemberCreate> memberCreate)

Batch create program members

Schedules creation of program members from a JSON array and returns 202 with async_action_id. The program must exist, be ACTIVE, and be inside its validity window. The body isnt checked before that response. Entries are processed in batches of 100. The raw body must be at most 10 MB. Each entry uses the same fields as [Create program member](/api-reference/programs/create-program-member). A failed entry is skipped. Its report row sets created to false and explains the failure in error. Skipped cases include an invalid customer_identification, an unknown customer, an invalid status, a duplicate customer in the batch (Duplicate customer ID), a customer who is already a member (Member already exists), metadata that doesnt match the vl_member schema, and entries past the loyalty members plan limit. Successful entries enroll the customer and create a loyalty card for each card definition on the program. Report columns are identification_type, customer_id, customer_source_id, program_id, member_id, created, and error. An empty array or a null entry fails the async action with invalid_request_payload. A body that isnt a JSON array fails it with top_level_object_should_be_an_array. Use [Get async action](/api-reference/async-actions/get-async-action) to read the status and the report. You can also open the result from Audit log, [Background tasks](/analyze/audit-logs#background-tasks).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class BatchCreateProgramMembersExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Unique loyalty program ID (format lprg_[a-f0-9]+).
            var memberCreate = new List<MemberCreate>(); // List<MemberCreate> | 

            try
            {
                // Batch create program members
                LoyaltiesProgramsMembersCreateInBulkResponseBody result = apiInstance.BatchCreateProgramMembers(programId, memberCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.BatchCreateProgramMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchCreateProgramMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch create program members
    ApiResponse<LoyaltiesProgramsMembersCreateInBulkResponseBody> response = apiInstance.BatchCreateProgramMembersWithHttpInfo(programId, memberCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.BatchCreateProgramMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Unique loyalty program ID (format lprg_[a-f0-9]+). |  |
| **memberCreate** | [**List&lt;MemberCreate&gt;**](MemberCreate.md) |  |  |

### Return type

[**LoyaltiesProgramsMembersCreateInBulkResponseBody**](LoyaltiesProgramsMembersCreateInBulkResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The batch is scheduled. Use &#x60;async_action_id&#x60; to follow processing. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creatememberorderpayment"></a>
# **CreateMemberOrderPayment**
> LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody CreateMemberOrderPayment (string programId, string memberId, LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody loyaltiesProgramsMembersOrdersPaymentsCreateRequestBody)

Pay for order with points

Pays for an order with points from the members card. The amount and points come from the card definitions pay-with-points exchange ratio, limited by the order total, the card balance, card spending caps, and the optional payment_limit. The binding cap is returned as details.spending_cap. The program and member must be ACTIVE, and the program must be inside its validity window. The card must belong to the member. The card definition must have pay-with-points enabled and an exchange-ratio formula. The order must already exist, identified by id or source_id. Modes: - TRANSACTION (default): creates a PENDING order transaction and a PENDING card transaction. Returns 202. The same order can be paid again; each call creates a new transaction. - DRY_RUN: simulates the payment and doesnt create a transaction. Returns 200 with status SIMULATED.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateMemberOrderPaymentExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Identifies the loyalty program (lprg_ followed by hexadecimal characters).
            var memberId = "memberId_example";  // string | Identifies the program member (lmbr_[a-f0-9]+).
            var loyaltiesProgramsMembersOrdersPaymentsCreateRequestBody = new LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody(); // LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody | 

            try
            {
                // Pay for order with points
                LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody result = apiInstance.CreateMemberOrderPayment(programId, memberId, loyaltiesProgramsMembersOrdersPaymentsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.CreateMemberOrderPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMemberOrderPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pay for order with points
    ApiResponse<LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody> response = apiInstance.CreateMemberOrderPaymentWithHttpInfo(programId, memberId, loyaltiesProgramsMembersOrdersPaymentsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.CreateMemberOrderPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program (lprg_ followed by hexadecimal characters). |  |
| **memberId** | **string** | Identifies the program member (lmbr_[a-f0-9]+). |  |
| **loyaltiesProgramsMembersOrdersPaymentsCreateRequestBody** | [**LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody**](LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody.md) |  |  |

### Return type

[**LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody**](LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dry run result (mode &#x60;DRY_RUN&#x60;). No transaction was created; the returned transaction has status &#x60;SIMULATED&#x60; and no &#x60;id&#x60;. and Payment accepted (mode &#x60;TRANSACTION&#x60;). A &#x60;PENDING&#x60; order transaction was created and will be processed asynchronously. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createprogrammember"></a>
# **CreateProgramMember**
> LoyaltiesProgramsMembersCreateResponseBody CreateProgramMember (string programId, LoyaltiesProgramsMembersCreateRequestBody loyaltiesProgramsMembersCreateRequestBody)

Create program member

Enrolls an existing customer as a member of the loyalty program and creates a loyalty card for each card definition assigned to the program. Card code generation is asynchronous, so code can be null right after creation. The program must be ACTIVE and inside its validity window, and the customer must already exist. A customer can be a member of a program only once. Identify the customer with customer_identification. status defaults to ACTIVE.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateProgramMemberExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Unique loyalty program ID (format lprg_[a-f0-9]+).
            var loyaltiesProgramsMembersCreateRequestBody = new LoyaltiesProgramsMembersCreateRequestBody(); // LoyaltiesProgramsMembersCreateRequestBody | 

            try
            {
                // Create program member
                LoyaltiesProgramsMembersCreateResponseBody result = apiInstance.CreateProgramMember(programId, loyaltiesProgramsMembersCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.CreateProgramMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProgramMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create program member
    ApiResponse<LoyaltiesProgramsMembersCreateResponseBody> response = apiInstance.CreateProgramMemberWithHttpInfo(programId, loyaltiesProgramsMembersCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.CreateProgramMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Unique loyalty program ID (format lprg_[a-f0-9]+). |  |
| **loyaltiesProgramsMembersCreateRequestBody** | [**LoyaltiesProgramsMembersCreateRequestBody**](LoyaltiesProgramsMembersCreateRequestBody.md) |  |  |

### Return type

[**LoyaltiesProgramsMembersCreateResponseBody**](LoyaltiesProgramsMembersCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created member with its automatically created cards. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprogrammember"></a>
# **GetProgramMember**
> MemberWithCards GetProgramMember (string programId, string memberId)

Get program member

 <Info> <Badge color gray>Documentation in progress</Badge> This documentation is in progress. The parameters, fields, request and response bodies, and other data may be subject to change. If you need more information or you want to share feedback, contact [Voucherify support](https://www.voucherify.io/contact-support) or your Technical Account Manager. </Info> Returns one member of the program together with that members loyalty cards. Each card includes balance, lifetime_bucket, next_expiration, and next_activation. tier_progress is not included. Use [Get program membership](/api-reference/programs/get-program-membership) when you need tier progress. card.code can be null shortly after member creation, while code generation is still running. Returns 404 when the program doesnt exist, or when the member doesnt exist in that program. The program is checked first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetProgramMemberExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Unique loyalty program ID (format lprg_[a-f0-9]+).
            var memberId = "memberId_example";  // string | Program member ID (format lmbr_[a-f0-9]+).

            try
            {
                // Get program member
                MemberWithCards result = apiInstance.GetProgramMember(programId, memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.GetProgramMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgramMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get program member
    ApiResponse<MemberWithCards> response = apiInstance.GetProgramMemberWithHttpInfo(programId, memberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.GetProgramMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Unique loyalty program ID (format lprg_[a-f0-9]+). |  |
| **memberId** | **string** | Program member ID (format lmbr_[a-f0-9]+). |  |

### Return type

[**MemberWithCards**](MemberWithCards.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The member with its cards. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprogrammembership"></a>
# **GetProgramMembership**
> LoyaltiesProgramsMembershipsGetResponseBody GetProgramMembership (string programId, string customerId, string identificationType = null)

Get program membership

Returns the membership for one customer in the program: the member, the program, and the members loyalty cards. A card includes tier_progress when its card definition has a tier structure and the member has a tier on that card. Otherwise tier_progress is omitted. identification_type chooses how customerId is read. It defaults to customer_id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetProgramMembershipExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Unique loyalty program ID (format lprg_[a-f0-9]+).
            var customerId = "customerId_example";  // string | Unique identifier of the customer or member, interpreted according to identification_type: a Voucherify customer ID (cust_...), a customer source_id, or a loyalty member ID (lmbr_...).
            var identificationType = "customer_id";  // string | Chooses how customerId is read. customer_id is the Voucherify customer ID and the default. customer_source_id is the customers source_id. member_id is the loyalty member ID. (optional)  (default to customer_id)

            try
            {
                // Get program membership
                LoyaltiesProgramsMembershipsGetResponseBody result = apiInstance.GetProgramMembership(programId, customerId, identificationType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.GetProgramMembership: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgramMembershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get program membership
    ApiResponse<LoyaltiesProgramsMembershipsGetResponseBody> response = apiInstance.GetProgramMembershipWithHttpInfo(programId, customerId, identificationType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.GetProgramMembershipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Unique loyalty program ID (format lprg_[a-f0-9]+). |  |
| **customerId** | **string** | Unique identifier of the customer or member, interpreted according to identification_type: a Voucherify customer ID (cust_...), a customer source_id, or a loyalty member ID (lmbr_...). |  |
| **identificationType** | **string** | Chooses how customerId is read. customer_id is the Voucherify customer ID and the default. customer_source_id is the customers source_id. member_id is the loyalty member ID. | [optional] [default to customer_id] |

### Return type

[**LoyaltiesProgramsMembershipsGetResponseBody**](LoyaltiesProgramsMembershipsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The membership in the program. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcardtransactions"></a>
# **ListCardTransactions**
> LoyaltiesProgramsMembersCardsTransactionsListResponseBody ListCardTransactions (string programId, string memberId, string cardId, int? limit = null, string order = null, string cursor = null, LoyaltiesProgramsMembersCardsTransactionsListRequestQuery filters = null)

List card transactions

Returns a cursor-paginated list of transactions on the members card. Filter by id, card_definition_id, and created_at. Order by id (default -id, newest first). Returns 404 when the program, member, or card doesnt exist. The program is checked first, then the member, then the card. A member of another program, or a card that isnt assigned to this member, is not found.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCardTransactionsExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Unique loyalty program ID (format lprg_[a-f0-9]+).
            var memberId = "memberId_example";  // string | Program member ID (format lmbr_[a-f0-9]+).
            var cardId = "cardId_example";  // string | Loyalty card ID (format lcrd_[a-f0-9]+).
            var limit = 10;  // int? | Maximum number of transactions to return. Must be between 1 and 100. Defaults to 10 when not provided. (optional)  (default to 10)
            var order = "-id";  // string | Orders results by transaction id. -id is newest first and the default. id is oldest first. An array that orders by id and -id together is rejected. (optional) 
            var cursor = "cursor_example";  // string | Pagination cursor returned in the cursor.next field of a previous response. Must match the pattern ^lcrsctx_[a-f0-9]+$. (optional) 
            var filters = new LoyaltiesProgramsMembersCardsTransactionsListRequestQuery(); // LoyaltiesProgramsMembersCardsTransactionsListRequestQuery | Field-specific filter conditions, passed as a deep object, e.g. filters[id][conditions][$is] lctx_0f5d0a8878caa3ee5c. (optional) 

            try
            {
                // List card transactions
                LoyaltiesProgramsMembersCardsTransactionsListResponseBody result = apiInstance.ListCardTransactions(programId, memberId, cardId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListCardTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCardTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List card transactions
    ApiResponse<LoyaltiesProgramsMembersCardsTransactionsListResponseBody> response = apiInstance.ListCardTransactionsWithHttpInfo(programId, memberId, cardId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListCardTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Unique loyalty program ID (format lprg_[a-f0-9]+). |  |
| **memberId** | **string** | Program member ID (format lmbr_[a-f0-9]+). |  |
| **cardId** | **string** | Loyalty card ID (format lcrd_[a-f0-9]+). |  |
| **limit** | **int?** | Maximum number of transactions to return. Must be between 1 and 100. Defaults to 10 when not provided. | [optional] [default to 10] |
| **order** | **string** | Orders results by transaction id. -id is newest first and the default. id is oldest first. An array that orders by id and -id together is rejected. | [optional]  |
| **cursor** | **string** | Pagination cursor returned in the cursor.next field of a previous response. Must match the pattern ^lcrsctx_[a-f0-9]+$. | [optional]  |
| **filters** | [**LoyaltiesProgramsMembersCardsTransactionsListRequestQuery**](LoyaltiesProgramsMembersCardsTransactionsListRequestQuery.md) | Field-specific filter conditions, passed as a deep object, e.g. filters[id][conditions][$is] lctx_0f5d0a8878caa3ee5c. | [optional]  |

### Return type

[**LoyaltiesProgramsMembersCardsTransactionsListResponseBody**](LoyaltiesProgramsMembersCardsTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cursor-paginated list of card transactions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberorderpayments"></a>
# **ListMemberOrderPayments**
> LoyaltiesProgramsMembersOrdersPaymentsListResponseBody ListMemberOrderPayments (string programId, string memberId, int? limit = null, string order = null, string cursor = null, LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery filters = null)

List member order payments

Lists stored PAY_WITH_POINTS order transactions for the program member, with cursor pagination. Filter by id, card_definition_id, and created_at. Order by id (default -id, newest first). Dry-run (SIMULATED) results arent stored and dont appear. Returns 404 when the program or the member doesnt exist. The program is checked first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberOrderPaymentsExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Identifies the loyalty program (lprg_ followed by hexadecimal characters).
            var memberId = "memberId_example";  // string | Identifies the program member (lmbr_[a-f0-9]+).
            var limit = 10;  // int? | Maximum number of items to return. An integer between 1 and 100; numeric strings are also accepted. Defaults to 10. (optional)  (default to 10)
            var order = "-id";  // string | Orders results by transaction id. -id is newest first and the default. id is oldest first. An array that orders by id and -id together is rejected. (optional) 
            var cursor = "cursor_example";  // string | Pagination cursor returned in the cursor.next field of a previous response (format: lcrsotx_ followed by hexadecimal characters). (optional) 
            var filters = new LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery(); // LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery | Filters results by field, e.g. filters[id][conditions][$is] lotx_.... Each field accepts a conditions object with condition operators. (optional) 

            try
            {
                // List member order payments
                LoyaltiesProgramsMembersOrdersPaymentsListResponseBody result = apiInstance.ListMemberOrderPayments(programId, memberId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListMemberOrderPayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberOrderPaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List member order payments
    ApiResponse<LoyaltiesProgramsMembersOrdersPaymentsListResponseBody> response = apiInstance.ListMemberOrderPaymentsWithHttpInfo(programId, memberId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListMemberOrderPaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program (lprg_ followed by hexadecimal characters). |  |
| **memberId** | **string** | Identifies the program member (lmbr_[a-f0-9]+). |  |
| **limit** | **int?** | Maximum number of items to return. An integer between 1 and 100; numeric strings are also accepted. Defaults to 10. | [optional] [default to 10] |
| **order** | **string** | Orders results by transaction id. -id is newest first and the default. id is oldest first. An array that orders by id and -id together is rejected. | [optional]  |
| **cursor** | **string** | Pagination cursor returned in the cursor.next field of a previous response (format: lcrsotx_ followed by hexadecimal characters). | [optional]  |
| **filters** | [**LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery**](LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery.md) | Filters results by field, e.g. filters[id][conditions][$is] lotx_.... Each field accepts a conditions object with condition operators. | [optional]  |

### Return type

[**LoyaltiesProgramsMembersOrdersPaymentsListResponseBody**](LoyaltiesProgramsMembersOrdersPaymentsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a paginated list of persisted order payment transactions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberrewardpurchases"></a>
# **ListMemberRewardPurchases**
> LoyaltiesProgramsMembersRewardsPurchasesListResponseBody ListMemberRewardPurchases (string programId, string memberId, int? limit = null, string order = null, string cursor = null, LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery filters = null)

List member reward purchases

Lists stored PURCHASE reward transactions for the program member, with cursor pagination. Filter by id, reward_id, card_definition_id, and created_at. Order by id (default -id, newest first). Purchases rejected before a transaction is stored dont appear. A purchase accepted with 202 that later fails is stored as REJECTED with details.rejection. Returns 404 when the program or the member doesnt exist. The program is checked first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberRewardPurchasesExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Unique loyalty program identifier (format: lprg_ followed by hexadecimal characters).
            var memberId = "memberId_example";  // string | Program member ID (format lmbr_[a-f0-9]+).
            var limit = 10;  // int? | Maximum number of items to return. An integer between 1 and 100; numeric strings are also accepted. Defaults to 10. (optional)  (default to 10)
            var order = "-id";  // string | Orders results by transaction id. -id is newest first and the default. id is oldest first. An array that orders by id and -id together is rejected. (optional) 
            var cursor = "cursor_example";  // string | Pagination cursor returned in the cursor.next field of a previous response (format: lcrstrx_ followed by hexadecimal characters). (optional) 
            var filters = new LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery(); // LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery | Field filters, e.g. filters[reward_id][conditions][$is] lrew_.... Each field accepts a conditions object with condition operators. (optional) 

            try
            {
                // List member reward purchases
                LoyaltiesProgramsMembersRewardsPurchasesListResponseBody result = apiInstance.ListMemberRewardPurchases(programId, memberId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListMemberRewardPurchases: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberRewardPurchasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List member reward purchases
    ApiResponse<LoyaltiesProgramsMembersRewardsPurchasesListResponseBody> response = apiInstance.ListMemberRewardPurchasesWithHttpInfo(programId, memberId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListMemberRewardPurchasesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Unique loyalty program identifier (format: lprg_ followed by hexadecimal characters). |  |
| **memberId** | **string** | Program member ID (format lmbr_[a-f0-9]+). |  |
| **limit** | **int?** | Maximum number of items to return. An integer between 1 and 100; numeric strings are also accepted. Defaults to 10. | [optional] [default to 10] |
| **order** | **string** | Orders results by transaction id. -id is newest first and the default. id is oldest first. An array that orders by id and -id together is rejected. | [optional]  |
| **cursor** | **string** | Pagination cursor returned in the cursor.next field of a previous response (format: lcrstrx_ followed by hexadecimal characters). | [optional]  |
| **filters** | [**LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery**](LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery.md) | Field filters, e.g. filters[reward_id][conditions][$is] lrew_.... Each field accepts a conditions object with condition operators. | [optional]  |

### Return type

[**LoyaltiesProgramsMembersRewardsPurchasesListResponseBody**](LoyaltiesProgramsMembersRewardsPurchasesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of reward purchase transactions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="purchasememberreward"></a>
# **PurchaseMemberReward**
> LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody PurchaseMemberReward (string programId, string memberId, LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody loyaltiesProgramsMembersRewardsPurchasesCreateRequestBody)

Purchase reward with points

Purchases a reward for the program member by spending points from the members card. The card comes from the matching reward costs card definition. The program, reward, and member must be ACTIVE. The program and reward must be inside their validity windows. The reward must be assigned to the program with stock available, a cost must match the customer, and the purchase must stay inside frequency, cooldown, balance, and spending limits. Modes: - TRANSACTION (default): creates a PENDING reward transaction and a PENDING card transaction. Returns 202. - DRY_RUN: simulates the purchase and doesnt create a transaction. Returns 200 with status SIMULATED.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class PurchaseMemberRewardExample
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
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LV2ProgramsApi(config);
            var programId = "programId_example";  // string | Unique loyalty program identifier (format: lprg_ followed by hexadecimal characters).
            var memberId = "memberId_example";  // string | Program member ID (format lmbr_[a-f0-9]+).
            var loyaltiesProgramsMembersRewardsPurchasesCreateRequestBody = new LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody(); // LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody | 

            try
            {
                // Purchase reward with points
                LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody result = apiInstance.PurchaseMemberReward(programId, memberId, loyaltiesProgramsMembersRewardsPurchasesCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.PurchaseMemberReward: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseMemberRewardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purchase reward with points
    ApiResponse<LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody> response = apiInstance.PurchaseMemberRewardWithHttpInfo(programId, memberId, loyaltiesProgramsMembersRewardsPurchasesCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.PurchaseMemberRewardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Unique loyalty program identifier (format: lprg_ followed by hexadecimal characters). |  |
| **memberId** | **string** | Program member ID (format lmbr_[a-f0-9]+). |  |
| **loyaltiesProgramsMembersRewardsPurchasesCreateRequestBody** | [**LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody**](LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody.md) |  |  |

### Return type

[**LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody**](LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dry run result (mode &#x60;DRY_RUN&#x60;). No transaction was created; the returned transaction has status &#x60;SIMULATED&#x60; and no &#x60;id&#x60;. and Purchase accepted (mode &#x60;TRANSACTION&#x60;). A &#x60;PENDING&#x60; reward transaction was created and will be processed asynchronously. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

