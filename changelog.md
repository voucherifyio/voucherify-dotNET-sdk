Voucherify .NET SDK - Changelog
===============================

- **2016-11-11** - `4.0.0` - Define serparaed libraries: Voucherify (server side methods) and Voucherify.Cleint (client side methods). Define Voucherify.Core. Define Voucherify.DataModel. Client Supported Apis: Vouchers, Redemptions. Server Supported Apis: Vouchers, Redemptions, Campaigns, Customers, Products.

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