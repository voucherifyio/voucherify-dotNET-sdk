# Voucherify.Model.ManagementProjectsStackingRulesUpdateResponseBody
Response body schema for **PUT** `/management/v1/projects/{projectId}/stacking-rules/{stackingRulesId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the stacking rules. | [optional] 
**ExclusiveCategories** | **List&lt;string&gt;** | Lists the IDs of the categories that are exclusive. | [optional] 
**JointCategories** | **List&lt;string&gt;** | Lists the IDs of the categories that are joint. | [optional] 
**RedeemablesLimit** | **int** | Defines how many redeemables can be sent to Voucherify for validation at the same time. | [optional] 
**ApplicableRedeemablesLimit** | **int** | Defines how many redeemables can be applied at the same time. The number must be less than or equal to &#x60;\&quot;redeemables_limit\&quot;&#x60;. | [optional] 
**ApplicableRedeemablesPerCategoryLimit** | **int** | Defines how many redeemables with the same category can be applied at the same time. The number must be less than or equal to &#x60;\&quot;applicable_redeemables_limit\&quot;&#x60;. | [optional] 
**ApplicableExclusiveRedeemablesLimit** | **int** | Defines how many redeemables with an assigned exclusive category can be applied at the same time. | [optional] 
**ApplicableExclusiveRedeemablesPerCategoryLimit** | **int** | Defines how many exclusive redeemables with the same category can be applied at the same time. The number must be less than or equal to &#x60;\&quot;applicable_exclusive_redeemables_limit\&quot;&#x60;. | [optional] 
**DiscountCalculationMode** | **string** | Defines if the discounts are applied by taking into account the initial order amount or the discounted order amount. | [optional] 
**InitialAmountModeCategories** | **List&lt;string&gt;** | Lists the IDs of the categories that apply a discount based on the initial amount. | [optional] 
**DiscountedAmountModeCategories** | **List&lt;string&gt;** | Lists the IDs of the categories that apply a discount based on the discounted amount. | [optional] 
**RedeemablesApplicationMode** | **string** | Defines the application mode for redeemables. &#x60;\&quot;ALL\&quot;&#x60; means that all redeemables must be validated for the redemption to be successful. &#x60;\&quot;PARTIAL\&quot;&#x60; means that only those redeemables that can be validated will be redeemed. The redeemables that fail validaton will be skipped. | [optional] 
**RedeemablesSortingRule** | **string** | Defines the sorting rule for redeemables. &#x60;\&quot;CATEGORY_HIERARCHY\&quot;&#x60; means that redeemables are applied with the order established by the hierarchy of the categories. &#x60;\&quot;REQUESTED_ORDER\&quot;&#x60; means that redeemables are applied with the order established in the request. | [optional] 
**RedeemablesRollbackOrderMode** | **string** | Defines the rollback mode for the order. &#x60;WITH_ORDER&#x60; is a default setting. The redemption is rolled back together with the data about the order, including related discount values. &#x60;WITHOUT_ORDER&#x60; allows rolling the redemption back without affecting order data, including the applied discount values. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the stacking rules were created. The value for this parameter is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the stacking rules were updated. The value for this parameter is shown in the ISO 8601 format. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

