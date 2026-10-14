# Voucherify.Model.V2LoyaltiesBenefitsGetResponseBody
Response body schema for **GET** `/v2/loyalties/benefits/{benefitId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique benefit ID, prefixed with &#x60;lben_&#x60;. | [optional] 
**Name** | **string** | Benefit name, unique within the project. | [optional] 
**Type** | **string** | Benefit type. | [optional] 
**Status** | **string** | Current benefit status. &#x60;DELETED&#x60; appears only in the response of the delete endpoint and in activity snapshots. | [optional] 
**Stock** | [**V2LoyaltiesBenefitsGetResponseBodyStock**](V2LoyaltiesBenefitsGetResponseBodyStock.md) |  | [optional] 
**Points** | [**V2LoyaltiesBenefitsGetResponseBodyPoints**](V2LoyaltiesBenefitsGetResponseBodyPoints.md) |  | [optional] 
**PointsProportional** | [**V2LoyaltiesBenefitsGetResponseBodyPointsProportional**](V2LoyaltiesBenefitsGetResponseBodyPointsProportional.md) |  | [optional] 
**Material** | **Object** |  | [optional] 
**Digital** | **Object** |  | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp of when the benefit was created, in ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp of the last update, in ISO 8601 format. &#x60;null&#x60; when the benefit was never updated. | [optional] 
**Object** | **string** | Type of the object. Always &#x60;benefit&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

