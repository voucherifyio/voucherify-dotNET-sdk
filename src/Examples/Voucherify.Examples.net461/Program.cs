using System;
using Voucherify.Client;
using DataModel = Voucherify.Client.DataModel;
using Exceptions = Voucherify.Client.Exceptions;

namespace Voucherify.Examples.net40
{
    class Program
    {
        private const string app_token = "f4248a4d-0541-4ea3-8bb0-08088da0c0a1";
        private const string app_id = "dfc43c42-3e67-4b65-acad-57399e49be54";

        private async static void Run()
        {
            try
            {
                Console.WriteLine("Voucherify. Get single voucher.");

                VoucherifyClient client = new VoucherifyClient(app_token, app_id).WithSSL();
                string voucherCode = "voucherify.io-sandbox-01";

                DataModel.Voucher voucher = await client.Vouchers.Get(voucherCode);

                Console.WriteLine("Voucher. Code: {0} Camplaing: {1} Category: {2} Discount: {3}", voucher.Code, voucher.Campaign, voucher.Category, voucher.Discount.Type.ToString());
            }
            catch (Exceptions.VoucherifyClientException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
            }
        }

        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }
    }
}
