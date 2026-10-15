# Voucherify.Model.CardPointsBucket
A points expiration bucket of a card.

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
**Id** | **string** | Unique points expiration bucket ID. | [optional] 
**CustomerId** | **string** | Voucherify ID of the customer owning the card. | [optional] 
**Points** | [**CardPointsBucketPoints**](CardPointsBucketPoints.md) |  | [optional] 
**ExpirationDate** | **DateTime?** | Date when the points in the bucket expire (&#x60;YYYY-MM-DD&#x60;). | [optional] 
**ExpirationType** | **string** | Points expiration type for the bucket. It can be inherited from the card definition or overridden by the earning rule. | [optional] 
**Status** | **string** | Bucket status. For the List card expiring points buckets, returns only &#x60;ACTIVE&#x60; buckets. | [optional] 
**Object** | **string** | Object type marker, always &#x60;card_points_bucket&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

