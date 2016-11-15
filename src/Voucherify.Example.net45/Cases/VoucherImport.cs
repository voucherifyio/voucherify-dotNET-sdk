using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class VoucherImport
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
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
                }.WithDiscount(new DataModel.Discount().WithPercentOff(67)));
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

                var voucherImport = await api.Vouchers.Import(vouchers);
                Console.WriteLine("[VoucherImport] Result: {0}", voucherImport);
            }
            catch(Exception e)
            {
                Console.WriteLine("[VoucherImport] Exception: {0}", e);
            }
        }
    }
}
