# Voucherify.Model.RewardPurchaseTransaction
A reward transaction. Represents a reward purchase or a reward refund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **string** | Unique identifier of the loyalty program (format &#x60;lprg_...&#x60;). | [optional] 
**MemberId** | **string** | Unique identifier of the program member (format &#x60;lmbr_...&#x60;). | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the transaction was created (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp when the transaction was last updated (ISO 8601), or &#x60;null&#x60;. | [optional] 
**CardId** | **string** | Unique identifier of the loyalty card the points were spent from (format &#x60;lcrd_...&#x60;). | [optional] 
**Id** | **string** | Unique reward transaction identifier (format &#x60;lrtx_...&#x60;). Absent for &#x60;DRY_RUN&#x60; (SIMULATED) transactions, which are never persisted. | [optional] 
**CardDefinitionId** | **string** | Unique identifier of the card definition for that card (format &#x60;lcdef_...&#x60;). &#x60;null&#x60; when none is stored. | [optional] 
**CardTransactionId** | **string** | Identifies of the underlying card transaction (format &#x60;lctx_...&#x60;). &#x60;null&#x60; for &#x60;DRY_RUN&#x60; (SIMULATED) transactions. | [optional] 
**RewardId** | **string** | Unique identifier of the purchased reward (format &#x60;lrew_...&#x60;). | [optional] 
**Status** | **string** | Transaction status:  - &#x60;PENDING&#x60;: Created and awaiting processing.  - &#x60;PROCESSING&#x60;: Being processed.  - &#x60;APPROVED&#x60;: Completed successfully.  - &#x60;REJECTED&#x60;: Rejected (see &#x60;details.rejection&#x60;).  - &#x60;SIMULATED&#x60;: Dry-run result that is not persisted.  - &#x60;REFUNDED&#x60;: Purchase has been refunded. | [optional] 
**Type** | **string** | Transaction type. | [optional] 
**Details** | **Object** |  | [optional] 
**Object** | **string** | Object type marker. Always &#x60;reward_transaction&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

