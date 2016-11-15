using System;
using System.Collections.Generic;

namespace Voucherify.Example.net20.Cases
{
    public class CampaignVoucherImport
    {
        public static void Run(Voucherify.Api api)
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

            api.Campaigns.ImportVouchers(
                "TEST-SDK-16",
                vouchers,
                (responseImport) => {
                    if (responseImport.Exception != null)
                    {
                        Console.WriteLine("[CampaignVoucherImport] Exception: {0}", responseImport.Exception);
                        return;
                    }

                    Console.WriteLine("[CampaignVoucherImport] Result: {0}", responseImport.Result);
                });
        }
    }
}
