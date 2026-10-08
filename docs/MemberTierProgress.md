# Voucherify.Model.MemberTierProgress
Member's tier progress on a card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Current** | **Object** |  | 
**TierStructure** | **Object** |  | 
**Deferred** | [**List&lt;MemberTierProgressDeferred&gt;**](MemberTierProgressDeferred.md) | Upcoming tier assignments scheduled to start later, when the tier structure defers tier changes. The member will be assigned to the deferred tier at the start date. | [optional] 
**Risks** | [**List&lt;MemberTierProgressRisk&gt;**](MemberTierProgressRisk.md) | Upcoming risks of losing or downgrading the current tier. | [optional] 
**Opportunities** | [**List&lt;MemberTierProgressOpportunity&gt;**](MemberTierProgressOpportunity.md) | Opportunities to reach higher tiers. Deferred tiers are not included in this list. | [optional] 
**Object** | **string** | Object type marker, always &#x60;member_tier_progress&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

