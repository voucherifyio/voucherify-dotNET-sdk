# Voucherify.Model.OrdersImportCreateRequestBodyItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID assigned by Voucherify of an existing order that will be linked to the redemption of this request. | [optional] 
**SourceId** | **string** | Unique source ID of an existing order that will be linked to the redemption of this request. | [optional] 
**Status** | **string** | The order status. | [optional] 
**Amount** | **int?** | A positive integer in the smallest currency unit (e.g. 100 cents for $1.00) representing the total amount of the order. This is the sum of the order items&#39; amounts. | [optional] 
**InitialAmount** | **int?** | A positive integer in the smallest currency unit (e.g. 100 cents for $1.00) representing the total amount of the order. This is the sum of the order items&#39; amounts. | [optional] 
**DiscountAmount** | **int?** | Sum of all order-level discounts applied to the order. It is expressed as an integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Array of items applied to the order. It can include up to 500 items. | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to an order. It can be useful for storing additional information about the order in a structured format. It can be used to define business validation rules or discount formulas. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the order was created. The value is shown in the ISO 8601 format. | [optional] 
**ReferrerId** | **string** | Unique referrer ID. | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Referrer** | [**Referrer**](Referrer.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

