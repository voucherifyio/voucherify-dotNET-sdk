# Voucherify.Model.MemberCard
A member's loyalty card - the member's assignment to the card (`member_role`, `created_at`) combined with the card details in the `card` object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberRole** | **string** | Role of the member on this card. Currently, loyalty program members can have only the &#x60;OWNER&#x60; role. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the card was assigned to the member (ISO 8601). | [optional] 
**Card** | **Object** |  | 
**Object** | **string** | Object type marker, always &#x60;member_card&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

