using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Client.Example.net20.Cases
{
    public class Validate
    {
        public static void Run(Voucherify.Client.Api api)
        {
            api.Vouchers.Validate(
                new DataModel.Queries.VoucherValidation() { Code = "<voucher_code>" },
                (response) => {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("[Validate]  Exception: {0}", response.Exception);
                        return;
                    }

                    Console.WriteLine("[Validate]  Result: {0}", response.Result);
                });
        }
    }
}
