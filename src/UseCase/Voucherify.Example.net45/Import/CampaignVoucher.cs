using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Import
{
    public class CampaignVoucher : IUseCase
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
                Console.WriteLine("[Import][CampaignVoucher] Created - Campaign: {0}", campaignCreate);
                Thread.Sleep(5000);

                var importVouchers = await api.Campaigns.ImportVouchers(campaignCreate.Name, new List<DataModel.Contexts.CampaignVoucherImport>()
                {
                    new DataModel.Contexts.CampaignVoucherImport()
                    {
                        Code = "Import1",
                        AdditionalInfo = "DESC",
                        VoucherRedemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(3)
                    },
                    new DataModel.Contexts.CampaignVoucherImport()
                    {
                        Code = "Import2",
                        AdditionalInfo = "DESC",
                        VoucherRedemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(3)
                    }
                });
                Console.WriteLine("[Import][CampaignVoucher] Imported");
                
                await api.Campaigns.Delete(campaignCreate.Name, new DataModel.Queries.CampaignDelete() { Force = true });
                Console.WriteLine("[Flows][Campaigns] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Import][CampaignVoucher] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Import][CampaignVoucher] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
