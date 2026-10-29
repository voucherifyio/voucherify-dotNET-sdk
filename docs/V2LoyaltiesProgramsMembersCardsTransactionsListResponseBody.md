# Voucherify.Model.V2LoyaltiesProgramsMembersCardsTransactionsListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/transactions`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;CardTransaction&gt;**](CardTransaction.md) | Card transactions on the current page. | [optional] 
**Cursor** | [**ListCursor**](ListCursor.md) |  | [optional] 
**Object** | **string** | Object type marker, always &#x60;list&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

