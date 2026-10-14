# Voucherify.Model.LoyaltiesProgramsMembersOrdersPaymentsListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/members/{memberId}/orders/payments`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;OrderPaymentTransaction&gt;**](OrderPaymentTransaction.md) | Order payment transactions. | [optional] 
**Cursor** | **Object** |  | [optional] 
**Object** | **string** | Object type marker. Always &#x60;list&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

