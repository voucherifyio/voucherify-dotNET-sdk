using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Redemptions
{
    public class RedeemAndRollback : IUseCase
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
                }.WithDiscount(new DataModel.Discount().WithPercentOff(67)));
                Console.WriteLine("[Redemptions][RedeemAndRollback] Created - Voucher: {0}", voucherCreate);

                var voucherValidate = await api.Validations.Validate(voucherCreate.Code, new DataModel.Contexts.Validation()
                {
                    Customer = new DataModel.Contexts.Customer()
                    {
                        Email = "test@test.com",
                        Name = "Test Test",
                        SourceId = "test@test.com"
                    },
                    Order = new DataModel.Contexts.Order().WithAmount(10000),
                    Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() { { "test", false } })
                });
                Console.WriteLine("[Redemptions][RedeemAndRollback] Validated - Validation: {0}", voucherValidate);

                var voucherRedeem = await api.Redemptions.Redeem(voucherCreate.Code, new DataModel.Queries.RedemptionRedeem(), new DataModel.Contexts.RedemptionRedeem()
                {
                    Order = new DataModel.Contexts.Order().WithAmount(10000)
                }.WithCustomer(new DataModel.Contexts.Customer()
                {
                    Email = "test@test.com",
                    Name = "Test Test",
                    SourceId = "test@test.com"
                }));
                Console.WriteLine("[Redemptions][RedeemAndRollback] Redeem - Redemption: {0}", voucherRedeem);
                Thread.Sleep(5000);

                var voucherRedeemRollback = await api.Redemptions.Rollback(voucherRedeem.Id, new DataModel.Queries.RedemptionRollback() { Reason = "Order cancedled" }, new DataModel.Contexts.RedemptionRollback() { });
                Console.WriteLine("[Redemptions][RedeemAndRollback] Redeem - Rollback: {0}", voucherRedeemRollback);
                
                await api.Vouchers.Delete(voucherCreate.Code, new DataModel.Queries.VoucherDelete() { Force = true });
                Console.WriteLine("[Redemptions][RedeemAndRollback] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Redemptions][RedeemAndRollback] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Redemptions][RedeemAndRollback] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
