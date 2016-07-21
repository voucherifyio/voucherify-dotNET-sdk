using System;
using Voucherify.Client;

namespace Voucherify.Client.net20.Example
{
    class Program
    {
        private const string app_token = "<your_app_token>";
        private const string app_id = "<your_app_id>";

        private static void Run()
        {
            Console.WriteLine("Voucherify. Get single voucher.");
            VoucherifyClient client = new VoucherifyClient(app_id, app_token).WithSSL();

            client.Vouchers.Get("<your_voucher_code>", (response) =>
                {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("Exception occured: {0}", response.Exception);
                    }
                    else
                    {
                        DataModel.Voucher voucher = response.Result;
                        Console.WriteLine("Voucher. Code: {0} Campaign: {1} Category: {2} Discount: {3}", voucher.Code, voucher.Campaign, voucher.Category, voucher.Discount.Type.ToString());
                    }
                });
        }

        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }
    }
}
