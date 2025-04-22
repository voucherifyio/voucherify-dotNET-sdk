# Voucherify.Model.QualificationsRedeemables
List of redeemables for examine qualification.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. Default is &#x60;list&#x60;. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of qualified redeemables. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;QualificationsRedeemable&gt;**](QualificationsRedeemable.md) | Array of qualified redeemables. | [optional] 
**Total** | **int** | The number of redeemables returned in the API request. | [optional] 
**HasMore** | **bool** | As results are always limited, the &#x60;has_more&#x60; flag indicates if there are more records for given parameters. This lets you know if you can run another request (with different options) to get more records returned in the results. | [optional] 
**MoreStartingAfter** | **DateTimeOffset** | Timestamp representing the date and time to use in &#x60;starting_after&#x60; cursor to get more redeemables. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

