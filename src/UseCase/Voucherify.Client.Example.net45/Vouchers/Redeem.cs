using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45.Vouchers
{
    public class Redeem : IUseCase
    {
        public async Task Run(Voucherify.Client.Api api)
        {
            try
            {
                var voucherRedeem = await api.Redemptions.Redeem(
                    new DataModel.Queries.RedemptionRedeem() { Code = "FPg37MlN" },
                    new DataModel.Contexts.RedemptionRedeem().WithCustomerId("customer@test.com"));
                Console.WriteLine("[Vouchers][Redeem] Redeemed - Redeemption: {0}", voucherRedeem);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Vouchers][Redeem] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Vouchers][Redeem] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
