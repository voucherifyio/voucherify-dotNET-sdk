# Voucherify.Model.MemberActivityDataRedemptionRewardParametersLoyaltyPoints
Defines how many points to credit on a `v2/loyalties` (loyalty hub) card, which program and card definition receive them, and what happens when the customer is not a member yet.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **int?** | Number of points to credit. Must be greater than &#x60;0&#x60;. | [optional] 
**ProgramId** | **string** | Unique &#x60;v2/loyalties&#x60; (loyalty hub) program ID, assigned by Voucherify. | [optional] 
**CardDefinitionId** | **string** | Unique card definition ID of the &#x60;v2/loyalties&#x60; (loyalty hub) card that receives the points. | [optional] 
**OnMissingMember** | **string** | Action when the customer is not a member of the program. &#x60;ENROLL&#x60; enrolls the customer and credits the points. &#x60;REJECT&#x60; rejects the award and the customer is not enrolled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

