# Voucherify.Model.ManagementProjectsWebhooksUpdateResponseBody
Response body schema for **PUT** `/management/v1/projects/{projectId}/webhooks/{webhookId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the webhook. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.Webhook]
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the webhook configuration was created. The value for this parameter is shown in the ISO 8601 format. | [optional] 
**TargetUrl** | **string** | URL address that receives webhooks. | [optional] 
**Events** | **List&lt;ManagementProjectsWebhooksUpdateResponseBody.EventsEnum&gt;** | Lists the events that trigger webhook sendout. | [optional] 
**Active** | **bool** | Determines if the webhook configuration is active. | [optional] [default to true]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

