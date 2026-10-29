# Voucherify.Model.LoyaltiesExamineEarningRulesExamineRequestBodyOrder
A hypothetical order used for estimation. For earning rules that calculate points proportionally, pass the whole cart content, including `items`, `discount_amount`, etc.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | Order amount after discounts - a non-negative integer. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**InitialAmount** | **decimal?** | Order amount before discounts - a non-negative integer. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**DiscountAmount** | **decimal?** | Total discount amount - a non-negative integer. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**Items** | [**List&lt;LoyaltiesExamineEarningRulesExamineRequestBodyOrderItem&gt;**](LoyaltiesExamineEarningRulesExamineRequestBodyOrderItem.md) | Order line items (up to 500). Can be &#x60;null&#x60;. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary key-value metadata; any JSON object is accepted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

