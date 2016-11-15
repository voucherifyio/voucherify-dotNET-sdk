using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20.Cases
{
    public class RedemptionFlow
    {
        public static void Run(Voucherify.Api api)
        {
            api.Vouchers.Create(new Voucherify.DataModel.Contexts.VoucherCreate()
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
            }.WithDiscount(new DataModel.Discount().WithPercentOff(69)),
                (responseCreate) =>
                {
                    if (responseCreate.Exception != null)
                    {
                        Console.WriteLine("[Redemption] (Create) Exception: {0}", responseCreate.Exception);
                        return;
                    }

                    Console.WriteLine("[Redemption] (Create) Result: {0}", responseCreate.Result);

                    api.Redemptions.Redeem(
                        responseCreate.Result.Code, 
                        new DataModel.Queries.RedemptionRedeem(),
                        new DataModel.Contexts.RedemptionRedeem() {}.WithCustomerId("bandraszyk@gmail.com"),
                        (responseRedeem) =>
                        {
                            if (responseRedeem.Exception != null)
                            {
                                Console.WriteLine("[Redemption] (Redeem) Exception: {0}", responseRedeem.Exception);
                                return;
                            }

                            Console.WriteLine("[Redemption] (Redeem) Result: {0}", responseRedeem.Result);
                            api.Redemptions.GetForVoucher(
                                responseCreate.Result.Code,
                                (responseList) =>
                                {
                                    if (responseList.Exception != null)
                                    {
                                        Console.WriteLine("[Redemption] (List) Exception: {0}", responseList.Exception);
                                        return;
                                    }

                                    Console.WriteLine("[Redemption] (List) Result: {0}", responseList.Result);
                                    System.Threading.Thread.Sleep(5000);
                                    api.Redemptions.Rollback(
                                        responseRedeem.Result.Id,
                                        new DataModel.Queries.RedemptionRollback(),
                                        new DataModel.Contexts.RedemptionRollback().WithCustomerId("bandraszyk@gmail.com"),
                                        (responseRollback) => {
                                            if (responseRollback.Exception != null)
                                            {
                                                Console.WriteLine("[Redemption] (Rollback) Exception: {0}", responseRollback.Exception);
                                                return;
                                            }

                                            Console.WriteLine("[Redemption] (Rollback) Result: {0}", responseRollback.Result);
                                            System.Threading.Thread.Sleep(5000);

                                            api.Vouchers.Delete(
                                                responseCreate.Result.Code,
                                                new DataModel.Queries.VoucherDelete() { Force = true },
                                                (responseDelete) => {
                                                    if (responseDelete.Exception != null)
                                                    {
                                                        Console.WriteLine("[Redemption] (Delete) Exception: {0}", responseDelete.Exception);
                                                        return;
                                                    }

                                                    Console.WriteLine("[Redemption] (Delete) Done");
                                                });
                                        });
                                });
                        });
                });
        }
    }
}
