# Voucherify.Model.CustomerLoyaltyMembershipCard
Loyalty card balance recorded on the customer membership.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardDefinitionId** | **string** | Identifies the card definition. | [optional] 
**CardId** | **string** | Identifies the loyalty card. | [optional] 
**Points** | **decimal?** | Points balance on the card. | [optional] 
**PendingPoints** | **decimal?** | Pending points on the card. | [optional] 
**NextActivationAt** | **DateTime?** | Date when the next points become active, in &#x60;YYYY-MM-DD&#x60; format. &#x60;null&#x60; when no activation is scheduled. | [optional] 
**NextExpirationAt** | **DateTime?** | Date when the next points expire, in &#x60;YYYY-MM-DD&#x60; format. &#x60;null&#x60; when no expiration is scheduled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

