# Voucherify.Model.ManagementProjectsCreateRequestBody
Request body schema for **POST** `/management/v1/projects`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CaseSensitiveCodes** | **bool** | Determines if the vouchers in the project will be case sensitive (if &#x60;true&#x60;, &#x60;C0dE-cfV&#x60; is not equal to &#x60;c0de-cfv&#x60;) or case insensitive (if false, &#x60;C0dE-cfV&#x60; is equal to &#x60;c0de-cfv&#x60;). | [optional] 
**Name** | **string** | The name of the project. | [optional] 
**Description** | **string** | A user-defined description of the project, e.g. its purpose, scope, region. | [optional] 
**Timezone** | **string** | The time zone in which the project is established. It can be in the GMT format or in accordance with IANA time zone database. | [optional] 
**Currency** | **string** | The currency used in the project. It is equal to a 3-letter ISO 4217 code. | [optional] 
**DialCode** | **string** | The country dial code for the project. It is equal to an ITU country code. | [optional] 
**WebhookVersion** | **string** | The webhook version used in the project. | [optional] [default to WebhookVersionEnum.V20240101]
**ClientTrustedDomains** | **List&lt;string&gt;** | An array of URL addresses that allow client requests. | [optional] 
**ClientRedeemEnabled** | **bool** | Enables client-side redemption. | [optional] 
**ClientPublishEnabled** | **bool** | Enables client-side publication. | [optional] 
**ClientListVouchersEnabled** | **bool** | Enables client-side listing of vouchers. | [optional] 
**ClientCreateCustomerEnabled** | **bool** | Enables client-side creation of customers. | [optional] 
**ClientLoyaltyEventsEnabled** | **bool** | Enables client-side events for loyalty and referral programs. | [optional] 
**ClientSetVoucherExpirationDateEnabled** | **bool** | Enables client-side setting of voucher expiration date. | [optional] 
**WebhooksCalloutNotifications** | [**ManagementProjectsCreateRequestBodyWebhooksCalloutNotifications**](ManagementProjectsCreateRequestBodyWebhooksCalloutNotifications.md) |  | [optional] 
**ApiUsageNotifications** | [**ManagementProjectsCreateRequestBodyApiUsageNotifications**](ManagementProjectsCreateRequestBodyApiUsageNotifications.md) |  | [optional] 
**ClusterId** | **string** | The identifier of the cluster where the project will be created. The default cluster is &#x60;eu1&#x60; unless otherwise configured. | [optional] 
**ApiVersion** | **string** | The API version used in the project. Currently, the default and only value is &#x60;v2018-08-01&#x60;. | [optional] [default to ApiVersionEnum.V20180801]
**Users** | [**List&lt;ManagementProjectsCreateRequestBodyUsersItem&gt;**](ManagementProjectsCreateRequestBodyUsersItem.md) | The users (their identifiers, logins, and roles) who will be assigned to the project. You can assign only existing Voucherify users.  It must be used either in the following combinations: - &#x60;id&#x60; and &#x60;role&#x60;, or - &#x60;login&#x60; and &#x60;role&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

