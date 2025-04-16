# Voucherify.Model.CustomersCreateResponseBody
Response body for **POST** `v1/customers`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of an existing customer that will be linked to redemption in this request. | [optional] 
**SourceId** | **string** | A unique identifier of the customer who validates a voucher. It can be a customer ID or email from a CRM system, database, or a third-party service. If you also pass a customer ID (unique ID assigned by Voucherify), the source ID will be ignored. | [optional] 
**Summary** | [**CustomerSummary**](CustomerSummary.md) |  | [optional] 
**Loyalty** | [**CustomerLoyalty**](CustomerLoyalty.md) |  | [optional] 
**Referrals** | [**CustomerReferrals**](CustomerReferrals.md) |  | [optional] 
**SystemMetadata** | **Object** | Object used to store system metadata information. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the customer was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the customer was updated. The value is shown in the ISO 8601 format. | [optional] 
**Assets** | [**CustomersCreateResponseBodyAssets**](CustomersCreateResponseBodyAssets.md) |  | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.Customer]
**Name** | **string** | Customer&#39;s first and last name. | [optional] 
**Description** | **string** | An arbitrary string that you can attach to a customer object. | [optional] 
**Email** | **string** | Customer&#39;s email address. | [optional] 
**Phone** | **string** | Customer&#39;s phone number. This parameter is mandatory when you try to send out codes to customers via an SMS channel. | [optional] 
**Birthday** | **DateTime?** | &#x60;Deprecated&#x60;. ~~Customer&#39;s birthdate; format YYYY-MM-DD~~. | [optional] 
**Birthdate** | **DateTime?** | Customer&#39;s birthdate; format YYYY-MM-DD. | [optional] 
**Address** | [**CustomersCreateResponseBodyAddress**](CustomersCreateResponseBodyAddress.md) |  | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a customer. The metadata object stores all custom attributes assigned to the customer. It can be useful for storing additional information about the customer in a structured format. This metadata can be used for validating whether the customer qualifies for a discount or it can be used in building customer segments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

