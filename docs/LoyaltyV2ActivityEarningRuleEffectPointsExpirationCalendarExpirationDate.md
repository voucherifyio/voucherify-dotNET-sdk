# Voucherify.Model.LoyaltyV2ActivityEarningRuleEffectPointsExpirationCalendarExpirationDate
A calendar expiration date. The maximum `day` depends on `month`: 29 for February (month 2), 30 for April/June/September/November (4, 6, 9, 11), 31 for the remaining months. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Day** | **int?** | Day of month (1-31; validated against the month length). | [optional] 
**Month** | **int?** | Month number (1-12). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

