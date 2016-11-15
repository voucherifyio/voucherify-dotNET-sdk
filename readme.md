Voucherify .Net SDK
===

###Version: 4.0.0

[Voucherify](http://voucherify.io?utm_source=github&utm_medium=sdk&utm_campaign=acq) is an API-first platform for software developers who are dissatisfied with high-maintenance custom coupon software. Our product is a coupon infrastructure through API that provides a quicker way to build coupon generation, distribution and tracking. Unlike legacy coupon software we have:

* an API-first SaaS platform that enables customisation of every aspect of coupon campaigns
* a management console that helps cut down maintenance and reporting overhead
* an infrastructure to scale up coupon activity in no time

Here you can find a library that makes it easier to integrate your .Net application (Client and Server) with Voucherify.

Setup
=====

Server Side Library
---

```
Install-Package Voucherify
```

Client Side Library
---

```
Install-Package Voucherify.Client
```

Or simple use libraries from `lib/{target-framework}` folder:

* `Voucherify.dll` - Server Side Library
* `Voucherify.Client.dll` - Client Side Library

Dependencies
---

* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) 
* [Microsoft.Bcl](https://www.nuget.org/packages/Microsoft.Bcl/) for .net45 Portable (portable45-net45+win8+wp8+wpa81)
* [Microsoft.Bcl.Build](https://www.nuget.org/packages/Microsoft.Bcl.Build/) for .net45 Portable (portable45-net45+win8+wp8+wpa81)
* [Microsoft.Net.Http](https://www.nuget.org/packages/Microsoft.Net.Http/) for .net45 Portable (portable45-net45+win8+wp8+wpa81)

.Net Framework Support
===

Server
---

* .Net 2.0
* .Net 3.5 
* .Net 4.0 
* .Net 4.5
* PCL [portable45-net45+win8+wp8+wpa81] 

Client
---

* .Net 2.0
* .Net 3.5 
* .Net 3.5 Unity 
* .Net 4.0 
* .Net 4.5
* PCL [portable45-net45+win8+wp8+wpa81] 

Initilization
===

Server Side:
---

Your server side keys can be found in your `Project Settings`.

```cs
var api = new Voucherify.Api("<your-app-id>", "<your-app-token>").WithSSL();
```

Client Side:
---

Your client side keys can be found in your `Project Settings`, the same as origin.

```cs
var api= new Voucherify.Client.Api("<your-client-app-id>", "<your-client-app-token>", "<origin>").WithSSL();
```

Usage
===

Callbacks Usage (.Net 2.0 - .Net 4.0)
---

```cs

using Voucherify;

...
	api.Vouchers.Get(
		"<your-voucher-code>", 
		(response) => 
		{
			if (response.Exception != null) {
				Console.WriteLine("Exception: {0}", response.Exception);
			} 
			else
			{
				Console.WriteLine("Voucher: {0}", response.Result);
			}
		});
...
```

Async Usage (.Net 4.5 standard + PCL [portable-net45+netcore45+wpa81+wp8])
---

```cs

using Voucherify;
using Voucherify.Core.Exceptions;

...
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
...

```

Unity
---

For Unity projects you would need to use libraries from `lib/.net35-Unity` folder and add link.xml files that prevents from stripping.

```xml
<linker>
  <assembly fullname="Voucherify.Client" preserve="all"/>
  <assembly fullname="Newtonsoft.JSON" preserve="all"/>
</linker>
```

Documentation
===

Documentation will be avaialble later. For futher reference please check source code or check [Voucherify.io API documentation](https://voucherify.readme.io/).

Supported API Methods - Server Side
===

Vouchers
---

- `[DataModel.Voucher] Api.Vouchers.Get([string] code)`
- `[DataModel.Voucher] Api.Vouchers.Create([DataModel.Contexts.VoucherCreate] voucher)`
- `[DataModel.Voucher] Api.Vouchers.Create([string] code, [DataModel.Contexts.VoucherCreate] voucher)`
- `[DataModel.Voucher] Api.Vouchers.Update([string] code, [DataModel.Contexts.VoucherUpdate] voucher)`
- `Api.Vouchers.Delete([string] code, [DataModel.Queries.VoucherDelete] query)`
- `Api.Vouchers.Publish([DataModel.Queries.VoucherPublish] query, [DataModel.Contexts.VoucherPublish] context)`
- `Api.Vouchers.Disable([string] code)`
- `Api.Vouchers.Enable([string] code)`
- `[DataModel.Results.VoucherValidation] Api.Vouchers.Validate([string] code, [DataModel.Contexts.VoucherValidation] context)`
- `[IList<DataModel.Voucher>] Api.Vouchers.List([DataModel.Queries.VouchersFilter] filter)`
- `Api.Vouchers.Import([List<DataModel.Contexts.VoucherImport>] vouchers)`

Redemptions
---

- `[DataModel.RedemptionList] Api.Redemptions.List([DataModel.Queries.RedemptionsFilter] filter)`
- `[DataModel.Results.RedemptionRedeem] Api.Redemptions.Redeem([string] voucherCode, [DataModel.Queries.RedemptionRedeem query], [DataModel.Contexts.RedemptionRedeem] context)`
- `Api.Redemptions.Rollback([string] voucherCode, [DataModel.Queries.RedemptionRollback] query, [DataModel.Contexts.RedemptionRollback] context)`
- `[DataModel.VoucherRedemption] Api.Redemptions.GetForVoucher([string] voucherCode)`

Campaigns
---

- `[DataModel.Campaign] Api.Campaigns.Craete([DataModel.Contexts.CampaignCreate] campaign)`
- `[DataModel.Voucher] Api.Campaigns.AddVoucher([string] name, [ DataModel.Contexts.CampaignAddVoucher] addVoucherContext)`
- `Api.Campaigns.ImportVouchers([string] name, [List<DataModel.Contexts.CampaignVoucherImport>] addVoucherContext)`

Customers
--- 

- `[DataModel.Customer] Api.Customers.Create([DataModel.Contexts.CustomerCreate] customer)`
- `[DataModel.Customer] Api.Customers.Get([string] customerId)`
- `[DataModel.Customer] Api.Customers.Update([string] customerId, [DataModel.Contexts.CustomerUpdate] customer)`
- `Api.Customers.Delete([string] customerId)`

Products
---

- `[DataModel.Product] Api.Products.Create([DataModel.Contexts.ProductCreate] product)`
- `[DataModel.Product] Api.Products.Get([string] productId)`
- `[DataModel.ProductList] Api.Products.List()`
- `Api.Products.Delete([string] productId)`
- `[DataModel.Sku] Api.Products.Create([string] productId, [DataModel.Contexts.SkuCreate] sku)`
- `[DataModel.Sku] Api.Products.GetSku([string] productId, [string] skuId)`
- `[DataModel.Sku] Api.Products.UpdateSku([string] productId, [string] skuId, [DataModel.Contexts.SkuUpdate] sku)`
- `Api.Products.DeleteSku([string] productId, [string] skuId)`
- `[DataModel.ProductSkus] Api.Products.ListSkus([string] productId)`

Supported API Methods - ClientSide
===

Vouchers
---

- `[DataModel.Results.VoucherValidation] Client.Api.Vouchers.Validate([DataModel.Queries.VoucherValidation] query)`

Redemptions
---

- `[DataModel.Results.RedemptionRedeem] Client.Api.Redemptions.Redeem([DataModel.Queries.RedemptionRedeem] query, [DataModel.Contexts.RedemptionRedeem] context)`

Changelog
===

- **2016-11-16** - `4.0.0` - Define serparaed libraries: Voucherify (server side methods) and Voucherify.Client (client side methods). Define Voucherify.Core. Define Voucherify.DataModel. Client Supported Apis: Vouchers, Redemptions. Server Supported Apis: Vouchers, Redemptions, Campaigns, Customers, Products.

-------------------------------

- **2016-11-02** - `3.1.0` - Added Validate method for Vouchers. Fixed issue with DiscoutType mapping.
- **2016-09-13** - `3.0.0` - Removed dependencied to RSP.Promise and RestSharp, stick to base libraries only.
- **2016-09-06** - `2.2.0` - Added Portable Class Library (portable45-net45+win8+wp8+wpa81). Added Order Items. Improved Error Handling.
- **2016-08-17** - `2.1.0` - Fixed Request Header for .Net 3.5+ and empty metadata issue.
- **2016-07-21** - `2.0.0` - Fixed Data Conversion Problems. Added Update method for Vouchers, Added Code Pattern for Voucher creation.
- **2016-07-11** - `1.1.3` - Fixed DLLs
- **2016-07-11** - `1.1.2` - Fixed package dependencies for .Net Framework 3.5+.
- **2016-07-11** - `1.1.1` - Fixed package dependencies.
- **2016-07-11** - `1.1.0` - Added support for .Net Framework 2.0 with clasic callback approach. Get rid of DataContract attribute.
- **2016-07-03** - `1.0.0` - Replace async/await with RSG.Promise library. Use RestSharp instead of HttpClient.
- **2016-07-03** - `0.2.0` - Introduced support for .Net Framework 3.5.
- **2016-06-26** - `0.1.0` - Inital verion of SDK that supports Vouchers, Redemption and Customer endpoints.
- **2016-07-11** - `1.1.1` - Fixed package dependencies.
- **2016-07-11** - `1.1.0` - Added support for .Net Framework 2.0 with clasic callback approach. Get rid of DataContract attribute.
- **2016-07-03** - `1.0.0` - Replace async/await with RSG.Promise library. Use RestSharp instead of HttpClient.
- **2016-07-03** - `0.2.0` - Introduced support for .Net Framework 3.5.
- **2016-06-26** - `0.1.0` - Inital verion of SDK that supports Vouchers, Redemption and Customer endpoints.

See more in [Changelog](changelog.md)
