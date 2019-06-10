<h3 align="center">Official <a href="http://voucherify.io?utm_source=github&utm_medium=sdk&utm_campaign=acq">Voucherify</a> SDK for .NET Framework</h3>

<p align="center">
    <a href="https://travis-ci.org/voucherifyio/voucherify-dotNET-sdk" rel="nofollow">
        <img src="https://travis-ci.org/voucherifyio/voucherify-dotNET-sdk.svg" alt="Build Status">
    </a>
    <a href="https://www.nuget.org/packages/Voucherify" rel="nofollow">
        <img src="http://img.shields.io/nuget/v/Voucherify.svg" alt="Build Status">
    </a> 
    <a href="https://www.nuget.org/packages/Voucherify.Client" rel="nofollow">
        <img src="http://img.shields.io/nuget/v/Voucherify.Client.svg" alt="Build Status">
    </a>
</p>



<hr />

<p align="center">
<b><a href="#frameworks-supported">Frameworks supported</a></b>
|
<b><a href="#dependencies">Dependencies</a></b>
|
<b><a href="#setup">Setup</a></b>
|
<b><a href="#callback-or-async">Callback or Async?</a></b>
|
<b><a href="#unity">Unity</a></b>
|
<b><a href="#xamarin">Xamarin</a></b>
|
<b><a href="#contributing">Contributing</a></b>
|
<b><a href="#changelog">Changelog</a></b>
</p>




<p align="center">
API:
<a href="#vouchers-api">Vouchers</a>
|
<a href="#campaigns-api">Campaigns</a>
|
<a href="#distributions-api">Distributions</a>
|
<a href="#validations-api">Validations</a>
|
<a href="#redemptions-api">Redemptions</a>
|
<a href="#customers-api">Customers</a>
|
<a href="#products-api">Products</a>
|
<a href="#events-api">Products</a>
|
<a href="#orders-api">Products</a>
|
<a href="#promotions-api">Promotions</a>
|
<a href="#segments-api">Segments</a>
|
<a href="#validation-rules-api">Validation Rules</a>
</p>

---

## Build

### Prerequisites MacOS

- Visual Studio
- `nuget install xunit.runner.console -Version 2.2.0 -OutputDirectory testrunner`

### Tests

```
nuget restore ./src/Tests/Voucherify.Tests.csproj
msbuild /p:"Configuration=Release" ./src/Tests/Voucherify.Tests.csproj
mono ./testrunner/xunit.runner.console.2.2.0/tools/xunit.console.exe ./src/Tests/bin/Release/netcoreapp2.0/Voucherify.Tests.dll
```

### Server

```
nuget restore ./src/Voucherify/Voucherify.csproj
msbuild /p:"Configuration=Release" ./src/Voucherify/Voucherify.csproj
nuget pack ./src/Voucherify/Voucherify.nuspec
```

### Client

```
nuget restore ./src/Voucherify/Voucherify.Client.csproj
msbuild /p:"Configuration=Release" ./src/Voucherify/Voucherify.Client.csproj
nuget pack ./src/Voucherify/Voucherify.Client.nuspec
```

### Running Examples

```
msbuild /p:"Configuration=Release" ./src/Examples/Examples.Voucherify.net45/Examples.Voucherify.net45.csproj
mono ./src/Examples/Examples.Voucherify.net45/bin/Release/Examples.Voucherify.net45.exe <api_key> <api_token>
```

## Frameworks supported
* .NET 2.0 (Server, Client)
* .NET 3.5 (Server, Client)
* .NET 4.0 (Server, Client)
* .NET 4.5 (Server, Client)
* .NET Standard 2.0 (Client, Server) - for Unity, Xamarin, etc.


## TLS support

Due to security resons old versions of TLS (1.0 and 1.1) will be deprecated soon and our api will not accept any calls using those layers. Thus, we decided to switch .NET SDK to use TLS 1.2 already. The following articles will help you setup your environemnt:

* .NET Framework 2.0: [Support for TLS System Default Versions included in the .NET Framework 2.0 SP2](https://support.microsoft.com/en-us/help/3154517/support-for-tls-system-default-versions-included-in-the-net-framework)
* .NET Framework 3.5: [Support for TLS System Default Versions included in the .NET Framework 3.5.1](https://support.microsoft.com/en-us/help/3154518/support-for-tls-system-default-versions-included-in-the-net-framework)

## Dependencies
* [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)  - 9.0.1 or later


The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/ndocs/guides/install-nuget) to obtain the latest version of the packages:

```
Install-Package Newtonsoft.Json
```

## Setup

### Server Side Library

`Install-Package Voucherify`

Or simple use libraries from `lib/{target-framework}` folder:

* `Voucherify.dll` - Server Side Library

[Log-in](http://app.voucherify.io/?utm_source=github&utm_medium=sdk&utm_campaign=acq#/login) to Voucherify web interface and obtain your Server Side Keys from [Configuration](https://app.voucherify.io/?utm_source=github&utm_medium=sdk&utm_campaign=acq#/app/configuration):

```csharp
var api = new Voucherify.Api(
            "<app_id>",
            "<token>")            
            .WithSSL();
```

You can also specify the API verison if needed:

```csharp
var api = new Voucherify.Api(
            "<app_id>",
            "<token>")            
            .WithSSL()
            .WithVersion(Voucherify.Core.ApiVerions.v2017_04_20);
```

### Client Side Library

`Install-Package Voucherify.Client`

Or simple use libraries from `lib/{target-framework}` folder:

* `Voucherify.Client.dll` - Client Side Library

[Log-in](http://app.voucherify.io/?utm_source=github&utm_medium=sdk&utm_campaign=acq#/login) to Voucherify web interface and obtain your Client Side Keys from [Configuration](https://app.voucherify.io/?utm_source=github&utm_medium=sdk&utm_campaign=acq#/app/configuration):

```csharp
var api = new Voucherify.Client.Api(
    "<client_app_id>",
    "<client_token>",
    "<origin>")
    .WithSSL();
```

## Callback or Async?

### Callbacks Usage (.NET 2.0 - .NET 4.0)

```csharp
api.Vouchers.Get("<your-voucher-code>", (response) =>
            {
                if (response.Exception != null)
                {
                    Console.WriteLine("Exception: {0}", response.Exception);
                }
                else
                {
                    Console.WriteLine("Voucher: {0}", response.Result);
                }
            });
```

### Async Usage (.NET 4.5, .NET Standard 2.0)

```csharp
        try
        {
            Voucher newVoucher = new Voucher()
            {
                Discount = Discount.WithAmountOff(10),
                Type = VoucherType.DiscountVoucher
            };

            Voucher voucher = await api.Vouchers.CreateVoucher(newVoucher);
            Console.WriteLine("Voucher: {0}", voucher);
        }
        catch (VoucherifyClientException exception)
        {
            Console.WriteLine("Exception: {0}", exception);
        }
```

## API

This SDK is fully consistent with restufl API Voucherify provides.
Detalied description and example responses  you will find at [official docs](https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq).
Method headers point to more detalied params description you can use.

### Vouchers API
Methods are provided within `Api.Vouchers.*` namespace.
- [Create Voucher](#create-voucher)
- [Get Voucher](#get-voucher)
- [Update Voucher](#update-voucher)
- [Delete Voucher](#delete-voucher)
- [List Vouchers](#list-vouchers)
- [Enable Voucher](#enable-voucher)
- [Disable Voucher](#disable-voucher)
- [Import Vouchers](#import-vouchers)
- [Add Gift Balance](#add-gift-balance)

#### [Create Voucher]
```csharp
public async Task<DataModel.Voucher> Create(DataModel.Contexts.VoucherCreate voucher)
public async Task<DataModel.Voucher> Create(string code, DataModel.Contexts.VoucherCreate voucher)

public void Create(DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
public void Create(string code, DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
```

Check [voucher object](https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#the-voucher-object).

#### [Get Voucher]
```csharp
public async Task<DataModel.Voucher> Get(string code)

public void Get(string code, Action<ApiResponse<DataModel.Voucher>> callback)
```
#### [Update Voucher]
```csharp
public async Task<DataModel.Voucher> Update(string code, DataModel.Contexts.VoucherUpdate voucher)

public void Update(string code, DataModel.Contexts.VoucherUpdate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
```
#### [Delete Voucher]
```csharp
public async Task Delete(string code)
public async Task Delete(string code, Core.DataModel.ForcedOperation query query)

public void Delete(string code, Action<ApiResponse> callback)
public void Delete(string code, Core.DataModel.ForcedOperation query query, Action<ApiResponse> callback)
```
#### [List Vouchers]
```csharp
public async Task<IList<DataModel.Voucher>> List(DataModel.Queries.VouchersFilter filter)

public void List(DataModel.Queries.VouchersFilter filter, Action<ApiResponse<IList<DataModel.Voucher>>> callback)
```
#### [Enable Voucher]
```csharp
public async Task<DataModel.Voucher> Enable(string code)

public void Enable(string code, Action<ApiResponse<DataModel.Voucher>> callback)
```
#### [Disable Voucher]
```csharp
public async Task<DataModel.Voucher> Disable(string code)

public void Disable(string code, Action<ApiResponse<DataModel.Voucher>> callback)
```
#### [Import Vouchers]
```csharp
public async Task<Core.DataModel.Empty> Import(List<DataModel.Contexts.VoucherImport> vouchers)

public void Import(List<DataModel.Contexts.VoucherImport> vouchers, Action<ApiResponse<Core.DataModel.Empty>> callback)
```
#### [Add Gift Balance]
```csharp
public async Task<DataModel.Balance> AddGiftBalance(string code, DataModel.Contexts.VoucherAddGiftBalance balance)
        
public void AddGiftBalance(string code, DataModel.Contexts.VoucherAddGiftBalance balance, Action<ApiResponse<DataModel.Balance>> callback)
```

---

### Campaigns API
Methods are provided within `Api.Campaigns.*` namespace.
- [Create Campaign](#create-campaign)
- [Get Campaign](#get-campaign)
- [Update Campaign](#update-campaign)
- [Delete Campaign](#delete-campaign)
- [List Campaigns](#list-campaigns)
- [Add Voucher to Campaign](#add-voucher-to-campaign)
- [Import Vouchers to Campaign](#import-vouchers-to-campaign)

#### [Create Campaign]
```csharp
public async Task<DataModel.Campaign> Create(DataModel.Contexts.CampaignCreate campaign)

public void Create(DataModel.Contexts.CampaignCreate campaign, Action<ApiResponse<DataModel.Campaign>> callback)
```
#### [Get Campaign]
```csharp
public async Task<DataModel.Campaign> Get(string name)

public void Get(string name, Action<ApiResponse<DataModel.Campaign>> callback)
```
#### [Update Campaign]
```csharp
public async Task<DataModel.Campaign> Update(string name, DataModel.Contexts.CampaignUpdate campaign)

public void Update(string name, DataModel.Contexts.CampaignUpdate campaign, Action<ApiResponse<DataModel.Campaign>> callback)
```
#### [Delete Campaigns]
```csharp
public async Task Delete(string name)
public async Task Delete(string name, Core.DataModel.ForcedOperation query query)
        
public void Delete(string name, Action<ApiResponse> callback)
public void Delete(string name, Core.DataModel.ForcedOperation query query, Action<ApiResponse> callback)
```
#### [List Campaigns]
```csharp
public async Task<DataModel.CampaignList> List(DataModel.Queries.CampaignFilter filter)
 
public void List(DataModel.Queries.CampaignFilter filter, Action<ApiResponse<DataModel.CampaignList>> callback)    
```
#### [Add Voucher to Campaign]
```csharp
public async Task<DataModel.Voucher> AddVoucher(string name, DataModel.Contexts.CampaignAddVoucher addVoucherContext)

public void AddVoucher(string name, DataModel.Contexts.CampaignAddVoucher addVoucherContext, Action<ApiResponse<DataModel.Voucher>> callback)
```
#### [Import Vouchers to Campaign]
```csharp
public async Task<Core.DataModel.Empty> ImportVouchers(string name, List<DataModel.Contexts.CampaignVoucherImport> addVoucherContext)

public void ImportVouchers(string name, List<DataModel.Contexts.CampaignVoucherImport> addVoucherContext, Action<ApiResponse<Core.DataModel.Empty>> callback)
```

---

### Distributions API
Methods are provided within `Api.Distributions.*` namespace.

#### [Publish Voucher]
```csharp
public async Task<DataModel.PublicationSingle> Publish(DataModel.Contexts.VoucherPublishSingle context)

public void Publish(DataModel.Contexts.VoucherPublishSingle context, Action<ApiResponse<DataModel.PublicatioSingle>> callback)
```

#### [Create Publication]
```csharp
public async Task<DataModel.Publication> CreatePublication(DataModel.Contexts.VoucherPublish context)

public void CreatePublication(DataModel.Contexts.VoucherPublish context, Action<ApiResponse<DataModel.Publication>> callback)
```

---

### Validations API
Methods are provided within `Api.Validations.*` namespace.

- [Validate Voucher](#validate-voucher)
- [Validate Promotion](#validate-promotion)
- [Validate](#validate)

#### [Validate Voucher]
```csharp
public async Task<DataModel.Validation> ValidateVoucher(string code, DataModel.Contexts.Validation context)

public void ValidateVoucher(string code, DataModel.Contexts.Validation context, Action<ApiResponse<DataModel.Validation>> callback)
```

#### [Validate Promotions]
```csharp
public async Task<DataModel.Validation> ValidatePromotion(DataModel.Contexts.Validation context)

public void ValidatePromotion(DataModel.Contexts.Validation context, Action<ApiResponse<DataModel.Validation>> callback)
```

#### [Validate]
```csharp
public async Task<DataModel.Validation> Validate(string code, DataModel.Contexts.Validation context)

public void Validate(string code, DataModel.Contexts.Validation context, Action<ApiResponse<DataModel.Validation>> callback)
```

---

### Redemptions API
Methods are provided within `Api.Redemptions.*` namespace.

- [Redeem Voucher](#redeem-voucher)
- [Redeem Promotion](#redeem-promotion)
- [Redeem](#redeem)
- [Get Redemption](#get-redemption)
- [List Redemptions](#list-redemptions)
- [Get Voucher's Redemptions](#get-vouchers-redemptions)
- [Rollback Redemption](#rollback-redemption)

#### [Redeem Voucher]
```csharp
public async Task<DataModel.Redemption> RedeemVoucher(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context)
        
public void RedeemVoucher(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context, Action<ApiResponse<DataModel.Redemption>> callback)        
```
#### [Redeem Promotion]
```csharp
public async Task<DataModel.Redemption> RedeemPromotion(string promotionId, DataModel.Contexts.RedemptionRedeem context)

public void RedeemPromotion(string promotionId, DataModel.Contexts.RedemptionRedeem context, Action<ApiResponse<DataModel.Redemption>> callback)        
```
#### [Redeem]
```csharp
public async Task<DataModel.Redemption> Redeem(string code, DataModel.Contexts.RedemptionRedeem context)

public void Redeem(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context, Action<ApiResponse<DataModel.Results.RedemptionRedeem>> callback)
```
#### [Get Redemption]
```csharp
public async Task<DataModel.Redemption> Get(string redemptionId)

public void Get(string redemptionId, Action<ApiResponse<DataModel.Redemption>> callback)
```
#### [List Redemptions]
```csharp
public async Task<DataModel.RedemptionList> List(DataModel.Queries.RedemptionsFilter filter)

public void List(DataModel.Queries.RedemptionsFilter filter, Action<ApiResponse<DataModel.RedemptionList>> callback)
```
#### [Get Voucher's Redemptions]
```csharp
public async Task<DataModel.VoucherRedemption> GetForVoucher(string code)

public void GetForVoucher(string code, Action<ApiResponse<DataModel.VoucherRedemption>> callback)
```
#### [Rollback Redemption]
```csharp
public async Task<DataModel.Results.RedemptionRollback> Rollback(string redemptionId, DataModel.Queries.RedemptionRollback query, DataModel.Contexts.RedemptionRollback context)

public void Rollback(string redemptionId, DataModel.Queries.RedemptionRollback query, DataModel.Contexts.RedemptionRollback context, Action<ApiResponse<DataModel.Results.RedemptionRollback>> callback)
```
Check [redemption rollback object](https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#the-redemption-rollback-object).

---

### Customers API
Methods are provided within `Api.Customers.*` namespace.

- [Create Customer](#create-customer)
- [Get Customer](#get-customer)
- [Update Customer](#update-customer)
- [Delete Customer](#delete-customer)
- [List Customers](#list-customers)

#### [Create Customer]
```csharp
public async Task<DataModel.Customer> Create(DataModel.Contexts.CustomerCreate customer)

public void Create(DataModel.Contexts.CustomerCreate customer, Action<ApiResponse<DataModel.Customer>> callback)
```
Check [customer object](https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#the-customer-object).
#### [Get Customer]
```csharp
public async Task<DataModel.Customer> Get(string customerId)

public void Get(string customerId, Action<ApiResponse<DataModel.Customer>> callback)
```
#### [Update Customer]
```csharp
public async Task<DataModel.Customer> Update(string customerId, DataModel.Contexts.CustomerUpdate customer)

public void Update(string customerId, DataModel.Contexts.CustomerUpdate customer, Action<ApiResponse<DataModel.Customer>> callback)
```
#### [Delete Customer]
```csharp
public async Task Delete(string customerId)

public void Delete(string customerId, Action<ApiResponse> callback)
```

#### [List Customers]
```csharp
public async Task<DataModel.CustomerList> List(DataModel.Queries.CustomerFilter filter)

public void List(DataModel.Queries.CustomerFilter filter, Action<ApiResponse<DataModel.CustomerList>> callback)
```

---

### Products API
Methods are provided within `Api.Products.*` namespace.

- [Create Product](#create-product)
- [Get Product](#get-product)
- [Update Product](#update-product)
- [Delete Product](#delete-product)
- [List Products](#list-products)
- [Create SKU](#create-sku)
- [Get SKU](#get-sku)
- [Update SKU](#update-sku)
- [Delete SKU](#delete-sku)
- [List all product SKUs](#list-all-product-skus)

#### [Create Product]
```csharp
public async Task<DataModel.Product> Create(DataModel.Contexts.ProductCreate product)

public void Create(DataModel.Contexts.ProductCreate product, Action<ApiResponse<DataModel.Product>> callback)
```
Check [product object](https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#the-product-object).
#### [Get Product]
```csharp
public async Task<DataModel.Product> Get(string productId)

public void Get(string productId, Action<ApiResponse<DataModel.Product>> callback)
```
#### [Update Product]
```csharp
public async Task<DataModel.Product> Update(string productId, DataModel.Contexts.ProductUpdate product)

public void Update(string productId, DataModel.Contexts.ProductUpdate product, Action<ApiResponse<DataModel.Product>> callback)
```
#### [Delete Product]
```csharp
public async Task Delete(string productId)
public async Task Delete(string productId, Core.DataModel.ForcedOperation query)

public void Delete(string productId, Action<ApiResponse> callback)
public void Delete(string productId, Core.DataModel.ForcedOperation query, Action<ApiResponse> callback)
```
#### [List Products]
```csharp
public async Task<DataModel.ProductList> List()

public void List(Action<ApiResponse<DataModel.ProductList>> callback)
```
#### [Create SKU]
```csharp
public async Task<DataModel.Sku> CreateSku(string productId, DataModel.Contexts.SkuCreate sku)

public void CreateSku(string productId, DataModel.Contexts.SkuCreate sku, Action<ApiResponse<DataModel.Sku>> callback)
```
Check [SKU object](https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#the-sku-object).
#### [Get SKU]
```csharp
public async Task<DataModel.Sku> GetSku(string productId, string skuId)

public void GetSku(string productId, string skuId, Action<ApiResponse<DataModel.Sku>> callback)
```
#### [Update SKU]
```csharp
public async Task<DataModel.Sku> UpdateSku(string productId, string skuId, DataModel.Contexts.SkuUpdate sku)

public void UpdateSku(string productId, string skuId, DataModel.Contexts.SkuUpdate sku, Action<ApiResponse<DataModel.Sku>> callback)
```
#### [Delete SKU]
```csharp
public async Task DeleteSku(string productId, string skuId)
public async Task DeleteSku(string productId, string skuId, Core.DataModel.ForcedOperation query)

public void DeleteSku(string productId, string skuId, Action<ApiResponse> callback)
public void DeleteSku(string productId, string skuId, Core.DataModel.ForcedOperation query, Action<ApiResponse> callback)
```
#### [List all product SKUs]
```csharp
public async Task<DataModel.ProductSkus> ListSkus(string productId)

public void ListSkus(string productId, Action<ApiResponse<DataModel.ProductSkus>> callback)
```

---

### Events API
Methods are provided within `Api.Events.*` namespace.

- [Create event](#create-event)

#### [Create Event]
```csharp
public async Task<DataModel.Event> Create(DataModel.Contexts.EventCreate eventObject)

public void Create(DataModel.Contexts.EventCreate eventObject, Action<ApiResponse<DataModel.Event>> callback)
```

---

### Orders API
Methods are provided within `Api.Orders.*` namespace.

- [Create order](#create-order)
- [Get order](#get-order)
- [Update order](update-order)
- [List orders](#list-orders)

#### [Create Order]
```csharp
public async Task<DataModel.Order> Create(DataModel.Contexts.OrderCreate order)

public void Create(DataModel.Contexts.OrderCreate order, Action<ApiResponse<DataModel.Order>> callback)
```
#### [Get Order]
```csharp
public async Task<DataModel.Order> Get(string orderId)

public void Get(string orderId, Action<ApiResponse<DataModel.Order>> callback)
```
#### [Update Order]
```csharp
public async Task<DataModel.Order> Update(string orderId, DataModel.Contexts.OrderUpdate order)

public void Update(string orderId, DataModel.Contexts.OrderUpdate order, Action<ApiResponse<DataModel.Order>> callback)
```
#### [List Orders]
```csharp
public async Task<DataModel.OrderList> List(DataModel.Queries.OrderFilter filter)

public void List(DataModel.Queries.OrderFilter filter, Action<ApiResponse<DataModel.OrderList>> callback)
```

---

### Promotions API
Methods are provided within `Api.Promotions.*` namespace.

- [Get Promotion Tier](#get-promotion-tier)
- [List For Campaign](#list-promotion-tiers-for-campaign)
- [Create Campaing](#create-promotion-campaign)
- [Add Tier To Campaign](#add-promotion-tier-to-campaign)
- [Update Promotion Tier](#update-promotion-tier)
- [Delete Promotion Tier](#delete-promotion-tier)

#### [Get Promotion Tier]
```csharp
 public async Task<DataModel.PromotionTier> Get(string promotionTierId)

public void Get(string promotionTierId, Action<ApiResponse<DataModel.PromotionTier>> callback)
```
#### [List For Campaign]
```csharp
public async Task<DataModel.PromotionTierList> ListForCampaign(string campaign)

public void ListForCampaign(string campaign, Action<ApiResponse<DataModel.PromotionTierList>> callback)
```
#### [Create Campaing]
```csharp
public async Task<DataModel.Campaign> CreateCampaign(DataModel.Contexts.CampaignPromotionCreate promotionCampaign)

public void CreateCampaign(DataModel.Contexts.CampaignPromotionCreate promotionCampaign, Action<ApiResponse<DataModel.Campaign>> callback)
```
#### [Add Tier To Campaign]
```csharp
public async Task<DataModel.PromotionTier> AddTierToCampaign(string campaignId, DataModel.Contexts.PromotionTierCreate promotionTier)

public void AddTierToCampaign(string campaignId, DataModel.Contexts.PromotionTierCreate promotionTier, Action<ApiResponse<DataModel.PromotionTier>> callback)
```
#### [Update Promotion Tier]
```csharp
public async Task<DataModel.PromotionTier> Update(string promotionTierId, DataModel.Contexts.PromotionTierUpdate promotionTier)

public void Update(string promotionTierId, DataModel.Contexts.PromotionTierUpdate promotionTier, Action<ApiResponse<DataModel.PromotionTier>> callback)
```
#### [Delete Promotion Tier]
```csharp
public async Task Delete(string promotionTierId)

public void Delete(string promotionTierId, Action<ApiResponse> callback)
```

---

### Segments API
Methods are provided within `Api.Segments.*` namespace.

- [Get Segment](#get-segment)
- [Create Segment](#create-segment)
- [Delete Segment](#delete-segment)

#### [Get Segment]
```csharp
public async Task<DataModel.Segment> Get(string segmentId)

public void Get(string segmentId, Action<ApiResponse<DataModel.Segment>> callback)
```
#### [Create Segment]
```csharp
 public async Task<DataModel.Segment> Create(DataModel.Contexts.SegmentCreate voucher)

public void Create(DataModel.Contexts.SegmentCreate voucher, Action<ApiResponse<DataModel.Segment>> callback)
```
#### [Delete Segment]
```csharp
public async Task Delete(string segmentId)

public void Delete(string segmentId, Action<ApiResponse> callback)
```

---

### Validation Rules API
Methods are provided within `Api.ValidationRules.*` namespace.

- [Create Validation Rule](#create-validation-rule)
- [Get Validation Rule](#get-validation-rule)
- [Update Validation Rule](#update-validation-rule)
- [Delete Validation Rule](#delete-validation-rule)
- [Create Validation Rule Assignment](#create-validation-rule-assignment)
- [Delete Validation Rule Assignment]](#delete-validation-rule-assignment)
- [List Validation Rules](#list-validation-rules)
- [List Validation Rule Assignments]](#list-validation-rule-assignments)

#### [Create Validation Rule]
```csharp
public async Task<DataModel.BusinessValidationRule> Create(DataModel.Contexts.BusinessValidationRuleCreate validationRule)

public void Create(DataModel.Contexts.BusinessValidationRuleCreate validationRule, Action<ApiResponse<DataModel.BusinessValidationRule>> callback)
```

#### [Get Validation Rule]
```csharp
public async Task<DataModel.BusinessValidationRule> Get(string validationRuleId)

public void Get(string validationRuleId, Action<ApiResponse<DataModel.BusinessValidationRule>> callback)
```

#### [Update Validation Rule]
```csharp
public async Task<DataModel.BusinessValidationRule> Update(string validationRuleId, DataModel.Contexts.BusinessValidationRuleUpdate validationRule)

public void Update(string validationRuleId, DataModel.Contexts.BusinessValidationRuleUpdate validationRule, Action<ApiResponse<DataModel.BusinessValidationRule>> callback)
```

#### [Delete Validation Rule]
```csharp
public async Task Delete(string validationRuleId)

public void Delete(string validationRuleId, Action<ApiResponse> callback)
```

#### [Create Validation Rule Assignment]
```csharp
public async Task<DataModel.BusinessValidationRuleAssignment> CreateAssignment(string validationRuleId, DataModel.Contexts.BusinessValidationRuleAssignmentCreate validationRule)

public void CreateAssignment(string validationRuleId, DataModel.Contexts.BusinessValidationRuleAssignmentCreate validationRule, Action<ApiResponse<DataModel.BusinessValidationRuleAssignment>> callback)
```

#### [Delete Validation Rule Assignment]
```csharp
public async Task DeleteAssignment(string validationRuleId, string assignmentId)

public void DeleteAssignment(string validationRuleId, string assignmentId, Action<ApiResponse> callback)
```

#### [List Validation Rules]
```csharp
public async Task<DataModel.BusinessValidationRuleList> List(DataModel.Queries.BusinessValidationRuleFilter filter)

public void List(DataModel.Queries.BusinessValidationRuleFilter filter, Action<ApiResponse<DataModel.BusinessValidationRuleList>> callback)
```

#### [List Validation Rule Assignments]
```csharp
public async Task<DataModel.BusinessValidationRuleAssignmentList> ListAssignments(string validationRuleId, DataModel.Queries.BusinessValidationRuleAssignmentFilter filter)

public void ListAssignments(string validationRuleId, DataModel.Queries.BusinessValidationRuleAssignmentFilter filter, Action<ApiResponse<DataModel.BusinessValidationRuleAssignmentList>> callback)
```

---

## Contributing

Bug reports and pull requests are welcome through [GitHub Issues](https://github.com/voucherifyio/voucherify-dotNET-sdk/issues).

## Changelog

- **2019-06-10** - `6.4.3` - Added `Assignments` property at Voucher and Campaign level
- **2019-05-09** - `6.4.2` - Change `Address` properties accessors from private to public
- **2019-02-06** - `6.4.1` - Added `amount` in Redemption  and `discount_amount` in Order
- **2019-02-03** - `6.4.0` - Replaced ApplicableProductList and ApplicableProduct. Added listing Promotion Tiers method.
- **2019-01-29** - `6.3.0` - Reorganized Delete methods with force option for: Voucher, Campaign, Product and Sku 
- **2019-01-28** - `6.2.0` - Added ApplicableTo property to Validation class
- **2019-01-25** - `6.1.0` - Extended OrderItem OrderItemProduct OrderItemSKU. Improved QuerySerializer
- **2018-12-27** - `6.0.1` - Added CreatedAt and UpdatedAt property to VoucherFilter
- **2018-12-20** - `6.0.0` - Replaced Voucher Validation Rules with Business Validation Rules. Added API Verions v2018-08-01.

-------------------------------

- **2018-11-15** - `5.0.1` - Fixed QuerySerializer for Array objects. Added RelatedObject to OrderItem and dedicated method for setting SourceId.
- **2018-11-09** - `5.0.0` - Introduced support for TLS 1.2. Added missing CreatePublication endpoint in Distributions namespace. Added Support for .Net Standard 2.0 and dropped for Unity and PLC as Standard version should be used instead. Moved solution to VS2017 and use new type of projects.

-------------------------------

- **2018-08-01** - `4.3.2` - Added Price to Product
- **2018-02-05** - `4.3.1` - Fixed Segments API endpoints. Fixed Library versioning.
- **2018-02-04** - `4.3.0` - Added support for Api Versions. Added support for Orders, Events, Promotions, Segments and Validation Rules.
- **2017-11-22** - `4.2.0` - Added 'ApplicableTo' property to Voucher.
- **2017-10-24** - `4.1.2` - Added 'key' property to VoucherifyClientException. Removed private setters for Order and Customer entities.
- **2017-08-30** - `4.1.1` - Added .ConfigureAwait(false) to all awaitable calls to prevent deadlocks when using the ASP.NET.
- **2016-12-19** - `4.1.0` - Added missing methods. Created two additional namespaces: Validations and Distributions. Support for gift.balance (for Gift Vouchers).
- **2016-11-17** - `4.0.2` - Fixed issue with InnerException serialization
- **2016-11-17** - `4.0.1` - Remove dependencies for Portable library to allow use it in Xamarin Applications.
- **2016-11-16** - `4.0.0` - Define separated libraries: Voucherify (server side methods) and Voucherify.Client (client side methods). Define Voucherify.Core. Define Voucherify.DataModel. Client Supported Apis: Vouchers, Redemptions. Server Supported Apis: Vouchers, Redemptions, Campaigns, Customers, Products.

-------------------------------

- **2016-11-02** - `3.1.0` - Added Validate method for Vouchers. Fixed issue with DiscountType mapping.
- **2016-09-13** - `3.0.0` - Removed dependencies to RSP.Promise and RestSharp, stick to base libraries only.

-------------------------------

- **2016-09-06** - `2.2.0` - Added Portable Class Library (portable45-net45+win8+wp8+wpa81). Added Order Items. Improved Error Handling.
- **2016-08-17** - `2.1.0` - Fixed Request Header for .Net 3.5+ and empty metadata issue.
- **2016-07-21** - `2.0.0` - Fixed Data Conversion Problems. Added Update method for Vouchers, Added Code Pattern for Voucher creation.

-------------------------------

- **2016-07-11** - `1.1.3` - Fixed DLLs
- **2016-07-11** - `1.1.2` - Fixed package dependencies for .Net Framework 3.5+.
- **2016-07-11** - `1.1.1` - Fixed package dependencies.
- **2016-07-11** - `1.1.0` - Added support for .Net Framework 2.0 with classic callback approach. Get rid of DataContract attribute.

-------------------------------

- **2016-07-03** - `1.0.0` - Replace async/await with RSG.Promise library. Use RestSharp instead of HttpClient.
- **2016-07-03** - `0.2.0` - Introduced support for .Net Framework 3.5.
- **2016-06-26** - `0.1.0` - Initial version of SDK that supports Vouchers, Redemption and Customer endpoints.
- **2016-07-11** - `1.1.1` - Fixed package dependencies.
- **2016-07-11** - `1.1.0` - Added support for .Net Framework 2.0 with classic callback approach. Get rid of DataContract attribute.
- **2016-07-03** - `1.0.0` - Replace async/await with RSG.Promise library. Use RestSharp instead of HttpClient.
- **2016-07-03** - `0.2.0` - Introduced support for .Net Framework 3.5.
- **2016-06-26** - `0.1.0` - Initial version of SDK that supports Vouchers, Redemption and Customer endpoints.

[Create Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#create-voucher
[Get Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#vouchers-get
[Update Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#update-voucher
[Delete Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#delete-voucher
[List Vouchers]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#list-vouchers
[Enable Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#enable-voucher
[Disable Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#disable-voucher
[Import Vouchers]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#import-vouchers-1

[Create Campaign]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#create-campaign
[Get Campaign]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#get-campaign
[Add Voucher to Campaign]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#add-voucher-to-campaign
[Import Vouchers to Campaign]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#import-vouchers

[Publish Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#publish-voucher
[Create Publication]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#create-publication

[Validate Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#validate-voucher

[Redeem Voucher]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#redeem-voucher
[List Redemptions]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#list-redemptions
[Get Voucher's Redemptions]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#vouchers-redemptions
[Rollback Redemption]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#rollback-redemption

[Create Customer]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#create-customer
[Get Customer]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#read-customer
[Update Customer]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#update-customer
[Delete Customer]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#delete-customer

[Create Product]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#create-product
[Get Product]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#get-product
[Update Product]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#update-product
[Delete Product]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#delete-product
[List Products]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#list-products
[Create SKU]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#create-sku
[Get SKU]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#get-sku
[Update SKU]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#update-sku
[Delete SKU]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#delete-sku
[List all product SKUs]: https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#list-skus