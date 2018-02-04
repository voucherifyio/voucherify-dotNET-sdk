using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Promotions
{
    public class CreatePromotionTierAndValidateAndRedeem : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                var promotionValidate = await api.Validations.Validate(null, new DataModel.Contexts.Validation()
                {
                    Customer = new DataModel.Contexts.Customer()
                    {
                        Email = "test@test.com",
                        Name = "Test Test",
                        SourceId = "test@test.com"
                    },
                    Order = new DataModel.Contexts.Order().WithAmount(50000),
                    Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() { { "test", false } })
                });
                Console.WriteLine("[Promotions][CreatePromotionTierAndValidateAndRedeem] Validated - Validation: {0}", promotionValidate);
                
                var promotionRedeem = await api.Redemptions.RedeemPromotion(promotionValidate.Promotions[0].Id, new DataModel.Contexts.RedemptionRedeem()
                    {
                        Order = new DataModel.Contexts.Order().WithAmount(50000)
                    }.WithCustomer(new DataModel.Contexts.Customer()
                    {
                        Email = "test@test.com",
                        Name = "Test Test",
                        SourceId = "test@test.com"
                    }));
                Console.WriteLine("[Promotions][CreatePromotionTierAndValidatceAndRedeem] Redeem - Redemption: {0}", promotionRedeem);
                Thread.Sleep(5000);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Promotions][CreatePromotionTierAndValidateAndRedeem] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Promotions][CreatePromotionTierAndValidateAndRedeem] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
