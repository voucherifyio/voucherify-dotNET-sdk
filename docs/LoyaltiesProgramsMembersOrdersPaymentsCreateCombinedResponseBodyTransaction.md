# Voucherify.Model.LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBodyTransaction
An order transaction representing a pay-with-points `SIMULATED` payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **string** | Unique identifier of the loyalty program (format &#x60;lprg_...&#x60;). | [optional] 
**MemberId** | **string** | Unique identifier of the program member (format &#x60;lmbr_...&#x60;). | [optional] 
**CardId** | **string** | Unique identifier of the loyalty card the points were spent from (format &#x60;lcrd_...&#x60;). | [optional] 
**CardDefinitionId** | **string** | Unique identifier of the card definition (format &#x60;lcdef_...&#x60;). | [optional] 
**CardTransactionId** | **Object** | &#x60;null&#x60; for &#x60;DRY_RUN&#x60; (&#x60;SIMULATED&#x60;) transactions. | [optional] 
**OrderId** | **string** | Unique identifier of the paid order (format &#x60;ord_...&#x60;). | [optional] 
**Status** | **string** | Transaction status. &#x60;SIMULATED&#x60; - dry-run create result, not persisted. | [optional] 
**Type** | **string** | Defines the transaction type. Always &#x60;PAY_WITH_POINTS&#x60;. | [optional] 
**Details** | **Object** |  | [optional] 
**UpdatedAt** | **Object** | Timestamp when the transaction was last updated (ISO 8601), or &#x60;null&#x60; for &#x60;DRY_RUN&#x60; (&#x60;SIMULATED&#x60;) transactions. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;order_transaction&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

