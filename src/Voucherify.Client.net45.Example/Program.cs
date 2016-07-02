using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.net45.Example
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

                VoucherifyClient client = new VoucherifyClient(app_id, app_token).WithSSL();
                string voucherCode = "<voucher_code>";

                DataModel.Voucher voucher = await client.Vouchers.Get(voucherCode);

                Console.WriteLine("Voucher. Code: {0} Camplaing: {1} Category: {2} Discount: {3}", voucher.Code, voucher.Campaign, voucher.Category, voucher.Discount.Type.ToString());
            }
            catch (Exception e)
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
