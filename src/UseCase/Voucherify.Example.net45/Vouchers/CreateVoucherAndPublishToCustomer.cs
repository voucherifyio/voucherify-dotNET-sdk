using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Vouchers
{
    public class CreateVoucherAndPublishToCustomer : IUseCase
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
                Console.WriteLine("[Vouchers][CreateVoucherAndPublishToCustomer] Created - Voucher: {0}", voucherCreate);

                var voucherPublish = await api.Distributions.CreatePublication(new DataModel.Contexts.VoucherPublish()
                {
                    Voucher = voucherCreate.Code,
                    Customer = new DataModel.Contexts.Customer()
                    {
                        Email = "test@test.com",
                        Name = "Test Test",
                        SourceId = "test@test.com"
                    },
                    Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() { { "key1", "value1" } })
                });
                Console.WriteLine("[Vouchers][CreateVoucherAndPublishToCustomer] Published - Publication: {0}", voucherPublish);
                
                await api.Vouchers.Delete(voucherCreate.Code, new DataModel.Queries.VoucherDelete() { Force = true });
                Console.WriteLine("[Vouchers][CreateVoucherAndPublishToCustomer] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Vouchers][CreateVoucherAndPublishToCustomer] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Vouchers][CreateVoucherAndPublishToCustomer] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
