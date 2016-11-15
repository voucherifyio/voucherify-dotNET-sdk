using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45.Cases
{
    public class Validate
    {
        public async static Task Run(Voucherify.Client.Api api)
        {
            try
            {
                var validation = await api.Vouchers.Validate(new DataModel.Queries.VoucherValidation() { Code = "<voucher_code>" });
                Console.WriteLine("[Validate]  Result: {0}", validation);
            }
            catch (Exception e)
            {
                Console.WriteLine("[Validate]  Exception: {0}", e);
            }
        }
    }
}
