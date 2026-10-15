# Voucherify.Model.LoyaltyV2ActivityEarningRuleEffectPointsExpirationSlidingExpirationPeriod
Sliding expiration inactivity period. The maximum `value` depends on `unit`: `DAY` - 90, `MONTH` - 12, `YEAR` - 1. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **int?** | Period length. Maximum depends on &#x60;unit&#x60;: 90 for DAY, 12 for MONTH, 1 for YEAR. | [optional] 
**Unit** | **string** | Period unit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

