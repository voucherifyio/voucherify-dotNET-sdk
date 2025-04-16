# Voucherify.Model.OrdersListResponseBody
Response body schema representing **GET** `v1/orders`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about orders in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of order objects. | [optional] [default to DataRefEnum.Orders]
**Orders** | [**List&lt;OrdersListResponseBodyOrdersItem&gt;**](OrdersListResponseBodyOrdersItem.md) | Contains array of order objects. | [optional] 
**Total** | **int?** | Total number of orders. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

