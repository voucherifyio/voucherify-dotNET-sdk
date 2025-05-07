# Voucherify.Model.CustomerReferralsCampaignsItem
Contains information about the source of the referral.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **string** | Unique campaign ID, assigned by Voucherify. | 
**ReferrerId** | **string** | Unique referrer ID, assigned by Voucherify. This is the customer ID of a customer that is referring this customer. | 
**RelatedObjectId** | **string** | Related object id | 
**RelatedObjectType** | **string** | Related object type, i.e. &#x60;redemption&#x60;. | 
**Date** | **DateTimeOffset** | Timestamp representing the date and time when the customer was referred in ISO 8601 format. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

