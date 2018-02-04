using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Import
{
    public class Voucher : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                var voucherImport = await api.Vouchers.Import(new List<DataModel.Contexts.VoucherImport>()
                {
                    new Voucherify.DataModel.Contexts.VoucherImport()
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
                    }.WithDiscount(new DataModel.Discount().WithPercentOff(67)),
                    new Voucherify.DataModel.Contexts.VoucherImport()
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
                    }.WithDiscount(new DataModel.Discount().WithPercentOff(69))
                });
                Console.WriteLine("[Import][Voucher] Imported");

                await api.Vouchers.Delete("code1", new DataModel.Queries.VoucherDelete() { Force = true });
                await api.Vouchers.Delete("code2", new DataModel.Queries.VoucherDelete() { Force = true });
                Console.WriteLine("[Import][Voucher] Deleted");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Import][Voucher] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Import][Voucher] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
