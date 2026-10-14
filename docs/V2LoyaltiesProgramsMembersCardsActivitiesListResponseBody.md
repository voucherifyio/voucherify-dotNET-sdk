# Voucherify.Model.V2LoyaltiesProgramsMembersCardsActivitiesListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/activities`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;CardActivity&gt;**](CardActivity.md) | Card activities on the current page. | [optional] 
**Cursor** | [**ListCursor**](ListCursor.md) |  | [optional] 
**Object** | **string** | Object type marker, always &#x60;list&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

