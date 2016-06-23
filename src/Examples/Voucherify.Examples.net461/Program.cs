using System;
using Voucherify.Client;
using DataModel = Voucherify.Client.DataModel;
using Exceptions = Voucherify.Client.Exceptions;

namespace Voucherify.Examples.net40
{
    class Program
    {
        private const string app_token = "<your_app_token>";
        private const string app_id = "<your_app_id>";

        private async static void Run()
        {
            try
            {
                Console.WriteLine("Voucherify. Get single voucher.");

                VoucherifyClient client = new VoucherifyClient(app_token, app_id).WithSSL();
                string voucherCode = "<voucher_code>";

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
