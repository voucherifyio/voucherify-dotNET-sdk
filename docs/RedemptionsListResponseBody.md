# Voucherify.Model.RedemptionsListResponseBody
Response body schema for **GET** `v1/redemptions`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about redemptions in a dictionary. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of redemption objects. | [optional] [default to "redemptions"]
**Redemptions** | [**List&lt;RedemptionsListResponseBodyRedemptionsItem&gt;**](RedemptionsListResponseBodyRedemptionsItem.md) |  | [optional] 
**Total** | **int?** | Total number of redemptions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

