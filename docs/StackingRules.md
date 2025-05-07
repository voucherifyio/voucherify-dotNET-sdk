# Voucherify.Model.StackingRules
Defines stacking rules for redeemables. Read more in the [Stacking Rule Documentation](https://support.voucherify.io/article/604-stacking-rules).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RedeemablesLimit** | **int?** | Defines how many redeemables can be sent in one stacking request (note: more redeemables means more processing time!). | [optional] 
**ApplicableRedeemablesLimit** | **int?** | Defines how many of the sent redeemables will be applied to the order. For example, a user can select 30 discounts but only 5 will be applied to the order and the remaining will be labelled as SKIPPED. | [optional] 
**ApplicableRedeemablesPerCategoryLimit** | **int?** | Defines how many redeemables per category can be applied in one request. | [optional] 
**ApplicableExclusiveRedeemablesLimit** | **int?** | Defines how many redeemables with an exclusive category can be applied in one request. | [optional] 
**ApplicableExclusiveRedeemablesPerCategoryLimit** | **int?** | Defines how many redeemables with an exclusive category per category in stacking rules can be applied in one request. | [optional] 
**ExclusiveCategories** | **List&lt;string&gt;** | Lists all exclusive categories. A redeemable from a campaign with an exclusive category is the only redeemable to be redeemed when applied with redeemables from other campaigns unless these campaigns are exclusive or joint. | [optional] 
**JointCategories** | **List&lt;string&gt;** | Lists all joint categories. A campaign with a joint category is always applied regardless of the exclusivity of other campaigns. | [optional] 
**RedeemablesApplicationMode** | **string** | Defines redeemables application mode. | [optional] 
**RedeemablesSortingRule** | **string** | Defines redeemables sorting rule. | [optional] 
**RedeemablesProductsApplicationMode** | **string** | Defines redeemables products application mode. | [optional] 
**RedeemablesNoEffectRule** | **string** | Defines redeemables no effect rule. | [optional] 
**RedeemablesRollbackOrderMode** | **string** | Defines the rollback mode for the order. &#x60;WITH_ORDER&#x60; is a default setting. The redemption is rolled back together with the data about the order, including related discount values. &#x60;WITHOUT_ORDER&#x60; allows rolling the redemption back without affecting order data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

