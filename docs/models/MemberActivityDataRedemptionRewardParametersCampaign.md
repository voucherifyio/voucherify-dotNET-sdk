# Voucherify.Model.MemberActivityDataRedemptionRewardParametersCampaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Balance** | **int** | The number of points to be added to a loyalty card or the amount to be added to the current balance on the gift card.  For gift cards, the value is multiplied by 100 to precisely represent 2 decimal places. For example, $100 amount is written as 10000. and Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;. | [optional] 
**Type** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

