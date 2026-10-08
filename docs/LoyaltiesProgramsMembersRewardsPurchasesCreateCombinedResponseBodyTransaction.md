# Voucherify.Model.LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBodyTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **string** |  | [optional] 
**CardDefinitionId** | **string** | Unique identifier of the card definition for that card (format &#x60;lcdef_...&#x60;). | [optional] 
**CardTransactionId** | **Object** | &#x60;null&#x60; for &#x60;DRY_RUN&#x60; (SIMULATED) transactions. | [optional] 
**ProgramId** | **string** | Unique identifier of the loyalty program (format &#x60;lprg_...&#x60;). | [optional] 
**MemberId** | **string** | Unique identifier of the program member (format &#x60;lmbr_...&#x60;). | [optional] 
**RewardId** | **string** | Unique identifier of the purchased reward (format &#x60;lrew_...&#x60;). | [optional] 
**Status** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**Details** | [**LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBodyTransactionDetails**](LoyaltiesProgramsMembersRewardsPurchasesCreateCombinedResponseBodyTransactionDetails.md) |  | [optional] 
**UpdatedAt** | **Object** | For &#x60;DRY_RUN&#x60; transactions, this is always &#x60;null&#x60;. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;reward_transaction&#x60;. | [optional] 
**Id** | **string** | Unique reward transaction identifier (format &#x60;lrtx_...&#x60;). | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the transaction was created (ISO 8601). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

