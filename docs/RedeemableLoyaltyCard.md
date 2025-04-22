# Voucherify.Model.RedeemableLoyaltyCard
Redeemable loyalty card object response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **int?** | Total number of points added to the loyalty card over its lifespan. | [optional] 
**Balance** | **int?** | Points available for reward redemption. This is calculated as follows: &#x60;balance&#x60; &#x3D; &#x60;points&#x60; - &#x60;expired_points&#x60; - &#x60;subtracted_points&#x60; - &#x60;redemption.redeemed_points&#x60;. | [optional] 
**ExchangeRatio** | **decimal?** | The cash equivalent of the points defined in the points_ratio property. | [optional] 
**PointsRatio** | **int?** | The number of loyalty points that will map to the predefined cash amount defined by the exchange_ratio property. | [optional] 
**Transfers** | [**List&lt;LoyaltiesTransferPoints&gt;**](LoyaltiesTransferPoints.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

