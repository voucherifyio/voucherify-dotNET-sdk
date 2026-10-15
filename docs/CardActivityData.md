# Voucherify.Model.CardActivityData
Snapshots of the objects involved at the time of the activity. Always contains `card` and `program`. For `vl.card.assigned` and `vl.card.unassigned`, also contains `member` and `member_card`. For `vl.card.code_generation.failed`, also contains `result`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Card** | [**Card**](Card.md) |  | 
**Program** | [**Program**](Program.md) |  | 
**Member** | [**Member**](Member.md) |  | [optional] 
**MemberCard** | [**MemberCard**](MemberCard.md) |  | [optional] 
**Result** | [**CardCodeGenerationFailureResult**](CardCodeGenerationFailureResult.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

