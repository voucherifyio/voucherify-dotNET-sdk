# Voucherify.Model.LoyaltyCardTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique transaction ID. | [optional] 
**SourceId** | **string** | The merchant&#39;s transaction ID if it is different from the Voucherify transaction ID. It is really useful in case of an integration between multiple systems. It can be a transaction ID from a CRM system, database or 3rd-party service. In case of a redemption, this value is null. | [optional] 
**VoucherId** | **string** | Unique voucher ID. | [optional] 
**CampaignId** | **string** | Unqiue campaign ID of the voucher&#39;s parent campaign if it is part of campaign that generates bulk codes. | [optional] 
**Source** | **string** | The channel through which the transaction took place, whether through the API or the the Dashboard. In case of a redemption, this value is null. | [optional] 
**Reason** | **string** | Reason why the transaction occurred. In case of a redemption, this value is null. | [optional] 
**RelatedTransactionId** | **string** | The related transaction ID on the receiving card. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the transaction was created. The value is shown in the ISO 8601 format. | [optional] 
**Details** | [**LoyaltyCardTransactionDetails**](LoyaltyCardTransactionDetails.md) |  | [optional] 
**Type** | **LoyaltyCardTransactionsType** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

