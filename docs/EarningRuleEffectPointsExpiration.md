# Voucherify.Model.EarningRuleEffectPointsExpiration
Points expiration override. Depending on `type`, exactly one of `rolling_expiration`, `calendar_expiration` or `sliding_expiration` is required; for `NO_EXPIRATION` all three must be null/absent. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Points expiration type. | [optional] 
**RollingExpiration** | [**EarningRuleEffectPointsExpirationRollingExpiration**](EarningRuleEffectPointsExpirationRollingExpiration.md) |  | [optional] 
**CalendarExpiration** | [**EarningRuleEffectPointsExpirationCalendarExpiration**](EarningRuleEffectPointsExpirationCalendarExpiration.md) |  | [optional] 
**SlidingExpiration** | [**EarningRuleEffectPointsExpirationSlidingExpiration**](EarningRuleEffectPointsExpirationSlidingExpiration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

