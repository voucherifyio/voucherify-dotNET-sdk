# Voucherify.Model.CampaignsImportVoucherItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Value representing the imported code. | [optional] 
**Redemption** | [**CampaignsImportVoucherItemRedemption**](CampaignsImportVoucherItemRedemption.md) |  | [optional] 
**Active** | **bool?** | A flag to toggle the voucher on or off. You can disable a voucher even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* voucher - &#x60;false&#x60; indicates an *inactive* voucher | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the code. A set of key/value pairs that you can attach to a voucher object. It can be useful for storing additional information about the voucher in a structured format. | [optional] 
**Category** | **string** | Tag defining the category that this voucher belongs to. Useful when listing vouchers using the [List Vouchers](ref:list-vouchers) endpoint. | [optional] 
**StartDate** | **DateTimeOffset?** | Activation timestamp presented in the ISO 8601 format. Voucher is *inactive before* this date. Start date defines when the code starts to be active. Allowed date formats are: - YYYY-MM-DD - YYYY-MM-DDTHH - YYYY-MM-DDTHH:mm - YYYY-MM-DDTHH:mm:ss - YYYY-MM-DDTHH:mm:ssZ - YYYY-MM-DDTHH:mm:ss.SSSZ | [optional] 
**ExpirationDate** | **DateTimeOffset?** | Expiration date defines when the code expires. Expiration timestamp is presented in the ISO 8601 format.  Voucher is *inactive after* this date. Allowed date formats are: - YYYY-MM-DD - YYYY-MM-DDTHH - YYYY-MM-DDTHH:mm - YYYY-MM-DDTHH:mm:ss - YYYY-MM-DDTHH:mm:ssZ - YYYY-MM-DDTHH:mm:ss.SSSZ | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;CampaignsImportVoucherItem.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**AdditionalInfo** | **string** | An optional field to keep any extra textual information about the code such as a code description and details. | [optional] 
**Type** | **string** |  | [optional] 
**LoyaltyCard** | [**SimpleLoyaltyCard**](SimpleLoyaltyCard.md) |  | [optional] 
**Gift** | [**Gift**](Gift.md) |  | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

