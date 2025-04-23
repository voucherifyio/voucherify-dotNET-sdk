# Voucherify.Model.LocationsListResponseBody
Response schema for listing locations using **GET** `v1/locations`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about locations in a dictionary. | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of metadata schema objects. | [optional] 
**Data** | [**List&lt;Location&gt;**](Location.md) | Array of location objects. | [optional] 
**Total** | **int?** | Total number of locations. | [optional] 
**HasMore** | **bool?** | As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request (with a different end date filter) to get more records returned in the results. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

