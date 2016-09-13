Voucherify .Net SDK
===

###Version: 2.2.0

[Voucherify](http://voucherify.io?utm_source=github&utm_medium=sdk&utm_campaign=acq) is an API-first platform for software developers who are dissatisfied with high-maintenance custom coupon software. Our product is a coupon infrastructure through API that provides a quicker way to build coupon generation, distribution and tracking. Unlike legacy coupon software we have:

* an API-first SaaS platform that enables customisation of every aspect of coupon campaigns
* a management console that helps cut down maintenance and reporting overhead
* an infrastructure to scale up coupon activity in no time

Here you can find a library that makes it easier to integrate your .Net application with Voucherify.

Setup
=====

```
Install-Package Voucherify.Client
```

Or simple use libraries from `lib/{target-framework}` folder.

Dependencies
---

* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) 
* [RSG.Promise](https://www.nuget.org/packages/RSG.Promise/) (except version for .Net Framework 2.0)
* [RestSharpy](https://www.nuget.org/packages/RestSharp/) (except version for .Net Framework 2.0)

Authentication
===

To create a client simpy add `Voucherify.Client` to usings and create an instance of `VoucherifyClient` class:

```cs
VoucherifyClient client = new VoucherifyClient("<your-app-id>", "<your-app-token>");
```

The App Id and App Token can be find in your application settings. [Log-in](http://app.voucherify.io/#/login) to Voucherify web interface and obtain your Application Keys from [Configuration](https://app.voucherify.io/#/app/configuration):

![](https://www.filepicker.io/api/file/WKYkl2bSAWKHccEN9tEG)

.Net Framework Support
===

* .Net 2.0
* .Net 3.5
* .Net 4.0
* .Net 4.5
* PCL (portable45-net45+win8+wp8+wpa81)

Usage .Net 2.0 - .Net 4.0
---

```cs

using Voucherify.Client;

...
	VoucherifyClient client = new VoucherifyClient("<your-app-id>", "<your-app-token>").WithSSL();
	client.Vouchers.Get("<your-voucher-code>", (response) => 
		{
			if (response.Exception != null) {
				Console.WriteLine("Exception: {0}", response.Exception);
			} 
			else
			{
                		Console.WriteLine("Voucher Code: {0}", response.Result.Code);
			}
		});
```


Usage.Net 4.5 standard + PCL (portable-net45+netcore45+wpa81+wp8)
---

```cs

using Voucherify.Client;
using Voucherify.Client.Exceptions;

...
	VoucherifyClient client = new VoucherifyClient(app_id, app_token).WithSSL();

	try
        {
        	Voucher newVoucher = new Voucher()
                {
                    Discount = Discount.WithAmountOff(10),
                    Type = VoucherType.DiscountVoucher
                };

                Voucher voucher = await client.Vouchers.CreateVoucher(newVoucher);
		Console.WriteLine("Voucher Code: {0}", voucher.Code);	
	}
	catch (VoucherifyClientException exception)
	{
		Console.WriteLine("Exception: {0}", exception);	
	}

...

```

Documentation
===

Documentation will be avaialble later. For futher reference please check source code or check [Voucherify.io API documentation](https://voucherify.readme.io/).

Supported API Methods
===

- `VoucherifyClient.Vouchers.ListVouchers(filter)`
- `VoucherifyClient.Vouchers.Get(code)`
- `VoucherifyClient.Vouchers.CreateVoucher(voucher)`
- `VoucherifyClient.Vouchers.CreateVoucherWithCode(code, voucher)`
- `VoucherifyClient.Vouchers.Update(code, voucher)`
- `VoucherifyClient.Vouchers.DisableVoucher(code)`
- `VoucherifyClient.Vouchers.EnableVoucher(code)`
- `VoucherifyClient.Vouchers.Redeem(code, query)`
- `VoucherifyClient.Vouchers.Redeem(code, context)`
- `VoucherifyClient.Vouchers.Redemption(code)`
- `VoucherifyClient.Redemptions.ListRedemptions(filter)`
- `VoucherifyClient.Redemptions.Rollback(redemptionId, query)`
- `VoucherifyClient.Customers.Create(customer)`
- `VoucherifyClient.Customers.Get(customerId)`
- `VoucherifyClient.Customers.Update(customerId, customer)`
- `VoucherifyClient.Customers.Delete(customerId)`

Changelog
===

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

See more in [Changelog](changelog.md)
