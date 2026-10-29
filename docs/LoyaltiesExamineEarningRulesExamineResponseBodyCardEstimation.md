# Voucherify.Model.LoyaltiesExamineEarningRulesExamineResponseBodyCardEstimation
Point estimation for a single card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Card** | [**ExamineCardReference**](ExamineCardReference.md) |  | [optional] 
**PointsEstimation** | **decimal?** | Total estimated points for the card across matching earning rules. | [optional] 
**EarningRules** | [**List&lt;LoyaltiesExamineEarningRulesExamineResponseBodyCardEarningRuleEstimation&gt;**](LoyaltiesExamineEarningRulesExamineResponseBodyCardEarningRuleEstimation.md) | Per-earning-rule estimations contributing to the total. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;card_estimation&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

