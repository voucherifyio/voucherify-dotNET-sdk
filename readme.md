Voucherify .Net SDK
===

###Version: 0.2.0
[Voucherify](http://voucherify.io?utm_source=github&utm_medium=sdk&utm_campaign=acq) has a new platform that will help your team automate voucher campaigns. It does this by providing composable API and the marketer-friendly interface that increases teams' productivity:

- **roll-out thousands** of vouchers **in minutes** instead of weeks,
- **check status** or disable **every single** promo code in real time, 
- **track redemption** history and build reports on the fly.

Here you can find a library that makes it easier to integrate your .Net application with Voucherify.

Setup
=====

```
Install-Package Voucherify.Client
```

**IMPORTANT (.NET 3.5 only)**: there is a need to install additonal package for `async` and `await` keyword support:

```
Install-Package AsyncBridge.Net35
```

**IMPORTANT (.NET 4.0 only)**: there is a need to install additonal package for `async` and `await` keyword support:

```
Install-Package Microsoft.Bcl.Async
```

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

.Net 3.
---

It requires to install additonal package for `async` and `await` and  `Task ` from  `System.Threading.Task` namespace keyword support:

```
Install-Package AsyncBridge.Net35
```

Then the library can be used the same way as for **.Net Framework 4.5** (see below).

.Net 4.0 (with KB2468871)
---

It requires to install additonal package for `async` and `await` keyword support:

```
Install-Package Microsoft.Bcl.Async
```

Also **KB2468871** must be installed.

Then the library can be used the same way as for **.Net Framework 4.5** (see below).

.Net 4.5
---

```cs
VoucherifyClient client = new VoucherifyClient("<your-app-id>", "<your-app-token>").WithSSL();
DataModel.Voucher voucher = await client.Vouchers.Get("<your-voucher-code>");
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

- **2016-07-03** - `0.2.0` - Introduced support for .Net Framework 3.5.
- **2016-06-26** - `0.1.0` - Inital verion of SDK that supports Vouchers, Redemption and Customer endpoints.

See more in [Changelog](CHANGELOG.md)