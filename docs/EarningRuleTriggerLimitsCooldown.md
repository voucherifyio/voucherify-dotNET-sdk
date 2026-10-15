# Voucherify.Model.EarningRuleTriggerLimitsCooldown
Cooldown between consecutive triggers per member. With `NO_COOLDOWN`, `fixed_cooldown` must be null/absent. With `FIXED_COOLDOWN`, `fixed_cooldown` is required. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Cooldown type. | [optional] 
**FixedCooldown** | [**EarningRuleTriggerLimitsCooldownFixedCooldown**](EarningRuleTriggerLimitsCooldownFixedCooldown.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

