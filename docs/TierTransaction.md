# Voucherify.Model.TierTransaction
A tier transaction. Records the outcome of a tier evaluation for a member card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique tier transaction identifier (format &#x60;lttx_...&#x60;). | [optional] 
**CardId** | **string** | Unique identifier of the related loyalty card (format &#x60;lcrd_...&#x60;). | [optional] 
**ProgramId** | **string** | Unique identifier of the loyalty program (format &#x60;lprg_...&#x60;). | [optional] 
**MemberId** | **string** | Unique identifier of the program member (format &#x60;lmbr_...&#x60;). | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (format &#x60;lcdef_...&#x60;). | [optional] 
**TierStructureId** | **string** | Unique identifier of the tier structure (format &#x60;lts_...&#x60;). | [optional] 
**TierId** | **string** | Unique identifier of the related tier (format &#x60;lt_...&#x60;), or &#x60;null&#x60;. | [optional] 
**Type** | **string** | Transaction type. &#x60;JOINED&#x60; - member joined a tier. &#x60;LEFT&#x60; - member left a tier. &#x60;UPGRADED&#x60; - member moved to a higher tier. &#x60;DOWNGRADED&#x60; - member moved to a lower tier. &#x60;EXPIRATION_CHANGED&#x60; - current tier unchanged; the expiration date was set, extended, or cleared. &#x60;EVALUATION_REFRESHED&#x60; - current tier and expiration day unchanged; the stored evaluation and points were recalculated. | [optional] 
**Details** | [**TierTransactionDetails**](TierTransactionDetails.md) |  | 
**Status** | **string** | Transaction status. &#x60;PENDING&#x60; - created, awaiting processing; &#x60;APPROVED&#x60; - completed successfully; &#x60;REJECTED&#x60; - rejected (see &#x60;details.rejection&#x60;). | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the transaction was created (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp when the transaction was last updated (ISO 8601), or &#x60;null&#x60;. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;tier_transaction&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

