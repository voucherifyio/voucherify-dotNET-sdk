# Voucherify.Model.SimpleOrderItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the order line item. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the &#x60;order_item&#x60;. | [optional] 
**SourceId** | **string** | The merchant&#39;s product/SKU ID (if it is different from the Voucherify product/SKU ID). It is useful in the integration between multiple systems. It can be an ID from an eCommerce site, a database, or a third-party service. | [optional] 
**RelatedObject** | **string** | Used along with the &#x60;source_id&#x60; property, can be set to either SKU or product. | [optional] 
**ProductId** | **string** | Unique identifier of the product. It is assigned by Voucherify. | [optional] 
**SkuId** | **string** | Unique identifier of the SKU. It is assigned by Voucherify. | [optional] 
**Quantity** | **int?** | Quantity of the particular item in the cart. | [optional] 
**AppliedQuantity** | **int?** | Quantity of items changed by the application of a new quantity items. It can be positive when an item is added or negative if an item is replaced. | [optional] 
**AppliedQuantityAmount** | **int?** | Amount for the items changed by the application of a new quantity items. It can be positive when an item is added or negative if an item is replaced. | [optional] 
**DiscountQuantity** | **int?** | Number of discounted items. | [optional] 
**AppliedDiscountQuantity** | **int?** | Number of the discounted items applied in the transaction. | [optional] 
**Amount** | **int?** | Total amount of the order item (price * quantity). | [optional] 
**DiscountAmount** | **int?** | Sum of all order-item-level discounts applied to the order. | [optional] 
**AppliedDiscountAmount** | **int?** | Order-level discount amount applied in the transaction. | [optional] 
**Price** | **int?** | Unit price of an item. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**SubtotalAmount** | **int?** | Final order item amount after the applied item-level discount.  If there are no item-level discounts applied, this item is equal to the &#x60;amount&#x60;.    &#x60;subtotal_amount&#x60;&#x3D;&#x60;amount&#x60;-&#x60;discount_amount&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

