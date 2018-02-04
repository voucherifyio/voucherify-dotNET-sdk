using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45.Vouchers
{
    public class Validate : IUseCase
    {
        public async Task Run(Voucherify.Client.Api api)
        {
            try
            {
                var voucherValidate = await api.Validations.ValidateVoucher(new DataModel.Queries.VoucherValidation() { Code = "wuq69c3A" });
                Console.WriteLine("[Vouchers][Redeem] Validated - Validation: {0}", voucherValidate);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Vouchers][Validate] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Vouchers][Validate] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
