# Voucherify.Model.LoyaltyV2ActivityEarningRuleEarningLimitsGlobal
Global (per member, across this rule) earning limits. With `NO_LIMIT`, `limits` is an empty array. With `LIMITED`, `limits` contains exactly one `TIME_BASED` limit. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Whether global earning limits apply. | [optional] 
**Limits** | **List&lt;Object&gt;** | Earning limits (at most one). Empty array when &#x60;type&#x60; is &#x60;NO_LIMIT&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

