# Voucherify.Model.ManagementProjectsBrandingListResponseBody
Object containing a list of brand configurations. It always contains one item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about the brand in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of brand objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;ManagementProjectsBranding&gt;**](ManagementProjectsBranding.md) | Array of brand objects. It contains only one object. | [optional] 
**Total** | **int** | The total number of brand objects. It is always &#x60;1&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

