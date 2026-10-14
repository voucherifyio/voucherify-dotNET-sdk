# Voucherify.Model.RewardValidityHoursResponse
Validity hours. `daily` is present only when `type` is DAILY; omitted otherwise.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Whether the reward is purchasable at any time or only during specific daily windows. | [optional] 
**Daily** | [**List&lt;LoyaltyV2ActivityRewardValidityDailyHoursResponse&gt;**](LoyaltyV2ActivityRewardValidityDailyHoursResponse.md) | Daily time windows. Present only when &#x60;type&#x60; is DAILY. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

