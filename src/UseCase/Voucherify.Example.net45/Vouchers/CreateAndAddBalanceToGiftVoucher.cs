using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Vouchers
{
    public class CreateAndAddBalanceToGiftVoucher : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                var voucherCreate = await api.Vouchers.Create(new DataModel.Contexts.VoucherCreate()
                {
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
                }.WithGift(new DataModel.Contexts.GiftCreate() { Amount = 10000 }));
                Console.WriteLine("[Vouchers][CreateAndAddBalanceToGiftVoucher] Created - Voucher: {0}", voucherCreate);

                var voucherBalance = await api.Vouchers.AddGiftBalance(voucherCreate.Code, new DataModel.Contexts.VoucherAddGiftBalance() { Amount = 5000 });
                Console.WriteLine("[Vouchers][CreateAndAddBalanceToGiftVoucher] Added Amount - Balance: {0}", voucherBalance);
                
                var voucherGet = await api.Vouchers.Get(voucherCreate.Code);
                Console.WriteLine("[Vouchers][CreateAndAddBalanceToGiftVoucher] Retrived - Voucher: {0}", voucherGet);

                await api.Vouchers.Delete(voucherCreate.Code, new DataModel.Queries.VoucherDelete() { Force = true });
                Console.WriteLine("[Vouchers][CreateAndAddBalanceToGiftVoucher] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Vouchers][CreateAndAddBalanceToGiftVoucher] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Vouchers][CreateAndAddBalanceToGiftVoucher] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
