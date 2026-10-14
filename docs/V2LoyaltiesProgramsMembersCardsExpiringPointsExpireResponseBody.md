# Voucherify.Model.V2LoyaltiesProgramsMembersCardsExpiringPointsExpireResponseBody
Response body schema for **POST** `/v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/expiring-points/{bucketId}/expire`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transaction** | [**CardTransaction**](CardTransaction.md) |  | 
**Status** | **string** | Result status. The API endpoint returns &#x60;TRANSACTION_CREATED&#x60;. | [optional] 
**Message** | **string** | Human-readable result message - \&quot;Points expiration transaction created\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

