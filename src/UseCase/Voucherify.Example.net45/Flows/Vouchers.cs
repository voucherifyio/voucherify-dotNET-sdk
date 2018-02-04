using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Flows
{
    public class Vouchers : IUseCase
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
                }.WithDiscount(new DataModel.Discount().WithPercentOff(67, null)));
                Console.WriteLine("[Flows][Vouchers] Created - Voucher: {0}", voucherCreate);

                var voucherGet = await api.Vouchers.Get(voucherCreate.Code);
                Console.WriteLine("[Flows][Vouchers] Retrieved - Voucher: {0}", voucherGet);

                var voucherUpdate = await api.Vouchers.Update(
                    voucherGet.Code,
                    DataModel.Contexts.VoucherUpdate.FromVoucher(voucherGet)
                        .WithAdditionalInfo("Some Additional Text"));
                Console.WriteLine("[Flows][Vouchers] Updated - Voucher: {0}", voucherUpdate);
                
                var voucherDisabled = await api.Vouchers.Disable(voucherGet.Code);
                Console.WriteLine("[Flows][Vouchers] Disabled - Voucher: {0}", voucherDisabled);

                var voucherEndabled = await api.Vouchers.Enable(voucherGet.Code);
                Console.WriteLine("[Flows][Vouchers] Enabled - Vocuher: {0}", voucherEndabled);
                
                var voucherList = await api.Vouchers.List(new DataModel.Queries.VouchersFilter() { Limit = 1, Category = voucherCreate.Category });
                Console.WriteLine("[Flows][Vouchers] List - Vouchers: {0}", voucherList);

                await api.Vouchers.Delete(
                    voucherGet.Code,
                    new DataModel.Queries.VoucherDelete() { Force = true });
                Console.WriteLine("[Flows][Vouchers] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Flows][Vouchers] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Flows][Vouchers] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
