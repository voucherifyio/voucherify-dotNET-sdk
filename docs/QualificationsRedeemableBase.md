# Voucherify.Model.QualificationsRedeemableBase
Data of single redeemable which was properly qualified.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the redeemable. | [optional] 
**Object** | **string** | Object type of the redeemable. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the object was created. The value is shown in the ISO 8601 format. | [optional] 
**Result** | [**RedeemableResult**](RedeemableResult.md) |  | [optional] 
**Order** | [**QualificationsRedeemableBaseOrder**](QualificationsRedeemableBaseOrder.md) |  | [optional] 
**ValidationRuleId** | **string** | A unique validation rule identifier assigned by the Voucherify API. The validation rule is verified before points are added to the balance. | [optional] 
**ApplicableTo** | [**ApplicableToResultList**](ApplicableToResultList.md) |  | [optional] 
**InapplicableTo** | [**InapplicableToResultList**](InapplicableToResultList.md) |  | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the product. A set of key/value pairs that you can attach to a product object. It can be useful for storing additional information about the product in a structured format. | [optional] 
**Categories** | [**List&lt;CategoryWithStackingRulesType&gt;**](CategoryWithStackingRulesType.md) | List of category information. | [optional] 
**Banner** | **string** | Name of the earning rule. This is displayed as a header for the earning rule in the Dashboard. | [optional] 
**Name** | **string** | Name of the redeemable. | [optional] 
**CampaignName** | **string** | Name of the campaign associated to the redeemable. This field is available only if object is not &#x60;campaign&#x60; | [optional] 
**CampaignId** | **string** | Id of the campaign associated to the redeemable. This field is available only if object is not &#x60;campaign&#x60; | [optional] 
**ValidationRulesAssignments** | [**ValidationRulesAssignmentsList**](ValidationRulesAssignmentsList.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

