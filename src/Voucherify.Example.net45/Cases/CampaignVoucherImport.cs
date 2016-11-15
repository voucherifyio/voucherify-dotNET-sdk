using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class CampaignVoucherImport
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                var vouchers = new List<DataModel.Contexts.CampaignVoucherImport>()
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
                };
                var importVouchers = await api.Campaigns.ImportVouchers("TEST-SDK-16", vouchers);
                Console.WriteLine("[CampaignVoucherImport] Result: {0}", importVouchers);
            }
            catch (Exception e)
            {
                Console.WriteLine("[CampaignVoucherImport]  Exception: {0}", e);
            }
        }
    }
}
