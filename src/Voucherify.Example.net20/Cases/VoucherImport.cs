using System;
using System.Collections.Generic;

namespace Voucherify.Example.net20.Cases
{
    public class VoucherImport
    {
        public static void Run(Voucherify.Api api)
        {
            var vouchers = new List<DataModel.Contexts.VoucherImport>();

            vouchers.Add(new Voucherify.DataModel.Contexts.VoucherImport()
            {
                Code = "code1",
                Active = true,
                Category = "TEST-SDK-Category",
                AdditionalInfo = "TEST-AdditionalInfo",
                StartDate = DateTime.Now.AddDays(-1),
                ExpirationDate = DateTime.Now.AddDays(10),
                Redemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(1),
                Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                        { "key1", "value1" },
                        { "key2", "value2" }
                    })
            }.WithDiscount(new DataModel.Discount().WithPercentOff(69)));
            vouchers.Add(new Voucherify.DataModel.Contexts.VoucherImport()
            {
                Code = "code2",
                Active = true,
                Category = "TEST-SDK-Category",
                AdditionalInfo = "TEST-AdditionalInfo",
                StartDate = DateTime.Now.AddDays(-1),
                ExpirationDate = DateTime.Now.AddDays(10),
                Redemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(1),
                Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                        { "key1", "value1" },
                        { "key2", "value2" }
                    })
            }.WithDiscount(new DataModel.Discount().WithPercentOff(69)));

            api.Vouchers.Import(vouchers, (response) => {
                if (response.Exception != null)
                {
                    Console.WriteLine("[VoucherImport] Exception: {0}", response.Exception);
                    return;
                }

                Console.WriteLine("[VoucherImport] Result: {0}", response.Result);
            });
        }
    }
}
