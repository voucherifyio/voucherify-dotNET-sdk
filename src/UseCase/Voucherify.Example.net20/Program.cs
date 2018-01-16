using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20
{
    class Program
    {
        static void Main(string[] args)
        {
            var serverApi = new Voucherify.Api("d0974524-fd04-48c5-a6db-c32b1ba8f4ea", "e389ed74-b23c-4f37-9ae1-65cd21fa2b86", Core.ApiVersion.v2017_04_20);

            //Cases.ApiUnauthorized.Run();
            //Cases.CampaignFlow.Run(serverApi);
            //Cases.CampaignVoucherImport.Run(serverApi);
            //Cases.CustomerFlow.Run(serverApi);
            //Cases.ProductFlow.Run(serverApi);
            //Cases.ProductList.Run(serverApi);
            //Cases.RedemptionFlow.Run(serverApi);
            Cases.RedemptionList.Run(serverApi);
            //Cases.VoucherFlow.Run(serverApi);
            //Cases.VoucherList.Run(serverApi);
            //Cases.VoucherImport.Run(serverApi);
            //Cases.CampaignList.Run(serverApi);

            Console.ReadLine();
        }
    }
}
