# Voucherify.Api.LV2ProgramsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateCardPendingPointsBucket**](LV2ProgramsApi.md#activatecardpendingpointsbucket) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/pending-points/{bucketId}/activate | Activate pending point bucket |
| [**ActivateProgramMember**](LV2ProgramsApi.md#activateprogrammember) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/activate | Activate program member |
| [**AdjustCardPoints**](LV2ProgramsApi.md#adjustcardpoints) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/points | Adjust card points |
| [**BatchCreateProgramMembers**](LV2ProgramsApi.md#batchcreateprogrammembers) | **POST** /v2/loyalties/programs/{programId}/members/batch | Batch create program members |
| [**CancelCardPendingPointsBucket**](LV2ProgramsApi.md#cancelcardpendingpointsbucket) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/pending-points/{bucketId}/cancel | Cancel pending point bucket |
| [**CreateMemberOrderPayment**](LV2ProgramsApi.md#creatememberorderpayment) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/orders/payments | Pay for order with points |
| [**CreateProgramMember**](LV2ProgramsApi.md#createprogrammember) | **POST** /v2/loyalties/programs/{programId}/members | Create program member |
| [**DeactivateProgramMember**](LV2ProgramsApi.md#deactivateprogrammember) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/deactivate | Deactivate program member |
| [**DeleteProgramMember**](LV2ProgramsApi.md#deleteprogrammember) | **DELETE** /v2/loyalties/programs/{programId}/members/{memberId} | Delete program member |
| [**ExpireCardPointsBucket**](LV2ProgramsApi.md#expirecardpointsbucket) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/expiring-points/{bucketId}/expire | Expire point bucket |
| [**GetMemberEarningRuleDailyReport**](LV2ProgramsApi.md#getmemberearningruledailyreport) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/earning-rules/{earningRuleId}/reports/daily | List member earning-rule daily reports |
| [**GetProgramMember**](LV2ProgramsApi.md#getprogrammember) | **GET** /v2/loyalties/programs/{programId}/members/{memberId} | Get program member |
| [**GetProgramMembership**](LV2ProgramsApi.md#getprogrammembership) | **GET** /v2/loyalties/programs/{programId}/memberships/{customerId} | Get program membership |
| [**GetProgramPointsEarningsDailyReport**](LV2ProgramsApi.md#getprogrampointsearningsdailyreport) | **GET** /v2/loyalties/programs/{programId}/reports/points-earnings/daily | List program points-earnings daily reports |
| [**GetProgramPointsEarningsSummaryReport**](LV2ProgramsApi.md#getprogrampointsearningssummaryreport) | **GET** /v2/loyalties/programs/{programId}/reports/points-earnings/summary | List program points-earnings summary reports |
| [**ListCardActivities**](LV2ProgramsApi.md#listcardactivities) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/activities | List card activities |
| [**ListCardExpiringPoints**](LV2ProgramsApi.md#listcardexpiringpoints) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/expiring-points | List card expiring points buckets |
| [**ListCardPendingPoints**](LV2ProgramsApi.md#listcardpendingpoints) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/pending-points | List card pending point buckets |
| [**ListCardTransactions**](LV2ProgramsApi.md#listcardtransactions) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/transactions | List card transactions |
| [**ListMemberBenefitTransactions**](LV2ProgramsApi.md#listmemberbenefittransactions) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/benefits/transactions | List member benefit transactions |
| [**ListMemberCardDailyReports**](LV2ProgramsApi.md#listmembercarddailyreports) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/reports/daily | List card daily points reports |
| [**ListMemberOrderPayments**](LV2ProgramsApi.md#listmemberorderpayments) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/orders/payments | List member order payments |
| [**ListMemberRewardPurchases**](LV2ProgramsApi.md#listmemberrewardpurchases) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/rewards/purchases | List member reward purchases |
| [**ListMemberTierTransactions**](LV2ProgramsApi.md#listmembertiertransactions) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/tiers/transactions | List member tier transactions |
| [**ListProgramEarningRuleAssignments**](LV2ProgramsApi.md#listprogramearningruleassignments) | **GET** /v2/loyalties/programs/{programId}/earning-rules | List program earning rule assignments |
| [**ListProgramEarningRulesDailyReports**](LV2ProgramsApi.md#listprogramearningrulesdailyreports) | **GET** /v2/loyalties/programs/{programId}/reports/earning-rules/daily | List program earning-rules daily reports |
| [**ListProgramEarningRulesSummaryReports**](LV2ProgramsApi.md#listprogramearningrulessummaryreports) | **GET** /v2/loyalties/programs/{programId}/reports/earning-rules/summary | List program earning-rules summary reports |
| [**ListProgramMemberActivities**](LV2ProgramsApi.md#listprogrammemberactivities) | **GET** /v2/loyalties/programs/{programId}/members/{memberId}/activities | List program member activities |
| [**ListProgramMembers**](LV2ProgramsApi.md#listprogrammembers) | **GET** /v2/loyalties/programs/{programId}/members | List program members |
| [**ListProgramMembersDailyReports**](LV2ProgramsApi.md#listprogrammembersdailyreports) | **GET** /v2/loyalties/programs/{programId}/reports/members/daily | List program members daily reports |
| [**ListProgramMembersSummaryReports**](LV2ProgramsApi.md#listprogrammemberssummaryreports) | **GET** /v2/loyalties/programs/{programId}/reports/members/summary | List program members summary reports |
| [**ListProgramRewardAssignments**](LV2ProgramsApi.md#listprogramrewardassignments) | **GET** /v2/loyalties/programs/{programId}/rewards | List program reward assignments |
| [**ListProgramRewardsDailyReports**](LV2ProgramsApi.md#listprogramrewardsdailyreports) | **GET** /v2/loyalties/programs/{programId}/reports/rewards/daily | List program rewards daily reports |
| [**ListProgramRewardsSpendingsDailyReports**](LV2ProgramsApi.md#listprogramrewardsspendingsdailyreports) | **GET** /v2/loyalties/programs/{programId}/reports/rewards/spendings/daily | List program rewards spendings daily reports |
| [**ListProgramRewardsSpendingsSummaryReports**](LV2ProgramsApi.md#listprogramrewardsspendingssummaryreports) | **GET** /v2/loyalties/programs/{programId}/reports/rewards/spendings/summary | List program rewards spendings summary reports |
| [**ListProgramRewardsSummaryReports**](LV2ProgramsApi.md#listprogramrewardssummaryreports) | **GET** /v2/loyalties/programs/{programId}/reports/rewards/summary | List program rewards summary reports |
| [**ListProgramSpendingDailyReports**](LV2ProgramsApi.md#listprogramspendingdailyreports) | **GET** /v2/loyalties/programs/{programId}/reports/spending/daily | List program spending daily reports |
| [**ListProgramSpendingSummaryReports**](LV2ProgramsApi.md#listprogramspendingsummaryreports) | **GET** /v2/loyalties/programs/{programId}/reports/spending/summary | List program spending summary reports |
| [**ListProgramTierStructureAssignments**](LV2ProgramsApi.md#listprogramtierstructureassignments) | **GET** /v2/loyalties/programs/{programId}/tier-structures | List program tier structure assignments |
| [**ListProgramTiersDailyReports**](LV2ProgramsApi.md#listprogramtiersdailyreports) | **GET** /v2/loyalties/programs/{programId}/reports/tiers/daily | List program tiers daily reports |
| [**ListProgramTiersSummaryReports**](LV2ProgramsApi.md#listprogramtierssummaryreports) | **GET** /v2/loyalties/programs/{programId}/reports/tiers/summary | List program tiers summary reports |
| [**PurchaseMemberReward**](LV2ProgramsApi.md#purchasememberreward) | **POST** /v2/loyalties/programs/{programId}/members/{memberId}/rewards/purchases | Purchase reward with points |
| [**RefundRewardPurchase**](LV2ProgramsApi.md#refundrewardpurchase) | **POST** /v2/loyalties/programs/{programId}/rewards/purchases/{rewardTransactionId}/refund | Refund reward purchase |
| [**UpdateProgramMember**](LV2ProgramsApi.md#updateprogrammember) | **PUT** /v2/loyalties/programs/{programId}/members/{memberId} | Update program member |

<a id="activatecardpendingpointsbucket"></a>
# **ActivateCardPendingPointsBucket**
> V2LoyaltiesProgramsMembersCardsPendingPointsActivateResponseBody ActivateCardPendingPointsBucket (string programId, string memberId, string cardId, string bucketId)

Activate pending point bucket

Activates a pending points bucket and creates a PENDING_POINTS_ACTIVATED card transaction. The transaction is created with status PENDING and processed asynchronously. No request body. The bucket must be PENDING, and its date must be after the current project day. The program and the member must be ACTIVE, and the program must be inside its validity window. Otherwise the response is 423. Returns 404 when the program or the member doesnt exist, when the card isnt assigned to that member, or when the bucket isnt on that card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ActivateCardPendingPointsBucketExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var bucketId = "bucketId_example";  // string | Identifies the pending points bucket. Format lcppb_[a-f0-9]+.

            try
            {
                // Activate pending point bucket
                V2LoyaltiesProgramsMembersCardsPendingPointsActivateResponseBody result = apiInstance.ActivateCardPendingPointsBucket(programId, memberId, cardId, bucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ActivateCardPendingPointsBucket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateCardPendingPointsBucketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate pending point bucket
    ApiResponse<V2LoyaltiesProgramsMembersCardsPendingPointsActivateResponseBody> response = apiInstance.ActivateCardPendingPointsBucketWithHttpInfo(programId, memberId, cardId, bucketId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ActivateCardPendingPointsBucketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **bucketId** | **string** | Identifies the pending points bucket. Format lcppb_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesProgramsMembersCardsPendingPointsActivateResponseBody**](V2LoyaltiesProgramsMembersCardsPendingPointsActivateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Result of the pending points activation. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="activateprogrammember"></a>
# **ActivateProgramMember**
> V2LoyaltiesProgramsMembersActivateResponseBody ActivateProgramMember (string programId, string memberId)

Activate program member

Moves an INACTIVE member to ACTIVE and sets updated_at. Records a vl.member.activated activity. No request body. Returns the member without a cards array. Returns 404 when the program doesnt exist, or when the member doesnt exist in that program. The program is checked first. A DELETED member returns 404. Returns 400 with key invalid_state_transition when the member is already ACTIVE.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ActivateProgramMemberExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.

            try
            {
                // Activate program member
                V2LoyaltiesProgramsMembersActivateResponseBody result = apiInstance.ActivateProgramMember(programId, memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ActivateProgramMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateProgramMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate program member
    ApiResponse<V2LoyaltiesProgramsMembersActivateResponseBody> response = apiInstance.ActivateProgramMemberWithHttpInfo(programId, memberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ActivateProgramMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesProgramsMembersActivateResponseBody**](V2LoyaltiesProgramsMembersActivateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The activated member, without cards. Status is always &#x60;ACTIVE&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adjustcardpoints"></a>
# **AdjustCardPoints**
> V2LoyaltiesProgramsMembersCardsPointsAdjustResponseBody AdjustCardPoints (string programId, string memberId, string cardId, V2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody v2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody)

Adjust card points

Manually adjusts the points balance of the members card. A positive points value creates an ADMIN_CREDIT card transaction. The expiration date comes from the member tier when that tier defines its own points expiration. Otherwise the date comes from the card definition. expiration_date is null when points dont expire. A negative points value creates an ADMIN_DEBIT card transaction. When points is 0, no transaction is created and status is NO_CHANGE. The transaction is created with status PENDING and processed asynchronously. The program and the member must be ACTIVE. The program must also be inside its validity window. Otherwise the response is 423. The response is 404 when the program or the member doesnt exist, or when the card isnt assigned to that member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class AdjustCardPointsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var v2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody = new V2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody(); // V2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody | 

            try
            {
                // Adjust card points
                V2LoyaltiesProgramsMembersCardsPointsAdjustResponseBody result = apiInstance.AdjustCardPoints(programId, memberId, cardId, v2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.AdjustCardPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustCardPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust card points
    ApiResponse<V2LoyaltiesProgramsMembersCardsPointsAdjustResponseBody> response = apiInstance.AdjustCardPointsWithHttpInfo(programId, memberId, cardId, v2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.AdjustCardPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **v2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody** | [**V2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody**](V2LoyaltiesProgramsMembersCardsPointsAdjustRequestBody.md) |  |  |

### Return type

[**V2LoyaltiesProgramsMembersCardsPointsAdjustResponseBody**](V2LoyaltiesProgramsMembersCardsPointsAdjustResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Result of the points adjustment. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="batchcreateprogrammembers"></a>
# **BatchCreateProgramMembers**
> V2LoyaltiesProgramsMembersCreateInBulkResponseBody BatchCreateProgramMembers (string programId, List<MemberCreate> memberCreate)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberCreate = new List<MemberCreate>(); // List<MemberCreate> | 

            try
            {
                // Batch create program members
                V2LoyaltiesProgramsMembersCreateInBulkResponseBody result = apiInstance.BatchCreateProgramMembers(programId, memberCreate);
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
    ApiResponse<V2LoyaltiesProgramsMembersCreateInBulkResponseBody> response = apiInstance.BatchCreateProgramMembersWithHttpInfo(programId, memberCreate);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberCreate** | [**List&lt;MemberCreate&gt;**](MemberCreate.md) |  |  |

### Return type

[**V2LoyaltiesProgramsMembersCreateInBulkResponseBody**](V2LoyaltiesProgramsMembersCreateInBulkResponseBody.md)

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

<a id="cancelcardpendingpointsbucket"></a>
# **CancelCardPendingPointsBucket**
> V2LoyaltiesProgramsMembersCardsPendingPointsCancelResponseBody CancelCardPendingPointsBucket (string programId, string memberId, string cardId, string bucketId)

Cancel pending point bucket

Cancels a pending points bucket so its points arent activated. Creates a PENDING_POINTS_CANCELED card transaction. The transaction is created with status PENDING and processed asynchronously. No request body. The bucket must be PENDING, and its date must be after the current project day. The program and the member must be ACTIVE, and the program must be inside its validity window. Otherwise the response is 423. Returns 404 when the program or the member doesnt exist, when the card isnt assigned to that member, or when the bucket isnt on that card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CancelCardPendingPointsBucketExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var bucketId = "bucketId_example";  // string | Identifies the pending points bucket. Format lcppb_[a-f0-9]+.

            try
            {
                // Cancel pending point bucket
                V2LoyaltiesProgramsMembersCardsPendingPointsCancelResponseBody result = apiInstance.CancelCardPendingPointsBucket(programId, memberId, cardId, bucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.CancelCardPendingPointsBucket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelCardPendingPointsBucketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel pending point bucket
    ApiResponse<V2LoyaltiesProgramsMembersCardsPendingPointsCancelResponseBody> response = apiInstance.CancelCardPendingPointsBucketWithHttpInfo(programId, memberId, cardId, bucketId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.CancelCardPendingPointsBucketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **bucketId** | **string** | Identifies the pending points bucket. Format lcppb_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesProgramsMembersCardsPendingPointsCancelResponseBody**](V2LoyaltiesProgramsMembersCardsPendingPointsCancelResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Result of the pending points cancellation. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creatememberorderpayment"></a>
# **CreateMemberOrderPayment**
> LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody CreateMemberOrderPayment (string programId, string memberId, V2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody v2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var v2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody = new V2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody(); // V2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody | 

            try
            {
                // Pay for order with points
                LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody result = apiInstance.CreateMemberOrderPayment(programId, memberId, v2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody);
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
    ApiResponse<LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBody> response = apiInstance.CreateMemberOrderPaymentWithHttpInfo(programId, memberId, v2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **v2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody** | [**V2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody**](V2LoyaltiesProgramsMembersOrdersPaymentsCreateRequestBody.md) |  |  |

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
> V2LoyaltiesProgramsMembersCreateResponseBody CreateProgramMember (string programId, V2LoyaltiesProgramsMembersCreateRequestBody v2LoyaltiesProgramsMembersCreateRequestBody)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var v2LoyaltiesProgramsMembersCreateRequestBody = new V2LoyaltiesProgramsMembersCreateRequestBody(); // V2LoyaltiesProgramsMembersCreateRequestBody | 

            try
            {
                // Create program member
                V2LoyaltiesProgramsMembersCreateResponseBody result = apiInstance.CreateProgramMember(programId, v2LoyaltiesProgramsMembersCreateRequestBody);
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
    ApiResponse<V2LoyaltiesProgramsMembersCreateResponseBody> response = apiInstance.CreateProgramMemberWithHttpInfo(programId, v2LoyaltiesProgramsMembersCreateRequestBody);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **v2LoyaltiesProgramsMembersCreateRequestBody** | [**V2LoyaltiesProgramsMembersCreateRequestBody**](V2LoyaltiesProgramsMembersCreateRequestBody.md) |  |  |

### Return type

[**V2LoyaltiesProgramsMembersCreateResponseBody**](V2LoyaltiesProgramsMembersCreateResponseBody.md)

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

<a id="deactivateprogrammember"></a>
# **DeactivateProgramMember**
> V2LoyaltiesProgramsMembersDeactivateResponseBody DeactivateProgramMember (string programId, string memberId)

Deactivate program member

Moves an ACTIVE member to INACTIVE and sets updated_at. Records a vl.member.deactivated activity. An INACTIVE member cant earn or spend points. No request body. Returns the member without a cards array. Returns 404 when the program doesnt exist, or when the member doesnt exist in that program. The program is checked first. A DELETED member returns 404. Returns 400 with key invalid_state_transition when the member is already INACTIVE.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeactivateProgramMemberExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.

            try
            {
                // Deactivate program member
                V2LoyaltiesProgramsMembersDeactivateResponseBody result = apiInstance.DeactivateProgramMember(programId, memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.DeactivateProgramMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateProgramMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deactivate program member
    ApiResponse<V2LoyaltiesProgramsMembersDeactivateResponseBody> response = apiInstance.DeactivateProgramMemberWithHttpInfo(programId, memberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.DeactivateProgramMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesProgramsMembersDeactivateResponseBody**](V2LoyaltiesProgramsMembersDeactivateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deactivated member, without cards. Status is always &#x60;INACTIVE&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteprogrammember"></a>
# **DeleteProgramMember**
> V2LoyaltiesProgramsMembersDeleteResponseBody DeleteProgramMember (string programId, string memberId)

Delete program member

Deletes the member and sets status to DELETED. Removes the members card assignments in this program. Returns the member without a cards array. Delete doesnt change updated_at. Records a vl.member.deleted activity. Each unassigned card also records vl.member.card.unassigned and vl.card.unassigned. When an assignment has a tier, the delete records a LEFT tier transaction with origin member_card_deleted. The same customer can join the program again. The new member gets a new ID. Returns 404 when the program doesnt exist, or when the member doesnt exist in that program. The program is checked first. Deleting a member that is already DELETED returns 404.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteProgramMemberExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.

            try
            {
                // Delete program member
                V2LoyaltiesProgramsMembersDeleteResponseBody result = apiInstance.DeleteProgramMember(programId, memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.DeleteProgramMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProgramMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete program member
    ApiResponse<V2LoyaltiesProgramsMembersDeleteResponseBody> response = apiInstance.DeleteProgramMemberWithHttpInfo(programId, memberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.DeleteProgramMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesProgramsMembersDeleteResponseBody**](V2LoyaltiesProgramsMembersDeleteResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted member (without cards). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="expirecardpointsbucket"></a>
# **ExpireCardPointsBucket**
> V2LoyaltiesProgramsMembersCardsExpiringPointsExpireResponseBody ExpireCardPointsBucket (string programId, string memberId, string cardId, string bucketId)

Expire point bucket

Expires an ACTIVE points bucket. Creates an ADMIN_POINTS_EXPIRATION card transaction. The transaction is created with status PENDING and processed asynchronously. No request body. The bucket must be ACTIVE, and its expiration_date must be on or after the current project day. The program and the member must be ACTIVE, and the program must be inside its validity window. Otherwise the response is 423. Returns 404 when the program, the member, or the card definition doesnt exist, when the card isnt assigned to that member, or when the bucket isnt on that card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExpireCardPointsBucketExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var bucketId = "bucketId_example";  // string | Identifies the points expiration bucket. Format lcpeb_[a-f0-9]+.

            try
            {
                // Expire point bucket
                V2LoyaltiesProgramsMembersCardsExpiringPointsExpireResponseBody result = apiInstance.ExpireCardPointsBucket(programId, memberId, cardId, bucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ExpireCardPointsBucket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExpireCardPointsBucketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Expire point bucket
    ApiResponse<V2LoyaltiesProgramsMembersCardsExpiringPointsExpireResponseBody> response = apiInstance.ExpireCardPointsBucketWithHttpInfo(programId, memberId, cardId, bucketId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ExpireCardPointsBucketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **bucketId** | **string** | Identifies the points expiration bucket. Format lcpeb_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesProgramsMembersCardsExpiringPointsExpireResponseBody**](V2LoyaltiesProgramsMembersCardsExpiringPointsExpireResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Result of the points expiration. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmemberearningruledailyreport"></a>
# **GetMemberEarningRuleDailyReport**
> V2LoyaltiesProgramsMembersEarningRulesReportsDailyListResponseBody GetMemberEarningRuleDailyReport (string programId, string memberId, string earningRuleId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution)

List member earning-rule daily reports

Returns aggregated daily usage statistics for a specific earning rule and member over the given date range and resolution. Each entry sums successful earning-rule triggers recorded in one period. Periods without recorded activity are omitted. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program or member does not exist, or when the earning rule does not exist or is not assigned to the program.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetMemberEarningRuleDailyReportExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var earningRuleId = "earningRuleId_example";  // string | Identifies the earning rule. Format lern_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.

            try
            {
                // List member earning-rule daily reports
                V2LoyaltiesProgramsMembersEarningRulesReportsDailyListResponseBody result = apiInstance.GetMemberEarningRuleDailyReport(programId, memberId, earningRuleId, startDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.GetMemberEarningRuleDailyReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMemberEarningRuleDailyReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List member earning-rule daily reports
    ApiResponse<V2LoyaltiesProgramsMembersEarningRulesReportsDailyListResponseBody> response = apiInstance.GetMemberEarningRuleDailyReportWithHttpInfo(programId, memberId, earningRuleId, startDate, endDate, resolution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.GetMemberEarningRuleDailyReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **earningRuleId** | **string** | Identifies the earning rule. Format lern_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |

### Return type

[**V2LoyaltiesProgramsMembersEarningRulesReportsDailyListResponseBody**](V2LoyaltiesProgramsMembersEarningRulesReportsDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Member earning-rule daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprogrammember"></a>
# **GetProgramMember**
> V2LoyaltiesProgramsMembersGetResponseBody GetProgramMember (string programId, string memberId)

Get program member

Returns one member of the program together with that members loyalty cards. Each card includes balance, lifetime_bucket, next_expiration, and next_activation. tier_progress is not included. Use [Get program membership](/api-reference/programs/get-program-membership) when you need tier progress. card.code can be null shortly after member creation, while code generation is still running. Returns 404 when the program doesnt exist, or when the member doesnt exist in that program. The program is checked first.

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.

            try
            {
                // Get program member
                V2LoyaltiesProgramsMembersGetResponseBody result = apiInstance.GetProgramMember(programId, memberId);
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
    ApiResponse<V2LoyaltiesProgramsMembersGetResponseBody> response = apiInstance.GetProgramMemberWithHttpInfo(programId, memberId);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |

### Return type

[**V2LoyaltiesProgramsMembersGetResponseBody**](V2LoyaltiesProgramsMembersGetResponseBody.md)

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
> V2LoyaltiesProgramsMembershipsGetResponseBody GetProgramMembership (string programId, string customerId, string identificationType = null)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var customerId = "customerId_example";  // string | Identifies the customer or member. identification_type selects the value: a Voucherify customer ID (cust_...), a customer source_id, or a loyalty member ID (lmbr_...).
            var identificationType = "customer_id";  // string | Selects how customerId is read. customer_id is the Voucherify customer ID and the default. customer_source_id is the customers source_id. member_id is the loyalty member ID. (optional)  (default to customer_id)

            try
            {
                // Get program membership
                V2LoyaltiesProgramsMembershipsGetResponseBody result = apiInstance.GetProgramMembership(programId, customerId, identificationType);
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
    ApiResponse<V2LoyaltiesProgramsMembershipsGetResponseBody> response = apiInstance.GetProgramMembershipWithHttpInfo(programId, customerId, identificationType);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **customerId** | **string** | Identifies the customer or member. identification_type selects the value: a Voucherify customer ID (cust_...), a customer source_id, or a loyalty member ID (lmbr_...). |  |
| **identificationType** | **string** | Selects how customerId is read. customer_id is the Voucherify customer ID and the default. customer_source_id is the customers source_id. member_id is the loyalty member ID. | [optional] [default to customer_id] |

### Return type

[**V2LoyaltiesProgramsMembershipsGetResponseBody**](V2LoyaltiesProgramsMembershipsGetResponseBody.md)

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

<a id="getprogrampointsearningsdailyreport"></a>
# **GetProgramPointsEarningsDailyReport**
> V2LoyaltiesProgramsReportsPointsEarningsDailyListResponseBody GetProgramPointsEarningsDailyReport (string programId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution, PointsEarningsReportListFilters filters = null)

List program points-earnings daily reports

Returns aggregated daily points-earnings statistics for the program over the given date range and resolution, optionally filtered by earning rule and card definition. Each entry sums earning operations recorded for one period, earning rule, earning item, and card definition. Periods without recorded activity are omitted. A filter that matches no rows returns an empty data array. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetProgramPointsEarningsDailyReportExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.
            var filters = new PointsEarningsReportListFilters(); // PointsEarningsReportListFilters | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program points-earnings daily reports
                V2LoyaltiesProgramsReportsPointsEarningsDailyListResponseBody result = apiInstance.GetProgramPointsEarningsDailyReport(programId, startDate, endDate, resolution, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.GetProgramPointsEarningsDailyReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgramPointsEarningsDailyReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program points-earnings daily reports
    ApiResponse<V2LoyaltiesProgramsReportsPointsEarningsDailyListResponseBody> response = apiInstance.GetProgramPointsEarningsDailyReportWithHttpInfo(programId, startDate, endDate, resolution, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.GetProgramPointsEarningsDailyReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |
| **filters** | [**PointsEarningsReportListFilters**](PointsEarningsReportListFilters.md) | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsReportsPointsEarningsDailyListResponseBody**](V2LoyaltiesProgramsReportsPointsEarningsDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program points-earnings daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprogrampointsearningssummaryreport"></a>
# **GetProgramPointsEarningsSummaryReport**
> V2LoyaltiesProgramsReportsPointsEarningsSummaryListResponseBody GetProgramPointsEarningsSummaryReport (string programId, PointsEarningsReportListFilters filters = null)

List program points-earnings summary reports

Returns total points-earnings statistics for the program (all time), optionally filtered by earning rule or card definition. Each entry sums earning operations for one earning rule, earning item, and card definition. Returns at most 100 rows, ordered by id descending. limit and order are not query parameters. A filter that matches no rows returns an empty data array. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetProgramPointsEarningsSummaryReportExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var filters = new PointsEarningsReportListFilters(); // PointsEarningsReportListFilters | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program points-earnings summary reports
                V2LoyaltiesProgramsReportsPointsEarningsSummaryListResponseBody result = apiInstance.GetProgramPointsEarningsSummaryReport(programId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.GetProgramPointsEarningsSummaryReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgramPointsEarningsSummaryReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program points-earnings summary reports
    ApiResponse<V2LoyaltiesProgramsReportsPointsEarningsSummaryListResponseBody> response = apiInstance.GetProgramPointsEarningsSummaryReportWithHttpInfo(programId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.GetProgramPointsEarningsSummaryReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **filters** | [**PointsEarningsReportListFilters**](PointsEarningsReportListFilters.md) | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsReportsPointsEarningsSummaryListResponseBody**](V2LoyaltiesProgramsReportsPointsEarningsSummaryListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program points-earnings summary report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcardactivities"></a>
# **ListCardActivities**
> V2LoyaltiesProgramsMembersCardsActivitiesListResponseBody ListCardActivities (string programId, string memberId, string cardId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersCardsActivitiesListRequestQueryFilters filters = null)

List card activities

Returns a cursor-paginated list of activities recorded for the members card. The card must still be assigned to that member. Filters are id, type, and created_at. Default order is -created_at, then id ascending. Returns 404 when the program doesnt exist, when the member doesnt exist in that program, or when the card isnt currently assigned to that member. The program is checked first, then the member. A DELETED member returns 404 with resource_type member. A missing assignment and a missing or deleted card both return 404 with resource_type card. Returns 400 with key invalid_query_params when the query fails validation. That check runs before the program, member, and card lookup. A cursor that doesnt match ^lcrsacrd_[a-f0-9]+$, a limit outside 1 to 100, an order other than created_at or -created_at, or an array that orders by both directions fails here. After the program, member, and card are found, an unknown or expired cursor returns invalid_or_expired_cursor. A cursor recorded for different filters or order returns cursor_and_query_mismatch. The cursor stays valid when only limit changes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCardActivitiesExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "created_at";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsacrd_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersCardsActivitiesListRequestQueryFilters(); // V2LoyaltiesProgramsMembersCardsActivitiesListRequestQueryFilters | Filters the results. Pass a deep object, for example filters[type][conditions][$is] vl.card.created. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List card activities
                V2LoyaltiesProgramsMembersCardsActivitiesListResponseBody result = apiInstance.ListCardActivities(programId, memberId, cardId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListCardActivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCardActivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List card activities
    ApiResponse<V2LoyaltiesProgramsMembersCardsActivitiesListResponseBody> response = apiInstance.ListCardActivitiesWithHttpInfo(programId, memberId, cardId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListCardActivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsacrd_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersCardsActivitiesListRequestQueryFilters**](V2LoyaltiesProgramsMembersCardsActivitiesListRequestQueryFilters.md) | Filters the results. Pass a deep object, for example filters[type][conditions][$is] vl.card.created. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersCardsActivitiesListResponseBody**](V2LoyaltiesProgramsMembersCardsActivitiesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cursor-paginated list of card activities. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcardexpiringpoints"></a>
# **ListCardExpiringPoints**
> V2LoyaltiesProgramsMembersCardsExpiringPointsListResponseBody ListCardExpiringPoints (string programId, string memberId, string cardId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersCardsExpiringPointsListRequestQuery filters = null)

List card expiring points buckets

Returns a cursor-paginated list of ACTIVE point expiration buckets for the members card. Each bucket groups points that share an expiration date and expiration type, including points from separate transactions. The list starts on the current project day. Earlier buckets are omitted. Results can be filtered by card definition ID and expiration date, and ordered by expiration_date. Returns an empty list when the card has no matching buckets. Returns 400 when the query is invalid or the cursor is invalid, expired, or doesnt match the query. Returns 404 when the program or the member doesnt exist, or when the card isnt assigned to that member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCardExpiringPointsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "expiration_date";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to expiration_date. Soonest expiration first. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrspeb_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersCardsExpiringPointsListRequestQuery(); // V2LoyaltiesProgramsMembersCardsExpiringPointsListRequestQuery | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_1297339938ae248cea. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List card expiring points buckets
                V2LoyaltiesProgramsMembersCardsExpiringPointsListResponseBody result = apiInstance.ListCardExpiringPoints(programId, memberId, cardId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListCardExpiringPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCardExpiringPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List card expiring points buckets
    ApiResponse<V2LoyaltiesProgramsMembersCardsExpiringPointsListResponseBody> response = apiInstance.ListCardExpiringPointsWithHttpInfo(programId, memberId, cardId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListCardExpiringPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to expiration_date. Soonest expiration first. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrspeb_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersCardsExpiringPointsListRequestQuery**](V2LoyaltiesProgramsMembersCardsExpiringPointsListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_1297339938ae248cea. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersCardsExpiringPointsListResponseBody**](V2LoyaltiesProgramsMembersCardsExpiringPointsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cursor-paginated list of points expiration buckets. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcardpendingpoints"></a>
# **ListCardPendingPoints**
> V2LoyaltiesProgramsMembersCardsPendingPointsListResponseBody ListCardPendingPoints (string programId, string memberId, string cardId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersCardsPendingPointsListRequestQuery filters = null)

List card pending point buckets

Returns a cursor-paginated list of pending point buckets for the members card. Every bucket has status PENDING. Pending points wait for activation (PERIOD_BASED, FIXED_DATES, or EVENT_BASED), following the card definition. The list starts on the next project day. The current days bucket is omitted because its still accumulating. Results can be filtered by card definition ID and ordered by date. Returns 404 when the program or the member doesnt exist, or when the card isnt assigned to that member. Bucket IDs from this list are the bucketId for [Activate pending point bucket](/api-reference/programs/activate-pending-point-bucket) and [Cancel pending point bucket](/api-reference/programs/cancel-pending-point-bucket).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCardPendingPointsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "date";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to date. Soonest activation first. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrscppb_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersCardsPendingPointsListRequestQuery(); // V2LoyaltiesProgramsMembersCardsPendingPointsListRequestQuery | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_128f495f720c4bec8c. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List card pending point buckets
                V2LoyaltiesProgramsMembersCardsPendingPointsListResponseBody result = apiInstance.ListCardPendingPoints(programId, memberId, cardId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListCardPendingPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCardPendingPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List card pending point buckets
    ApiResponse<V2LoyaltiesProgramsMembersCardsPendingPointsListResponseBody> response = apiInstance.ListCardPendingPointsWithHttpInfo(programId, memberId, cardId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListCardPendingPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to date. Soonest activation first. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrscppb_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersCardsPendingPointsListRequestQuery**](V2LoyaltiesProgramsMembersCardsPendingPointsListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_128f495f720c4bec8c. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersCardsPendingPointsListResponseBody**](V2LoyaltiesProgramsMembersCardsPendingPointsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cursor-paginated list of pending point buckets. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcardtransactions"></a>
# **ListCardTransactions**
> V2LoyaltiesProgramsMembersCardsTransactionsListResponseBody ListCardTransactions (string programId, string memberId, string cardId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersCardsTransactionsListRequestQuery filters = null)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "-id";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsctx_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersCardsTransactionsListRequestQuery(); // V2LoyaltiesProgramsMembersCardsTransactionsListRequestQuery | Filters the results. Pass a deep object, for example filters[id][conditions][$is] lctx_0f5d0a8878caa3ee5c. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List card transactions
                V2LoyaltiesProgramsMembersCardsTransactionsListResponseBody result = apiInstance.ListCardTransactions(programId, memberId, cardId, limit, order, cursor, filters);
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
    ApiResponse<V2LoyaltiesProgramsMembersCardsTransactionsListResponseBody> response = apiInstance.ListCardTransactionsWithHttpInfo(programId, memberId, cardId, limit, order, cursor, filters);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsctx_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersCardsTransactionsListRequestQuery**](V2LoyaltiesProgramsMembersCardsTransactionsListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[id][conditions][$is] lctx_0f5d0a8878caa3ee5c. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersCardsTransactionsListResponseBody**](V2LoyaltiesProgramsMembersCardsTransactionsListResponseBody.md)

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

<a id="listmemberbenefittransactions"></a>
# **ListMemberBenefitTransactions**
> V2LoyaltiesProgramsMembersBenefitsTransactionsListResponseBody ListMemberBenefitTransactions (string programId, string memberId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersBenefitsTransactionsListRequestQuery filters = null)

List member benefit transactions

Lists benefit transactions (benefit fulfillments) for a given program member, with cursor-based pagination. Supports filtering by benefit ID and creation date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberBenefitTransactionsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "id";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsbtx_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersBenefitsTransactionsListRequestQuery(); // V2LoyaltiesProgramsMembersBenefitsTransactionsListRequestQuery | Filters the results. Pass a deep object, for example filters[benefit_id][conditions][$is] lben_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List member benefit transactions
                V2LoyaltiesProgramsMembersBenefitsTransactionsListResponseBody result = apiInstance.ListMemberBenefitTransactions(programId, memberId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListMemberBenefitTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberBenefitTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List member benefit transactions
    ApiResponse<V2LoyaltiesProgramsMembersBenefitsTransactionsListResponseBody> response = apiInstance.ListMemberBenefitTransactionsWithHttpInfo(programId, memberId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListMemberBenefitTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsbtx_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersBenefitsTransactionsListRequestQuery**](V2LoyaltiesProgramsMembersBenefitsTransactionsListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[benefit_id][conditions][$is] lben_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersBenefitsTransactionsListResponseBody**](V2LoyaltiesProgramsMembersBenefitsTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of benefit transactions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmembercarddailyreports"></a>
# **ListMemberCardDailyReports**
> LoyaltiesProgramsMembersCardsReportsDailyListResponseBody ListMemberCardDailyReports (string programId, string memberId, string cardId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution)

List card daily points reports

Returns aggregated points statistics for a members loyalty card over the given date range and resolution. Each entry sums the point operations recorded in one period. Periods without recorded activity are omitted. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program or member does not exist, or when the card does not exist or is not assigned to the member in the program.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberCardDailyReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var cardId = "cardId_example";  // string | Identifies the loyalty card. Format lcrd_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.

            try
            {
                // List card daily points reports
                LoyaltiesProgramsMembersCardsReportsDailyListResponseBody result = apiInstance.ListMemberCardDailyReports(programId, memberId, cardId, startDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListMemberCardDailyReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberCardDailyReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List card daily points reports
    ApiResponse<LoyaltiesProgramsMembersCardsReportsDailyListResponseBody> response = apiInstance.ListMemberCardDailyReportsWithHttpInfo(programId, memberId, cardId, startDate, endDate, resolution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListMemberCardDailyReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **cardId** | **string** | Identifies the loyalty card. Format lcrd_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |

### Return type

[**LoyaltiesProgramsMembersCardsReportsDailyListResponseBody**](LoyaltiesProgramsMembersCardsReportsDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Card daily points report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberorderpayments"></a>
# **ListMemberOrderPayments**
> V2LoyaltiesProgramsMembersOrdersPaymentsListResponseBody ListMemberOrderPayments (string programId, string memberId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery filters = null)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "-id";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsotx_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery(); // V2LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery | Filters the results. Pass a deep object, for example filters[id][conditions][$is] lotx_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List member order payments
                V2LoyaltiesProgramsMembersOrdersPaymentsListResponseBody result = apiInstance.ListMemberOrderPayments(programId, memberId, limit, order, cursor, filters);
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
    ApiResponse<V2LoyaltiesProgramsMembersOrdersPaymentsListResponseBody> response = apiInstance.ListMemberOrderPaymentsWithHttpInfo(programId, memberId, limit, order, cursor, filters);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsotx_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery**](V2LoyaltiesProgramsMembersOrdersPaymentsListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[id][conditions][$is] lotx_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersOrdersPaymentsListResponseBody**](V2LoyaltiesProgramsMembersOrdersPaymentsListResponseBody.md)

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
> V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBody ListMemberRewardPurchases (string programId, string memberId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery filters = null)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "-id";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrstrx_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery(); // V2LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List member reward purchases
                V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBody result = apiInstance.ListMemberRewardPurchases(programId, memberId, limit, order, cursor, filters);
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
    ApiResponse<V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBody> response = apiInstance.ListMemberRewardPurchasesWithHttpInfo(programId, memberId, limit, order, cursor, filters);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrstrx_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery**](V2LoyaltiesProgramsMembersRewardsPurchasesListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBody**](V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBody.md)

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

<a id="listmembertiertransactions"></a>
# **ListMemberTierTransactions**
> V2LoyaltiesProgramsMembersTiersTransactionsListResponseBody ListMemberTierTransactions (string programId, string memberId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersTiersTransactionsListRequestQuery filters = null)

List member tier transactions

Lists tier transactions for the member: joins, leaves, upgrades, downgrades, expiration changes, and evaluation refreshes. Results use cursor pagination. Default order is -id, newest first. Filters are card_id, card_definition_id, and created_at. Returns 404 when the program doesnt exist, or when the member doesnt exist in that program. The program is checked first. A DELETED member returns 404. Returns 400 with key invalid_query_params when the query fails validation. That check runs before the program and member lookup. order must be id or -id. An array that orders by both directions is rejected. A cursor that doesnt match ^lcrsttx_[a-f0-9]+$ fails here. After the program and member are found, an unknown or expired cursor returns invalid_or_expired_cursor. A cursor recorded for different filters or order returns cursor_and_query_mismatch. The cursor stays valid when only limit changes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberTierTransactionsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "-id";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsttx_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersTiersTransactionsListRequestQuery(); // V2LoyaltiesProgramsMembersTiersTransactionsListRequestQuery | Filters the results. Pass a deep object, for example filters[card_id][conditions][$is] lcrd_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List member tier transactions
                V2LoyaltiesProgramsMembersTiersTransactionsListResponseBody result = apiInstance.ListMemberTierTransactions(programId, memberId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListMemberTierTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberTierTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List member tier transactions
    ApiResponse<V2LoyaltiesProgramsMembersTiersTransactionsListResponseBody> response = apiInstance.ListMemberTierTransactionsWithHttpInfo(programId, memberId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListMemberTierTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -id. Newest first. The same field cannot be used in both directions. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsttx_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersTiersTransactionsListRequestQuery**](V2LoyaltiesProgramsMembersTiersTransactionsListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[card_id][conditions][$is] lcrd_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersTiersTransactionsListResponseBody**](V2LoyaltiesProgramsMembersTiersTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of tier transactions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramearningruleassignments"></a>
# **ListProgramEarningRuleAssignments**
> V2LoyaltiesProgramsEarningRulesListResponseBody ListProgramEarningRuleAssignments (string programId, string limit = null, string order = null, string cursor = null)

List program earning rule assignments

Returns a cursor-paginated list of earning rules assigned to the program.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramEarningRuleAssignmentsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var limit = "\"10\"";  // string | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to "10")
            var order = "-created_at";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrserna_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 

            try
            {
                // List program earning rule assignments
                V2LoyaltiesProgramsEarningRulesListResponseBody result = apiInstance.ListProgramEarningRuleAssignments(programId, limit, order, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramEarningRuleAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramEarningRuleAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program earning rule assignments
    ApiResponse<V2LoyaltiesProgramsEarningRulesListResponseBody> response = apiInstance.ListProgramEarningRuleAssignmentsWithHttpInfo(programId, limit, order, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramEarningRuleAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **limit** | **string** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to &quot;10&quot;] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrserna_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |

### Return type

[**V2LoyaltiesProgramsEarningRulesListResponseBody**](V2LoyaltiesProgramsEarningRulesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of earning rule assignments. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramearningrulesdailyreports"></a>
# **ListProgramEarningRulesDailyReports**
> V2LoyaltiesProgramsReportsEarningRulesDailyListResponseBody ListProgramEarningRulesDailyReports (string programId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution, EarningRulesReportListFilters filters = null)

List program earning-rules daily reports

Returns aggregated daily earning-rule evaluation statistics for the program over the given date range and resolution, optionally filtered by earning rule. Each entry counts eligibility checks for one period and earning rule. Periods without recorded activity are omitted. failures_breakdown is always an empty object. A filter that matches no rows returns an empty data array. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramEarningRulesDailyReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.
            var filters = new EarningRulesReportListFilters(); // EarningRulesReportListFilters | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program earning-rules daily reports
                V2LoyaltiesProgramsReportsEarningRulesDailyListResponseBody result = apiInstance.ListProgramEarningRulesDailyReports(programId, startDate, endDate, resolution, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramEarningRulesDailyReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramEarningRulesDailyReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program earning-rules daily reports
    ApiResponse<V2LoyaltiesProgramsReportsEarningRulesDailyListResponseBody> response = apiInstance.ListProgramEarningRulesDailyReportsWithHttpInfo(programId, startDate, endDate, resolution, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramEarningRulesDailyReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |
| **filters** | [**EarningRulesReportListFilters**](EarningRulesReportListFilters.md) | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsReportsEarningRulesDailyListResponseBody**](V2LoyaltiesProgramsReportsEarningRulesDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program earning-rules daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramearningrulessummaryreports"></a>
# **ListProgramEarningRulesSummaryReports**
> V2LoyaltiesProgramsReportsEarningRulesSummaryListResponseBody ListProgramEarningRulesSummaryReports (string programId, EarningRulesReportListFilters filters = null)

List program earning-rules summary reports

Returns total earning-rule evaluation statistics for the program (all time), optionally filtered by earning rule. Includes success and failure counts with a failures breakdown. Each entry counts eligibility checks for one earning rule. Returns at most 100 rows, ordered by id descending. limit and order are not query parameters. A filter that matches no rows returns an empty data array. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramEarningRulesSummaryReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var filters = new EarningRulesReportListFilters(); // EarningRulesReportListFilters | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program earning-rules summary reports
                V2LoyaltiesProgramsReportsEarningRulesSummaryListResponseBody result = apiInstance.ListProgramEarningRulesSummaryReports(programId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramEarningRulesSummaryReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramEarningRulesSummaryReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program earning-rules summary reports
    ApiResponse<V2LoyaltiesProgramsReportsEarningRulesSummaryListResponseBody> response = apiInstance.ListProgramEarningRulesSummaryReportsWithHttpInfo(programId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramEarningRulesSummaryReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **filters** | [**EarningRulesReportListFilters**](EarningRulesReportListFilters.md) | Filters the results. Pass a deep object, for example filters[earning_rule_id][conditions][$is] lern_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsReportsEarningRulesSummaryListResponseBody**](V2LoyaltiesProgramsReportsEarningRulesSummaryListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program earning-rules summary report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogrammemberactivities"></a>
# **ListProgramMemberActivities**
> V2LoyaltiesProgramsMembersActivitiesListResponseBody ListProgramMemberActivities (string programId, string memberId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersActivitiesListRequestQueryFilters filters = null)

List program member activities

Returns a cursor-paginated list of lifecycle and card-assignment activities recorded for the member. Filters are id, type, and created_at. Default order is -created_at, then id ascending. Returns 404 when the program doesnt exist, or when the member doesnt exist in that program. The program is checked first. A DELETED member returns 404. Returns 400 with key invalid_query_params when the query fails validation. That check runs before the program and member lookup. A cursor that doesnt match ^lcrsambr_[a-f0-9]+$, a limit outside 1 to 100, an order other than created_at or -created_at, or an array that orders by both directions fails here. After the program and member are found, an unknown or expired cursor returns invalid_or_expired_cursor. A cursor recorded for different filters or order returns cursor_and_query_mismatch. The cursor stays valid when only limit changes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramMemberActivitiesExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "created_at";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsambr_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersActivitiesListRequestQueryFilters(); // V2LoyaltiesProgramsMembersActivitiesListRequestQueryFilters | Filters the results. Pass a deep object, for example filters[type][conditions][$is] vl.member.created. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program member activities
                V2LoyaltiesProgramsMembersActivitiesListResponseBody result = apiInstance.ListProgramMemberActivities(programId, memberId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMemberActivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramMemberActivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program member activities
    ApiResponse<V2LoyaltiesProgramsMembersActivitiesListResponseBody> response = apiInstance.ListProgramMemberActivitiesWithHttpInfo(programId, memberId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMemberActivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsambr_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersActivitiesListRequestQueryFilters**](V2LoyaltiesProgramsMembersActivitiesListRequestQueryFilters.md) | Filters the results. Pass a deep object, for example filters[type][conditions][$is] vl.member.created. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersActivitiesListResponseBody**](V2LoyaltiesProgramsMembersActivitiesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cursor-paginated list of member activities. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogrammembers"></a>
# **ListProgramMembers**
> V2LoyaltiesProgramsMembersListResponseBody ListProgramMembers (string programId, int? limit = null, string order = null, string cursor = null, V2LoyaltiesProgramsMembersListRequestQuery filters = null)

List program members

Returns a cursor-paginated list of members of the program. Deleted members are omitted. Results can be filtered by ID, status, customer ID and creation date. Results can be ordered by creation date, status, or customer ID (ascending or descending). The same field cannot be ordered both ascending and descending at the same time. Returns 404 when the program does not exist. List items do not include the cards array. Use the following endpoints to retrieve cards for a given member: - [Get customer memberships](/api-reference/programs/get-customer-memberships), - [Get program member](/api-reference/programs/get-program-member), - [Get program membership](/api-reference/programs/get-program-membership).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramMembersExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var limit = 10;  // int? | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to 10)
            var order = "-created_at";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsmbr_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 
            var filters = new V2LoyaltiesProgramsMembersListRequestQuery(); // V2LoyaltiesProgramsMembersListRequestQuery | Filters the results. Pass a deep object, for example filters[status][conditions][$is] ACTIVE. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program members
                V2LoyaltiesProgramsMembersListResponseBody result = apiInstance.ListProgramMembers(programId, limit, order, cursor, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program members
    ApiResponse<V2LoyaltiesProgramsMembersListResponseBody> response = apiInstance.ListProgramMembersWithHttpInfo(programId, limit, order, cursor, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **limit** | **int?** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to 10] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsmbr_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |
| **filters** | [**V2LoyaltiesProgramsMembersListRequestQuery**](V2LoyaltiesProgramsMembersListRequestQuery.md) | Filters the results. Pass a deep object, for example filters[status][conditions][$is] ACTIVE. Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsMembersListResponseBody**](V2LoyaltiesProgramsMembersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cursor-paginated list of members. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogrammembersdailyreports"></a>
# **ListProgramMembersDailyReports**
> LoyaltiesProgramsReportsMembersDailyListResponseBody ListProgramMembersDailyReports (string programId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution)

List program members daily reports

Returns member and card changes for the program over the given date range and resolution. Each row covers one period with recorded activity. Periods without activity are omitted. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramMembersDailyReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.

            try
            {
                // List program members daily reports
                LoyaltiesProgramsReportsMembersDailyListResponseBody result = apiInstance.ListProgramMembersDailyReports(programId, startDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMembersDailyReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramMembersDailyReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program members daily reports
    ApiResponse<LoyaltiesProgramsReportsMembersDailyListResponseBody> response = apiInstance.ListProgramMembersDailyReportsWithHttpInfo(programId, startDate, endDate, resolution);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMembersDailyReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |

### Return type

[**LoyaltiesProgramsReportsMembersDailyListResponseBody**](LoyaltiesProgramsReportsMembersDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program members daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogrammemberssummaryreports"></a>
# **ListProgramMembersSummaryReports**
> LoyaltiesProgramsReportsMembersSummaryListResponseBody ListProgramMembersSummaryReports (string programId)

List program members summary reports

Returns all-time member and card totals for the program. The response contains one row when activity was recorded, and an empty data array otherwise. limit and order are not query parameters. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramMembersSummaryReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.

            try
            {
                // List program members summary reports
                LoyaltiesProgramsReportsMembersSummaryListResponseBody result = apiInstance.ListProgramMembersSummaryReports(programId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMembersSummaryReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramMembersSummaryReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program members summary reports
    ApiResponse<LoyaltiesProgramsReportsMembersSummaryListResponseBody> response = apiInstance.ListProgramMembersSummaryReportsWithHttpInfo(programId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramMembersSummaryReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |

### Return type

[**LoyaltiesProgramsReportsMembersSummaryListResponseBody**](LoyaltiesProgramsReportsMembersSummaryListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program members summary report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramrewardassignments"></a>
# **ListProgramRewardAssignments**
> V2LoyaltiesProgramsRewardsListResponseBody ListProgramRewardAssignments (string programId, string limit = null, string order = null, string cursor = null)

List program reward assignments

Returns a cursor-paginated list of rewards assigned to the program, including their stock configuration and redemption counters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramRewardAssignmentsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var limit = "\"10\"";  // string | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to "10")
            var order = "-created_at";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsrewa_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 

            try
            {
                // List program reward assignments
                V2LoyaltiesProgramsRewardsListResponseBody result = apiInstance.ListProgramRewardAssignments(programId, limit, order, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramRewardAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program reward assignments
    ApiResponse<V2LoyaltiesProgramsRewardsListResponseBody> response = apiInstance.ListProgramRewardAssignmentsWithHttpInfo(programId, limit, order, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **limit** | **string** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to &quot;10&quot;] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrsrewa_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |

### Return type

[**V2LoyaltiesProgramsRewardsListResponseBody**](V2LoyaltiesProgramsRewardsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of reward assignments. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramrewardsdailyreports"></a>
# **ListProgramRewardsDailyReports**
> LoyaltiesProgramsReportsRewardsDailyListResponseBody ListProgramRewardsDailyReports (string programId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution, RewardsReportListFilters filters = null)

List program rewards daily reports

Returns aggregated reward-purchase statistics for the program over the given date range and resolution, optionally filtered by reward. Each row covers one reward and one period with recorded purchases. Periods without recorded purchases are omitted. failures_breakdown is always an empty object. A filter that matches no rows returns an empty data array. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramRewardsDailyReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.
            var filters = new RewardsReportListFilters(); // RewardsReportListFilters | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program rewards daily reports
                LoyaltiesProgramsReportsRewardsDailyListResponseBody result = apiInstance.ListProgramRewardsDailyReports(programId, startDate, endDate, resolution, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsDailyReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramRewardsDailyReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program rewards daily reports
    ApiResponse<LoyaltiesProgramsReportsRewardsDailyListResponseBody> response = apiInstance.ListProgramRewardsDailyReportsWithHttpInfo(programId, startDate, endDate, resolution, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsDailyReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |
| **filters** | [**RewardsReportListFilters**](RewardsReportListFilters.md) | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**LoyaltiesProgramsReportsRewardsDailyListResponseBody**](LoyaltiesProgramsReportsRewardsDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program rewards daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramrewardsspendingsdailyreports"></a>
# **ListProgramRewardsSpendingsDailyReports**
> LoyaltiesProgramsReportsRewardsSpendingsDailyListResponseBody ListProgramRewardsSpendingsDailyReports (string programId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution, RewardsSpendingsReportListFilters filters = null)

List program rewards spendings daily reports

Returns aggregated points spent on reward purchases for the program over the given date range and resolution. Each row covers one reward, reward cost, reward spending, card definition, and period with an approved point spend. Periods without an approved point spend are omitted. Optionally filters by reward, cost, spending, and card definition. A filter that matches no rows returns an empty data array. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramRewardsSpendingsDailyReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.
            var filters = new RewardsSpendingsReportListFilters(); // RewardsSpendingsReportListFilters | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program rewards spendings daily reports
                LoyaltiesProgramsReportsRewardsSpendingsDailyListResponseBody result = apiInstance.ListProgramRewardsSpendingsDailyReports(programId, startDate, endDate, resolution, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsSpendingsDailyReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramRewardsSpendingsDailyReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program rewards spendings daily reports
    ApiResponse<LoyaltiesProgramsReportsRewardsSpendingsDailyListResponseBody> response = apiInstance.ListProgramRewardsSpendingsDailyReportsWithHttpInfo(programId, startDate, endDate, resolution, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsSpendingsDailyReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |
| **filters** | [**RewardsSpendingsReportListFilters**](RewardsSpendingsReportListFilters.md) | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**LoyaltiesProgramsReportsRewardsSpendingsDailyListResponseBody**](LoyaltiesProgramsReportsRewardsSpendingsDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program rewards spendings daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramrewardsspendingssummaryreports"></a>
# **ListProgramRewardsSpendingsSummaryReports**
> LoyaltiesProgramsReportsRewardsSpendingsSummaryListResponseBody ListProgramRewardsSpendingsSummaryReports (string programId, RewardsSpendingsReportListFilters filters = null)

List program rewards spendings summary reports

Returns all-time points spent on reward purchases for the program. Each row covers one reward, reward cost, reward spending, and card definition with an approved point spend. Filters rows by reward, cost, spending, and card definition. Returns at most 100 rows, ordered by id descending. limit and order are not query parameters. A filter that matches no rows returns an empty data array. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramRewardsSpendingsSummaryReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var filters = new RewardsSpendingsReportListFilters(); // RewardsSpendingsReportListFilters | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program rewards spendings summary reports
                LoyaltiesProgramsReportsRewardsSpendingsSummaryListResponseBody result = apiInstance.ListProgramRewardsSpendingsSummaryReports(programId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsSpendingsSummaryReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramRewardsSpendingsSummaryReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program rewards spendings summary reports
    ApiResponse<LoyaltiesProgramsReportsRewardsSpendingsSummaryListResponseBody> response = apiInstance.ListProgramRewardsSpendingsSummaryReportsWithHttpInfo(programId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsSpendingsSummaryReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **filters** | [**RewardsSpendingsReportListFilters**](RewardsSpendingsReportListFilters.md) | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**LoyaltiesProgramsReportsRewardsSpendingsSummaryListResponseBody**](LoyaltiesProgramsReportsRewardsSpendingsSummaryListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program rewards spendings summary report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramrewardssummaryreports"></a>
# **ListProgramRewardsSummaryReports**
> LoyaltiesProgramsReportsRewardsSummaryListResponseBody ListProgramRewardsSummaryReports (string programId, RewardsReportListFilters filters = null)

List program rewards summary reports

Returns all-time reward-purchase totals for the program, one row per reward with a recorded purchase attempt. Filters rows with filters[reward_id]. Returns at most 100 rows, ordered by id descending. limit and order are not query parameters. A filter that matches no rows returns an empty data array. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramRewardsSummaryReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var filters = new RewardsReportListFilters(); // RewardsReportListFilters | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program rewards summary reports
                LoyaltiesProgramsReportsRewardsSummaryListResponseBody result = apiInstance.ListProgramRewardsSummaryReports(programId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsSummaryReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramRewardsSummaryReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program rewards summary reports
    ApiResponse<LoyaltiesProgramsReportsRewardsSummaryListResponseBody> response = apiInstance.ListProgramRewardsSummaryReportsWithHttpInfo(programId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramRewardsSummaryReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **filters** | [**RewardsReportListFilters**](RewardsReportListFilters.md) | Filters the results. Pass a deep object, for example filters[reward_id][conditions][$is] lrew_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**LoyaltiesProgramsReportsRewardsSummaryListResponseBody**](LoyaltiesProgramsReportsRewardsSummaryListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program rewards summary report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramspendingdailyreports"></a>
# **ListProgramSpendingDailyReports**
> LoyaltiesProgramsReportsSpendingDailyListResponseBody ListProgramSpendingDailyReports (string programId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution, SpendingReportListFilters filters = null)

List program spending daily reports

Returns aggregated points-spending statistics for the program over the given date range and resolution. Each row covers one card definition and one period with recorded spending. Periods without recorded spending are omitted. Optionally filters by card definition. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramSpendingDailyReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.
            var filters = new SpendingReportListFilters(); // SpendingReportListFilters | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program spending daily reports
                LoyaltiesProgramsReportsSpendingDailyListResponseBody result = apiInstance.ListProgramSpendingDailyReports(programId, startDate, endDate, resolution, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramSpendingDailyReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramSpendingDailyReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program spending daily reports
    ApiResponse<LoyaltiesProgramsReportsSpendingDailyListResponseBody> response = apiInstance.ListProgramSpendingDailyReportsWithHttpInfo(programId, startDate, endDate, resolution, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramSpendingDailyReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |
| **filters** | [**SpendingReportListFilters**](SpendingReportListFilters.md) | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**LoyaltiesProgramsReportsSpendingDailyListResponseBody**](LoyaltiesProgramsReportsSpendingDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program spending daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramspendingsummaryreports"></a>
# **ListProgramSpendingSummaryReports**
> LoyaltiesProgramsReportsSpendingSummaryListResponseBody ListProgramSpendingSummaryReports (string programId, SpendingReportListFilters filters = null)

List program spending summary reports

Returns all-time point-spending totals for the program, one row per card definition that has recorded spending. Filters rows with filters[card_definition_id]. Returns at most 10 rows (max number of card definitions per program), ordered by id descending. limit and order are not query parameters. Returns 200 with an empty data array when no spending is recorded. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramSpendingSummaryReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var filters = new SpendingReportListFilters(); // SpendingReportListFilters | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program spending summary reports
                LoyaltiesProgramsReportsSpendingSummaryListResponseBody result = apiInstance.ListProgramSpendingSummaryReports(programId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramSpendingSummaryReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramSpendingSummaryReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program spending summary reports
    ApiResponse<LoyaltiesProgramsReportsSpendingSummaryListResponseBody> response = apiInstance.ListProgramSpendingSummaryReportsWithHttpInfo(programId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramSpendingSummaryReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **filters** | [**SpendingReportListFilters**](SpendingReportListFilters.md) | Filters the results. Pass a deep object, for example filters[card_definition_id][conditions][$is] lcdef_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**LoyaltiesProgramsReportsSpendingSummaryListResponseBody**](LoyaltiesProgramsReportsSpendingSummaryListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program spending summary report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramtierstructureassignments"></a>
# **ListProgramTierStructureAssignments**
> V2LoyaltiesProgramsTierStructuresListResponseBody ListProgramTierStructureAssignments (string programId, string limit = null, string order = null, string cursor = null)

List program tier structure assignments

Returns a cursor-paginated list of tier structures assigned to the program. Currently, a program can have only one tier structure assigned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramTierStructureAssignmentsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var limit = "\"10\"";  // string | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. (optional)  (default to "10")
            var order = "-created_at";  // string | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. (optional) 
            var cursor = "cursor_example";  // string | Continues pagination. Pass the cursor.next value from a previous response. Format lcrstsa_[a-f0-9]+. The cursor matches the filters and order of that response. (optional) 

            try
            {
                // List program tier structure assignments
                V2LoyaltiesProgramsTierStructuresListResponseBody result = apiInstance.ListProgramTierStructureAssignments(programId, limit, order, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramTierStructureAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramTierStructureAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program tier structure assignments
    ApiResponse<V2LoyaltiesProgramsTierStructuresListResponseBody> response = apiInstance.ListProgramTierStructureAssignmentsWithHttpInfo(programId, limit, order, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramTierStructureAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **limit** | **string** | Limits the page size to an integer from 1 to 100. Defaults to 10. A numeric string is accepted and rounded to the nearest integer. | [optional] [default to &quot;10&quot;] |
| **order** | **string** | Orders the results. Accepts one value or an array. Prefix a field with - for descending order. Defaults to -created_at. The same field cannot be used in both directions. Rows with the same sort value are then ordered by id ascending. | [optional]  |
| **cursor** | **string** | Continues pagination. Pass the cursor.next value from a previous response. Format lcrstsa_[a-f0-9]+. The cursor matches the filters and order of that response. | [optional]  |

### Return type

[**V2LoyaltiesProgramsTierStructuresListResponseBody**](V2LoyaltiesProgramsTierStructuresListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of tier structure assignments. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramtiersdailyreports"></a>
# **ListProgramTiersDailyReports**
> V2LoyaltiesProgramsReportsTiersDailyListResponseBody ListProgramTiersDailyReports (string programId, DateTimeOffset startDate, DateTimeOffset endDate, string resolution, TiersReportListFilters filters = null)

List program tiers daily reports

Returns aggregated tier-movement statistics for the program over the given date range and resolution, optionally filtered by tier structure and tier. Each row covers one tier structure, one tier, and one period with recorded movement. Periods without recorded movement are omitted. A filter that matches no rows returns an empty data array. The date range is limited per resolution: - 90 days for day, - 12 weeks for week, - 12 months for month, - 4 quarters for quarter, - start_date must be before end_date, - start_date and end_date are inclusive. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramTiersDailyReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var startDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive start of the report date range. Format YYYY-MM-DD.
            var endDate = DateTime.Parse("2013-10-20");  // DateTimeOffset | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date.
            var resolution = "day";  // string | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters.
            var filters = new TiersReportListFilters(); // TiersReportListFilters | Filters the results. Pass a deep object, for example filters[tier_structure_id][conditions][$is] lts_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program tiers daily reports
                V2LoyaltiesProgramsReportsTiersDailyListResponseBody result = apiInstance.ListProgramTiersDailyReports(programId, startDate, endDate, resolution, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramTiersDailyReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramTiersDailyReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program tiers daily reports
    ApiResponse<V2LoyaltiesProgramsReportsTiersDailyListResponseBody> response = apiInstance.ListProgramTiersDailyReportsWithHttpInfo(programId, startDate, endDate, resolution, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramTiersDailyReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **startDate** | **DateTimeOffset** | Sets the inclusive start of the report date range. Format YYYY-MM-DD. |  |
| **endDate** | **DateTimeOffset** | Sets the inclusive end of the report date range. Format YYYY-MM-DD. Must be after start_date. |  |
| **resolution** | **string** | Sets the aggregation resolution. day allows at most 90 days, week at most 12 weeks, month at most 12 months, and quarter at most 4 quarters. |  |
| **filters** | [**TiersReportListFilters**](TiersReportListFilters.md) | Filters the results. Pass a deep object, for example filters[tier_structure_id][conditions][$is] lts_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsReportsTiersDailyListResponseBody**](V2LoyaltiesProgramsReportsTiersDailyListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program tiers daily report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listprogramtierssummaryreports"></a>
# **ListProgramTiersSummaryReports**
> V2LoyaltiesProgramsReportsTiersSummaryListResponseBody ListProgramTiersSummaryReports (string programId, TiersReportListFilters filters = null)

List program tiers summary reports

Returns all-time tier-movement totals for the program, one row per tier structure and tier that has recorded movement. Filters rows with filters[tier_structure_id] and filters[tier_id]. Returns at most 100 rows, ordered by id descending. limit and order are not query parameters. A filter that matches no rows returns an empty data array. Returns 400 when query validation fails. Returns 404 when the program does not exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListProgramTiersSummaryReportsExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var filters = new TiersReportListFilters(); // TiersReportListFilters | Filters the results. Pass a deep object, for example filters[tier_id][conditions][$is] lt_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. (optional) 

            try
            {
                // List program tiers summary reports
                V2LoyaltiesProgramsReportsTiersSummaryListResponseBody result = apiInstance.ListProgramTiersSummaryReports(programId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.ListProgramTiersSummaryReports: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProgramTiersSummaryReportsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List program tiers summary reports
    ApiResponse<V2LoyaltiesProgramsReportsTiersSummaryListResponseBody> response = apiInstance.ListProgramTiersSummaryReportsWithHttpInfo(programId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.ListProgramTiersSummaryReportsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **filters** | [**TiersReportListFilters**](TiersReportListFilters.md) | Filters the results. Pass a deep object, for example filters[tier_id][conditions][$is] lt_.... Fields combine through junction, which defaults to AND. Omit filters to apply no field filter. | [optional]  |

### Return type

[**V2LoyaltiesProgramsReportsTiersSummaryListResponseBody**](V2LoyaltiesProgramsReportsTiersSummaryListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Program tiers summary report. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="purchasememberreward"></a>
# **PurchaseMemberReward**
> LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody PurchaseMemberReward (string programId, string memberId, V2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody v2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody)

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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var v2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody = new V2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody(); // V2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody | 

            try
            {
                // Purchase reward with points
                LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody result = apiInstance.PurchaseMemberReward(programId, memberId, v2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody);
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
    ApiResponse<LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBody> response = apiInstance.PurchaseMemberRewardWithHttpInfo(programId, memberId, v2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody);
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
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **v2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody** | [**V2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody**](V2LoyaltiesProgramsMembersRewardsPurchasesCreateRequestBody.md) |  |  |

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

<a id="refundrewardpurchase"></a>
# **RefundRewardPurchase**
> V2LoyaltiesProgramsRewardsPurchasesRefundResponseBody RefundRewardPurchase (string programId, string rewardTransactionId, V2LoyaltiesProgramsRewardsPurchasesRefundRequestBody v2LoyaltiesProgramsRewardsPurchasesRefundRequestBody = null)

Refund reward purchase

Refunds an APPROVED reward purchase made by a program member. The purchase transaction is marked REFUNDED, a new REFUND reward transaction is created with status APPROVED, and the points spent on the purchase are returned to the members card. The request body is optional and an empty payload is allowed. Policies default to refund: DEFAULT and stock: DEFAULT. The endpoint responds with 202 before the card balance changes. A POINTS_RETURNED card transaction is created for the members card and processed shortly after the response. When the members tier or the card definition expires points, returned points receive a new expiration date from that setting. They dont inherit the expiration of the originally spent points. A NO_EXPIRATION setting leaves the returned points without an expiration date. Card earning limits dont block the refund. For a LOYALTY_CARD_POINTS reward, the points credited to the target card are also reversed, with a POINTS_PURCHASE_REVERSED card transaction on that card. That transaction is processed shortly after the response. Its expiration is copied from the original points-purchased transaction. A DISCOUNT_COUPONS refund deletes the issued vouchers. details.result.digital.discount_coupons[].result is DELETED, or SKIPPED when the voucher isnt deleted. A GIFT_VOUCHERS refund subtracts the credited amount. details.result.digital.gift_vouchers[].result is CREDITS_SUBTRACTED, or SKIPPED when the balance update is rejected. The refund reverses that purchase in the rewards purchase limits for the project-local day of the original purchase. A day whose purchases are all refunded no longer counts as the members last purchase. Only rewards whose refunds.type is REFUNDABLE can be refunded. Any other reward is rejected with 423 and key reward_refund_policy_does_not_allow_refunds. policies.refund set to ALLOW refunds it anyway. The program must exist, and the reward transaction must belong to that program. Otherwise the request fails with 404. The program is checked first. The request is rejected with 423 when: - The program isnt ACTIVE (non_active_program) or is outside its validity window (program_outside_validity_window), - The transaction isnt a purchase (non_purchase_reward_transaction) or isnt APPROVED (non_approved_reward_transaction); refunding the same purchase twice fails here, - The reward no longer exists (reward_not_found), isnt assigned to the program (refund_reward_not_assigned_to_program), the members card is gone (refund_card_not_found), or the card definition is gone (refund_card_definition_not_found), - The reward type isnt supported (reward_type_not_supported_for_refunds), - For a LOYALTY_CARD_POINTS reward, the purchase result is missing (loyalty_card_points_purchase_result_not_found), the target card is gone (loyalty_card_points_target_card_not_found), the points-purchased card transaction is missing (loyalty_card_points_purchase_not_found), the target cards available balance is lower than the purchased points (loyalty_card_points_insufficient_balance), or the target card definition is gone (loyalty_card_points_target_card_definition_not_found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class RefundRewardPurchaseExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var rewardTransactionId = "rewardTransactionId_example";  // string | Identifies the reward transaction of the purchase to refund. Format lrtx_[a-f0-9]+.
            var v2LoyaltiesProgramsRewardsPurchasesRefundRequestBody = new V2LoyaltiesProgramsRewardsPurchasesRefundRequestBody(); // V2LoyaltiesProgramsRewardsPurchasesRefundRequestBody | Optional refund policies. An empty payload is allowed. (optional) 

            try
            {
                // Refund reward purchase
                V2LoyaltiesProgramsRewardsPurchasesRefundResponseBody result = apiInstance.RefundRewardPurchase(programId, rewardTransactionId, v2LoyaltiesProgramsRewardsPurchasesRefundRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.RefundRewardPurchase: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefundRewardPurchaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refund reward purchase
    ApiResponse<V2LoyaltiesProgramsRewardsPurchasesRefundResponseBody> response = apiInstance.RefundRewardPurchaseWithHttpInfo(programId, rewardTransactionId, v2LoyaltiesProgramsRewardsPurchasesRefundRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.RefundRewardPurchaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **rewardTransactionId** | **string** | Identifies the reward transaction of the purchase to refund. Format lrtx_[a-f0-9]+. |  |
| **v2LoyaltiesProgramsRewardsPurchasesRefundRequestBody** | [**V2LoyaltiesProgramsRewardsPurchasesRefundRequestBody**](V2LoyaltiesProgramsRewardsPurchasesRefundRequestBody.md) | Optional refund policies. An empty payload is allowed. | [optional]  |

### Return type

[**V2LoyaltiesProgramsRewardsPurchasesRefundResponseBody**](V2LoyaltiesProgramsRewardsPurchasesRefundResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Refund accepted. The refund reward transaction has been created with status APPROVED and points will be returned to the member&#39;s card asynchronously. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateprogrammember"></a>
# **UpdateProgramMember**
> V2LoyaltiesProgramsMembersUpdateResponseBody UpdateProgramMember (string programId, string memberId, V2LoyaltiesProgramsMembersUpdateRequestBody v2LoyaltiesProgramsMembersUpdateRequestBody)

Update program member

Updates a program members metadata. Provided object keys are merged into the existing metadata; omitted keys are preserved. Pass metadata: null to clear all metadata (sets it to an empty object). This endpoint cannot change status. Use [Activate program member](/api-reference/programs/activate-program-member) or [Deactivate program member](/api-reference/programs/deactivate-program-member) for status transitions. Records a vl.member.updated activity. Returns the updated member without the cards array. Returns 404 when the program or member does not exist. Returns 400 when the request body fails validation or the project vl_member metadata schema rejects the payload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateProgramMemberExample
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
            var programId = "programId_example";  // string | Identifies the loyalty program. Format lprg_[a-f0-9]+.
            var memberId = "memberId_example";  // string | Identifies the member. Format lmbr_[a-f0-9]+.
            var v2LoyaltiesProgramsMembersUpdateRequestBody = new V2LoyaltiesProgramsMembersUpdateRequestBody(); // V2LoyaltiesProgramsMembersUpdateRequestBody | 

            try
            {
                // Update program member
                V2LoyaltiesProgramsMembersUpdateResponseBody result = apiInstance.UpdateProgramMember(programId, memberId, v2LoyaltiesProgramsMembersUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LV2ProgramsApi.UpdateProgramMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProgramMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update program member
    ApiResponse<V2LoyaltiesProgramsMembersUpdateResponseBody> response = apiInstance.UpdateProgramMemberWithHttpInfo(programId, memberId, v2LoyaltiesProgramsMembersUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LV2ProgramsApi.UpdateProgramMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **programId** | **string** | Identifies the loyalty program. Format lprg_[a-f0-9]+. |  |
| **memberId** | **string** | Identifies the member. Format lmbr_[a-f0-9]+. |  |
| **v2LoyaltiesProgramsMembersUpdateRequestBody** | [**V2LoyaltiesProgramsMembersUpdateRequestBody**](V2LoyaltiesProgramsMembersUpdateRequestBody.md) |  |  |

### Return type

[**V2LoyaltiesProgramsMembersUpdateResponseBody**](V2LoyaltiesProgramsMembersUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated member (without cards). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

