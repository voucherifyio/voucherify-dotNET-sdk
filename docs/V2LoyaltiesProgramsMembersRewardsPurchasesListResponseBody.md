# Voucherify.Model.V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/members/{memberId}/rewards/purchases`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;RewardPurchaseTransaction&gt;**](RewardPurchaseTransaction.md) | Reward purchase transactions (type &#x60;PURCHASE&#x60; only). | [optional] 
**Cursor** | [**V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBodyCursor**](V2LoyaltiesProgramsMembersRewardsPurchasesListResponseBodyCursor.md) |  | [optional] 
**Object** | **string** | Object type marker. Always &#x60;list&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

