# Voucherify.Model.ManagementProjectsUpdateRequestBody
Request body schema for **PUT** `/management/v1/projects/{projectId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the project. | [optional] 
**Description** | **string** | A user-defined description of the project, e.g. its purpose, scope, region. | [optional] 
**Timezone** | **string** | The time zone in which the project is established. It can be in the GMT format or in accordance with IANA time zone database. | [optional] 
**Currency** | **string** | The currency used in the project. It is equal to a 3-letter ISO 4217 code. | [optional] 
**DialCode** | **string** | The country dial code for the project. It is equal to an ITU country code. | [optional] 
**WebhookVersion** | **string** | The webhook version used in the project. | [optional] 
**ClientTrustedDomains** | **List&lt;string&gt;** | An array of URL addresses that allow client requests. | [optional] 
**ClientRedeemEnabled** | **bool?** | Enables client-side redemption. | [optional] 
**ClientPublishEnabled** | **bool?** | Enables client-side publication. | [optional] 
**ClientListVouchersEnabled** | **bool?** | Enables client-side listing of vouchers. | [optional] 
**ClientCreateCustomerEnabled** | **bool?** | Enables client-side creation of customers. | [optional] 
**ClientLoyaltyEventsEnabled** | **bool?** | Enables client-side events for loyalty and referral programs. | [optional] 
**ClientSetVoucherExpirationDateEnabled** | **bool?** | Enables client-side setting of voucher expiration date. | [optional] 
**WebhooksCalloutNotifications** | [**ManagementProjectsUpdateRequestBodyWebhooksCalloutNotifications**](ManagementProjectsUpdateRequestBodyWebhooksCalloutNotifications.md) |  | [optional] 
**ApiUsageNotifications** | [**ManagementProjectsUpdateRequestBodyApiUsageNotifications**](ManagementProjectsUpdateRequestBodyApiUsageNotifications.md) |  | [optional] 
**DefaultCodeConfig** | [**ManagementProjectsUpdateRequestBodyDefaultCodeConfig**](ManagementProjectsUpdateRequestBodyDefaultCodeConfig.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

