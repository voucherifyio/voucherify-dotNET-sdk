using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Flows
{
    public class Campaigns : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                var campaignCreate = await api.Campaigns.Create(
                    new DataModel.Contexts.CampaignCreate()
                    {
                        Name = "TEST-SDK-14",
                        VouchersCount = 5,
                        Voucher = new DataModel.Contexts.CampaignVoucherCreate()
                        {
                            Redemption = new DataModel.Contexts.VoucherRedemption().SingleUse()
                        }.WithDiscount(new DataModel.Discount().WithAmountOff(2000)),
                        Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() { { "test", true }  })
                    });
                Console.WriteLine("[Flows][Campaigns] Created - Campaign: {0}", campaignCreate);
                Thread.Sleep(5000);
                var campaignGet = await api.Campaigns.Get(campaignCreate.Name);
                Console.WriteLine("[Flows][Campaigns] Retrieved - Campaign: {0}", campaignGet);


                var campaignUpdated = await api.Campaigns.Update(campaignCreate.Name, new DataModel.Contexts.CampaignUpdate()
                {
                    StartDate = DateTime.Today.AddDays(5)
                });
                Console.WriteLine("[Flows][Campaigns] Updated - Campaign: {0}", campaignUpdated);

                var campaignAddVoucher = await api.Campaigns.AddVoucher(
                    campaignCreate.Name,
                    new DataModel.Contexts.CampaignAddVoucher()
                    {
                        AdditionalInfo = "DESC",
                        VoucherRedemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(3)
                    });
                Console.WriteLine("[Flows][Campaigns] Added Voucher - Voucher: {0}", campaignAddVoucher);

                var camapignList = await api.Campaigns.List( new DataModel.Queries.CampaignFilter() { Limit = 1 });
                Console.WriteLine("[Flows][Campaigns] Listed - Campaigns: {0}", camapignList);

                await api.Campaigns.Delete(campaignCreate.Name, new DataModel.Queries.CampaignDelete() { Force = true });
                Console.WriteLine("[Flows][Campaigns] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Flows][Campaigns] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Flows][Campaigns] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
