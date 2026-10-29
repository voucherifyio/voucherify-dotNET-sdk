# Voucherify.Model.CardTransaction
A card transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique card transaction ID assigned by Voucherify. | [optional] 
**CardId** | **string** | ID of the card the transaction belongs to. Assigned by Voucherify. | [optional] 
**ProgramId** | **string** | ID of the loyalty program. Assigned by Voucherify. | [optional] 
**MemberId** | **string** | ID of the member owning the card. Assigned by Voucherify. | [optional] 
**CardDefinitionId** | **string** | ID of the card definition of the card. Assigned by Voucherify. | [optional] 
**CardType** | **string** | Card type. | [optional] 
**Type** | **string** | Transaction type. Options depend on the endpoint and the transaction variant. | [optional] 
**Details** | [**CardTransactionDetails**](CardTransactionDetails.md) |  | [optional] 
**Status** | **string** | Transaction processing status. Transactions are created as &#x60;PENDING&#x60; and processed asynchronously. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the transaction was created (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp when the transaction was last updated (ISO 8601), or &#x60;null&#x60;. | [optional] 
**Object** | **string** | Object type marker, always &#x60;card_transaction&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

