# Voucherify.Model.CustomerLoyalty
Summary of the customer's **legacy loyalty** activity: points on loyalty cards and referred customers. Loyalty hub memberships are listed separately under `loyalty_memberships` on the customer object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **int?** | Customer&#39;s loyalty points minus expired points for all loyalty cards (**legacy loyalty**) which the customer has. | [optional] 
**ReferredCustomers** | **int?** | Total number of customers referred by the customer. | [optional] 
**Campaigns** | [**Dictionary&lt;string, CustomerLoyaltyCampaignsEntryValue&gt;**](CustomerLoyaltyCampaignsEntryValue.md) | Contains **legacy loyalty** and referral campaigns with details about point balances and how many customers were referred by the customer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

