# Voucherify.Model.V2LoyaltiesProgramsMembersTiersTransactionsListRequestQuery
Request query schema for **GET** `/v2/loyalties/programs/{programId}/members/{memberId}/tiers/transactions`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Junction** | **string** | Logical junction between the field filters. Defaults to AND behavior. | [optional] 
**CardId** | [**LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardId**](LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardId.md) |  | [optional] 
**CardDefinitionId** | [**LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardDefinitionId**](LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardDefinitionId.md) |  | [optional] 
**CreatedAt** | [**TransactionFilterDateConditions**](TransactionFilterDateConditions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

