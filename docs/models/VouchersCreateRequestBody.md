# Voucherify.Model.VouchersCreateRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Code that identifies a voucher. The pattern can use all the letters of the English alphabet, Arabic numerals, and special characters. Pass this attribute in the request body to create a distinct code. Otherwise, either use the &#x60;code_config&#x60; object to set the rules that the Voucherify API will use to create a random code, or don&#39;t pass any code and Voucherify will generate a random code. | [optional] 
**Campaign** | **string** | Identifies the voucher&#39;s parent campaign using a unique campaign name. | [optional] 
**CampaignId** | **string** | Identifies the voucher&#39;s parent campaign using a unique campaign ID assigned by the Voucherify API. | [optional] 
**Category** | **string** | The name of the category that this voucher belongs to. Useful when listing vouchers with the [List Vouchers](ref:list-vouchers) endpoint. | [optional] 
**CategoryId** | **string** | Unique identifier assigned by Voucherify to the name of the category that this voucher belongs to. Useful when listing vouchers with the [List Vouchers](ref:list-vouchers) endpoint. | [optional] 
**StartDate** | **DateTimeOffset** | Start date defines when the code starts to be active. Activation timestamp is presented in the ISO 8601 format. Voucher is *inactive before* this date. | [optional] 
**ExpirationDate** | **DateTimeOffset** | Expiration date defines when the code expires. Expiration timestamp is presented in the ISO 8601 format.  Voucher is *inactive after* this date. | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;VouchersCreateRequestBody.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 
**Active** | **bool** | A flag to toggle the voucher on or off. You can disable a voucher even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* voucher - &#x60;false&#x60; indicates an *inactive* voucher | [optional] 
**AdditionalInfo** | **string** | An optional field to keep any extra textual information about the code such as a code description and details. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the code. A set of key/value pairs that you can attach to a voucher object. It can be useful for storing additional information about the voucher in a structured format. | [optional] 
**ValidationRules** | **List&lt;string&gt;** | Array containing the ID of the validation rule associated with the voucher. | [optional] 
**Redemption** | [**VouchersCreateRequestBodyRedemption**](VouchersCreateRequestBodyRedemption.md) |  | [optional] 
**Type** | **string** |  | [optional] 
**LoyaltyCard** | [**SimpleLoyaltyCard**](SimpleLoyaltyCard.md) |  | [optional] 
**CodeConfig** | [**CodeConfig**](CodeConfig.md) |  | [optional] 
**Gift** | [**Gift**](Gift.md) |  | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

