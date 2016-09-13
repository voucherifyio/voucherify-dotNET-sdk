using System;
using System.Threading.Tasks;
using Voucherify.Client.DataModel;

namespace Voucherify.Client.net45.Example
{
    class Program
    {
        private const string app_token = "<your_app_token>";
        private const string app_id = "<your_app_id>";

        private static async Task Run()
        {
            Console.WriteLine("Voucherify. Create single voucher.");
            VoucherifyClient client = new VoucherifyClient(app_id, app_token).WithSSL();

            try
            {
                Voucher newVoucher = new Voucher()
                {
                    Discount = Discount.WithAmountOff(10),
                    Type = VoucherType.DiscountVoucher
                };

                Voucher voucher = await client.Vouchers.CreateVoucher(newVoucher);
                Console.WriteLine("Voucher. Code: {0} Campaign: {1} Category: {2} Discount: {3}", voucher.Code, voucher.Campaign, voucher.Category, voucher.Discount.Type.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception occured: {0}", exception);
            }
        }

        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }
    }
}
