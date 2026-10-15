# Voucherify.Model.EarningRuleEffect
Effect applied when an earning is triggered. Depending on `type`, exactly one of `points`, `points_proportional` or `benefit` is required and the others must be null/absent. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Effect type. | [optional] 
**Points** | [**EarningRuleEffectPoints**](EarningRuleEffectPoints.md) |  | [optional] 
**PointsProportional** | [**EarningRuleEffectPointsProportional**](EarningRuleEffectPointsProportional.md) |  | [optional] 
**Benefit** | [**LoyaltyV2ActivityEarningRuleEffectBenefit**](LoyaltyV2ActivityEarningRuleEffectBenefit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

