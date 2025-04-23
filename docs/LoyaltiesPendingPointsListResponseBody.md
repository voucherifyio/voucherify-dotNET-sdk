# Voucherify.Model.LoyaltiesPendingPointsListResponseBody
Response body schema for **GET** `/loyalties/{campaignId}/pending-points`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of pending point objects. | [optional] 
**Data** | [**List&lt;LoyaltyPendingPoints&gt;**](LoyaltyPendingPoints.md) | A dictionary that contains an array of pending point entries. Each entry in the array is a separate pending point object. | [optional] 
**HasMore** | **bool?** | As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request to get more records returned in the results. | [optional] 
**MoreStartingAfter** | **string** | Returns an ID that can be used to return another page of results. Use the pending point entry ID in the &#x60;starting_after_id&#x60; query parameter to display another page of the results starting after the entry with that ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

