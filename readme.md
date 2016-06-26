Voucherify .Net SDK
===================

###Version: 0.1.0
[Voucherify](http://voucherify.io?utm_source=github&utm_medium=sdk&utm_campaign=acq) has a new platform that will help your team automate voucher campaigns. It does this by providing composable API and the marketer-friendly interface that increases teams' productivity:

- **roll-out thousands** of vouchers **in minutes** instead of weeks,
- **check status** or disable **every single** promo code in real time, 
- **track redemption** history and build reports on the fly.

Here you can find a library that makes it easier to integrate your .Net application with Voucherify.


Setup
=====

TODO: Publish on Nuget


Authentication
==============

[Log-in](http://app.voucherify.io/#/login) to Voucherify web interface and obtain your Application Keys from [Configuration](https://app.voucherify.io/#/app/configuration):

![](https://www.filepicker.io/api/file/WKYkl2bSAWKHccEN9tEG)

Usage
=====

The `VoucherifyClient` manages all your interaction with the Voucherify API.

```cs
VoucherifyClient client = new VoucherifyClient("appId", "appToken");
```

Basic Concept
===

Every method was written to work asynchronously with the use of `async` and `await` kewords.

```cs
VoucherifyClient client = new VoucherifyClient("<app_id>", "<app_token>").WithSSL();
string voucherCode = "<voucher_code>";

DataModel.Voucher voucher = await client.Vouchers.Get(voucherCode);
```

Supported Frameworks
===

Library is compatible with Micsrosoft .Net Framework 4.0 but `Microsoft.Bcl.Async` package is required to be installed through `nuget`. Library work with newer frameworks as well.


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

For futher reference please check source code or check [Voucherify.io API documentation](https://voucherify.readme.io/).

Changelog
=========

- **2016-06-26** - `0.1.0` - Inital verion of SDK that supports Vouchers, Redemption and Customer endpoints.

See more in [Changelog](CHANGELOG.md)