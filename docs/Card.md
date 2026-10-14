# Voucherify.Model.Card
A full loyalty card snapshot.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardType** | **string** | Card type. Currently only &#x60;INDIVIDUAL&#x60; is supported. | [optional] 
**LifetimeBucket** | [**CardLifetimeBucket**](CardLifetimeBucket.md) |  | [optional] 
**Balance** | [**CardBalance**](CardBalance.md) |  | [optional] 
**Id** | **string** | Identifies the card. | [optional] 
**ProgramId** | **string** | Identifies the loyalty program. | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition. | [optional] 
**Code** | **string** | Human-readable card code. &#x60;null&#x60; until asynchronous code generation finishes. | [optional] 
**CustomerId** | **string** | Identifies the customer linked to the card. | [optional] 
**MemberId** | **string** | Identifies the member linked to the card. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Records when the card was created (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Records the last update (ISO 8601). &#x60;null&#x60; if the card has never been updated. | [optional] 
**Object** | **string** | Object type. Always &#x60;card&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

