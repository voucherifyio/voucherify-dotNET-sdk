using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class RedemptionFlow
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                var voucherCreate = await api.Vouchers.Create(new Voucherify.DataModel.Contexts.VoucherCreate()
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
                Console.WriteLine("[Redemption] (Create) Result: {0}", voucherCreate);
                var redemptionRedeem = await api.Redemptions.Redeem(
                    voucherCreate.Code,
                    new DataModel.Queries.RedemptionRedeem(),
                    new DataModel.Contexts.RedemptionRedeem() { }.WithCustomerId("bandraszyk@gmail.com"));
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("[Redemption] (Redeem) Result: {0}", redemptionRedeem);
                var redemptionList = await api.Redemptions.GetForVoucher(voucherCreate.Code);
                Console.WriteLine("[Redemption] (List) Result: {0}", redemptionList);
                System.Threading.Thread.Sleep(5000);
                var redemptionRollback = await api.Redemptions.Rollback(
                    redemptionRedeem.Id,
                    new DataModel.Queries.RedemptionRollback(),
                    new DataModel.Contexts.RedemptionRollback().WithCustomerId("bandraszyk@gmail.com"));
                Console.WriteLine("[Redemption] (Rollback) Result: {0}", redemptionRollback);
                await api.Vouchers.Delete(
                    voucherCreate.Code,
                    new DataModel.Queries.VoucherDelete() { Force = true });
                Console.WriteLine("[Redemption] (Delete) Done");

            }
            catch (Exception e)
            {
                Console.WriteLine("[Redemption] Exception: {0}", e);
            }
        }
    }
}
