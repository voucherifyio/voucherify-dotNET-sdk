# Voucherify.Model.ClientQualificationsCheckEligibilityResponseBody
Response body schema for **POST** `v1/qualifications`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Redeemables** | [**QualificationsRedeemables**](QualificationsRedeemables.md) |  | [optional] 
**TrackingId** | **string** | This identifier is generated during voucher qualification based on your internal id (e.g., email, database ID). This is a hashed customer source ID. | [optional] 
**Order** | [**ClientQualificationsCheckEligibilityResponseBodyOrder**](ClientQualificationsCheckEligibilityResponseBodyOrder.md) |  | [optional] 
**StackingRules** | [**StackingRules**](StackingRules.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

