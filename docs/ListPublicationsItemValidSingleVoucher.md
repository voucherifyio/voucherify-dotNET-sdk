# Voucherify.Model.ListPublicationsItemValidSingleVoucher

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique publication ID, assigned by Voucherify. | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the &#x60;publication&#x60;. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the publication was created. The value is shown in the ISO 8601 format. | [optional] 
**CustomerId** | **string** | Unique customer ID of the customer receiving the publication. | [optional] 
**TrackingId** | **string** | Customer&#39;s &#x60;source_id&#x60;. | [optional] 
**Metadata** | [**ListPublicationsItemValidSingleVoucherMetadata**](ListPublicationsItemValidSingleVoucherMetadata.md) |  | [optional] 
**Channel** | **string** | How the publication was originated. It can be your own custom channel or an example value provided here. | [optional] 
**SourceId** | **string** | The merchant&#39;s publication ID if it is different from the Voucherify publication ID. It&#39;s an optional tracking identifier of a publication. It is really useful in case of an integration between multiple systems. It can be a publication ID from a CRM system, database or 3rd-party service.  | [optional] 
**Customer** | [**CustomerWithSummaryLoyaltyReferrals**](CustomerWithSummaryLoyaltyReferrals.md) |  | [optional] 
**Vouchers** | **List&lt;string&gt;** | Contains the voucher IDs that was assigned by Voucherify. | [optional] 
**VouchersId** | **List&lt;string&gt;** | Contains the unique internal voucher IDs that was assigned by Voucherify. | [optional] 
**Result** | **string** | Status of the publication attempt. | [optional] 
**Voucher** | [**ListPublicationsItemVoucher**](ListPublicationsItemVoucher.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

