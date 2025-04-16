# Voucherify.Model.ManagementProjectsWebhooksCreateRequestBody
Request body schema for **POST** `/management/v1/projects/{projectId}/webhooks/{webhookId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetUrl** | **string** | URL address that receives webhooks. | [optional] 
**Events** | **List&lt;ManagementProjectsWebhooksCreateRequestBody.EventsEnum&gt;** | Lists the events that trigger webhook sendout. | [optional] 
**Active** | **bool?** | Determines if the webhook configuration is active. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

