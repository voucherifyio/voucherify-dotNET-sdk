# Voucherify.Model.LoyaltiesTransactionsListResponseBody
Response body schema for **GET** `v1/loyalties/{campaignId}/transactions`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of transaction objects. | [optional] 
**Data** | [**List&lt;LoyaltyCardTransaction&gt;**](LoyaltyCardTransaction.md) | A dictionary that contains an array of transactions. Each entry in the array is a separate transaction object. | [optional] 
**HasMore** | **bool?** | As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request (with a different paging or a different start date filter) to get more records returned in the results. | [optional] 
**MoreStartingAfter** | **string** | Returns an ID that can be used to return another page of results. Use the transaction ID in the &#x60;starting_after_id&#x60; query parameter to display another page of the results starting after the transaction with that ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

