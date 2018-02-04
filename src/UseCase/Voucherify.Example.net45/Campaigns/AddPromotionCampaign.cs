using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Campaigns
{
    public class AddPromotionCampaign : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                var campaignCreate = await api.Promotions.CreateCampaign(new DataModel.Contexts.CampaignPromotionCreate()
                {
                    Name = "TEST-SDK-20-PROMOTION",
                    Type = DataModel.CampaignType.Static,
                    Promotion = new DataModel.Contexts.PromotionTierListCreate()
                        .WithTiers(new List<DataModel.Contexts.PromotionTierCreate>() {
                            new DataModel.Contexts.PromotionTierCreate()
                            {
                                Name = "Drogi order",
                                Action = new DataModel.PromotionTierAction()
                                {
                                    Discount = new DataModel.Discount().WithAmountOff(1000)
                                },
                                Banner = "Congratulations, you get $10 off",
                                Condition = new DataModel.Contexts.ValidationRuleCreate()
                                    .WithOrders(new Core.DataModel.Metadata(new Dictionary<string, object>() {
                                        { "total_amount", new Dictionary<string, object>() { {  "$more_than", new int[] { 10000 } } } }
                                    }))
                            }
                        }),
                     Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() { { "test", true } })
                });
                Console.WriteLine("[Campaigns][AddPromotionCampaign] Created - Campaign: {0}", campaignCreate);
                Thread.Sleep(5000);

                await api.Campaigns.Delete(campaignCreate.Name, new DataModel.Queries.CampaignDelete());
                Console.WriteLine("[Campaigns][AddPromotionCampaign] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Campaigns][AddPromotionCampaign] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Campaigns][AddPromotionCampaign] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
