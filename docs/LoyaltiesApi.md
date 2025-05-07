# Voucherify.Api.LoyaltiesApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateMemberPendingPoints**](LoyaltiesApi.md#activatememberpendingpoints) | **POST** /v1/loyalties/members/{memberId}/pending-points/{pendingPointsId}/activate | Activate Member Pending Points |
| [**AddMember**](LoyaltiesApi.md#addmember) | **POST** /v1/loyalties/{campaignId}/members | Add Member |
| [**CancelMemberPendingPoints**](LoyaltiesApi.md#cancelmemberpendingpoints) | **POST** /v1/loyalties/members/{memberId}/pending-points/{pendingPointsId}/cancel | Cancel Member Pending Points |
| [**CreateEarningRule**](LoyaltiesApi.md#createearningrule) | **POST** /v1/loyalties/{campaignId}/earning-rules | Create Earning Rule |
| [**CreateInBulkLoyaltyTiers**](LoyaltiesApi.md#createinbulkloyaltytiers) | **POST** /v1/loyalties/{campaignId}/tiers | Create loyalty tiers |
| [**CreateLoyaltyProgram**](LoyaltiesApi.md#createloyaltyprogram) | **POST** /v1/loyalties | Create Loyalty Campaign |
| [**CreatePointsExpirationExport**](LoyaltiesApi.md#createpointsexpirationexport) | **POST** /v1/loyalties/{campaignId}/points-expiration/export | Export Loyalty Campaign Point Expiration |
| [**CreateRewardAssignment1**](LoyaltiesApi.md#createrewardassignment1) | **POST** /v1/loyalties/{campaignId}/rewards | Create Reward Assignment |
| [**DeleteEarningRule**](LoyaltiesApi.md#deleteearningrule) | **DELETE** /v1/loyalties/{campaignId}/earning-rules/{earningRuleId} | Delete Earning Rule |
| [**DeleteLoyaltyProgram**](LoyaltiesApi.md#deleteloyaltyprogram) | **DELETE** /v1/loyalties/{campaignId} | Delete Loyalty Campaign |
| [**DeleteRewardAssignment1**](LoyaltiesApi.md#deleterewardassignment1) | **DELETE** /v1/loyalties/{campaignId}/rewards/{assignmentId} | Delete Reward Assignment |
| [**DisableEarningRule**](LoyaltiesApi.md#disableearningrule) | **POST** /v1/loyalties/{campaignId}/earning-rules/{earningRuleId}/disable | Disable Earning Rule |
| [**EnableEarningRule**](LoyaltiesApi.md#enableearningrule) | **POST** /v1/loyalties/{campaignId}/earning-rules/{earningRuleId}/enable | Enable Earning Rule |
| [**ExportLoyaltyCampaignTransactions**](LoyaltiesApi.md#exportloyaltycampaigntransactions) | **POST** /v1/loyalties/{campaignId}/transactions/export | Export Loyalty Campaign Transactions |
| [**ExportLoyaltyCardTransactions**](LoyaltiesApi.md#exportloyaltycardtransactions) | **POST** /v1/loyalties/members/{memberId}/transactions/export | Export Loyalty Card Transactions |
| [**ExportLoyaltyCardTransactions1**](LoyaltiesApi.md#exportloyaltycardtransactions1) | **POST** /v1/loyalties/{campaignId}/members/{memberId}/transactions/export | Export Loyalty Card Transactions |
| [**GetEarningRule**](LoyaltiesApi.md#getearningrule) | **GET** /v1/loyalties/{campaignId}/earning-rules/{earningRuleId} | Get Earning Rule |
| [**GetLoyaltyProgram**](LoyaltiesApi.md#getloyaltyprogram) | **GET** /v1/loyalties/{campaignId} | Get Loyalty Campaign |
| [**GetLoyaltyTier**](LoyaltiesApi.md#getloyaltytier) | **GET** /v1/loyalties/{campaignId}/tiers/{loyaltyTierId} | Get Loyalty Tier |
| [**GetMember**](LoyaltiesApi.md#getmember) | **GET** /v1/loyalties/members/{memberId} | Get Member |
| [**GetMember1**](LoyaltiesApi.md#getmember1) | **GET** /v1/loyalties/{campaignId}/members/{memberId} | Get Member |
| [**GetRewardAssignment1**](LoyaltiesApi.md#getrewardassignment1) | **GET** /v1/loyalties/{campaignId}/reward-assignments/{assignmentId} | Get Reward Assignment |
| [**GetRewardAssignment2**](LoyaltiesApi.md#getrewardassignment2) | **GET** /v1/loyalties/{campaignId}/rewards/{assignmentId} | Get Reward Assignment |
| [**GetRewardDetails**](LoyaltiesApi.md#getrewarddetails) | **GET** /v1/loyalties/{campaignId}/reward-assignments/{assignmentId}/reward | Get Reward Details |
| [**ListCampaignPendingPoints**](LoyaltiesApi.md#listcampaignpendingpoints) | **GET** /v1/loyalties/{campaignId}/pending-points | List Campaign Pending Points |
| [**ListEarningRules**](LoyaltiesApi.md#listearningrules) | **GET** /v1/loyalties/{campaignId}/earning-rules | List Earning Rules |
| [**ListLoyaltyCampaignTransactions**](LoyaltiesApi.md#listloyaltycampaigntransactions) | **GET** /v1/loyalties/{campaignId}/transactions | List Loyalty Campaign Transactions |
| [**ListLoyaltyCardTransactions**](LoyaltiesApi.md#listloyaltycardtransactions) | **GET** /v1/loyalties/members/{memberId}/transactions | List Loyalty Card Transactions |
| [**ListLoyaltyCardTransactions1**](LoyaltiesApi.md#listloyaltycardtransactions1) | **GET** /v1/loyalties/{campaignId}/members/{memberId}/transactions | List Loyalty Card Transactions |
| [**ListLoyaltyPrograms**](LoyaltiesApi.md#listloyaltyprograms) | **GET** /v1/loyalties | List Loyalty Campaigns |
| [**ListLoyaltyTierEarningRules**](LoyaltiesApi.md#listloyaltytierearningrules) | **GET** /v1/loyalties/{campaignId}/tiers/{loyaltyTierId}/earning-rules | List Loyalty Tier Earning Rules |
| [**ListLoyaltyTierRewards**](LoyaltiesApi.md#listloyaltytierrewards) | **GET** /v1/loyalties/{campaignId}/tiers/{loyaltyTierId}/rewards | List Loyalty Tier Rewards |
| [**ListLoyaltyTiers**](LoyaltiesApi.md#listloyaltytiers) | **GET** /v1/loyalties/{campaignId}/tiers | List Loyalty Tiers |
| [**ListMemberActivity**](LoyaltiesApi.md#listmemberactivity) | **GET** /v1/loyalties/members/{memberId}/activity | List Member Activity |
| [**ListMemberActivity1**](LoyaltiesApi.md#listmemberactivity1) | **GET** /v1/loyalties/{campaignId}/members/{memberId}/activity | List Member Activity |
| [**ListMemberLoyaltyTier**](LoyaltiesApi.md#listmemberloyaltytier) | **GET** /v1/loyalties/members/{memberId}/tiers | List Member&#39;s Loyalty Tiers |
| [**ListMemberPendingPoints**](LoyaltiesApi.md#listmemberpendingpoints) | **GET** /v1/loyalties/members/{memberId}/pending-points | List Member Pending Points |
| [**ListMemberPendingPoints1**](LoyaltiesApi.md#listmemberpendingpoints1) | **GET** /v1/loyalties/{campaignId}/members/{memberId}/pending-points | List Member Pending Points |
| [**ListMemberRewards**](LoyaltiesApi.md#listmemberrewards) | **GET** /v1/loyalties/members/{memberId}/rewards | List Member Rewards |
| [**ListMembers**](LoyaltiesApi.md#listmembers) | **GET** /v1/loyalties/{campaignId}/members | List Members |
| [**ListPointsExpiration**](LoyaltiesApi.md#listpointsexpiration) | **GET** /v1/loyalties/{campaignId}/members/{memberId}/points-expiration | List Loyalty Card Point Expiration |
| [**ListRewardAssignments1**](LoyaltiesApi.md#listrewardassignments1) | **GET** /v1/loyalties/{campaignId}/reward-assignments | List Reward Assignments |
| [**ListRewardAssignments2**](LoyaltiesApi.md#listrewardassignments2) | **GET** /v1/loyalties/{campaignId}/rewards | List Reward Assignments |
| [**RedeemReward**](LoyaltiesApi.md#redeemreward) | **POST** /v1/loyalties/members/{memberId}/redemption | Redeem Reward |
| [**RedeemReward1**](LoyaltiesApi.md#redeemreward1) | **POST** /v1/loyalties/{campaignId}/members/{memberId}/redemption | Redeem Reward |
| [**TransferPoints**](LoyaltiesApi.md#transferpoints) | **POST** /v1/loyalties/{campaignId}/members/{memberId}/transfers | Transfer Loyalty Points |
| [**UpdateEarningRule**](LoyaltiesApi.md#updateearningrule) | **PUT** /v1/loyalties/{campaignId}/earning-rules/{earningRuleId} | Update Earning Rule |
| [**UpdateLoyaltyCardBalance**](LoyaltiesApi.md#updateloyaltycardbalance) | **POST** /v1/loyalties/members/{memberId}/balance | Adjust Loyalty Card Balance |
| [**UpdateLoyaltyCardBalance1**](LoyaltiesApi.md#updateloyaltycardbalance1) | **POST** /v1/loyalties/{campaignId}/members/{memberId}/balance | Adjust Loyalty Card Balance |
| [**UpdateLoyaltyProgram**](LoyaltiesApi.md#updateloyaltyprogram) | **PUT** /v1/loyalties/{campaignId} | Update Loyalty Campaign |
| [**UpdateRewardAssignment1**](LoyaltiesApi.md#updaterewardassignment1) | **PUT** /v1/loyalties/{campaignId}/rewards/{assignmentId} | Update Reward Assignment |

<a id="activatememberpendingpoints"></a>
# **ActivateMemberPendingPoints**
> LoyaltiesMembersPendingPointsActivateResponseBody ActivateMemberPendingPoints (string memberId, string pendingPointsId)

Activate Member Pending Points

>🚧 Beta endpoint The endpoint is behind a feature flag as it is still in development. Contact [Voucherify support](https://www.voucherify.io/contact-support) to unlock the feature for your organization. All current parameters and fields are listed and described. Activate manually the pending points and add them to the loyalty card. The pending points are determined by the pending point ID. Once activated, the pending point entry with that ID is not listed by the endpoints: List member (with campaign ID, without campaign ID), List campaign pending points. This **POST** method does not require a request body. 👍 Configuring pending points Pending points are configured as part of an earning rule with POST Create earning rule or PUT Update earning rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ActivateMemberPendingPointsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card code assigned to a particular customer.
            var pendingPointsId = "pendingPointsId_example";  // string | Unique pending point identifier, assigned by Voucherify.

            try
            {
                // Activate Member Pending Points
                LoyaltiesMembersPendingPointsActivateResponseBody result = apiInstance.ActivateMemberPendingPoints(memberId, pendingPointsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ActivateMemberPendingPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateMemberPendingPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate Member Pending Points
    ApiResponse<LoyaltiesMembersPendingPointsActivateResponseBody> response = apiInstance.ActivateMemberPendingPointsWithHttpInfo(memberId, pendingPointsId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ActivateMemberPendingPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card code assigned to a particular customer. |  |
| **pendingPointsId** | **string** | Unique pending point identifier, assigned by Voucherify. |  |

### Return type

[**LoyaltiesMembersPendingPointsActivateResponseBody**](LoyaltiesMembersPendingPointsActivateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns details about the activated pending points, the current point balance, and loyalty card in general. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addmember"></a>
# **AddMember**
> LoyaltiesMembersCreateResponseBody AddMember (string campaignId, LoyaltiesMembersCreateRequestBody loyaltiesMembersCreateRequestBody = null)

Add Member

This method assigns a loyalty card to a customer. It selects a loyalty card suitable for publication, adds a publish entry, and returns the published voucher.   A voucher is suitable for publication when its active and hasnt been published yet.    📘 Auto-update campaign  In case you want to ensure the number of publishable codes increases automatically with the number of customers, you should use **auto-update** campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class AddMemberExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID of the loyalty program.
            var loyaltiesMembersCreateRequestBody = new LoyaltiesMembersCreateRequestBody(); // LoyaltiesMembersCreateRequestBody | Provide details to whom the loyalty card should be assigned.     You can choose to either specify the exact loyalty card code that you want to publish from existin (non-assigned) codes, or choose not to specify a voucher code. If you choose not to specify a code in the request paylaod, then the system will choose the next available voucher code available to be assigned to a customer.   You can also include metadata in the request payload. This metadata will be assigned to the publication object, but will not be returned in the response to this endpoint. To see of publications (assignments of particular codes to customers) and publication metadata, use the List Publications endpoint. (optional) 

            try
            {
                // Add Member
                LoyaltiesMembersCreateResponseBody result = apiInstance.AddMember(campaignId, loyaltiesMembersCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.AddMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Member
    ApiResponse<LoyaltiesMembersCreateResponseBody> response = apiInstance.AddMemberWithHttpInfo(campaignId, loyaltiesMembersCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.AddMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID of the loyalty program. |  |
| **loyaltiesMembersCreateRequestBody** | [**LoyaltiesMembersCreateRequestBody**](LoyaltiesMembersCreateRequestBody.md) | Provide details to whom the loyalty card should be assigned.     You can choose to either specify the exact loyalty card code that you want to publish from existin (non-assigned) codes, or choose not to specify a voucher code. If you choose not to specify a code in the request paylaod, then the system will choose the next available voucher code available to be assigned to a customer.   You can also include metadata in the request payload. This metadata will be assigned to the publication object, but will not be returned in the response to this endpoint. To see of publications (assignments of particular codes to customers) and publication metadata, use the List Publications endpoint. | [optional]  |

### Return type

[**LoyaltiesMembersCreateResponseBody**](LoyaltiesMembersCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the voucher object that was published to the customer provided in the request payload. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancelmemberpendingpoints"></a>
# **CancelMemberPendingPoints**
> void CancelMemberPendingPoints (string memberId, string pendingPointsId)

Cancel Member Pending Points

>🚧 Beta endpoint The endpoint is behind a feature flag as it is still in development. Contact [Voucherify support](https://www.voucherify.io/contact-support) to unlock the feature for your organization. All current parameters and fields are listed and described. Cancel manually the pending points for the loyalty card. The pending points are determined by the pending point ID. Once canceled, the pending point entry with that ID is not listed by the endpoints: List member (with campaign ID, without campaign ID), List campaign pending points. This **POST** method does not require a request body and it returns an empty, 204, response. 👍 Configuring pending points Pending points are configured as part of an earning rule with POST Create earning rule or PUT Update earning rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CancelMemberPendingPointsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card code assigned to a particular customer.
            var pendingPointsId = "pendingPointsId_example";  // string | Unique pending point identifier, assigned by Voucherify.

            try
            {
                // Cancel Member Pending Points
                apiInstance.CancelMemberPendingPoints(memberId, pendingPointsId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.CancelMemberPendingPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelMemberPendingPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Member Pending Points
    apiInstance.CancelMemberPendingPointsWithHttpInfo(memberId, pendingPointsId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.CancelMemberPendingPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card code assigned to a particular customer. |  |
| **pendingPointsId** | **string** | Unique pending point identifier, assigned by Voucherify. |  |

### Return type

void (empty response body)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content if the pending points are canceled successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createearningrule"></a>
# **CreateEarningRule**
> List&lt;LoyaltiesEarningRulesCreateResponseBody&gt; CreateEarningRule (string campaignId, List<LoyaltiesEarningRulesCreateRequestBodyItem> loyaltiesEarningRulesCreateRequestBodyItem = null)

Create Earning Rule

Create earning rules for a loyalty campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateEarningRuleExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var loyaltiesEarningRulesCreateRequestBodyItem = new List<LoyaltiesEarningRulesCreateRequestBodyItem>(); // List<LoyaltiesEarningRulesCreateRequestBodyItem> | Customize the request body based on the type of earning rules you would like to create. The request body is an array of objects. The required minimum properties to include in the payload for each object are event and loyalty. Additionally, if you choose to add a validity_timeframe, you must include a start_date. Furthermore, an earning rule event type:   - customer.segment.entered requires a segment object - a custom event requires a custom_event object - a customer.loyalty.tier.joined, customer.loyalty.tier.left, customer.loyalty.tier.upgraded, customer.loyalty.tier.downgraded, customer.loyalty.tier.prolonged requires a loyalty_tier object (optional) 

            try
            {
                // Create Earning Rule
                List<LoyaltiesEarningRulesCreateResponseBody> result = apiInstance.CreateEarningRule(campaignId, loyaltiesEarningRulesCreateRequestBodyItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.CreateEarningRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEarningRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Earning Rule
    ApiResponse<List<LoyaltiesEarningRulesCreateResponseBody>> response = apiInstance.CreateEarningRuleWithHttpInfo(campaignId, loyaltiesEarningRulesCreateRequestBodyItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.CreateEarningRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **loyaltiesEarningRulesCreateRequestBodyItem** | [**List&lt;LoyaltiesEarningRulesCreateRequestBodyItem&gt;**](LoyaltiesEarningRulesCreateRequestBodyItem.md) | Customize the request body based on the type of earning rules you would like to create. The request body is an array of objects. The required minimum properties to include in the payload for each object are event and loyalty. Additionally, if you choose to add a validity_timeframe, you must include a start_date. Furthermore, an earning rule event type:   - customer.segment.entered requires a segment object - a custom event requires a custom_event object - a customer.loyalty.tier.joined, customer.loyalty.tier.left, customer.loyalty.tier.upgraded, customer.loyalty.tier.downgraded, customer.loyalty.tier.prolonged requires a loyalty_tier object | [optional]  |

### Return type

[**List&lt;LoyaltiesEarningRulesCreateResponseBody&gt;**](LoyaltiesEarningRulesCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an array of earning rule objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createinbulkloyaltytiers"></a>
# **CreateInBulkLoyaltyTiers**
> List&lt;LoyaltyTier&gt; CreateInBulkLoyaltyTiers (string campaignId, List<LoyaltiesTiersCreateInBulkRequestBodyItem> loyaltiesTiersCreateInBulkRequestBodyItem = null)

Create loyalty tiers

Creates loyalty tiers for desired campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateInBulkLoyaltyTiersExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique loyalty campaign ID or name.
            var loyaltiesTiersCreateInBulkRequestBodyItem = new List<LoyaltiesTiersCreateInBulkRequestBodyItem>(); // List<LoyaltiesTiersCreateInBulkRequestBodyItem> | Provide tier definitions you want to add to existing loyalty campaign. (optional) 

            try
            {
                // Create loyalty tiers
                List<LoyaltyTier> result = apiInstance.CreateInBulkLoyaltyTiers(campaignId, loyaltiesTiersCreateInBulkRequestBodyItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.CreateInBulkLoyaltyTiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInBulkLoyaltyTiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create loyalty tiers
    ApiResponse<List<LoyaltyTier>> response = apiInstance.CreateInBulkLoyaltyTiersWithHttpInfo(campaignId, loyaltiesTiersCreateInBulkRequestBodyItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.CreateInBulkLoyaltyTiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique loyalty campaign ID or name. |  |
| **loyaltiesTiersCreateInBulkRequestBodyItem** | [**List&lt;LoyaltiesTiersCreateInBulkRequestBodyItem&gt;**](LoyaltiesTiersCreateInBulkRequestBodyItem.md) | Provide tier definitions you want to add to existing loyalty campaign. | [optional]  |

### Return type

[**List&lt;LoyaltyTier&gt;**](LoyaltyTier.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns created loyalty tiers. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createloyaltyprogram"></a>
# **CreateLoyaltyProgram**
> LoyaltiesCreateCampaignResponseBody CreateLoyaltyProgram (LoyaltiesCreateCampaignRequestBody loyaltiesCreateCampaignRequestBody = null)

Create Loyalty Campaign

Creates a batch of loyalty cards aggregated in a single loyalty campaign. It also allows you to define a custom codes pattern.    📘 Global uniqueness  All codes are unique across the whole project. Voucherify wont allow to generate the same codes in any of your campaigns.  🚧 Asyncronous action!  This is an asynchronous action, you cant read or modify a newly created campaign until the code generation is completed. See creation_status field in the loyalty campaign object description.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateLoyaltyProgramExample
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

            var apiInstance = new LoyaltiesApi(config);
            var loyaltiesCreateCampaignRequestBody = new LoyaltiesCreateCampaignRequestBody(); // LoyaltiesCreateCampaignRequestBody | Specify the loyalty campaign details. (optional) 

            try
            {
                // Create Loyalty Campaign
                LoyaltiesCreateCampaignResponseBody result = apiInstance.CreateLoyaltyProgram(loyaltiesCreateCampaignRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.CreateLoyaltyProgram: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLoyaltyProgramWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Loyalty Campaign
    ApiResponse<LoyaltiesCreateCampaignResponseBody> response = apiInstance.CreateLoyaltyProgramWithHttpInfo(loyaltiesCreateCampaignRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.CreateLoyaltyProgramWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loyaltiesCreateCampaignRequestBody** | [**LoyaltiesCreateCampaignRequestBody**](LoyaltiesCreateCampaignRequestBody.md) | Specify the loyalty campaign details. | [optional]  |

### Return type

[**LoyaltiesCreateCampaignResponseBody**](LoyaltiesCreateCampaignResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a campaign object with its settings but without the loyalty card codes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpointsexpirationexport"></a>
# **CreatePointsExpirationExport**
> LoyaltiesPointsExpirationExportCreateResponseBody CreatePointsExpirationExport (string campaignId, LoyaltiesPointsExpirationExportCreateRequestBody loyaltiesPointsExpirationExportCreateRequestBody = null)

Export Loyalty Campaign Point Expiration

Schedule the generation of a points expiration CSV file for a particular campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreatePointsExpirationExportExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID or name.
            var loyaltiesPointsExpirationExportCreateRequestBody = new LoyaltiesPointsExpirationExportCreateRequestBody(); // LoyaltiesPointsExpirationExportCreateRequestBody | Specify the data filters, types of data to return and order in which the results should be returned. (optional) 

            try
            {
                // Export Loyalty Campaign Point Expiration
                LoyaltiesPointsExpirationExportCreateResponseBody result = apiInstance.CreatePointsExpirationExport(campaignId, loyaltiesPointsExpirationExportCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.CreatePointsExpirationExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePointsExpirationExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Loyalty Campaign Point Expiration
    ApiResponse<LoyaltiesPointsExpirationExportCreateResponseBody> response = apiInstance.CreatePointsExpirationExportWithHttpInfo(campaignId, loyaltiesPointsExpirationExportCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.CreatePointsExpirationExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID or name. |  |
| **loyaltiesPointsExpirationExportCreateRequestBody** | [**LoyaltiesPointsExpirationExportCreateRequestBody**](LoyaltiesPointsExpirationExportCreateRequestBody.md) | Specify the data filters, types of data to return and order in which the results should be returned. | [optional]  |

### Return type

[**LoyaltiesPointsExpirationExportCreateResponseBody**](LoyaltiesPointsExpirationExportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an object with the export ID of the scheduled generation of CSV file with exported points expirations. You can use either the &lt;!- - [Get Export](OpenAPI.json/paths/~1exports~1{exportId}/get) - -&gt;[Get Export](ref:get-export) endpoint to view the status and obtain the URL of the CSV file or &lt;!- - [Download Export](OpenAPI.json/paths/~1exports~1{export_Id}/get) - -&gt;[Download Export](ref:download-export) endpoint to download the CSV file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrewardassignment1"></a>
# **CreateRewardAssignment1**
> LoyaltiesRewardsCreateAssignmentResponseBody CreateRewardAssignment1 (string campaignId, List<LoyaltiesRewardsCreateAssignmentItemRequestBody> loyaltiesRewardsCreateAssignmentItemRequestBody = null)

Create Reward Assignment

Add rewards to a loyalty campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class CreateRewardAssignment1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var loyaltiesRewardsCreateAssignmentItemRequestBody = new List<LoyaltiesRewardsCreateAssignmentItemRequestBody>(); // List<LoyaltiesRewardsCreateAssignmentItemRequestBody> | Define the cost of the rewards in loyalty points. (optional) 

            try
            {
                // Create Reward Assignment
                LoyaltiesRewardsCreateAssignmentResponseBody result = apiInstance.CreateRewardAssignment1(campaignId, loyaltiesRewardsCreateAssignmentItemRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.CreateRewardAssignment1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRewardAssignment1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Reward Assignment
    ApiResponse<LoyaltiesRewardsCreateAssignmentResponseBody> response = apiInstance.CreateRewardAssignment1WithHttpInfo(campaignId, loyaltiesRewardsCreateAssignmentItemRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.CreateRewardAssignment1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **loyaltiesRewardsCreateAssignmentItemRequestBody** | [**List&lt;LoyaltiesRewardsCreateAssignmentItemRequestBody&gt;**](LoyaltiesRewardsCreateAssignmentItemRequestBody.md) | Define the cost of the rewards in loyalty points. | [optional]  |

### Return type

[**LoyaltiesRewardsCreateAssignmentResponseBody**](LoyaltiesRewardsCreateAssignmentResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of reward assignment objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteearningrule"></a>
# **DeleteEarningRule**
> void DeleteEarningRule (string campaignId, string earningRuleId)

Delete Earning Rule

This method deletes an earning rule for a specific loyalty campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteEarningRuleExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var earningRuleId = "earningRuleId_example";  // string | A unique earning rule ID.

            try
            {
                // Delete Earning Rule
                apiInstance.DeleteEarningRule(campaignId, earningRuleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.DeleteEarningRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEarningRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Earning Rule
    apiInstance.DeleteEarningRuleWithHttpInfo(campaignId, earningRuleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.DeleteEarningRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **earningRuleId** | **string** | A unique earning rule ID. |  |

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

<a id="deleteloyaltyprogram"></a>
# **DeleteLoyaltyProgram**
> LoyaltiesDeleteResponseBody DeleteLoyaltyProgram (string campaignId, bool? force = null)

Delete Loyalty Campaign

Deletes a loyalty campaign and all related loyalty cards. This action cannot be undone. Also, it immediately removes any redemptions on loyalty cards. If the force parameter is set to false or not set at all, the loyalty campaign and all related loyalty cards will be moved to the bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteLoyaltyProgramExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var force = true;  // bool? | If this flag is set to true, the campaign and related vouchers will be removed permanently. If it is set to false or not set at all, the loyalty campaign and all related loyalty cards will be moved to the bin. Going forward, the user will be able to create the next campaign with the same name. (optional) 

            try
            {
                // Delete Loyalty Campaign
                LoyaltiesDeleteResponseBody result = apiInstance.DeleteLoyaltyProgram(campaignId, force);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.DeleteLoyaltyProgram: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLoyaltyProgramWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Loyalty Campaign
    ApiResponse<LoyaltiesDeleteResponseBody> response = apiInstance.DeleteLoyaltyProgramWithHttpInfo(campaignId, force);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.DeleteLoyaltyProgramWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **force** | **bool?** | If this flag is set to true, the campaign and related vouchers will be removed permanently. If it is set to false or not set at all, the loyalty campaign and all related loyalty cards will be moved to the bin. Going forward, the user will be able to create the next campaign with the same name. | [optional]  |

### Return type

[**LoyaltiesDeleteResponseBody**](LoyaltiesDeleteResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the ID of the scheduled asynchronous action, informing you that your request has been accepted and the loyalty campaign will be deleted from the repository asynchronously. To check the deletion status and result, copy the &#x60;async_action_id&#x60; from the response and pass it using &lt;!- - [Get Async Action](OpenAPI.json/paths/~1async-actions~1{asyncActionId}/get) - -&gt;[Get Async Action](ref:get-async-action) endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterewardassignment1"></a>
# **DeleteRewardAssignment1**
> void DeleteRewardAssignment1 (string campaignId, string assignmentId)

Delete Reward Assignment

This method deletes a reward assignment for a particular loyalty campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DeleteRewardAssignment1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var assignmentId = "assignmentId_example";  // string | A unique reward assignment ID.

            try
            {
                // Delete Reward Assignment
                apiInstance.DeleteRewardAssignment1(campaignId, assignmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.DeleteRewardAssignment1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRewardAssignment1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Reward Assignment
    apiInstance.DeleteRewardAssignment1WithHttpInfo(campaignId, assignmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.DeleteRewardAssignment1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **assignmentId** | **string** | A unique reward assignment ID. |  |

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

<a id="disableearningrule"></a>
# **DisableEarningRule**
> LoyaltiesEarningRulesDisableResponseBody DisableEarningRule (string campaignId, string earningRuleId)

Disable Earning Rule

Disable an earning rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class DisableEarningRuleExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID or name.
            var earningRuleId = "earningRuleId_example";  // string | Unique identifier of an earning rule, assigned by Voucherify.

            try
            {
                // Disable Earning Rule
                LoyaltiesEarningRulesDisableResponseBody result = apiInstance.DisableEarningRule(campaignId, earningRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.DisableEarningRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableEarningRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable Earning Rule
    ApiResponse<LoyaltiesEarningRulesDisableResponseBody> response = apiInstance.DisableEarningRuleWithHttpInfo(campaignId, earningRuleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.DisableEarningRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID or name. |  |
| **earningRuleId** | **string** | Unique identifier of an earning rule, assigned by Voucherify. |  |

### Return type

[**LoyaltiesEarningRulesDisableResponseBody**](LoyaltiesEarningRulesDisableResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an earning rule object with the &#x60;active&#x60; parameter set to &#x60;false&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="enableearningrule"></a>
# **EnableEarningRule**
> LoyaltiesEarningRulesEnableResponseBody EnableEarningRule (string campaignId, string earningRuleId)

Enable Earning Rule

Enable an earning rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class EnableEarningRuleExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID or name.
            var earningRuleId = "earningRuleId_example";  // string | Unique identifier of an earning rule, assigned by Voucherify.

            try
            {
                // Enable Earning Rule
                LoyaltiesEarningRulesEnableResponseBody result = apiInstance.EnableEarningRule(campaignId, earningRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.EnableEarningRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableEarningRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Earning Rule
    ApiResponse<LoyaltiesEarningRulesEnableResponseBody> response = apiInstance.EnableEarningRuleWithHttpInfo(campaignId, earningRuleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.EnableEarningRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID or name. |  |
| **earningRuleId** | **string** | Unique identifier of an earning rule, assigned by Voucherify. |  |

### Return type

[**LoyaltiesEarningRulesEnableResponseBody**](LoyaltiesEarningRulesEnableResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an earning rule object with the &#x60;active&#x60; parameter set to &#x60;true&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportloyaltycampaigntransactions"></a>
# **ExportLoyaltyCampaignTransactions**
> CampaignsTransactionsExportCreateResponseBody ExportLoyaltyCampaignTransactions (string campaignId, LoyaltiesTransactionsExportCreateRequestBody loyaltiesTransactionsExportCreateRequestBody = null)

Export Loyalty Campaign Transactions

Export transactions is an asynchronous process that generates a CSV file with the data about or point movements on all loyalty cards in a given campaign. To export transactions: 1. In the export request, use parameters to select which fields will be exported, in what order, and which data will be filtered. 2. Use the returned id to track the export status with the GET Export method. 3. In the GET Export method, when the returned status field has the DONE value, the export file has been generated. 4. Use the URL in the result property to download the file. You must be logged to your Voucherify account on a given cluster in the browser to be able to download the file. An export request will almost always result in a single file being generated by the system. However, when the data volume is large, the system may split the results into multiple files. An example export file can look as follows:    👍 Export Campaign Transactions  This method works in the same way the POST Export Campaign Transactions does, but it is limited to loyalty campaigns only. The POST Export Campaign Transactions method can also export gift card campaign transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExportLoyaltyCampaignTransactionsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var loyaltiesTransactionsExportCreateRequestBody = new LoyaltiesTransactionsExportCreateRequestBody(); // LoyaltiesTransactionsExportCreateRequestBody | Specify the parameters for the transaction export. (optional) 

            try
            {
                // Export Loyalty Campaign Transactions
                CampaignsTransactionsExportCreateResponseBody result = apiInstance.ExportLoyaltyCampaignTransactions(campaignId, loyaltiesTransactionsExportCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ExportLoyaltyCampaignTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyCampaignTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Loyalty Campaign Transactions
    ApiResponse<CampaignsTransactionsExportCreateResponseBody> response = apiInstance.ExportLoyaltyCampaignTransactionsWithHttpInfo(campaignId, loyaltiesTransactionsExportCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ExportLoyaltyCampaignTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **loyaltiesTransactionsExportCreateRequestBody** | [**LoyaltiesTransactionsExportCreateRequestBody**](LoyaltiesTransactionsExportCreateRequestBody.md) | Specify the parameters for the transaction export. | [optional]  |

### Return type

[**CampaignsTransactionsExportCreateResponseBody**](CampaignsTransactionsExportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object representing an export. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportloyaltycardtransactions"></a>
# **ExportLoyaltyCardTransactions**
> LoyaltiesMembersTransactionsExportCreateResponseBody ExportLoyaltyCardTransactions (string memberId, LoyaltiesMembersTransactionsExportCreateRequestBody loyaltiesMembersTransactionsExportCreateRequestBody = null)

Export Loyalty Card Transactions

Export transactions that are associated with point movements on a loyalty card.   

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExportLoyaltyCardTransactionsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | A unique code identifying the loyalty card that you are looking to export transaction data for.
            var loyaltiesMembersTransactionsExportCreateRequestBody = new LoyaltiesMembersTransactionsExportCreateRequestBody(); // LoyaltiesMembersTransactionsExportCreateRequestBody | Specify the parameters and filters for the transaction export. (optional) 

            try
            {
                // Export Loyalty Card Transactions
                LoyaltiesMembersTransactionsExportCreateResponseBody result = apiInstance.ExportLoyaltyCardTransactions(memberId, loyaltiesMembersTransactionsExportCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ExportLoyaltyCardTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyCardTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Loyalty Card Transactions
    ApiResponse<LoyaltiesMembersTransactionsExportCreateResponseBody> response = apiInstance.ExportLoyaltyCardTransactionsWithHttpInfo(memberId, loyaltiesMembersTransactionsExportCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ExportLoyaltyCardTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | A unique code identifying the loyalty card that you are looking to export transaction data for. |  |
| **loyaltiesMembersTransactionsExportCreateRequestBody** | [**LoyaltiesMembersTransactionsExportCreateRequestBody**](LoyaltiesMembersTransactionsExportCreateRequestBody.md) | Specify the parameters and filters for the transaction export. | [optional]  |

### Return type

[**LoyaltiesMembersTransactionsExportCreateResponseBody**](LoyaltiesMembersTransactionsExportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an export object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportloyaltycardtransactions1"></a>
# **ExportLoyaltyCardTransactions1**
> LoyaltiesMembersTransactionsExportCreateResponseBody ExportLoyaltyCardTransactions1 (string campaignId, string memberId, LoyaltiesMembersTransactionsExportCreateRequestBody loyaltiesMembersTransactionsExportCreateRequestBody = null)

Export Loyalty Card Transactions

Export transactions that are associated with point movements on a loyalty card.   

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ExportLoyaltyCardTransactions1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | A unique identifier of the loyalty campaign containing the voucher whose transactions you would like to export.
            var memberId = "memberId_example";  // string | A unique code identifying the loyalty card that you are looking to export transaction data for.
            var loyaltiesMembersTransactionsExportCreateRequestBody = new LoyaltiesMembersTransactionsExportCreateRequestBody(); // LoyaltiesMembersTransactionsExportCreateRequestBody | Specify the parameters and filters for the transaction export. (optional) 

            try
            {
                // Export Loyalty Card Transactions
                LoyaltiesMembersTransactionsExportCreateResponseBody result = apiInstance.ExportLoyaltyCardTransactions1(campaignId, memberId, loyaltiesMembersTransactionsExportCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ExportLoyaltyCardTransactions1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportLoyaltyCardTransactions1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Loyalty Card Transactions
    ApiResponse<LoyaltiesMembersTransactionsExportCreateResponseBody> response = apiInstance.ExportLoyaltyCardTransactions1WithHttpInfo(campaignId, memberId, loyaltiesMembersTransactionsExportCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ExportLoyaltyCardTransactions1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | A unique identifier of the loyalty campaign containing the voucher whose transactions you would like to export. |  |
| **memberId** | **string** | A unique code identifying the loyalty card that you are looking to export transaction data for. |  |
| **loyaltiesMembersTransactionsExportCreateRequestBody** | [**LoyaltiesMembersTransactionsExportCreateRequestBody**](LoyaltiesMembersTransactionsExportCreateRequestBody.md) | Specify the parameters and filters for the transaction export. | [optional]  |

### Return type

[**LoyaltiesMembersTransactionsExportCreateResponseBody**](LoyaltiesMembersTransactionsExportCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an export object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getearningrule"></a>
# **GetEarningRule**
> LoyaltiesEarningRulesGetResponseBody GetEarningRule (string campaignId, string earningRuleId)

Get Earning Rule

Retrieves an earning rule assigned to a campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetEarningRuleExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var earningRuleId = "earningRuleId_example";  // string | A unique earning rule ID.

            try
            {
                // Get Earning Rule
                LoyaltiesEarningRulesGetResponseBody result = apiInstance.GetEarningRule(campaignId, earningRuleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetEarningRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEarningRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Earning Rule
    ApiResponse<LoyaltiesEarningRulesGetResponseBody> response = apiInstance.GetEarningRuleWithHttpInfo(campaignId, earningRuleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetEarningRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **earningRuleId** | **string** | A unique earning rule ID. |  |

### Return type

[**LoyaltiesEarningRulesGetResponseBody**](LoyaltiesEarningRulesGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an earning rule object with the earning rule details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getloyaltyprogram"></a>
# **GetLoyaltyProgram**
> LoyaltiesGetCampaignResponseBody GetLoyaltyProgram (string campaignId)

Get Loyalty Campaign

Retrieve a specific loyalty campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetLoyaltyProgramExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 

            try
            {
                // Get Loyalty Campaign
                LoyaltiesGetCampaignResponseBody result = apiInstance.GetLoyaltyProgram(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetLoyaltyProgram: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyProgramWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Loyalty Campaign
    ApiResponse<LoyaltiesGetCampaignResponseBody> response = apiInstance.GetLoyaltyProgramWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetLoyaltyProgramWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |

### Return type

[**LoyaltiesGetCampaignResponseBody**](LoyaltiesGetCampaignResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a loyalty campaign object for a given loyalty campaign ID.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getloyaltytier"></a>
# **GetLoyaltyTier**
> LoyaltiesTiersGetResponseBody GetLoyaltyTier (string campaignId, string loyaltyTierId)

Get Loyalty Tier

Retrieve a loyalty tier from a loyalty campaign by the loyalty tier ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetLoyaltyTierExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique loyalty campaign ID or name.
            var loyaltyTierId = "loyaltyTierId_example";  // string | Unique loyalty tier ID.

            try
            {
                // Get Loyalty Tier
                LoyaltiesTiersGetResponseBody result = apiInstance.GetLoyaltyTier(campaignId, loyaltyTierId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetLoyaltyTier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoyaltyTierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Loyalty Tier
    ApiResponse<LoyaltiesTiersGetResponseBody> response = apiInstance.GetLoyaltyTierWithHttpInfo(campaignId, loyaltyTierId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetLoyaltyTierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique loyalty campaign ID or name. |  |
| **loyaltyTierId** | **string** | Unique loyalty tier ID. |  |

### Return type

[**LoyaltiesTiersGetResponseBody**](LoyaltiesTiersGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a loyalty tier object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmember"></a>
# **GetMember**
> LoyaltiesMembersGetResponseBody GetMember (string memberId)

Get Member

Retrieve loyalty card with the given member ID (i.e. voucher code).      📘 Alternative endpoint  This endpoint is an alternative to this endpoint. The URL was re-designed to allow you to retrieve loyalty card details without having to provide the campaignId as a path parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetMemberExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card code assigned to a particular customer.

            try
            {
                // Get Member
                LoyaltiesMembersGetResponseBody result = apiInstance.GetMember(memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Member
    ApiResponse<LoyaltiesMembersGetResponseBody> response = apiInstance.GetMemberWithHttpInfo(memberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card code assigned to a particular customer. |  |

### Return type

[**LoyaltiesMembersGetResponseBody**](LoyaltiesMembersGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns loyalty card details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmember1"></a>
# **GetMember1**
> LoyaltiesMembersGetResponseBody GetMember1 (string campaignId, string memberId)

Get Member

Retrieves the loyalty card with the given member ID (i.e. voucher code).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetMember1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.
            var memberId = "memberId_example";  // string | Unique code that identifies the loyalty card.

            try
            {
                // Get Member
                LoyaltiesMembersGetResponseBody result = apiInstance.GetMember1(campaignId, memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetMember1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMember1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Member
    ApiResponse<LoyaltiesMembersGetResponseBody> response = apiInstance.GetMember1WithHttpInfo(campaignId, memberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetMember1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |
| **memberId** | **string** | Unique code that identifies the loyalty card. |  |

### Return type

[**LoyaltiesMembersGetResponseBody**](LoyaltiesMembersGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns loyalty card details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrewardassignment1"></a>
# **GetRewardAssignment1**
> LoyaltiesRewardAssignmentsGetResponseBody GetRewardAssignment1 (string campaignId, string assignmentId)

Get Reward Assignment

Retrieve specific reward assignment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetRewardAssignment1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var assignmentId = "assignmentId_example";  // string | Unique reward assignment ID.

            try
            {
                // Get Reward Assignment
                LoyaltiesRewardAssignmentsGetResponseBody result = apiInstance.GetRewardAssignment1(campaignId, assignmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetRewardAssignment1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRewardAssignment1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Reward Assignment
    ApiResponse<LoyaltiesRewardAssignmentsGetResponseBody> response = apiInstance.GetRewardAssignment1WithHttpInfo(campaignId, assignmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetRewardAssignment1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **assignmentId** | **string** | Unique reward assignment ID. |  |

### Return type

[**LoyaltiesRewardAssignmentsGetResponseBody**](LoyaltiesRewardAssignmentsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns specific reward assignment. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrewardassignment2"></a>
# **GetRewardAssignment2**
> LoyaltiesRewardsGetResponseBody GetRewardAssignment2 (string campaignId, string assignmentId)

Get Reward Assignment

Retrieve specific reward assignment.  📘 Alternative endpoint  This endpoint is an alternative to this endpoint. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetRewardAssignment2Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var assignmentId = "assignmentId_example";  // string | A unique reward assignment ID.

            try
            {
                // Get Reward Assignment
                LoyaltiesRewardsGetResponseBody result = apiInstance.GetRewardAssignment2(campaignId, assignmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetRewardAssignment2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRewardAssignment2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Reward Assignment
    ApiResponse<LoyaltiesRewardsGetResponseBody> response = apiInstance.GetRewardAssignment2WithHttpInfo(campaignId, assignmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetRewardAssignment2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **assignmentId** | **string** | A unique reward assignment ID. |  |

### Return type

[**LoyaltiesRewardsGetResponseBody**](LoyaltiesRewardsGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns specific reward assignment. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrewarddetails"></a>
# **GetRewardDetails**
> LoyaltiesRewardAssignmentsRewardGetResponseBody GetRewardDetails (string campaignId, string assignmentId)

Get Reward Details

Get reward details in the context of a loyalty campaign and reward assignment ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class GetRewardDetailsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var assignmentId = "assignmentId_example";  // string | Unique reward assignment ID.

            try
            {
                // Get Reward Details
                LoyaltiesRewardAssignmentsRewardGetResponseBody result = apiInstance.GetRewardDetails(campaignId, assignmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.GetRewardDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRewardDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Reward Details
    ApiResponse<LoyaltiesRewardAssignmentsRewardGetResponseBody> response = apiInstance.GetRewardDetailsWithHttpInfo(campaignId, assignmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.GetRewardDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **assignmentId** | **string** | Unique reward assignment ID. |  |

### Return type

[**LoyaltiesRewardAssignmentsRewardGetResponseBody**](LoyaltiesRewardAssignmentsRewardGetResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns reward details in the context of a loyalty *campaign* and reward assignment ID. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcampaignpendingpoints"></a>
# **ListCampaignPendingPoints**
> LoyaltiesPendingPointsListResponseBody ListCampaignPendingPoints (string campaignId, int? limit = null, ParameterOrderListPendingPoints? order = null, string startingAfterId = null)

List Campaign Pending Points

>🚧 Beta endpoint The endpoint is behind a feature flag as it is still in development. Contact [Voucherify support](https://www.voucherify.io/contact-support) to unlock the feature for your organization. All current parameters and fields are listed and described. Lists all pending points that are currently assigned to all loyalty cards in a campaign. Once the points are added to the card, the entry is no longer returned. 👍 Configuring pending points Pending points are configured as part of an earning rule with POST Create earning rule or PUT Update earning rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListCampaignPendingPointsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.
            var limit = 56;  // int? | Limit the number of the pending point entries that the API returns in the response. (optional) 
            var order = (ParameterOrderListPendingPoints) "id";  // ParameterOrderListPendingPoints? | Orders the pending point entries according the pending point entry ID. The dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the results starting after a result with the given ID. (optional) 

            try
            {
                // List Campaign Pending Points
                LoyaltiesPendingPointsListResponseBody result = apiInstance.ListCampaignPendingPoints(campaignId, limit, order, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListCampaignPendingPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCampaignPendingPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Campaign Pending Points
    ApiResponse<LoyaltiesPendingPointsListResponseBody> response = apiInstance.ListCampaignPendingPointsWithHttpInfo(campaignId, limit, order, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListCampaignPendingPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |
| **limit** | **int?** | Limit the number of the pending point entries that the API returns in the response. | [optional]  |
| **order** | **ParameterOrderListPendingPoints?** | Orders the pending point entries according the pending point entry ID. The dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the results starting after a result with the given ID. | [optional]  |

### Return type

[**LoyaltiesPendingPointsListResponseBody**](LoyaltiesPendingPointsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all pending point entries for all loyalty cards in the campaign. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listearningrules"></a>
# **ListEarningRules**
> LoyaltiesEarningRulesListResponseBody ListEarningRules (string campaignId, int? limit = null, int? page = null, ParameterOrderListEarningRules? order = null)

List Earning Rules

Returns a list of all earning rules within a given campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListEarningRulesExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var order = (ParameterOrderListEarningRules) "created_at";  // ParameterOrderListEarningRules? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Earning Rules
                LoyaltiesEarningRulesListResponseBody result = apiInstance.ListEarningRules(campaignId, limit, page, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListEarningRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEarningRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Earning Rules
    ApiResponse<LoyaltiesEarningRulesListResponseBody> response = apiInstance.ListEarningRulesWithHttpInfo(campaignId, limit, page, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListEarningRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **order** | **ParameterOrderListEarningRules?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**LoyaltiesEarningRulesListResponseBody**](LoyaltiesEarningRulesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of earning rules. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listloyaltycampaigntransactions"></a>
# **ListLoyaltyCampaignTransactions**
> LoyaltiesTransactionsListResponseBody ListLoyaltyCampaignTransactions (string campaignId, int? limit = null, ParameterOrderListTransactions? order = null, string startingAfterId = null, ParametersFiltersListCampaignTransactions filters = null)

List Loyalty Campaign Transactions

Retrieves all transactions for the campaign with the given campaign ID or campaign name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListLoyaltyCampaignTransactionsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListTransactions) "id";  // ParameterOrderListTransactions? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. (optional) 
            var filters = new ParametersFiltersListCampaignTransactions(); // ParametersFiltersListCampaignTransactions | Filters for listing responses. The id filter denotes the unique transaction identifier. (optional) 

            try
            {
                // List Loyalty Campaign Transactions
                LoyaltiesTransactionsListResponseBody result = apiInstance.ListLoyaltyCampaignTransactions(campaignId, limit, order, startingAfterId, filters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyCampaignTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLoyaltyCampaignTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Campaign Transactions
    ApiResponse<LoyaltiesTransactionsListResponseBody> response = apiInstance.ListLoyaltyCampaignTransactionsWithHttpInfo(campaignId, limit, order, startingAfterId, filters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyCampaignTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListTransactions?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. | [optional]  |
| **filters** | [**ParametersFiltersListCampaignTransactions**](ParametersFiltersListCampaignTransactions.md) | Filters for listing responses. The id filter denotes the unique transaction identifier. | [optional]  |

### Return type

[**LoyaltiesTransactionsListResponseBody**](LoyaltiesTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with a &#x60;data&#x60; property that contains an array of transactions. The maximum number of transactions returned is determined by the &#x60;limit&#x60; query parameter. Each entry in the array is a separate transaction object. If more results are available, the &#x60;has_more&#x60; flag has value &#x60;true&#x60; and the value of the &#x60;more_starting_after&#x60; property can be used to retrieve another page of results. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listloyaltycardtransactions"></a>
# **ListLoyaltyCardTransactions**
> LoyaltiesMembersTransactionsListResponseBody ListLoyaltyCardTransactions (string memberId, int? limit = null, ParameterOrderListTransactions? order = null, ParameterFiltersListMemberTransactions filters = null, string startingAfterId = null)

List Loyalty Card Transactions

Retrieve transaction data related to point movements for a specific loyalty card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListLoyaltyCardTransactionsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | A unique code identifying the loyalty card that you are looking to retrieve transaction data for.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListTransactions) "id";  // ParameterOrderListTransactions? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var filters = new ParameterFiltersListMemberTransactions(); // ParameterFiltersListMemberTransactions | Filters for listing member transactions. id is the unique identifier of the transaction. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. (optional) 

            try
            {
                // List Loyalty Card Transactions
                LoyaltiesMembersTransactionsListResponseBody result = apiInstance.ListLoyaltyCardTransactions(memberId, limit, order, filters, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyCardTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLoyaltyCardTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Card Transactions
    ApiResponse<LoyaltiesMembersTransactionsListResponseBody> response = apiInstance.ListLoyaltyCardTransactionsWithHttpInfo(memberId, limit, order, filters, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyCardTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | A unique code identifying the loyalty card that you are looking to retrieve transaction data for. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListTransactions?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **filters** | [**ParameterFiltersListMemberTransactions**](ParameterFiltersListMemberTransactions.md) | Filters for listing member transactions. id is the unique identifier of the transaction. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. | [optional]  |

### Return type

[**LoyaltiesMembersTransactionsListResponseBody**](LoyaltiesMembersTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of loyalty card transaction objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listloyaltycardtransactions1"></a>
# **ListLoyaltyCardTransactions1**
> LoyaltiesMembersTransactionsListResponseBody ListLoyaltyCardTransactions1 (string campaignId, string memberId, int? limit = null, ParameterOrderListTransactions? order = null, ParameterFiltersListMemberTransactions filters = null, string startingAfterId = null)

List Loyalty Card Transactions

Retrieve transaction data related to point movements for a specific loyalty card.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListLoyaltyCardTransactions1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | A unique identifier of the loyalty campaign containing the voucher whose transactions you would like to return.
            var memberId = "memberId_example";  // string | A unique code identifying the loyalty card that you are looking to retrieve transaction data for.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListTransactions) "id";  // ParameterOrderListTransactions? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var filters = new ParameterFiltersListMemberTransactions(); // ParameterFiltersListMemberTransactions | Filters for listing member transactions. id is the unique identifier of the transaction. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. (optional) 

            try
            {
                // List Loyalty Card Transactions
                LoyaltiesMembersTransactionsListResponseBody result = apiInstance.ListLoyaltyCardTransactions1(campaignId, memberId, limit, order, filters, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyCardTransactions1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLoyaltyCardTransactions1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Card Transactions
    ApiResponse<LoyaltiesMembersTransactionsListResponseBody> response = apiInstance.ListLoyaltyCardTransactions1WithHttpInfo(campaignId, memberId, limit, order, filters, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyCardTransactions1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | A unique identifier of the loyalty campaign containing the voucher whose transactions you would like to return. |  |
| **memberId** | **string** | A unique code identifying the loyalty card that you are looking to retrieve transaction data for. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListTransactions?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **filters** | [**ParameterFiltersListMemberTransactions**](ParameterFiltersListMemberTransactions.md) | Filters for listing member transactions. id is the unique identifier of the transaction. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the transactions starting after a transaction with the given ID. | [optional]  |

### Return type

[**LoyaltiesMembersTransactionsListResponseBody**](LoyaltiesMembersTransactionsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of loyalty card transaction objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listloyaltyprograms"></a>
# **ListLoyaltyPrograms**
> LoyaltiesListCampaignsResponseBody ListLoyaltyPrograms (int? limit = null, int? page = null, ParameterExpandListCampaigns? expand = null, ParameterOrderListCampaigns? order = null)

List Loyalty Campaigns

Returns a list of your loyalty campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListLoyaltyProgramsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var expand = (ParameterExpandListCampaigns) "category";  // ParameterExpandListCampaigns? | Includes an expanded categories object in the response. If the [Areas and Stores](https://support.voucherify.io/article/623-areas-and-stores) Enterprise feature is enabled, add access_settings_assignments to return assigned areas and stores. (optional) 
            var order = (ParameterOrderListCampaigns) "created_at";  // ParameterOrderListCampaigns? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Loyalty Campaigns
                LoyaltiesListCampaignsResponseBody result = apiInstance.ListLoyaltyPrograms(limit, page, expand, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyPrograms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLoyaltyProgramsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Campaigns
    ApiResponse<LoyaltiesListCampaignsResponseBody> response = apiInstance.ListLoyaltyProgramsWithHttpInfo(limit, page, expand, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyProgramsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **expand** | **ParameterExpandListCampaigns?** | Includes an expanded categories object in the response. If the [Areas and Stores](https://support.voucherify.io/article/623-areas-and-stores) Enterprise feature is enabled, add access_settings_assignments to return assigned areas and stores. | [optional]  |
| **order** | **ParameterOrderListCampaigns?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**LoyaltiesListCampaignsResponseBody**](LoyaltiesListCampaignsResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with loyalty program objects. The loyalty campaigns are returned sorted by creation date, with the most recent campaigns appearing first. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listloyaltytierearningrules"></a>
# **ListLoyaltyTierEarningRules**
> LoyaltiesTiersEarningRulesListResponseBody ListLoyaltyTierEarningRules (string campaignId, string loyaltyTierId, int? limit = null, int? page = null)

List Loyalty Tier Earning Rules

Retrieve available earning rules for a given tier and the calculation method for earning points.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListLoyaltyTierEarningRulesExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID or name.
            var loyaltyTierId = "loyaltyTierId_example";  // string | Unique loyalty tier ID.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 

            try
            {
                // List Loyalty Tier Earning Rules
                LoyaltiesTiersEarningRulesListResponseBody result = apiInstance.ListLoyaltyTierEarningRules(campaignId, loyaltyTierId, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyTierEarningRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLoyaltyTierEarningRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Tier Earning Rules
    ApiResponse<LoyaltiesTiersEarningRulesListResponseBody> response = apiInstance.ListLoyaltyTierEarningRulesWithHttpInfo(campaignId, loyaltyTierId, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyTierEarningRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID or name. |  |
| **loyaltyTierId** | **string** | Unique loyalty tier ID. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |

### Return type

[**LoyaltiesTiersEarningRulesListResponseBody**](LoyaltiesTiersEarningRulesListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of earning rules for a given tier. The object for each earning rule also contains information about how the points are calculated; this includes mapping. If a specific multiplier was used to calculate points for a given tier, then the &#x60;loyalty.points&#x60; parameter will account for this calculation. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listloyaltytierrewards"></a>
# **ListLoyaltyTierRewards**
> LoyaltiesTiersRewardsListResponseBody ListLoyaltyTierRewards (string campaignId, string loyaltyTierId)

List Loyalty Tier Rewards

Get available rewards for a given tier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListLoyaltyTierRewardsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID or name.
            var loyaltyTierId = "loyaltyTierId_example";  // string | Unique loyalty tier ID.

            try
            {
                // List Loyalty Tier Rewards
                LoyaltiesTiersRewardsListResponseBody result = apiInstance.ListLoyaltyTierRewards(campaignId, loyaltyTierId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyTierRewards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLoyaltyTierRewardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Tier Rewards
    ApiResponse<LoyaltiesTiersRewardsListResponseBody> response = apiInstance.ListLoyaltyTierRewardsWithHttpInfo(campaignId, loyaltyTierId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyTierRewardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID or name. |  |
| **loyaltyTierId** | **string** | Unique loyalty tier ID. |  |

### Return type

[**LoyaltiesTiersRewardsListResponseBody**](LoyaltiesTiersRewardsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary of loyalty tier reward objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listloyaltytiers"></a>
# **ListLoyaltyTiers**
> LoyaltiesTiersListResponseBody ListLoyaltyTiers (string campaignId, int? limit = null, ParameterOrderListLoyaltyTiers? order = null)

List Loyalty Tiers

Retrieve a list of loyalty tiers which were added to the loyalty program.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListLoyaltyTiersExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique loyalty campaign ID or name.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderListLoyaltyTiers) "created_at";  // ParameterOrderListLoyaltyTiers? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 

            try
            {
                // List Loyalty Tiers
                LoyaltiesTiersListResponseBody result = apiInstance.ListLoyaltyTiers(campaignId, limit, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyTiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLoyaltyTiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Tiers
    ApiResponse<LoyaltiesTiersListResponseBody> response = apiInstance.ListLoyaltyTiersWithHttpInfo(campaignId, limit, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListLoyaltyTiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique loyalty campaign ID or name. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderListLoyaltyTiers?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |

### Return type

[**LoyaltiesTiersListResponseBody**](LoyaltiesTiersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of loyalty tier objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberactivity"></a>
# **ListMemberActivity**
> LoyaltiesMemberActivityListResponseBody ListMemberActivity (string memberId, int? limit = null, ParameterOrderCreatedAt? order = null, string startingAfterId = null)

List Member Activity

  📘 Alternative endpoint  This endpoint is an alternative to this endpoint. The URL was re-designed to allow you to get member activities without having to provide the campaignId as a path parameter. Retrieves the list of activities for the given member ID related to a voucher and customer who is the holder of the voucher.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberActivityExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card assigned to a particular customer.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderCreatedAt) "created_at";  // ParameterOrderCreatedAt? | Apply this filter to order the events according the date and time when it was created. The dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the events starting after an event with the given ID. (optional) 

            try
            {
                // List Member Activity
                LoyaltiesMemberActivityListResponseBody result = apiInstance.ListMemberActivity(memberId, limit, order, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListMemberActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Member Activity
    ApiResponse<LoyaltiesMemberActivityListResponseBody> response = apiInstance.ListMemberActivityWithHttpInfo(memberId, limit, order, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListMemberActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card assigned to a particular customer. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderCreatedAt?** | Apply this filter to order the events according the date and time when it was created. The dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the events starting after an event with the given ID. | [optional]  |

### Return type

[**LoyaltiesMemberActivityListResponseBody**](LoyaltiesMemberActivityListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of event objects related to the loyalty card. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberactivity1"></a>
# **ListMemberActivity1**
> LoyaltiesMemberActivityListResponseBody ListMemberActivity1 (string campaignId, string memberId, int? limit = null, ParameterOrderCreatedAt? order = null, string startingAfterId = null)

List Member Activity

Retrieves the list of activities for the given member ID related to a voucher and customer who is the holder of the voucher.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberActivity1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.
            var memberId = "memberId_example";  // string | A code that identifies the loyalty card.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var order = (ParameterOrderCreatedAt) "created_at";  // ParameterOrderCreatedAt? | Apply this filter to order the events according the date and time when it was created. The dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the events starting after an event with the given ID. (optional) 

            try
            {
                // List Member Activity
                LoyaltiesMemberActivityListResponseBody result = apiInstance.ListMemberActivity1(campaignId, memberId, limit, order, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListMemberActivity1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberActivity1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Member Activity
    ApiResponse<LoyaltiesMemberActivityListResponseBody> response = apiInstance.ListMemberActivity1WithHttpInfo(campaignId, memberId, limit, order, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListMemberActivity1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |
| **memberId** | **string** | A code that identifies the loyalty card. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **order** | **ParameterOrderCreatedAt?** | Apply this filter to order the events according the date and time when it was created. The dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the events starting after an event with the given ID. | [optional]  |

### Return type

[**LoyaltiesMemberActivityListResponseBody**](LoyaltiesMemberActivityListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of event objects related to the loyalty card. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberloyaltytier"></a>
# **ListMemberLoyaltyTier**
> LoyaltiesMembersTiersListResponseBody ListMemberLoyaltyTier (string memberId)

List Member's Loyalty Tiers

Retrieve member tiers using the loyalty card ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberLoyaltyTierExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card assigned to a particular customer.

            try
            {
                // List Member's Loyalty Tiers
                LoyaltiesMembersTiersListResponseBody result = apiInstance.ListMemberLoyaltyTier(memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListMemberLoyaltyTier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberLoyaltyTierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Member's Loyalty Tiers
    ApiResponse<LoyaltiesMembersTiersListResponseBody> response = apiInstance.ListMemberLoyaltyTierWithHttpInfo(memberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListMemberLoyaltyTierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card assigned to a particular customer. |  |

### Return type

[**LoyaltiesMembersTiersListResponseBody**](LoyaltiesMembersTiersListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a data array containing the member&#39;s loyalty tiers. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberpendingpoints"></a>
# **ListMemberPendingPoints**
> LoyaltiesMembersPendingPointsListResponseBody ListMemberPendingPoints (string memberId, int? limit = null, ParameterOrderListPendingPoints? order = null, string startingAfterId = null)

List Member Pending Points

>🚧 Beta endpoint The endpoint is behind a feature flag as it is still in development. Contact [Voucherify support](https://www.voucherify.io/contact-support) to unlock the feature for your organization. All current parameters and fields are listed and described.  📘 Alternative endpoint  This endpoint is an alternative to this endpoint. The URL was re-designed to list member pending points without having to provide the campaignId as a path parameter. Lists all pending points that are currently assigned to the loyalty card. Once the points are added to the card, the entry is no longer returned. 👍 Configuring pending points Pending points are configured as part of an earning rule with POST Create earning rule or PUT Update earning rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberPendingPointsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card code assigned to a particular customer.
            var limit = 56;  // int? | Limit the number of the pending point entries that the API returns in the response. (optional) 
            var order = (ParameterOrderListPendingPoints) "id";  // ParameterOrderListPendingPoints? | Orders the pending point entries according the pending point entry ID. The dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the results starting after a result with the given ID. (optional) 

            try
            {
                // List Member Pending Points
                LoyaltiesMembersPendingPointsListResponseBody result = apiInstance.ListMemberPendingPoints(memberId, limit, order, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListMemberPendingPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberPendingPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Member Pending Points
    ApiResponse<LoyaltiesMembersPendingPointsListResponseBody> response = apiInstance.ListMemberPendingPointsWithHttpInfo(memberId, limit, order, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListMemberPendingPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card code assigned to a particular customer. |  |
| **limit** | **int?** | Limit the number of the pending point entries that the API returns in the response. | [optional]  |
| **order** | **ParameterOrderListPendingPoints?** | Orders the pending point entries according the pending point entry ID. The dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the results starting after a result with the given ID. | [optional]  |

### Return type

[**LoyaltiesMembersPendingPointsListResponseBody**](LoyaltiesMembersPendingPointsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all pending point entries. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberpendingpoints1"></a>
# **ListMemberPendingPoints1**
> LoyaltiesMembersPendingPointsListResponseBody ListMemberPendingPoints1 (string campaignId, string memberId, int? limit = null, ParameterOrderListPendingPoints? order = null, string startingAfterId = null)

List Member Pending Points

>🚧 Beta endpoint The endpoint is behind a feature flag as it is still in development. Contact [Voucherify support](https://www.voucherify.io/contact-support) to unlock the feature for your organization. All current parameters and fields are listed and described. Lists all pending points that are currently assigned to the loyalty card. Once the points are added to the card, the entry is no longer returned. 👍 Configuring pending points Pending points are configured as part of an earning rule with POST Create earning rule or PUT Update earning rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberPendingPoints1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.
            var memberId = "memberId_example";  // string | Unique loyalty card code assigned to a particular customer.
            var limit = 56;  // int? | Limit the number of the pending point entries that the API returns in the response. (optional) 
            var order = (ParameterOrderListPendingPoints) "id";  // ParameterOrderListPendingPoints? | Orders the pending point entries according the pending point entry ID. The dash - preceding a sorting option means sorting in a descending order. (optional) 
            var startingAfterId = "startingAfterId_example";  // string | A cursor for pagination. It retrieves the results starting after a result with the given ID. (optional) 

            try
            {
                // List Member Pending Points
                LoyaltiesMembersPendingPointsListResponseBody result = apiInstance.ListMemberPendingPoints1(campaignId, memberId, limit, order, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListMemberPendingPoints1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberPendingPoints1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Member Pending Points
    ApiResponse<LoyaltiesMembersPendingPointsListResponseBody> response = apiInstance.ListMemberPendingPoints1WithHttpInfo(campaignId, memberId, limit, order, startingAfterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListMemberPendingPoints1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |
| **memberId** | **string** | Unique loyalty card code assigned to a particular customer. |  |
| **limit** | **int?** | Limit the number of the pending point entries that the API returns in the response. | [optional]  |
| **order** | **ParameterOrderListPendingPoints?** | Orders the pending point entries according the pending point entry ID. The dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **startingAfterId** | **string** | A cursor for pagination. It retrieves the results starting after a result with the given ID. | [optional]  |

### Return type

[**LoyaltiesMembersPendingPointsListResponseBody**](LoyaltiesMembersPendingPointsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all pending point entries. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmemberrewards"></a>
# **ListMemberRewards**
> LoyaltiesMembersRewardsListResponseBody ListMemberRewards (string memberId, bool? affordableOnly = null)

List Member Rewards

Retrieves the list of rewards that the given customer (identified by member_id, which is a loyalty card assigned to a particular customer) **can get in exchange for loyalty points**.   You can use the affordable_only parameter to limit the results to rewards that the customer can actually afford (only rewards whose price in points is not higher than the loyalty points balance on a loyalty card).   Please note that rewards that are disabled (i.e. set to Not Available in the Dashboard) for a given loyalty tier reward mapping will not be returned in this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMemberRewardsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card assigned to a particular customer.
            var affordableOnly = true;  // bool? | Limit the results to rewards that the customer can actually afford (only rewards whose price in points is not higher than the loyalty points balance on a loyalty card). Set this flag to true to return rewards which the customer can actually afford. (optional) 

            try
            {
                // List Member Rewards
                LoyaltiesMembersRewardsListResponseBody result = apiInstance.ListMemberRewards(memberId, affordableOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListMemberRewards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberRewardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Member Rewards
    ApiResponse<LoyaltiesMembersRewardsListResponseBody> response = apiInstance.ListMemberRewardsWithHttpInfo(memberId, affordableOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListMemberRewardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card assigned to a particular customer. |  |
| **affordableOnly** | **bool?** | Limit the results to rewards that the customer can actually afford (only rewards whose price in points is not higher than the loyalty points balance on a loyalty card). Set this flag to true to return rewards which the customer can actually afford. | [optional]  |

### Return type

[**LoyaltiesMembersRewardsListResponseBody**](LoyaltiesMembersRewardsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of rewards for the given &#x60;member_id&#x60;. Returns a filtered list if the query parameter &#x60;affordable_only&#x60; is set to &#x60;true&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmembers"></a>
# **ListMembers**
> LoyaltiesListMembersResponseBody ListMembers (string campaignId, int? limit = null, int? page = null, string customer = null, ParameterCreatedBeforeAfter createdAt = null, ParameterUpdatedBeforeAfter updatedAt = null, ParameterOrderVouchers? order = null, string code = null, List<string> ids = null)

List Members

Returns a list of your loyalty cards. The loyalty cards are sorted by creation date, with the most recent loyalty cards appearing first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListMembersExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID of the loyalty program.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var customer = "customer_example";  // string | A tracking identifier of a customer who is the holder of the vouchers. It can be an id generated by Voucherify or the source_id. Remember to use the proper URL escape codes if the source_id contains special characters. (optional) 
            var createdAt = new ParameterCreatedBeforeAfter(); // ParameterCreatedBeforeAfter | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z (optional) 
            var updatedAt = new ParameterUpdatedBeforeAfter(); // ParameterUpdatedBeforeAfter | A filter on the list based on the object updated_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [updated_at][before] 2017-09-08T13:52:18.227Z (optional) 
            var order = (ParameterOrderVouchers) "created_at";  // ParameterOrderVouchers? | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. (optional) 
            var code = "code_example";  // string |  (optional) 
            var ids = new List<string>(); // List<string> |  (optional) 

            try
            {
                // List Members
                LoyaltiesListMembersResponseBody result = apiInstance.ListMembers(campaignId, limit, page, customer, createdAt, updatedAt, order, code, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Members
    ApiResponse<LoyaltiesListMembersResponseBody> response = apiInstance.ListMembersWithHttpInfo(campaignId, limit, page, customer, createdAt, updatedAt, order, code, ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID of the loyalty program. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **customer** | **string** | A tracking identifier of a customer who is the holder of the vouchers. It can be an id generated by Voucherify or the source_id. Remember to use the proper URL escape codes if the source_id contains special characters. | [optional]  |
| **createdAt** | [**ParameterCreatedBeforeAfter**](ParameterCreatedBeforeAfter.md) | A filter on the list based on the object created_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [created_at][before] 2017-09-08T13:52:18.227Z | [optional]  |
| **updatedAt** | [**ParameterUpdatedBeforeAfter**](ParameterUpdatedBeforeAfter.md) | A filter on the list based on the object updated_at field. The value is a dictionary with the following options: before, after. A date value must be presented in ISO 8601 format (2016-11-16T14:14:31Z or 2016-11-16). An example: [updated_at][before] 2017-09-08T13:52:18.227Z | [optional]  |
| **order** | **ParameterOrderVouchers?** | Sorts the results using one of the filtering options, where the dash - preceding a sorting option means sorting in a descending order. | [optional]  |
| **code** | **string** |  | [optional]  |
| **ids** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**LoyaltiesListMembersResponseBody**](LoyaltiesListMembersResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of loyalty cards within a campaign. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpointsexpiration"></a>
# **ListPointsExpiration**
> LoyaltiesMembersPointsExpirationListResponseBody ListPointsExpiration (string campaignId, string memberId, int? limit = null, int? page = null)

List Loyalty Card Point Expiration

Retrieve loyalty point expiration buckets for a given loyalty card. Expired point buckets are not returned in this endpoint. You can use the Exports API to retrieve a list of both ACTIVE and EXPIRED point buckets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListPointsExpirationExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var memberId = "memberId_example";  // string | Loyalty card code.
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 

            try
            {
                // List Loyalty Card Point Expiration
                LoyaltiesMembersPointsExpirationListResponseBody result = apiInstance.ListPointsExpiration(campaignId, memberId, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListPointsExpiration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPointsExpirationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Loyalty Card Point Expiration
    ApiResponse<LoyaltiesMembersPointsExpirationListResponseBody> response = apiInstance.ListPointsExpirationWithHttpInfo(campaignId, memberId, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListPointsExpirationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **memberId** | **string** | Loyalty card code. |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |

### Return type

[**LoyaltiesMembersPointsExpirationListResponseBody**](LoyaltiesMembersPointsExpirationListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of loyalty points expiration buckets along with an expiration date if the points are due to expire. No expiration date parameter is returned if the loyalty points bucket does not expire. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrewardassignments1"></a>
# **ListRewardAssignments1**
> LoyaltiesRewardAssignmentsListResponseBody ListRewardAssignments1 (string campaignId, int? limit = null, int? page = null, string assignmentId = null)

List Reward Assignments

Returns reward assignments from a given loyalty campaign.  📘 Alternative endpoint  This endpoint is an alternative to this endpoint. The URL was re-designed to be more contextual to the type of data returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListRewardAssignments1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var assignmentId = "assignmentId_example";  // string | A unique reward assignment ID. (optional) 

            try
            {
                // List Reward Assignments
                LoyaltiesRewardAssignmentsListResponseBody result = apiInstance.ListRewardAssignments1(campaignId, limit, page, assignmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListRewardAssignments1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRewardAssignments1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Reward Assignments
    ApiResponse<LoyaltiesRewardAssignmentsListResponseBody> response = apiInstance.ListRewardAssignments1WithHttpInfo(campaignId, limit, page, assignmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListRewardAssignments1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **assignmentId** | **string** | A unique reward assignment ID. | [optional]  |

### Return type

[**LoyaltiesRewardAssignmentsListResponseBody**](LoyaltiesRewardAssignmentsListResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with reward assignment objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrewardassignments2"></a>
# **ListRewardAssignments2**
> LoyaltiesRewardsListAssignmentsResponseBody ListRewardAssignments2 (string campaignId, int? limit = null, int? page = null, string assignmentId = null)

List Reward Assignments

Returns active rewards from a given loyalty campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class ListRewardAssignments2Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var limit = 56;  // int? | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. (optional) 
            var page = 56;  // int? | Which page of results to return. The lowest value is 1. (optional) 
            var assignmentId = "assignmentId_example";  // string | A unique reward assignment ID. (optional) 

            try
            {
                // List Reward Assignments
                LoyaltiesRewardsListAssignmentsResponseBody result = apiInstance.ListRewardAssignments2(campaignId, limit, page, assignmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.ListRewardAssignments2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRewardAssignments2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Reward Assignments
    ApiResponse<LoyaltiesRewardsListAssignmentsResponseBody> response = apiInstance.ListRewardAssignments2WithHttpInfo(campaignId, limit, page, assignmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.ListRewardAssignments2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **limit** | **int?** | Limits the number of objects to be returned. The limit can range between 1 and 100 items. If no limit is set, it returns 10 items. | [optional]  |
| **page** | **int?** | Which page of results to return. The lowest value is 1. | [optional]  |
| **assignmentId** | **string** | A unique reward assignment ID. | [optional]  |

### Return type

[**LoyaltiesRewardsListAssignmentsResponseBody**](LoyaltiesRewardsListAssignmentsResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dictionary with reward assignment objects. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="redeemreward"></a>
# **RedeemReward**
> LoyaltiesMembersRedemptionRedeemResponseBody RedeemReward (string memberId, LoyaltiesMembersRedemptionRedeemRequestBody loyaltiesMembersRedemptionRedeemRequestBody = null)

Redeem Reward

  📘 Alternative endpoint  This endpoint is an alternative to this endpoint. The URL was re-designed to allow you to redeem a reward without having to provide the campaignId as a path parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class RedeemRewardExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card assigned to a particular customer.
            var loyaltiesMembersRedemptionRedeemRequestBody = new LoyaltiesMembersRedemptionRedeemRequestBody(); // LoyaltiesMembersRedemptionRedeemRequestBody | Specify the reward to be redeemed. In case of a pay with points reward, specify the order and the number of points to be applied to the order. Please note that if you do not specify the amount of points, the application will default to applying the number of points to pay for the remainder of the order. If the limit of available points on the card is reached, then only the available points on the card will be applied to the order. (optional) 

            try
            {
                // Redeem Reward
                LoyaltiesMembersRedemptionRedeemResponseBody result = apiInstance.RedeemReward(memberId, loyaltiesMembersRedemptionRedeemRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.RedeemReward: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RedeemRewardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Redeem Reward
    ApiResponse<LoyaltiesMembersRedemptionRedeemResponseBody> response = apiInstance.RedeemRewardWithHttpInfo(memberId, loyaltiesMembersRedemptionRedeemRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.RedeemRewardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card assigned to a particular customer. |  |
| **loyaltiesMembersRedemptionRedeemRequestBody** | [**LoyaltiesMembersRedemptionRedeemRequestBody**](LoyaltiesMembersRedemptionRedeemRequestBody.md) | Specify the reward to be redeemed. In case of a pay with points reward, specify the order and the number of points to be applied to the order. Please note that if you do not specify the amount of points, the application will default to applying the number of points to pay for the remainder of the order. If the limit of available points on the card is reached, then only the available points on the card will be applied to the order. | [optional]  |

### Return type

[**LoyaltiesMembersRedemptionRedeemResponseBody**](LoyaltiesMembersRedemptionRedeemResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a redemption object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="redeemreward1"></a>
# **RedeemReward1**
> LoyaltiesMembersRedemptionRedeemResponseBody RedeemReward1 (string campaignId, string memberId, LoyaltiesMembersRedemptionRedeemRequestBody loyaltiesMembersRedemptionRedeemRequestBody = null)

Redeem Reward

Exchange points from a loyalty card for a specified reward. This API method returns an assigned award in the response. It means that if a requesting customer gets a coupon code with a discount for the next order, that discount code will be visible in response as part of the reward object definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class RedeemReward1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.
            var memberId = "memberId_example";  // string | A code that identifies the loyalty card.
            var loyaltiesMembersRedemptionRedeemRequestBody = new LoyaltiesMembersRedemptionRedeemRequestBody(); // LoyaltiesMembersRedemptionRedeemRequestBody | Specify the reward to be redeemed. In case of a pay with points reward, specify the order and the number of points to be applied to the order. Please note that if you do not specify the amount of points, the application will default to applying the number of points to pay for the remainder of the order. If the limit of available points on the card is reached, then only the available points on the card will be applied to the order. (optional) 

            try
            {
                // Redeem Reward
                LoyaltiesMembersRedemptionRedeemResponseBody result = apiInstance.RedeemReward1(campaignId, memberId, loyaltiesMembersRedemptionRedeemRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.RedeemReward1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RedeemReward1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Redeem Reward
    ApiResponse<LoyaltiesMembersRedemptionRedeemResponseBody> response = apiInstance.RedeemReward1WithHttpInfo(campaignId, memberId, loyaltiesMembersRedemptionRedeemRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.RedeemReward1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |
| **memberId** | **string** | A code that identifies the loyalty card. |  |
| **loyaltiesMembersRedemptionRedeemRequestBody** | [**LoyaltiesMembersRedemptionRedeemRequestBody**](LoyaltiesMembersRedemptionRedeemRequestBody.md) | Specify the reward to be redeemed. In case of a pay with points reward, specify the order and the number of points to be applied to the order. Please note that if you do not specify the amount of points, the application will default to applying the number of points to pay for the remainder of the order. If the limit of available points on the card is reached, then only the available points on the card will be applied to the order. | [optional]  |

### Return type

[**LoyaltiesMembersRedemptionRedeemResponseBody**](LoyaltiesMembersRedemptionRedeemResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a redemption object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="transferpoints"></a>
# **TransferPoints**
> LoyaltiesMembersTransfersCreateResponseBody TransferPoints (string campaignId, string memberId, List<LoyaltiesTransferPoints> loyaltiesTransferPoints = null)

Transfer Loyalty Points

Transfer points between different loyalty cards which have holders. You need to provide the campaign ID and the loyalty card ID you want the points to be transferred to as path parameters in the URL. In the request body, you provide the loyalty cards you want the points to be transferred from and the number of points to transfer from each card. Transfer works only for loyalty cards that have holders, meaning they were published to customers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class TransferPointsExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | A unique identifier of the loyalty campaign containing the voucher to which the loyalty points will be sent (destination).
            var memberId = "memberId_example";  // string | A unique code identifying the loyalty card to which the user wants to transfer loyalty points (destination).
            var loyaltiesTransferPoints = new List<LoyaltiesTransferPoints>(); // List<LoyaltiesTransferPoints> | Provide the loyalty cards you want the points to be transferred from and the number of points to transfer from each card. (optional) 

            try
            {
                // Transfer Loyalty Points
                LoyaltiesMembersTransfersCreateResponseBody result = apiInstance.TransferPoints(campaignId, memberId, loyaltiesTransferPoints);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.TransferPoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransferPointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transfer Loyalty Points
    ApiResponse<LoyaltiesMembersTransfersCreateResponseBody> response = apiInstance.TransferPointsWithHttpInfo(campaignId, memberId, loyaltiesTransferPoints);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.TransferPointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | A unique identifier of the loyalty campaign containing the voucher to which the loyalty points will be sent (destination). |  |
| **memberId** | **string** | A unique code identifying the loyalty card to which the user wants to transfer loyalty points (destination). |  |
| **loyaltiesTransferPoints** | [**List&lt;LoyaltiesTransferPoints&gt;**](LoyaltiesTransferPoints.md) | Provide the loyalty cards you want the points to be transferred from and the number of points to transfer from each card. | [optional]  |

### Return type

[**LoyaltiesMembersTransfersCreateResponseBody**](LoyaltiesMembersTransfersCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a loyalty card object for the loaded loyalty card, ie. the one that that points were transferred to from the other cards(s). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateearningrule"></a>
# **UpdateEarningRule**
> LoyaltiesEarningRulesUpdateResponseBody UpdateEarningRule (string campaignId, string earningRuleId, LoyaltiesEarningRulesUpdateRequestBody loyaltiesEarningRulesUpdateRequestBody = null)

Update Earning Rule

Update an earning rule definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateEarningRuleExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var earningRuleId = "earningRuleId_example";  // string | A unique earning rule ID.
            var loyaltiesEarningRulesUpdateRequestBody = new LoyaltiesEarningRulesUpdateRequestBody(); // LoyaltiesEarningRulesUpdateRequestBody | Specify the parameters that you would like to update for the given earning rule. (optional) 

            try
            {
                // Update Earning Rule
                LoyaltiesEarningRulesUpdateResponseBody result = apiInstance.UpdateEarningRule(campaignId, earningRuleId, loyaltiesEarningRulesUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.UpdateEarningRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEarningRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Earning Rule
    ApiResponse<LoyaltiesEarningRulesUpdateResponseBody> response = apiInstance.UpdateEarningRuleWithHttpInfo(campaignId, earningRuleId, loyaltiesEarningRulesUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.UpdateEarningRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **earningRuleId** | **string** | A unique earning rule ID. |  |
| **loyaltiesEarningRulesUpdateRequestBody** | [**LoyaltiesEarningRulesUpdateRequestBody**](LoyaltiesEarningRulesUpdateRequestBody.md) | Specify the parameters that you would like to update for the given earning rule. | [optional]  |

### Return type

[**LoyaltiesEarningRulesUpdateResponseBody**](LoyaltiesEarningRulesUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated earning rule object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateloyaltycardbalance"></a>
# **UpdateLoyaltyCardBalance**
> LoyaltiesMembersBalanceUpdateResponseBody UpdateLoyaltyCardBalance (string memberId, LoyaltiesMembersBalanceUpdateRequestBody loyaltiesMembersBalanceUpdateRequestBody = null)

Adjust Loyalty Card Balance

This method gives adds or removes balance to an existing loyalty card that is assigned to a holder. The removal of points will consume the points that expire the soonest.   >🚧 Async Action    This is an async action. If you want to perform several add or remove loyalty card balance actions in a short time and their order matters, set up sufficient time-out between the calls.  📘 Alternative endpoint  This endpoint is an alternative to this endpoint. The URL was re-designed to allow you to add or remove loyalty card balance without having to provide the campaignId as a path parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateLoyaltyCardBalanceExample
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

            var apiInstance = new LoyaltiesApi(config);
            var memberId = "memberId_example";  // string | Unique loyalty card assigned to a particular customer.
            var loyaltiesMembersBalanceUpdateRequestBody = new LoyaltiesMembersBalanceUpdateRequestBody(); // LoyaltiesMembersBalanceUpdateRequestBody | Specify the point adjustment along with the expiration mechanism. (optional) 

            try
            {
                // Adjust Loyalty Card Balance
                LoyaltiesMembersBalanceUpdateResponseBody result = apiInstance.UpdateLoyaltyCardBalance(memberId, loyaltiesMembersBalanceUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.UpdateLoyaltyCardBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLoyaltyCardBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust Loyalty Card Balance
    ApiResponse<LoyaltiesMembersBalanceUpdateResponseBody> response = apiInstance.UpdateLoyaltyCardBalanceWithHttpInfo(memberId, loyaltiesMembersBalanceUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.UpdateLoyaltyCardBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberId** | **string** | Unique loyalty card assigned to a particular customer. |  |
| **loyaltiesMembersBalanceUpdateRequestBody** | [**LoyaltiesMembersBalanceUpdateRequestBody**](LoyaltiesMembersBalanceUpdateRequestBody.md) | Specify the point adjustment along with the expiration mechanism. | [optional]  |

### Return type

[**LoyaltiesMembersBalanceUpdateResponseBody**](LoyaltiesMembersBalanceUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a balance object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateloyaltycardbalance1"></a>
# **UpdateLoyaltyCardBalance1**
> LoyaltiesMembersBalanceUpdateResponseBody UpdateLoyaltyCardBalance1 (string campaignId, string memberId, LoyaltiesMembersBalanceUpdateRequestBody loyaltiesMembersBalanceUpdateRequestBody = null)

Adjust Loyalty Card Balance

This method adds or removes balance to an existing loyalty card that is assigned to a holder. The removal of points will consume the points that expire the soonest.   >🚧 Async Action    This is an async action. If you want to perform several add or remove loyalty card balance actions in a short time and their order matters, set up sufficient time-out between the calls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateLoyaltyCardBalance1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | Unique campaign ID.
            var memberId = "memberId_example";  // string | A code that identifies the loyalty card.
            var loyaltiesMembersBalanceUpdateRequestBody = new LoyaltiesMembersBalanceUpdateRequestBody(); // LoyaltiesMembersBalanceUpdateRequestBody | Specify the point adjustment along with the expiration mechanism. (optional) 

            try
            {
                // Adjust Loyalty Card Balance
                LoyaltiesMembersBalanceUpdateResponseBody result = apiInstance.UpdateLoyaltyCardBalance1(campaignId, memberId, loyaltiesMembersBalanceUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.UpdateLoyaltyCardBalance1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLoyaltyCardBalance1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust Loyalty Card Balance
    ApiResponse<LoyaltiesMembersBalanceUpdateResponseBody> response = apiInstance.UpdateLoyaltyCardBalance1WithHttpInfo(campaignId, memberId, loyaltiesMembersBalanceUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.UpdateLoyaltyCardBalance1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | Unique campaign ID. |  |
| **memberId** | **string** | A code that identifies the loyalty card. |  |
| **loyaltiesMembersBalanceUpdateRequestBody** | [**LoyaltiesMembersBalanceUpdateRequestBody**](LoyaltiesMembersBalanceUpdateRequestBody.md) | Specify the point adjustment along with the expiration mechanism. | [optional]  |

### Return type

[**LoyaltiesMembersBalanceUpdateResponseBody**](LoyaltiesMembersBalanceUpdateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a balance object. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateloyaltyprogram"></a>
# **UpdateLoyaltyProgram**
> LoyaltiesUpdateCampaignResponseBody UpdateLoyaltyProgram (string campaignId, LoyaltiesUpdateCampaignRequestBody loyaltiesUpdateCampaignRequestBody = null)

Update Loyalty Campaign

Updates a loyalty program.  Fields other than those specified in the allowed request body payload wont be modified (even if provided they are silently skipped). Any parameters not provided will be left unchanged.  This method will update the loyalty cards which have not been published or redeemed yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateLoyaltyProgramExample
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var loyaltiesUpdateCampaignRequestBody = new LoyaltiesUpdateCampaignRequestBody(); // LoyaltiesUpdateCampaignRequestBody | Specify the new values for the parameters that you would like to update for the given loyalty campaign. (optional) 

            try
            {
                // Update Loyalty Campaign
                LoyaltiesUpdateCampaignResponseBody result = apiInstance.UpdateLoyaltyProgram(campaignId, loyaltiesUpdateCampaignRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.UpdateLoyaltyProgram: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLoyaltyProgramWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Loyalty Campaign
    ApiResponse<LoyaltiesUpdateCampaignResponseBody> response = apiInstance.UpdateLoyaltyProgramWithHttpInfo(campaignId, loyaltiesUpdateCampaignRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.UpdateLoyaltyProgramWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **loyaltiesUpdateCampaignRequestBody** | [**LoyaltiesUpdateCampaignRequestBody**](LoyaltiesUpdateCampaignRequestBody.md) | Specify the new values for the parameters that you would like to update for the given loyalty campaign. | [optional]  |

### Return type

[**LoyaltiesUpdateCampaignResponseBody**](LoyaltiesUpdateCampaignResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the loyalty campaign object if the update succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updaterewardassignment1"></a>
# **UpdateRewardAssignment1**
> LoyaltiesRewardsUpdateAssignmentResponseBody UpdateRewardAssignment1 (string campaignId, string assignmentId, LoyaltiesRewardsUpdateAssignmentRequestBody loyaltiesRewardsUpdateAssignmentRequestBody = null)

Update Reward Assignment

Updates rewards parameters, i.e. the points cost for the specific reward.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class UpdateRewardAssignment1Example
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

            var apiInstance = new LoyaltiesApi(config);
            var campaignId = "campaignId_example";  // string | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign. 
            var assignmentId = "assignmentId_example";  // string | A unique reward assignment ID.
            var loyaltiesRewardsUpdateAssignmentRequestBody = new LoyaltiesRewardsUpdateAssignmentRequestBody(); // LoyaltiesRewardsUpdateAssignmentRequestBody | Update the points cost for the reward assignment. (optional) 

            try
            {
                // Update Reward Assignment
                LoyaltiesRewardsUpdateAssignmentResponseBody result = apiInstance.UpdateRewardAssignment1(campaignId, assignmentId, loyaltiesRewardsUpdateAssignmentRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoyaltiesApi.UpdateRewardAssignment1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRewardAssignment1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Reward Assignment
    ApiResponse<LoyaltiesRewardsUpdateAssignmentResponseBody> response = apiInstance.UpdateRewardAssignment1WithHttpInfo(campaignId, assignmentId, loyaltiesRewardsUpdateAssignmentRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoyaltiesApi.UpdateRewardAssignment1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The campaign ID or name of the loyalty campaign. You can either pass the campaign ID, which was assigned by Voucherify, or the name of the campaign as the path parameter value, e.g., Loyalty%20Campaign.  |  |
| **assignmentId** | **string** | A unique reward assignment ID. |  |
| **loyaltiesRewardsUpdateAssignmentRequestBody** | [**LoyaltiesRewardsUpdateAssignmentRequestBody**](LoyaltiesRewardsUpdateAssignmentRequestBody.md) | Update the points cost for the reward assignment. | [optional]  |

### Return type

[**LoyaltiesRewardsUpdateAssignmentResponseBody**](LoyaltiesRewardsUpdateAssignmentResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a reward assignment with an updated points value. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

