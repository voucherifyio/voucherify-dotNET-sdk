using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20
{
    class Program
    {
        static void Main(string[] args)
        {
            var serverApi = new Voucherify.Api("<app_id>", "<token>");

            //Cases.ApiUnauthorized.Run();
            //Cases.CampaignFlow.Run(serverApi);
            //Cases.CampaignVoucherImport.Run(serverApi);
            //Cases.CustomerFlow.Run(serverApi);
            //Cases.ProductFlow.Run(serverApi);
            //Cases.ProductList.Run(serverApi);
            //Cases.RedemptionFlow.Run(serverApi);
            //Cases.RedemptionList.Run(serverApi);
            //Cases.VoucherFlow.Run(serverApi);
            //Cases.VoucherList.Run(serverApi);
            //Cases.VoucherImport.Run(serverApi);

            Console.ReadLine();
        }
    }
}
