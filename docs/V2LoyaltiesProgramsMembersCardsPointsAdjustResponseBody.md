# Voucherify.Model.V2LoyaltiesProgramsMembersCardsPointsAdjustResponseBody
Response body schema for **POST** `/v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/points`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transaction** | [**CardTransaction**](CardTransaction.md) |  | [optional] 
**Status** | **string** | &#x60;TRANSACTION_CREATED&#x60; when a transaction was created, &#x60;NO_CHANGE&#x60; when the requested points amount was zero. | [optional] 
**Message** | **string** | Human-readable result message: - \&quot;Points addition transaction created\&quot;, - \&quot;Points subtraction transaction created\&quot;, - \&quot;Provided amount is zero, transaction was not created\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

