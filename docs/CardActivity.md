# Voucherify.Model.CardActivity
An activity recorded for a card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTimeOffset?** | Timestamp when the activity was recorded (ISO 8601). | [optional] 
**GroupId** | **string** | ID grouping activities recorded within the same request. | [optional] 
**Source** | [**ActivitySource**](ActivitySource.md) |  | [optional] 
**Id** | **string** | Unique activity ID. | [optional] 
**CardId** | **string** | ID of the card the activity relates to. | [optional] 
**Type** | **string** | Activity type. Allowed values: &#x60;vl.card.created&#x60;, &#x60;vl.card.assigned&#x60;, &#x60;vl.card.unassigned&#x60;, &#x60;vl.card.code_generation.succeeded&#x60;, and &#x60;vl.card.code_generation.failed&#x60;. | [optional] 
**Data** | [**CardActivityData**](CardActivityData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

