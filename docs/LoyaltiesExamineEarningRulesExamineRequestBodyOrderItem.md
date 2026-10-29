# Voucherify.Model.LoyaltiesExamineEarningRulesExamineRequestBodyOrderItem
A hypothetical order line item used for estimation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Order item ID assigned by Voucherify. Can be &#x60;null&#x60;. | [optional] 
**SourceId** | **string** | Order item source ID, e.g. from an external system. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**ProductId** | **string** | Product ID. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**SkuId** | **string** | SKU ID. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**RelatedObject** | **string** | Whether the item refers to a product or a SKU. Can be &#x60;null&#x60;. | [optional] 
**Amount** | **decimal?** | Item amount before discounts - a non-negative integer. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**DiscountAmount** | **decimal?** | Item discount amount - a non-negative integer. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**Quantity** | **decimal?** | Item quantity - a positive integer. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**Price** | **decimal?** | Item unit price - a non-negative integer. May be provided as a string or a number. Can be &#x60;null&#x60;. | [optional] 
**Product** | [**LoyaltiesExamineEarningRulesExamineRequestBodyOrderItemProduct**](LoyaltiesExamineEarningRulesExamineRequestBodyOrderItemProduct.md) |  | [optional] 
**Sku** | [**LoyaltiesExamineEarningRulesExamineRequestBodyOrderItemSku**](LoyaltiesExamineEarningRulesExamineRequestBodyOrderItemSku.md) |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary key-value metadata; any JSON object is accepted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

