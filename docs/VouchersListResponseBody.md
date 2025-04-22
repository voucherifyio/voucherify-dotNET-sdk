# Voucherify.Model.VouchersListResponseBody
Response body schema for **GET** `v1/vouchers`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of voucher objects. | [optional] [default to DataRefEnum.Vouchers]
**Vouchers** | [**List&lt;VoucherWithCategories&gt;**](VoucherWithCategories.md) | A dictionary that contains an array of  vouchers. Each entry in the array is a separate voucher object. | [optional] 
**Total** | **int?** | Returns how many vouchers in the project meet the limits defined by the query parameter definitions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

