using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Voucherify.Client;
using DataModel = Voucherify.Client.DataModel;

namespace Voucherify.Examples.net40
{
    class Program
    {
        private const string app_token = "3266b9f8-e246-4f79-bdf0-833929b1380c";
        private const string app_id =    "c70a6f00-cf91-4756-9df5-47628850002b";

        private async static void Run()
        {
            try
            {
                Console.WriteLine("Testing Voucherify Module");

                VoucherifyClient client = new VoucherifyClient(app_token, app_id).WithSSL();
                string voucherCode = "Testing7fjWdr";
                
                DataModel.Voucher voucher = await client.Vouchers.Get(voucherCode);

                Console.WriteLine(voucher.Code);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 

        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }
    }
}
