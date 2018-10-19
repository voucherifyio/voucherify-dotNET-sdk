using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net45
{
    class Program
    {
        static void Main(string[] args)
        {
            string applicationId = args.Length > 0 ? args[0] : "";
            string applicationSecret = args.Length > 1 ? args[1] : "";

            var serverApi = new Voucherify.Api(applicationId, applicationSecret);

            IUseCase[] useCases = new IUseCase[]
            {
                /*
                new Campaigns.AddDiscountCampaign(),
                new Campaigns.AddPromotionCampaign(),
                new Campaigns.PublishOneFromAutoUpdate(),
                new Campaigns.PublishMultipleFromAutoUpdate(),
                new Flows.Campaigns(),
                new Flows.Customers(),
                new Flows.Products(),
                new Flows.Vouchers(),
                new Import.CampaignVoucher(),
                new Import.Voucher(),
                new Promotions.CreatePromotionTierAndValidateAndRedeem(),
                new Redemptions.RedeemAndRollback(),
                new Vouchers.CreateAndAddBalanceToGiftVoucher(),
                new Vouchers.CreateAndValidateAndRedeemDiscountVoucher(),
                new Vouchers.CreateAndValidateAndRedeemGiftVoucher(),
                new Vouchers.CreateVoucherAndPublishToCustomer()
                */
            };

            Console.WriteLine("Started.");

            foreach (IUseCase useCase in useCases)
            {
                useCase.Run(serverApi).Wait();
            }

            Console.WriteLine("Finalized. Press any key to continue.");
            Console.ReadLine();
        }
    }
}
