using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20.Cases
{
    public class CampaignFlow
    {
        public static void Run(Voucherify.Api api)
        {
            api.Campaigns.Create(
                new DataModel.Contexts.CampaignCreate()
                {
                    Name = "TEST-SDK-16",
                    Type = DataModel.CampaignType.Static,
                    VouchersCount = 10,
                    Voucher = new DataModel.Contexts.CampaignVoucherCreate()
                    {
                        Redemption = new DataModel.Contexts.VoucherRedemption().SingleUse()
                    }.WithDiscount(new DataModel.Discount().WithPercentOff(20))
                },
                (responseCreate) =>
                {
                    if (responseCreate.Exception != null)
                    {
                        Console.WriteLine("[CampaignFlow] (Create) Exception: {0}", responseCreate.Exception);
                        return;
                    }

                    Console.WriteLine("[CampaignFlow] (Create) Result: {0}", responseCreate.Result);
                    System.Threading.Thread.Sleep(5000);

                    api.Campaigns.AddVoucher(
                        responseCreate.Result.Name,
                        new DataModel.Contexts.CampaignAddVoucher()
                        {
                            AdditionalInfo = "DESC",
                            VoucherRedemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(3)
                        },
                        (responseAdd) =>
                        {
                            if (responseAdd.Exception != null)
                            {
                                Console.WriteLine("[CampaignFlow] (Add) Exception: {0}", responseAdd.Exception);
                                return;
                            }

                            Console.WriteLine("[CampaignFlow] (Add) Result: {0}", responseAdd.Result);
                        });
                });
        }
    }
}
