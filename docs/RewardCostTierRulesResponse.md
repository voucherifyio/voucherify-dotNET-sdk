# Voucherify.Model.RewardCostTierRulesResponse
Tier requirements for a reward cost. `any_of` is omitted when `type` is `NO_REQUIREMENTS`. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Tier requirement type. | [optional] 
**AnyOf** | [**List&lt;RewardCostTierRulesAnyOfEntryResponse&gt;**](RewardCostTierRulesAnyOfEntryResponse.md) | Lists tier combinations that qualify. Present when &#x60;type&#x60; is &#x60;ANY_OF&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

