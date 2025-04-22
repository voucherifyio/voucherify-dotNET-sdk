# Voucherify.Model.RewardsAssignmentsCreateRequestBodyParametersLoyalty
Defines the equivalent points value of the reward.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **int** | Number of points that will be subtracted from the loyalty card points balance if the reward is redeemed. Must be positive integer. | [optional] 
**AutoRedeem** | **bool** | Determines if the reward is redeemed automatically when the customer reaches the sufficient number of points to redeem it. Value &#x60;true&#x60; means that the automatic reward redemption is active. Only one reward can be set to be redeemed automatically in a loyalty campaign, i.e. only one can have the value &#x60;true&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

