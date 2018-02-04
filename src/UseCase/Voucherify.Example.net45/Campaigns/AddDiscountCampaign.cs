using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Campaigns
{
    public class AddDiscountCampaign : IUseCase
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
                        Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() { { "test", true } })
                    });
                Console.WriteLine("[Campaigns][AddDiscountCampaign] Created - Campaign: {0}", campaignCreate);
                Thread.Sleep(5000);

                await api.Campaigns.Delete(campaignCreate.Name, new DataModel.Queries.CampaignDelete() { Force = true });
                Console.WriteLine("[Campaigns][AddDiscountCampaign] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Campaigns][AddDiscountCampaign] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Campaigns][AddDiscountCampaign] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
