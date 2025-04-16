# Voucherify.Model.ManagementProject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the project. | [optional] 
**Name** | **string** | The name of the project. | [optional] 
**Description** | **string** | A user-defined description of the project, e.g. its purpose, scope, region. | [optional] 
**Timezone** | **string** | The time zone in which the project is established. It can be in the GMT format or in accordance with IANA time zone database. | [optional] 
**Currency** | **string** | The currency used in the project. It is equal to a 3-letter ISO 4217 code. | [optional] 
**DialCode** | **string** | The country dial code for the project. It is equal to an ITU country code. | [optional] 
**WebhookVersion** | **string** | The webhook version used in the project. | [optional] [default to WebhookVersionEnum.V20240101]
**ClientTrustedDomains** | **List&lt;string&gt;** | An array of URL addresses that allow client requests. | [optional] 
**ClientRedeemEnabled** | **bool?** | Enables client-side redemption. | [optional] 
**ClientPublishEnabled** | **bool?** | Enables client-side publication. | [optional] 
**ClientListVouchersEnabled** | **bool?** | Enables client-side listing of vouchers. | [optional] 
**ClientCreateCustomerEnabled** | **bool?** | Enables client-side creation of customers. | [optional] 
**ClientLoyaltyEventsEnabled** | **bool?** | Enables client-side events for loyalty and referral programs. | [optional] 
**ClientSetVoucherExpirationDateEnabled** | **bool?** | Enables client-side setting of voucher expiration date. | [optional] 
**WebhooksCalloutNotifications** | [**ManagementProjectWebhooksCalloutNotifications**](ManagementProjectWebhooksCalloutNotifications.md) |  | [optional] 
**ApiUsageNotifications** | [**ManagementProjectApiUsageNotifications**](ManagementProjectApiUsageNotifications.md) |  | [optional] 
**ClusterId** | **string** | The identifier of the cluster where the project will be created. | [optional] 
**CaseSensitiveCodes** | **bool?** | Determines if the vouchers in the project will be: - case sensitive - if &#x60;true&#x60;, &#x60;C0dE-cfV&#x60; is **not** equal to &#x60;c0de-cfv&#x60;), - case insensitive - if &#x60;false&#x60;, &#x60;C0dE-cfV&#x60; is equal to &#x60;c0de-cfv&#x60;. | [optional] 
**ApiVersion** | **string** | The API version used in the project. Currently, the default and only value is &#x60;v2018-08-01&#x60;. | [optional] [default to ApiVersionEnum.V20180801]
**IsSandbox** | **bool?** | Determines if the project is a sandbox project. | [optional] 
**WebhookToken** | **string** | Webhook token used for authentication. | [optional] 
**DefaultCodeConfig** | [**ManagementProjectDefaultCodeConfig**](ManagementProjectDefaultCodeConfig.md) |  | [optional] 
**Limits** | [**ManagementProjectLimits**](ManagementProjectLimits.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

