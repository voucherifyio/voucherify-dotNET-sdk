# Voucherify.Model.ClientValidationsValidateResponseBodyRedeemablesItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** |  | [optional] 
**Id** | **string** | Redeemable ID, i.e. the voucher code. | [optional] 
**Object** | **string** | Redeemable&#39;s object type. | [optional] 
**Order** | [**ClientValidationsValidateResponseBodyRedeemablesItemOrder**](ClientValidationsValidateResponseBodyRedeemablesItemOrder.md) |  | [optional] 
**ApplicableTo** | [**ApplicableToResultList**](ApplicableToResultList.md) |  | [optional] 
**InapplicableTo** | [**InapplicableToResultList**](InapplicableToResultList.md) |  | [optional] 
**Result** | [**ClientValidationsValidateResponseBodyRedeemablesItemResult**](ClientValidationsValidateResponseBodyRedeemablesItemResult.md) |  | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes in the form of key/value pairs assigned to the redeemable. | [optional] 
**Categories** | [**List&lt;CategoryWithStackingRulesType&gt;**](CategoryWithStackingRulesType.md) |  | [optional] 
**CampaignName** | **string** | Campaign name. Displayed only if the &#x60;options.expand&#x60; is passed with a &#x60;redeemable&#x60; value in the validation request body. | [optional] 
**CampaignId** | **string** | Unique campaign ID assigned by Voucherify. Displayed only if the &#x60;options.expand&#x60; is passed with a &#x60;redeemable&#x60; value in the validation request body. | [optional] 
**Name** | **string** | Name of the promotion tier. Displayed only if the &#x60;options.expand&#x60; is passed with a &#x60;redeemable&#x60; value in the validation request body. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

