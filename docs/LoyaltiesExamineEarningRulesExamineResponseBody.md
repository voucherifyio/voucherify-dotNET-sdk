# Voucherify.Model.LoyaltiesExamineEarningRulesExamineResponseBody
Response body schema for **POST** `/v2/loyalties/examine/earning-rules`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | **string** | Examined trigger event (e.g. &#x60;customer.order.paid&#x60;, &#x60;customer.segment.entered&#x60;, &#x60;customer.custom_event&#x60;). &#x60;null&#x60; when &#x60;trigger.type&#x60; is &#x60;ALL&#x60;. | [optional] 
**Customer** | [**ExamineCustomerReference**](ExamineCustomerReference.md) |  | [optional] 
**EarningRules** | [**List&lt;LoyaltiesExamineEarningRulesExamineResponseBodyEarningRuleDetail&gt;**](LoyaltiesExamineEarningRulesExamineResponseBodyEarningRuleDetail.md) | Lists earning rules that produced a points or benefit estimation, deduplicated across memberships. | [optional] 
**Memberships** | [**List&lt;LoyaltiesExamineEarningRulesExamineResponseBodyMembership&gt;**](LoyaltiesExamineEarningRulesExamineResponseBodyMembership.md) | Lists one entry for each active membership whose program has earning rules for the examined trigger. Includes a card only when its estimated points are greater than 0, and a benefit only when an earning rule can grant it. Both arrays can be empty. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;earnings_examine_result&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

