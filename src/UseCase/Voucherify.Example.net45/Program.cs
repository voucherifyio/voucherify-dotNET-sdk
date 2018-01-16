using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net45
{
    class Program
    {
        static void Main(string[] args)
        {
            var serverApi = new Voucherify.Api("<app_id>", "<token>");

            //Cases.ApiUnauthorized.Run().Wait();
            //Cases.CampaignFlow.Run(serverApi).Wait();
            //Cases.CampaignVoucherImport.Run(serverApi).Wait();
            //Cases.CustomerFlow.Run(serverApi).Wait();
            //Cases.ProductFlow.Run(serverApi).Wait();
            //Cases.ProductList.Run(serverApi).Wait();
            //Cases.RedemptionFlow.Run(serverApi).Wait();
            //Cases.RedemptionList.Run(serverApi).Wait();
            //Cases.VoucherFlow.Run(serverApi).Wait();
            //Cases.VoucherList.Run(serverApi).Wait();
            //Cases.VoucherImport.Run(serverApi).Wait();

            Console.ReadLine();
        }
    }
}
