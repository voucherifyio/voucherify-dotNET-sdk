# Voucherify.Model.PromotionTierCreateParams
This is an object representing a promotion tier create params. Promotion tiers are always assigned to a campaign and cannot be used standalone.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the promotion tier. | [optional] 
**Banner** | **string** | Text to be displayed to your customers on your website. | [optional] 
**Action** | [**PromotionTierCreateParamsAction**](PromotionTierCreateParamsAction.md) |  | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the promotion tier. A set of key/value pairs that you can attach to a promotion tier object. It can be useful for storing additional information about the promotion tier in a structured format. | [optional] 
**ValidationRules** | **List&lt;string&gt;** | Array containing the ID of the validation rule associated with the promotion tier. | [optional] 
**Active** | **bool?** | A flag to toggle the promotion tier on or off. You can disable a promotion tier even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* promotion tier - &#x60;false&#x60; indicates an *inactive* promotion tier | [optional] 
**Hierarchy** | **int?** | The promotions hierarchy defines the order in which the discounts from different tiers will be applied to a customer&#39;s order. If a customer qualifies for discounts from more than one tier, discounts will be applied in the order defined in the hierarchy. | [optional] 
**StartDate** | **DateTimeOffset?** | Activation timestamp defines when the promotion tier starts to be active in ISO 8601 format. Promotion tier is *inactive before* this date.  | [optional] 
**ExpirationDate** | **DateTimeOffset?** | Activation timestamp defines when the promotion tier expires in ISO 8601 format. Promotion tier is *inactive after* this date.  | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;PromotionTierCreateParams.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 
**Category** | **string** | Assign category to the promotion tier. | [optional] 
**CategoryId** | **string** | Instead of using the category name, you can alternatively assign a new category to a promotion tier using a unique category ID, i.e. &#x60;cat_0c9da30e7116ba6bba&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

