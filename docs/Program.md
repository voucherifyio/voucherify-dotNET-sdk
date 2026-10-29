# Voucherify.Model.Program
A loyalty program.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique program identifier. | [optional] 
**Name** | **string** | Program name. | [optional] 
**Status** | **string** | Program status. | [optional] 
**StartDate** | **DateTimeOffset?** | Program validity start date (ISO 8601), or &#x60;null&#x60; when not set. | [optional] 
**EndDate** | **DateTimeOffset?** | Program validity end date (ISO 8601), or &#x60;null&#x60; when not set. | [optional] 
**ValidityHours** | [**ProgramValidityHours**](ProgramValidityHours.md) |  | [optional] 
**Metadata** | **Object** | Arbitrary key-value metadata. Defaults to &#x60;{}&#x60;. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Creation timestamp (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Last update timestamp (ISO 8601), or &#x60;null&#x60; when never updated. | [optional] 
**Object** | **string** | Object type marker. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

