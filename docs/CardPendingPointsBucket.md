# Voucherify.Model.CardPendingPointsBucket
A pending point bucket of a card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **string** | ID of the card the bucket belongs to. | [optional] 
**CardDefinitionId** | **string** | ID of the card definition of the card. | [optional] 
**ProgramId** | **string** | ID of the loyalty program. | [optional] 
**MemberId** | **string** | ID of the member owning the card. | [optional] 
**CardType** | **string** | Card type. Currently, only &#x60;INDIVIDUAL&#x60; is supported. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the bucket was created (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp when the bucket was last updated (ISO 8601), or &#x60;null&#x60;. | [optional] 
**Id** | **string** | Unique pending point bucket ID. | [optional] 
**Points** | [**CardPendingPointsBucketPoints**](CardPendingPointsBucketPoints.md) |  | [optional] 
**Date** | **DateTime?** | Scheduled activation date of the pending points (&#x60;YYYY-MM-DD&#x60;). For the &#x60;EVENT_BASED&#x60; type this is the cancellation deadline. | [optional] 
**Type** | **string** | Pending points activation type from the card definition. | [optional] 
**Status** | **string** | Bucket status. | [optional] 
**Object** | **string** | Object type marker, always &#x60;card_pending_points_bucket&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

