using System;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class CampaignFlow
    {
        public async static Task Run(Voucherify.Api api)
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
                        Metadata = new Core.DataModel.Metadata(new System.Collections.Generic.Dictionary<string, object>() {
                            { "test", true }
                        })
                    });
                Console.WriteLine("[CampaignFlow] (Create) Result: {0}", campaignCreate);
                System.Threading.Thread.Sleep(5000);
                var campaignAddVoucher = await api.Campaigns.AddVoucher(
                    campaignCreate.Name,
                    new DataModel.Contexts.CampaignAddVoucher()
                    {
                        AdditionalInfo = "DESC",
                        VoucherRedemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(3)
                    });
                Console.WriteLine("[CampaignFlow] (Add) Result: {0}", campaignAddVoucher);
            }
            catch (Exception e)
            {
                Console.WriteLine("[CampaignFlow]  Exception: {0}", e);
            }
        }
    }
}
