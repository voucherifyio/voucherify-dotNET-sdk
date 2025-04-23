# Voucherify.Model.ClientValidationsValidateResponseBodyRedeemablesItemOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID assigned by Voucherify of an existing order that will be linked to the redemption of this request. | [optional] 
**SourceId** | **string** | Unique source ID of an existing order that will be linked to the redemption of this request. | [optional] 
**Status** | **string** | The order status. | [optional] 
**Amount** | **int?** | This is the sum of the order items&#39; amounts. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**InitialAmount** | **int?** | This is the sum of the order items&#39; amounts before any discount or other effect (e.g. add missing units) is applied. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**DiscountAmount** | **int?** | Sum of all order-level discounts applied to the order. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**ItemsDiscountAmount** | **int?** | Sum of all product-specific discounts applied to the order. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**TotalDiscountAmount** | **int?** | Sum of all order-level AND all product-specific discounts applied to the order. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**TotalAmount** | **int?** | Order amount after undoing all the discounts through the rollback redemption. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**AppliedDiscountAmount** | **int?** | This field shows the order-level discount applied. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**ItemsAppliedDiscountAmount** | **int?** | Sum of all product-specific discounts applied in a particular request. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00).   &#x60;sum(items, i &#x3D;&gt; i.applied_discount_amount)&#x60; | [optional] 
**TotalAppliedDiscountAmount** | **int?** | Sum of all order-level AND all product-specific discounts applied in a particular request. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00).   &#x60;total_applied_discount_amount&#x60; &#x3D; &#x60;applied_discount_amount&#x60; + &#x60;items_applied_discount_amount&#x60; | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to an order. It can be useful for storing additional information about the order in a structured format. It can be used to define business validation rules or discount formulas. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the order was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the order was last updated in ISO 8601 format. | [optional] 
**CustomerId** | **string** | Unique customer identifier of the customer making the purchase. The ID is assigned by Voucherify. | [optional] 
**ReferrerId** | **string** | Unique referrer ID. | [optional] 
**Customer** | [**ClientValidationsValidateResponseBodyRedeemablesItemOrderCustomer**](ClientValidationsValidateResponseBodyRedeemablesItemOrderCustomer.md) |  | [optional] 
**Referrer** | [**ClientValidationsValidateResponseBodyRedeemablesItemOrderReferrer**](ClientValidationsValidateResponseBodyRedeemablesItemOrderReferrer.md) |  | [optional] 
**Redemptions** | [**Dictionary&lt;string, OrderRedemptionsEntry&gt;**](OrderRedemptionsEntry.md) |  | [optional] 
**Items** | [**List&lt;OrderCalculatedItem&gt;**](OrderCalculatedItem.md) | Array of items applied to the order. It can include up to 500 items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

