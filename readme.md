<h3 align="center">Official <a href="http://voucherify.io?utm_source=github&utm_medium=sdk&utm_campaign=acq">Voucherify</a> SDK for .NET Framework</h3>
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
</p>

---

## Frameworks supported
* .NET 2.0 (Server, Client)
* .NET 3.5 (Server, Client)
* .NET 3.5 Unity (Client)
* .NET 4.0 (Server, Client)
* .NET 4.5 (Server, Client)
* PCL (portable45-net45+win8+wp8+wpa81) (Server, Client)

## Dependencies
* [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)  - 9.0.1 or later


The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/ndocs/guides/install-nuget) to obtain the latest version of the packages:

```
Install-Package Newtonsoft.Json
```

### PCL (portable45-net45+win8+wp8+wpa81) (Server, Client)

There could be a need to install additional packages in case the assemblies are not available in your framework. Those references has been removed from original package to support using Voucherify directly in Xamarin.Droid and Xamarin.iOS environments where both: `HttpClient` and `async/await` operations are supported without additional libraries.

```
Install-Package Microsoft.Net.Http
Install-Package Microsoft.Bcl
Install-Package Microsoft.Bcl.Build
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

### Async Usage (.NET 4.5 standard + PCL (portable-net45+netcore45+wpa81+wp8))

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

## Unity

[Unity README](/readme-Unity.md)

## Xamarin

[Xamarin README](/readme-Xamarin.md)

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

#### [Create Voucher]
```csharp
public async Task<DataModel.Voucher> Create(DataModel.Contexts.VoucherCreate voucher)
public async Task<DataModel.Voucher> Create(string code, DataModel.Contexts.VoucherCreate voucher)

public void Create(DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
public void Create(string code, DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
```

Check [voucher oject](https://docs.voucherify.io/reference?utm_source=github&utm_medium=sdk&utm_campaign=acq#the-voucher-object).

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
public async Task Delete(string code, DataModel.Queries.VoucherDelete query)

public void Delete(string code, DataModel.Queries.VoucherDelete query, Action<ApiResponse> callback)
```
#### [List Vouchers]
```csharp
public async Task<IList<DataModel.Voucher>> List(DataModel.Queries.VouchersFilter filter)

public void List(DataModel.Queries.VouchersFilter filter, Action<ApiResponse<IList<DataModel.Voucher>>> callback)
```
#### [Enable Voucher]
```csharp
public async Task Enable(string code)

public void Enable(string code, Action<ApiResponse> callback)
```
#### [Disable Voucher]
```csharp
public async Task Disable(string code)

public void Disable(string code, Action<ApiResponse> callback)
```
#### [Import Vouchers]
```csharp
public async Task<Core.DataModel.Empty> Import(List<DataModel.Contexts.VoucherImport> vouchers)

public void Import(List<DataModel.Contexts.VoucherImport> vouchers, Action<ApiResponse<Core.DataModel.Empty>> callback)
```

---

### Campaigns API
Methods are provided within `Api.Campaigns.*` namespace.
- [Create Campaign](#create-campaign)
- [Get Campaign](#get-campaign)
- [Add Voucher to Campaign](#add-voucher-to-campaign)
- [Import Vouchers to Campaign](#import-vouchers-to-campaign)

#### [Create Campaign]
```csharp
public async Task<DataModel.Campaign> Create(DataModel.Contexts.CampaignCreate campaign)

public void Create(DataModel.Contexts.CampaignCreate campaign, Action<ApiResponse<DataModel.Campaign>> callback)
```
#### [Get Campaign]
```csharp
// TODO
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
public async Task Publish(DataModel.Queries.VoucherPublish query, DataModel.Contexts.VoucherPublish context)

public void Publish(DataModel.Queries.VoucherPublish query, DataModel.Contexts.VoucherPublish context, Action<ApiResponse<Core.DataModel.Empty>> callback)
```

---

### Validations API
Methods are provided within `Api.Validations.*` namespace.

#### [Validate Voucher]
```csharp
public async Task<DataModel.Results.VoucherValidation> ValidateVoucher(string code, DataModel.Contexts.VoucherValidation context)

public void ValidateVoucher(string code, DataModel.Contexts.VoucherValidation context, Action<ApiResponse<DataModel.Results.VoucherValidation>> callback)
```

---

### Redemptions API
Methods are provided within `Api.Redemptions.*` namespace.

- [Redeem Voucher](#redeem-voucher)
- [List Redemptions](#list-redemptions)
- [Get Voucher's Redemptions](#get-vouchers-redemptions)
- [Rollback Redemption](#rollback-redemption)

#### [Redeem Voucher]
```csharp
public async Task<DataModel.Results.RedemptionRedeem> Redeem(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context)

public void Redeem(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context, Action<ApiResponse<DataModel.Results.RedemptionRedeem>> callback)
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

public void Delete(string productId, Action<ApiResponse> callback)
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

public void DeleteSku(string productId, string skuId, Action<ApiResponse> callback)
```
#### [List all product SKUs]
```csharp
public async Task<DataModel.ProductSkus> ListSkus(string productId)

public void ListSkus(string productId, Action<ApiResponse<DataModel.ProductSkus>> callback)
```

---

## Contributing

Bug reports and pull requests are welcome through [GitHub Issues](https://github.com/voucherifyio/voucherify-dotNET-sdk/issues).

## Changelog

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