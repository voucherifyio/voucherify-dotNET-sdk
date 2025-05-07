# Voucherify.Model.PublicationsListResponseBody
Response body schema for listing publications using **GET** `v1/publications`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about publications in a dictionary. | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of publications. | [optional] 
**Publications** | [**List&lt;PublicationsListResponseBodyPublicationsItem&gt;**](PublicationsListResponseBodyPublicationsItem.md) | Response schema model for publishing vouchers to a specific customer. | [optional] 
**Total** | **int?** | Total number of publications. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

