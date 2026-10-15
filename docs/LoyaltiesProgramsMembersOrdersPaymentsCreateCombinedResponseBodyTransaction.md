# Voucherify.Model.LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBodyTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **string** | Unique identifier of the loyalty program (format &#x60;lprg_...&#x60;). | [optional] 
**MemberId** | **string** | Unique identifier of the program member (format &#x60;lmbr_...&#x60;). | [optional] 
**CardId** | **string** | Unique identifier of the loyalty card the points were spent from (format &#x60;lcrd_...&#x60;). | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (format &#x60;lcdef_...&#x60;). | [optional] 
**CardTransactionId** | **Object** | &#x60;null&#x60; for &#x60;DRY_RUN&#x60; (&#x60;SIMULATED&#x60;) transactions. | [optional] 
**OrderId** | **string** | Identifies the paid order (format &#x60;ord_...&#x60;). | [optional] 
**Status** | **string** |  | [optional] 
**Type** | **string** | Defines the transaction type. Always &#x60;PAY_WITH_POINTS&#x60;. | [optional] 
**Details** | [**LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBodyTransactionDetails**](LoyaltiesProgramsMembersOrdersPaymentsCreateCombinedResponseBodyTransactionDetails.md) |  | [optional] 
**UpdatedAt** | **Object** | Timestamp when the transaction was last updated (ISO 8601), or &#x60;null&#x60; for &#x60;DRY_RUN&#x60; (&#x60;SIMULATED&#x60;) transactions. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;order_transaction&#x60;. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the transaction was created (ISO 8601). | [optional] 
**Id** | **string** | Identifies the order transaction (&#x60;lotx_...&#x60;). Absent on dry-run (&#x60;SIMULATED&#x60;) create responses, which are never persisted. Always present in list responses. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

