# Voucherify.Model.LoyaltyV2ActivityEarningRuleEffectPointsExpirationRollingExpirationPeriod
Rolling expiration period. The maximum `value` depends on `unit`: `DAY` - 90, `MONTH` - 12, `YEAR` - 5. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Unit** | **string** | Period unit. | [optional] 
**Value** | **int?** | Period length. Maximum depends on &#x60;unit&#x60;: 90 for DAY, 12 for MONTH, 5 for YEAR. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

