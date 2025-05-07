# Voucherify.Model.LoyaltiesListMembersResponseBody
Response body schema for **GET** `v1/loyalties/{campaignId}/members`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about members in a dictionary. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of voucher objects. | [optional] [default to DataRefEnum.Vouchers]
**Vouchers** | [**List&lt;LoyaltyMember&gt;**](LoyaltyMember.md) | Contains array of voucher objects representing loyalty cards, in other words, loyalty program members. | [optional] 
**Total** | **int** | Total number of voucher objects. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

