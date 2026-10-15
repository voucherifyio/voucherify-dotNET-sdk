# Voucherify.Model.V2LoyaltiesProgramsMembersTiersTransactionsListRequestQuery
Request query schema for **GET** `/v2/loyalties/programs/{programId}/members/{memberId}/tiers/transactions`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Junction** | **string** | Joins the field filters. Allowed values are &#x60;AND&#x60; and &#x60;OR&#x60;. Defaults to &#x60;AND&#x60;. | [optional] 
**CardId** | [**LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardId**](LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardId.md) |  | [optional] 
**CardDefinitionId** | [**LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardDefinitionId**](LoyaltiesProgramsMembersTiersTransactionsListRequestQueryCardDefinitionId.md) |  | [optional] 
**CreatedAt** | [**TransactionFilterDateConditions**](TransactionFilterDateConditions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

