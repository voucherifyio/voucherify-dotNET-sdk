# Voucherify.Model.V2LoyaltiesEarningRulesGetResponseBody
Response body schema for **GET** `/v2/loyalties/earning-rules/{earningRuleId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Earning rule ID (&#x60;lern_...&#x60;). | [optional] 
**Name** | **string** | Earning rule name. | [optional] 
**Status** | **string** | Current status. &#x60;DELETED&#x60; also exists internally but deleted rules are excluded from API reads. | [optional] 
**Earnings** | [**List&lt;EarningRuleEarning&gt;**](EarningRuleEarning.md) | Earning definitions of the rule. Contains at least one earning. | [optional] 
**Trigger** | [**EarningRuleTrigger**](EarningRuleTrigger.md) |  | 
**Error** | [**LoyaltyV2ActivityEarningRuleError**](LoyaltyV2ActivityEarningRuleError.md) |  | [optional] 
**ValidityHours** | [**EarningRuleValidityHours**](EarningRuleValidityHours.md) |  | 
**StartDate** | **DateTimeOffset?** | Date-time from which the rule is active. Can be &#x60;null&#x60;. | [optional] 
**EndDate** | **DateTimeOffset?** | Date-time until which the rule is active. Can be &#x60;null&#x60;. | [optional] 
**TriggerLimits** | [**V2LoyaltiesEarningRulesGetResponseBodyTriggerLimits**](V2LoyaltiesEarningRulesGetResponseBodyTriggerLimits.md) |  | [optional] 
**EarningLimits** | [**LoyaltyV2ActivityEarningRuleEarningLimits**](LoyaltyV2ActivityEarningRuleEarningLimits.md) |  | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary key-value metadata; any JSON object is accepted. | 
**CreatedAt** | **DateTimeOffset?** | Creation timestamp (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Last update timestamp (ISO 8601). &#x60;null&#x60; when never updated. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;earning_rule&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

