# Voucherify.Model.BenefitTransaction
A benefit transaction. Represents a benefit fulfillment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramId** | **string** | Unique identifier of the loyalty program (format &#x60;lprg_...&#x60;). | [optional] 
**MemberId** | **string** | Unique identifier of the program member (format &#x60;lmbr_...&#x60;). | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the transaction was created (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp when the transaction was last updated (ISO 8601), or &#x60;null&#x60;. | [optional] 
**Id** | **string** | Unique benefit transaction identifier (format &#x60;lbtx_...&#x60;). | [optional] 
**BenefitId** | **string** | Unique identifier of the fulfilled benefit (format &#x60;lben_...&#x60;). | [optional] 
**EarningRuleId** | **string** | Unique identifier of the earning rule that triggered the fulfillment (format &#x60;lern_...&#x60;). | [optional] 
**Type** | **string** | Transaction type. Always &#x60;FULFILLMENT&#x60;. | [optional] 
**Details** | [**BenefitTransactionDetails**](BenefitTransactionDetails.md) |  | [optional] 
**Status** | **string** | Transaction status. &#x60;PENDING&#x60; - created, awaiting processing; &#x60;APPROVED&#x60; - completed successfully; &#x60;REJECTED&#x60; - rejected (see &#x60;details.rejection&#x60;). | [optional] 
**Object** | **string** | Object type marker. Always &#x60;benefit_transaction&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

