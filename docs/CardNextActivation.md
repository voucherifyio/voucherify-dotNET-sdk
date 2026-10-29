# Voucherify.Model.CardNextActivation
The nearest upcoming pending points activation on a card. For the `EVENT_BASED` type, `date` is omitted and `cancel_date` is returned instead; for other types `date` is returned and `cancel_date` is omitted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **decimal?** | Number of pending points to be activated. | [optional] 
**Type** | **string** | Pending points activation type from the card definition. | [optional] 
**Date** | **DateTime?** | Activation date (&#x60;YYYY-MM-DD&#x60;). Present for all types except &#x60;EVENT_BASED&#x60;. | [optional] 
**CancelDate** | **DateTime?** | Date when the pending points are canceled if the activating event does not occur (&#x60;YYYY-MM-DD&#x60;). Present only for the &#x60;EVENT_BASED&#x60; type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

